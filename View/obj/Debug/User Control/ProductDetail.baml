   M S B A M L   `   `   `  ����?  ;View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:View.User_ControlView.User_Control  5      %    View.User_Control.ProductDetail   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      +localclr-namespace:View.User_Control  5      -   5        $��productDetail��5      .��5      � $
��1000��6   .+�5   
   �� -   5          ��Name$  btnBack��5   :   $��50��6   $��50��6    K� ZIndex$ 1��6(   $
��Left=�5      $	��Top=�68   $��5 60 0 0q�6P   $��0q�6d   ��5      �� 5       �� ImageSource$ ..\image\icon\back.ico��6   6D   5      � 5   
   .+�5      ��  J� Effect 5      -  'System.Windows.Media.Effects.BlurEffect  5         Radius$ 10Q�6!      
KernelType$ Gaussian=�6-   ��5      �� 5      $* $..\image\thumb\san-pham-chi-tiet.jpg��6!   5      5      � 5   
    � ColumnDefinitions 5      �� 5      6%   �� 5       6%   .+�5"      �� $��Hidden=�6   .��5#      �� $��0 60 0 0q�6   $��Center=�6/   .+�5$      �� $	��380��6   $	��380��6)   $��5q�66   $��1q�6A   
�������._�5&      �� ��6    �� *	ImageMain+ �� ElementName$ productDetail��6Z   5'      �� 5(      $	��380��6   $	��380��6)   $��5q�66   $��1q�6A   
�������
�������._�5*      �� ��6    �� *	ImageSub1+$ productDetail��6Y   5+      �� 5,      $	��380��6   $	��380��6)   $��5q�66   $��1q�6A   
�������
�������._�5.      �� ��6    �� *	ImageSub2+$ productDetail��6Y   5/      50      51      �� 53      $��15 70q�6   $��1��6(   .+�54      ��  �� TextAlignment$ Center=�6S   $
��Left=�6j   $��40(�55      $��0 0 0 15q�6&      NameProductStyle#���   68   ��54      �� *NameProduct+$ productDetail��55   8   � 56       57      �� 58      $��* �6+   �� 59      $
��Auto �6+   	 � RowDefinitions	 5;      �� 5<      �� 5=      �� 5>      .+�5A      �� $	��250��6   $	��250��6)   $��1q�66   
�������
�������._�5C      �� ��6    �� *	ImageMain+$ productDetail��6Y   5D      �� 5E      $��1��6!   $
��0 15q�6.   .+�5F      �� $��Category��6$   �� 5G      #���   6_   $��25(�6�   ��6$   �� *CategoryProduct+$ productDetail��6�   5H      �� 5I      $��1��6!   $��Center=�61   .+�5J      �� -   5        
 ��Name$
 cbSize��5K   #   $��20(�5J   #   $��30q�61    & "MaterialDesignFloatingHintComboBox#��[ 5L      .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton .   SecondaryHueMidBrush   UnderlineBrush# �  5N      .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ Inverted=�5O      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$
 Size��5P         
HelperText$ Select one Size��5Q      $��80��5R      $
��Left=�6    .@�5S      �� $��M��6+   �� 5T      $��L��6+   �� 5U      $��XL��6+   5V      �� 5W      $��0,15,0,0q�6&   $��32��5X       �� Orientation$ 
Horizontal=�6)   .+�5Y      �� -   5        $  btnMinus��5Z   %   
�������$��32��5[      $��32��6)   ��5\   "   �� 5]   &   $ ..\image\icon\minus.png��61   6Y   5_      �� 5`      -   5         ��Name$ 
tbNumOfPro��5a   (   
���   � �� Padding$
 30 5q�5`   ;   $��0��5b   $   $��20(�6-   $��32��6;   $��70��6G   6U   �� 5c      -   5        $  btnPlus��5d   %   
�������$��32��5e      $��32��6)   ��5f   "   �� 5g   &   $ ..\image\icon\plus.png��61   6X   5i      5j      �� 5k      -   5        $ tbPrice��5k   �   $��2��6C   $��1��6S   $
��0 15q�6`     PriceProductStyle#���  6n   ��6$   �� *Price_product+6�   5m      5o      �� 5q      -   5        $  btnAddToHistory��5r   T   $��50��5q   !   $	��100��6-   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 20 20 20 20��5r        ForegroundSilverBrush#���  5t   !   $��0q�6V    � ToolTip 5u      �� 5v   "     BackgroundLightBrush#���  6,   $��Add To Shopping Bag��5w   ,   5x   #   .��5z      �� $��5q�6$   $��..\image\icon\add.ico��6/   6P   5{      5|      5~      5�      5�      