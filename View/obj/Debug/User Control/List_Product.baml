   M S B A M L   `   `   `  ����?  ;View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:View.User_ControlView.User_Control  5      $    View.User_Control.List_Product   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      +localclr-namespace:View.User_Control  5      -   5        $��listProduct��5	      .��5      �� $��Hidden=�6   $��Visible=�6:   1  +MaterialDesignThemes.Wpf.ScrollViewerAssist    IsAutoHideEnabled  . .��5   
   �� .+�5      � .+�5      ��  �� CornerRadius$ 20��6   $	��621��6+   $
��1000��68   ��5      �� 5       j� Stretch$ UniformToFill=�6[    �� ImageSource 6%   �� *Thumb+ �� ElementName$ listProduct��6[    J� Effect 5      -  'System.Windows.Media.Effects.BlurEffect  5         Radius$ 15Q�6%      
KernelType$ Gaussian=�61   5      �� 5         TextBlockStyle#���   6N   $��60(�6w   ��6   �� *
typeName+$ listProduct��6w   5      �� 5      -   5         ��Name$ lvDataBinding��5      $
��auto��5      $
��auto��5      $��0q�6!   ��5      �� *	Product+��5      �� 5      	 �� 
TargetType"	 ��6   .�5       �� 
 �� Property
 � �� �� Value
 ���� 5!   1   �� 5"      
 � �� 5#      �� 5$   "    �� 
TargetType" ��62   .R�5%   &   �� 5&   #   5(      5)      ��5+      �� 5,      .R�5-      #   View.User_Control.ItemProduct  $��5q�6,   5.      ��50      �� 51      .R�52      � $
��1000��6$    � Orientation$ 
Horizontal=�61   53      55      57      59      5;      