using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace Online_Shopping
{
    /// <summary>
    /// Interaction logic for BasketWindow.xaml
    /// </summary>
    public partial class BasketWindow : Window
    {
        List<Tuple<int, int>> basketTuple = new List<Tuple<int, int>>();
        ObservableCollection<OnlineShoppingBUS.ProductInBasket> basketList = new ObservableCollection<OnlineShoppingBUS.ProductInBasket>();

        public delegate void PassProductToMain(int id);

        public event PassProductToMain EventPassProduct;

        public BasketWindow()
        {
            InitializeComponent();
        }

        public BasketWindow(List<Tuple<int, int>> basket)
        {
            InitializeComponent();
            basketTuple = basket;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach(var item in basketTuple)
            {
                OnlineShoppingBUS.Product tmpProduct = OnlineShoppingBUS.HangHoaBUS.Instance.GetProduct(item.Item1);

                OnlineShoppingBUS.ProductInBasket tmpPB = new OnlineShoppingBUS.ProductInBasket
                {
                    MaHangHoa = tmpProduct.MaHangHoa,
                    TenHangHoa = tmpProduct.TenHangHoa,
                    DonGia = tmpProduct.DonGia,
                    SoLuongDat = item.Item2,
                    TongTien = item.Item2 * tmpProduct.DonGia
                };
                basketList.Add(tmpPB);
            }

            BasketDataGrid.ItemsSource = basketList;
            CalculateTotal();
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            OnlineShoppingBUS.ProductInBasket item = (OnlineShoppingBUS.ProductInBasket)BasketDataGrid.SelectedItem;
            if (item == null)
            {
                return;
            }
            else
            {
                EventPassProduct(item.MaHangHoa);
                basketList.Remove(item);
                CalculateTotal();
            }
        }

        private void OrderButton_Click(object sender, RoutedEventArgs e)
        {
            if(basketList.Count == 0)
            {
                return;
            }
            else
            {
                int maDon = OnlineShoppingBUS.DonDatHangBUS.Instance.GetAmountOfOrders() + 1;
                float tongTien = CalculateTotal();
                OnlineShoppingBUS.DonDatHangBUS.Instance.AddNewOrder(maDon, 1, "467 East Rocky Cowley Road", "0342480476", "COD", 15000, tongTien);

                foreach (var item in basketList)
                {
                    OnlineShoppingBUS.DonDatHangBUS.Instance.AddProductToOrder(maDon, item.MaHangHoa, item.SoLuongDat);
                }
                MessageBox.Show("Đặt hàng thành công!");
                ClearBasket();
                this.Close();
            }
        }

        public float CalculateTotal()
        {
            float total = 0;
            foreach (var item in basketList)
            {
                total += item.TongTien;
            }

            TotalMoneyTextBox.Text = total.ToString();
            return total;
        }

        public void ClearBasket()
        {
            while (basketList.Count > 0)
            {
                EventPassProduct(basketList[0].MaHangHoa);
                basketList.Remove(basketList[0]);
            }
        }
    }
}
