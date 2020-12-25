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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace Online_Shopping
{
    /// <summary>
    /// Interaction logic for SellerPage.xaml
    /// </summary>
    public partial class SellerPage : Page
    {
        ObservableCollection<OnlineShoppingBUS.Product> productList = new ObservableCollection<OnlineShoppingBUS.Product>();
        public SellerPage()
        {
            InitializeComponent();
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            SellerDataGrid.ItemsSource = OnlineShoppingBUS.HangHoaBUS.Instance.GetProductOfSeller().ToList();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddProductWindow addWindow = new AddProductWindow();
            addWindow.ShowDialog();

            SellerDataGrid.ItemsSource = OnlineShoppingBUS.HangHoaBUS.Instance.GetProductOfSeller().ToList();
        }
    }
}
