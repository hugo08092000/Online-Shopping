   M S B A M L   `   `   `  ����J  FOnline Shopping, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Online_ShoppingOnline_Shopping  5   	   "    Online_Shopping.BasketWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Online_Shopping     5   	   G CHandyControl, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null0hc'https://handyorg.github.io/handycontrol  5   	   -   5          � Title$  Giỏ hàng��5	   	   $	��450��6   $	��500��6'    � WindowStartupLocation$ CenterScreen=�5
   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $��10 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��10 �6    � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $	��10* �6   �� 5      $��1* �6   �� 5      $��10 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ BasketDataGrid��5         AutoGenerateColumns .     
IsReadOnly . $��1��5      $��2��5      $��0,10,-0.4,0.4q�5      $��2��5          Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Header$ Sản phẩm��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 5#   %   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 5$   %   �� *
TenHangHoa+  5%      $ 
Đơn giá��6%   $	 * 5&   %   
 5'   %   �� *DonGia+  5(      $ Số lượng��6%   $	 * 5)   %   
 5*   %   �� *
SoLuongDat+  5+      $ Tổng tiền��6%   $	 * 5,   %   
 5-   %   �� *
TongTien+5/      �� 51       �� Orientation$ 
Horizontal=�6   $��right=�52      $��Center=�53      $��right=�54      $��2��55      $��2��56      .+�57      �� -   5         ��Name$ OrderButton��57      $��Đặt hàng��58         ButtonPrimary#��[  59      )  #HandyControl.Controls.BorderElement   CornerRadius$ 15��5:      $	��100��5;      $��30��5<      5=      �� 5>      $�� ��6   �� 5?      -   5        $ RemoveButton��5?      $��Xóa khỏi giỏ��5@      #��[  5A      $ 15��5B      $	��100��5C      $��30��5D      
���  ��5E   &   5F      �� 5H      $ 
Horizontal=�6   $��2��5I      $��1��5J      .+�5K      �� $��Tổng giá trị: ��6   $��18(�5L      $��Center=�5M      �� 5N      -   5         ��Name$ TotalMoneyTextBox��5N      $��0��5O      $��18(�5P      $��Center=�5Q      5R      5V      5W      