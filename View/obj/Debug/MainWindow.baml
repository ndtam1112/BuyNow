   M S B A M L   `   `   `  ����?  ;View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ViewView  5   	       View.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   localclr-namespace:View  5   	     � WindowStyle$
  None=�5	   	    � 
ResizeMode$ NoResize=�5
   	   
������  � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency .  � Title$
 Main��5   	   $	��621��6   $
��1000��6#    � 	Resources 5       �� Source�� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.PopupBox.xaml?�6!   %    .��5      � .+�5   
   �� -   5         ��Name$ border��5      $��1q�6!   ���	#FF000000 �� CornerRadius$ 20��6M   	 �� Padding$	 1q�6_   $��Center=�5   	   $��Center=�6&   ._�5      � .+�5      �� -   5        $
��mask��5      
������� 68   �� 
 �� ElementName$
 border�� �� Path$ CornerRadius�� 5      -   5         �Name$ 
HomeLayout��5       J� OpacityMask 5      !� 5       !� Visual 6&   �� $

 mask��.+�5      r� -   5         r�Name$ movieLoader��5   #   $
��Left=�68   $	��621��6S    r� LoadedBehavior$
 Play=�6`   $	��Top=�5      $
��1000��63    � Triggers 5      :� 5       :� RoutedEvent$ MediaElement.Loaded��6+   [�5    "   �� 5!   &   .��5"   *   �� .��5#   .   p�  p� Source$; 5D:\My App\BuyNow\View\image\thumb\Untitled-design.mp4?�6<    �� 
TargetName$ movieLoader��6{    g� RepeatBehavior$ Forever��6�   5$   +   5%   '   5'      5)      5+      5,      5-      � 5/   
    � RowDefinitions 50      �� 51      $��61 �6    �� 52      $	��560 �6    .+�57      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   .+�58      �� -   5         ��Name$ btnHome��5=      
������ $��50��59   !   $��0q�5:   !   $��Center=�5;   !   $��Center=�5<   !   $	��3,0q�5>   $   .��5?      �� $��image\icon\home.ico��6   5@      �� 5B      -   5        $ btnCategory��5D   !   
������ $��50��5C   !   $��0q�5E   !   $��Center=�5F   !   $��Center=�5G   !   $	��3,0q�5I   ;   .��5J      �� $��image\icon\category.ico��6   6?   5K      �� 5M      -   5        $ btnMe��5R   	   
������ $��50��5N   !   $��0q�5O   !   $��Center=�5P   !   $��Center=�5Q   !   $	��3,0q�5S      .��5T      �� $��image\icon\account.ico��6   6?   5U      �� 5W      -   5         ��Name$ search��5W      
���/���$��18(�5Y       �� TextAlignment$ Center=�5Z      $��2 4 0 0q�5[      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Search by id . . .��5\      $��50��6N   $	��240��6Z   6h   �� 5^      -	   5        $ 	btnSearch��5c   	   
������ $��50��5_   !   $��0q�5`   !   $��Center=�5a   !   $��Center=�5b   !   $	��3,0q�5d   !   .��5e      �� $��image\icon\search.ico��6   6>   5f      5i      � 5k       � ColumnDefinitions 5l      �� 5m      $
��Auto �6'   �� 5n      $
��Auto �6'   �� 5o      $��* �6'   �� 5p      $
��Auto �6'   �� 5q      $
��Auto �6'   .+�5u      ]� .+�5v      �� $2��,D:\My App\BuyNow\View\image\thumb\logo-2.ico��6   $��8q�6R   $��43��6]   �� 5w      $��
ShopName®��6    $��25(�61   $��5 0 0 0q�6?      TextBlockStyle#���   6P   5x      '  !MaterialDesignThemes.Wpf.PopupBox  5|       3 /MaterialDesignMultiFloatingActionAccentPopupBox#��[ 5}         PlacementMode$ BottomAndAlignRightEdges=�5~      $��4��6>   $��40��6N   $��40��6Z   
������ $��5q�5   /      ToggleContent 5�      �� 5�      $��image\icon\xbox_menu.ico��6       PopupContent. 5�      �� .+�5�      �� -
   5        $ 
btnSignOut��5�      $��25��5�   !   $��25��6-   $	��Top=�5�      $��Right=�5�      $��0q�5�      $��3q�5�       $  MaterialDesignFlatAccentBgButton#���  6(   ��5�      �� 5�   "     �� ImageSource$  image\icon\sign-out.ico��6-   5�      �� 5�      -   5        $ btnMinimize��5�      $��25��5�   !   $��25��6-   $	��Top=�5�      $��Right=�5�      $��3q�5�      $��0q�5�        macos-minimize-style#���  6-   ��5�      �� 5�   "   $%  image\icon\macos-minimize-2.png��6-   5�      �� 5�      -   5        $ btnClose��5�      $��25��5�   !   $��25��6-   $	��Top=�5�      $��Right=�5�      $��0q�5�      $��3q�5�        close-window-style#���  5�   0   ��5�      �� 5�   "   $#  image\icon\close-window-2.png��6-   5�      5�      5�      �� 5�      -   5        $ btnCart��5�      $��30��5�      $��30��6$   $��Center=�5�      $��5q�64   $��0q�5�   !   $��3��65   $��Center=�5�      
������ $��0q�5�      .��5�      �� $/��)D:\My App\BuyNow\View\image\icon\cart.ico��6   5�      5�      � 5�      -   5        $ 
mainLayout��5�       $��1��6   5�      5�      5�      5�      