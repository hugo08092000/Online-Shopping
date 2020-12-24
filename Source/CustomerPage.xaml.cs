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
    /// Interaction logic for CustomerPage.xaml
    /// </summary>
    public partial class CustomerPage : Page
    {
        List<Tuple<int, int>> basket = new List<Tuple<int, int>>();
        public CustomerPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            CustomerDataGrid.ItemsSource = OnlineShoppingBUS.HangHoaBUS.Instance.GetAll().ToList();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var item =  (OnlineShoppingBUS.Product)CustomerDataGrid.SelectedItem;
            string tmpAmount = AmountTextBox.Text;
            int amount;

            try
            {
                amount = int.Parse(tmpAmount);
            }
            catch
            {
                MessageBox.Show("Hãy nhập số nguyên");
                return;
            }

           

            foreach (Tuple<int, int> part in basket)
            {
                if(part.Item1 == item.MaHangHoa)
                {
                    amount += part.Item2;
                    basket.Remove(part);
                    break;
                }
            }

            Tuple<int, int> toAdd = new Tuple<int, int>(item.MaHangHoa, amount);
            basket.Add(toAdd);
            AmountBorder.Visibility = Visibility.Visible;

            Amount.Text = basket.Count().ToString();
        }

        private void BasketButton_Click(object sender, RoutedEventArgs e)
        {
            BasketWindow basketWindow = new BasketWindow(basket);
            basketWindow.EventPassProduct += BasketWindow_EventPassProduct;
            basketWindow.ShowDialog();
        }

        private void BasketWindow_EventPassProduct(int id)
        {
            foreach (var item in basket)
            {
                if (item.Item1 == id)
                {
                    basket.Remove(item);
                    if (basket.Count() == 0)
                    {
                        AmountBorder.Visibility = Visibility.Collapsed;
                    }
                    else
                    {
                        Amount.Text = basket.Count().ToString();
                    }
                    return;
                }
            }
        }
    }
}
