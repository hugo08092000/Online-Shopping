   M S B A M L   `   `   `  ����J  FOnline Shopping, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Online_ShoppingOnline_Shopping  5           Online_Shopping.SellerPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Online_Shopping     5      G CHandyControl, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null0hc'https://handyorg.github.io/handycontrol  5        N� Title$  
SellerPage��5
      .��5      �  � RowDefinitions 5   
   �� 5      $��5 �6   �� 5      $	��10* �6   �� 5      $��1* �6   �� 5      $��5 �6    � ColumnDefinitions 5   
   �� 5      $��5 �6   �� 5      $��6* �6   �� 5      $��1* �6   �� 5      $��5 �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��Right=�5      $��1��5      $��2��5      .+�5      �� $�� ��6   5       �� 5"   
   $)��#Danh sách sản phẩm đăng bán��6   $��1��5#      $��1��5$       K� ZIndex$ 2��5%      $��Bottom=�5&      $��30(�5'      $
��Bold"�5(      $��	15 0 0 15q�5)       J� IsHitTestVisible .  
����  �5+      �� 5-   
   -   5         ��Name$ ListDataGridBorder��5-      
����  �$	��0.5q�5/       �� CornerRadius$ 15��50      $��1��51      $��1��52      $��2��53      $��0 10 0 0q�54       �� Padding$ 8q�55      ._�56      &   System.Windows.Controls.DataGrid  -   5        	  Name$	 SellerDataGrid��56      
   AutoGenerateColumns
 .     
IsReadOnly .    Columns 59      0  *System.Windows.Controls.DataGridTextColumn  5:      ,  &System.Windows.Controls.DataGridColumn   Header$ Sản phẩm��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5;   )   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5<   )   �� *
TenHangHoa+  5=      $ Loại hàng��6)   $ * 5>   )    5?   )   �� *TenLoaiHang+  5@      $ 
Danh mục��6)   $ * 5A   )    5B   )   �� *
TenDanhMuc+  5C      $ 
Đơn giá��6)   $ * 5D   )    5E   )   �� *DonGia+5H      5I      �� 5K   
   $��2��6   $��1��5L      $��2��5M      $��Center=�5N      $��Right=�5O      $ 
Horizontal=�5P      .+�5Q      � .+�5R      �� -   5        $ AmountBorder��5R      $��0��5S      $��0��5T      $��16��5U      $��16��5V      $��-91 -18 0 0q�5W      
���  ��$ 50��5Y      $ 2��5Z      $y�	Collapsed=�5[      ._�5\      �� -   5         ��Name$ Amount��5\       
�������$��Center=�5^       $��Center=�5_       $��8(�5`       5a      �� 5b      $ 
Horizontal=�6   .+�5c      �� -   5        $��RefreshButton��5d      $��Refresh��5c      $	��100��5e         ButtonPrimary#��[  5f      )  #HandyControl.Controls.BorderElement   CornerRadius$ 15��5g      5h      �� 5j      $�� ��6    �� 5l      -   5        $��	AddButton��5m      $��Thêm sản phẩm��5l      $	��125��5n      $��30��5o      #��[  5p      $ 15��5q      5r      5s      5u      5w      5x      5y      