   M S B A M L   `   `   `  ����?  ;View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ViewView  5   	       
View.Login   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   localclr-namespace:View  5   	   -   5          � WindowStyle$
  None=�5	   	    � 
ResizeMode$ NoResize=�5
   	   
������  � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency .  � Title$ Login��5   	   $	��621��6   $
��1000��6$   .��5      � .+�5   
   � .+�5      �� -   5         ��Name$ border��5      $��1q�6%   ���	#FF000000 �� CornerRadius$ 20��6Q    �� Padding$ 1q�6c   $��Center=�5   	   $��Center=�6&   ._�5      � .+�5      �� -   5        $
��mask��5      
������� 6<   ��  �� ElementName$ border��	 �� Path$	 CornerRadius�� 5      
 J� OpacityMask
 5      !� 5       !� Visual 6*   �� $
 mask��.+�5      r� -   5         r�Name$ movieLoader��5   '   $
��Left=�6<   $	��621��6W    r� LoadedBehavior$
 Play=�6d   $	��Top=�5      $
��1000��63    � Triggers 5      :� 5   "    :� RoutedEvent$ MediaElement.Loaded��6/   [�5   &   �� 5    *   .��5!   .   �� .��5"   2   p�  p� Source$7 1D:\My App\BuyNow\View\image\thumb\login-thumb.mp4?�6@    �� 
TargetName$ movieLoader��6{    g� RepeatBehavior$ Forever��6�   5#   /   5$   +   5&   #   5(      5)      5*      5+      5,      �� 5.   
   .+�5/      �� -   5         ��Name$ btnClose��54      $��25��5/      $��25��6!   $	��Top=�50      $��Right=�51      $��0,5,10,0q�52      $��0q�53         close-window-style#���   56      ��57      �� 58       �� ImageSource$# image\icon\close-window-2.png��6!   5:      5;      �� 5<   
   .+�5=      �� -   5        $ btnMinimize��5>      $��25��5=      $��25��6!   $	��Top=�5?      $��Right=�5@      $��0,5,40,0q�5B      $��0q�5C        macos-minimize-style#���  6-   ��5D      �� 5E      $% image\icon\macos-minimize-2.png��6!   5G      5H      �� 5K   
    �� Orientation$ Vertical=�6   $��
0,10,10,10q�6,   .+�5L      �� $ 
Horizontal=�6   .+�5M      �� $ Vertical=�6   $��40,10,40,10q�64   .+�5N      �� $��Welcome��6    $��50(�6/     NameProductStyle#���  6=   �� 5O      $��
to ShopNow��6    $��50(�62   #���  6@   5P      5Q      �� 5R      $��Sign In��6   $��50(�6'   $��Center=�65   $��0,0,0,5q�5S      $
��Bold"�6)   $��Gabriola)�6;   
�������5T   -   � 5U      $��0 25 0 0q�6   $��Center=�6%   $��Center=�6B    � ColumnDefinitions 5V      �� 5W      $��75 �6'   64   �� 5X      $	��500 �6'   65    � RowDefinitions 5Z      �� 5[      $��65 �6$   62   �� 5\      $��65 �6$   62   .+�5^      �� 
�������$	��380��61   $��65��6=   $��Center=�6I   $��0,1,0,1q�5_      $��0��6/   $��2��6<   $��Bottom=�5`      $ 	50,50,0,0��60   ._�5a      �  5b      �� 5c      $
��Auto �6/   �� 5d      .+�5f      �� $��20 0 0 0q�6    $��image\icon\phone.ico��62   $��40��6P   6^   �� 5g      -   5         ��Name$ tbPhone��5g   "   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Phone��5h      $��0q�5i      $��15(�6)   $	��280��5j      $��10 5 0 0q�6+   $��Center=�5k      $
��Left=�69   $��1��5l      .��6.   5m      5n      5o      �� 5q      
�������$	��380��61   $��65��6=   $��Center=�6I   
������ $��2��5r   /   $��2��6<   $��Bottom=�5s      $ 	0,0,50,50��60   ._�5t      �  5u      �� 5v      $
��Auto �6/   �� 5w      .+�5y      �� $��20 0 0 0q�6    $��image\icon\password.ico��62   $��40��6S   6a   G� 5z      -   5         G�Name$ pbBox��5}   '   $��10,5,0,0q�5z   '   $	��280��69   $ Password��5{   /   .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton . $��Center=�5~      $
��Left=�69   $��1��5      $��15(�6#   $��0q�61   $��1��6E   5�      5�      5�      �� 5�      -	   5        $ btnLogin��5�      $��2��6+   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 60��6<   $��65��5�      $��65��6    $��	300,0,0,0q�6,   
����� �$��0q�5�      $��1��6)   .��5�      �� $��image\icon\right.png��6   6<   5�      5�      �� 5�      -
   5        $ 	btnSignUp��5�      $��60��5�      $	��145��6   $ 	0,30,30,0��5�      
�������$��2q�5�      
�������$��	0,130,0,0q�5�      $
��Left=�6(   .��5�      �� $��Sign Up��6   $��
Montserrat)�6+   $��15(�6C   
���  ��$
��Bold"�6b   5�      5�      5�      5�      