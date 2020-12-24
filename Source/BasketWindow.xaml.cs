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
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            OnlineShoppingBUS.ProductInBasket item = (OnlineShoppingBUS.ProductInBasket)BasketDataGrid.SelectedItem;
            EventPassProduct(item.MaHangHoa);
            basketList.Remove(item);
        }
    }
}
