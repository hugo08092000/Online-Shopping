   M S B A M L   `   `   `  ����J  FOnline Shopping, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Online_ShoppingOnline_Shopping  5   	   &     Online_Shopping.AddProductWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Online_Shopping     5   	   G CHandyControl, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null0hc'https://handyorg.github.io/handycontrol  5   	   -   5          � WindowStartupLocation$  CenterScreen=�5       � Title$$ Đăng bán sản phẩm mới��5	   	   $	��450��6'   $	��550��64    � 
ResizeMode$ NoResize=�5
   	   .��5      � .+�5   
   �� $
��Left=�6   $	��420��5      
���   �$	��Top=�5      $	��544��5      ���	#FFF4F4F55      � 5   
   $
��Left=�6   $��51��5      $��	10,10,0,0q�5      $	��Top=�5      $	��780��5      �� 5   
   -   5         ��Name$ TITLE��5      $��Center=�5      $��0,15,0,0q�5      $
��Wrap=�5      $��THÊM MỚI SẢN PHẨM��5      $	��Top=�5      $��Arial)�5      $��20(�5       $
��Bold"�5!      �� 5"   
   -   5        $ NameProduct��5"      $
��Left=�5#      $��	40,61,0,0q�5$      $
��Wrap=�5%      $��Tên sản phẩm��5&      $	��Top=�5'      $��16(�5(      �� 5*   
   -   5        $ PriceProduct��5*      $
��Left=�5+      $��
40,138,0,0q�5,      $
��Wrap=�5-      $��Giá sản phẩm��5.      $	��Top=�5/      $��16(�6,   �� 50   
   -   5         ��Name$ NameBox��50      $
��Left=�51      $��36��52      $��	40,82,0,0q�6    �� TextWrapping$
 Wrap=�53      $	��Top=�54      $	��216��6*   $��16(�66    �� 
AcceptsTab . $��Italic$�55   $   �� 56   
   -   5        $ DescriptionBox��56      $
��Left=�57      $	��169��6-   $��
40,230,0,0q�6:   $
 Wrap=�58      $	��Top=�6&   $	��216��6>   $��16(�59       . $��Italic$�62   �� 5:   
   -   5        $ PriceBox��5:      $
��Left=�5;      $��36��6-   $��
40,159,0,0q�5<      $
 Wrap=�6&   $	��Top=�5=      $	��216��6*   $��16(�66   $��Italic$�5>       . 6%   �� 5@   
   -   5        $ DescriptionProduct��5@      $
��Left=�60   $��
41,209,0,0q�6K   $
��Wrap=�6_   $��Mô tả sản phẩm��6s   $	��Top=�6�   $��16(�6�   �� 5A   
   $
��Left=�6   $��
337,60,0,0q�6/   $
��Wrap=�6C   $��Loại sản phẩm��6W   $	��Top=�6l   $��23��6�   $��16(�6�   �� 5D   
   -	   5        $ NameProduct_Copy3��5D      $
��Left=�6/   $��337,133,0,0q�6J   $
��Wrap=�6_   $!��Số lượng muốn nhập��6s   $	��Top=�6�   $��16(�6�   �� 5E   
   -
   5        $ 	AmountBox��5E      $
��Left=�5F      $��36��5G      $��337,159,0,0q�6   $
 Wrap=�5H      $��0��6&   $	��Top=�6/   $��60��5I      $��16(�6    . $��Italic$�5J       �� TextAlignment$ Right=�5K       J� RenderTransformOrigin$ 0.323,0.494&�5L      $  HandyControl.Controls.ComboBox  5N   
   -   5        	  Name$	 ShowCategoryListBtn��5N      $
��Left=�5O      $��
337,88,0,0q�5P      $	��Top=�5Q      $	��143��61   �� 5S   
   -   5        
 ��Name$
 SaveBtn��5S      $��Đăng��6"   $
��Left=�61   $��363,292,0,0q�5T      $	��Top=�6&   $	��100��5U      $��30��5V      $��14(�5W   '      ButtonPrimary#��[  5X      )  #HandyControl.Controls.BorderElement   CornerRadius$ 15��5Y      5[      5\      