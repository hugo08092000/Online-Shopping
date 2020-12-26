using OnlineShoppingBUS;
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

namespace Online_Shopping
{
    /// <summary>
    /// Interaction logic for HistoryOrder.xaml
    /// </summary>
    public partial class HistoryOrder : Page
    {
        DonDatHangBUS dDHB;
        public HistoryOrder()
        {
            InitializeComponent();
            dDHB = new DonDatHangBUS();
        }

        private void txtMaKhachHang_TextChanged(object sender, TextChangedEventArgs e)
        {
            loadData();
        }
        void loadData()
        {
            System.Data.DataTable dataTable = dDHB.GetHistoryOfOrder(txtMaKhachHang.Text.ToString());
            ddGHistory.ItemsSource = dataTable.DefaultView;
        }
    }
}
