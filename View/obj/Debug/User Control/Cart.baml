   M S B A M L   `   `   `  ����?  ;View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:View.User_ControlView.User_Control  5          View.User_Control.Cart   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      +localclr-namespace:View.User_Control  5      .��5      � 
�������$
��1000��6   $	��621��6+     � ColumnDefinitions  5   
   �� 5      $	��700 �6   �� 5      $	��300 �6   .+�5   
   � $��0��6   $��0 60 0 0q�6   .+�5      �� -   5         ��Name$ lvCart��5      $
��auto��5      $
��auto��5      $��Hidden=�5   #   $��0q�6U   ��5      �� *	History+��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value
 ���� 5   1   �� 5       � �� 5      �� 5   "    �� 
TargetType" ��62   .R�5   &   �� 5   #   5       5!      ��5#      �� 5$      .R�5%          View.User_Control.ItemCart  $��5q�6)   5&      ��5(      �� 5)      .R�5*      � $	��600��6$    � Orientation$ Vertical=�60   5+      5-      5.      �� 5/   
   $��1��6   $��..\image\thumb\bill.jpg��6    �� 50   
   $��1��6   $��0,200,0,197q�6%   $
��Left=�6:   .+�51      �� $��20(�6   $��0 20 0 0q�6&   $��Cart Totals��68      NameProductCartStyle#���   6K   �� 52       �� Orientation$ 
Horizontal=�6   .+�53      �� -   5         ��Name$ tbPriceSumAll��54      $��	20 40 0 0q�6$     PriceProductStyle#���  55      �� 56      $��5 40 0 0q�6   $	��VND��6.   57      �� 59      -   5        	 ��Name$	 	btnBuyNow��5:       $  MaterialDesignFlatAccentBgButton#���  59      $��0 50 0 0q�6P   +  %MaterialDesignThemes.Wpf.ButtonAssist
   CornerRadius$
 15��5;      $	��130��6?   $��30��6K   .��5<      �� $��20(�6   $��.....��6*   5=      5>      �� 5@   
   $��0 55 0 0q�6   $��Shopping Cart��6&   $��2��6;   $	��Top=�6O     NameProductStyle#���  5A      5B      5C      