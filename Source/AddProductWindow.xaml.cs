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

namespace Online_Shopping
{
    /// <summary>
    /// Interaction logic for AddProductWindow.xaml
    /// </summary>
    public partial class AddProductWindow : Window
    {
        public AddProductWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> loaiHang = new List<string>
            {
                "Sách",
                "Điện tử"
            };
            ShowCategoryListBtn.ItemsSource = loaiHang;
            ShowCategoryListBtn.SelectedIndex = 0;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if((NameBox.Text == "") || (PriceBox.Text == ""))
            {
                MessageBox.Show("Chưa nhập đủ!");
                return;
            }

            string tenHangHoa = NameBox.Text;
            int maHangHoa;
            float giaHangHoa;
            int loaiHangHoa;
            int soLuong;

            string tmp = PriceBox.Text;
            try
            {
                giaHangHoa = float.Parse(tmp);
            }
            catch
            {
                MessageBox.Show("Giá phải là số!");
                return;
            }

            tmp = ShowCategoryListBtn.SelectedItem.ToString();
            if(tmp == "Sách")
            {
                loaiHangHoa = 2;
            }
            else
            {
                loaiHangHoa = 1;
            }

            tmp = AmountBox.Text;
            try
            {
                soLuong = int.Parse(tmp);
            }
            catch
            {
                MessageBox.Show("Số lượng phải là số!");
                return;
            }

            maHangHoa = OnlineShoppingBUS.HangHoaBUS.Instance.GetNumberOfProducts() + 1;
            OnlineShoppingBUS.HangHoaBUS.Instance.AddProduct(maHangHoa, tenHangHoa, giaHangHoa, loaiHangHoa);
            OnlineShoppingBUS.HangHoaBUS.Instance.AddProductToStorage(maHangHoa, soLuong);
            this.Close();
        }

    }
}
