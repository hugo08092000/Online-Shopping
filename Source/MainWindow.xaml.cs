﻿using System;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void CustomerFrame_Loaded(object sender, RoutedEventArgs e)
        {
            CustomerPage customerPage = new CustomerPage();
            CustomerFrame.Navigate(customerPage);
        }

        private void SellerFrame_Loaded(object sender, RoutedEventArgs e)
        {
            SellerPage sellerPage = new SellerPage();
            SellerFrame.Navigate(sellerPage);
        }
    }
}
