   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	   ` \De.TorstenMandelkow.MetroChart, Version=0.9.5818.20693, Culture=neutral, PublicKeyToken=nullwTclr-namespace:De.TorstenMandelkow.MetroChart;assembly=De.TorstenMandelkow.MetroChartDe.TorstenMandelkow.MetroChart 5   	       
Vista.Menu   5   	   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   e
MetroChartTclr-namespace:De.TorstenMandelkow.MetroChart;assembly=De.TorstenMandelkow.MetroChart  5   	   -   5          � Title$
  Menu��5
   	   $��668.333��6   $��1179.499��6'    � Triggers 5      :� 5   
    :� RoutedEvent$ Loaded��6   .[�5      �� .��5      ��  g� Duration$ 00:00:6D�6    �� TargetProperty$ Opacity�60   .��5      W�  W� From$ 0X�6&   	 W� To$ 1X�6/   5      5      5      .��5      � .+�5   
   ]� ��. .+�5      �� $	��Top=�6   ���	#FF2196F3.+�5      ��  �� Orientation$ 
Horizontal=�6   ���	#FF2196F3$��Center=�6N   $��Right=�6i   .+�5      �� -   5        $��btnMessages��5   �    0  ,MaterialDesignFloatingActionMiniAccentButton#��[  67   $��30��6}   $��25��6�   
�������$��Right=�6�   ��6�   Z� ��6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Email=�62   $��20��6?   $��20��6J   5      �� 5      -   5        	 ��Name$	 
btnSetting��5      #��[  61   $��30��6w   $��25��6�   
�������$��Right=�6�   ��6�   Z� ��6�   Z� .��5        $ Account=�62   $��20��6A   $��20��6L   5      �� 5      -   5        $	 btnExit��5      #��[  6.   $��30��6t   $��25��6   $��Right=�6�   
���������6�   Z� ��6�   Z� .��5        $ Power=�62   $��20��6?   $��20��6J   $��Right=�6V   5       5!      5"      �� 5$      $��Bottom=�6   .+�5%      � .+�5&      �� ��5'      �� 5(      .R�5)   "   � 
 � ColumnDefinitions
 5*   &   �� 5+   *   $	��150 �6;   �� 5,   *   $��3* �6;   5/   #   50      .@�53      �� -   5         ��Name$ StatusMessage��53   8   $��1��6(   $��Stretch=�6O   $��Center=�6l   .��54      �� -   5        $��lblCursorPosition��54   (   $
��Bold"�6A   $��18(�6S   $��Center=�6a   55      �� 56      -   5        $��	statusImg��56   8   $��0��6(   $��Center=�6I   $��Right=�6d   $��Center=�6�   .��57      �� -   5        $	��img��57   $   $	��100��6/   $��20��6;   $��Center=�6G   $��Center=�6d   58      5:      �� 5;      -	   5        $��	txtEditor��5;   3    �� AcceptsReturn . 5<      5=      �� 5@      $
��Left=�6   $	��300��6/   ���	#FF2196F3.+�5B      �   PrimaryHueMidBrush#��[ 6   $��Stretch=�6N   $��Stretch=�6j    � RowDefinitions 5C      �� 5D      $��70 �6(   �� 5E      $��30 �6(   �� 5F      $��30 �6(   �� 5G      $	��450 �6(   
 5J      �� 5K      $��* �6+   67   .+�5N      � $��0��6   $��0��6(   
�������.+�5O      � $��Stretch=�6   $��Stretch=�6;   
 5P      �� 5Q   "   $��* �63   6?    5S      �� 5T   "   $��* �60   6=   .+�5V      �� -
   5         ��Name$ imgLogo��5V   $   $��0��65   $��0��6B   $=��7C:\Users\jamara\source\repos\LoginSystem\image\logo.png��6R    � Cursor$
 Hand��6�   $��Stretch=�6�   $��Stretch=�6�   $
��Fill=�6  5W      5Y      � 5Z      $��1��6   
�������.+�5[      �� -   5         ��Name$ lblSociedadActual��5[   $   
���   �$��14(�6R   $��Center=�6`   $��Center=�6}   $
��Bold"�6�    �� Padding$ 5,0,0,0q�6�   6�   5\      � 5]      $��2��6   
�������.+�5^      �� -   5        $ lblUsuarioActual��5^   $   
���   �$��14(�6Q   $��Center=�6_   $��Center=�6|   $
��Bold"�6�   $ 5,0,0,0q�6�   6�   5_      � 5`      $��3��6   $��Stretch=�6(   $��Stretch=�6D   .+�5a      �� $��Stretch=�6'   $��Hidden=�6E   $��Visible=�6l   $
��auto��6�   .��5b      �� -   5         ��Name$ Menus��5b   )   5d      5e      5g      5i      5n      �� 5p      
�������$��Stretch=�6,   $��Stretch=�6H   .+�5q      � 
 5r      �� 5s      $��* �6+   67    5u      �� 5v      $��* �6(   65   5x      �� 5y      -   5        $ imgImage��5y      $��0��6*   $��0��67    J� Opacity$	 0.4Q�6G   $��logoSCV_V3.PNG��6U   $��Stretch=�6n   $��Stretch=�6�   $
��Fill=�6�   $	��573��6�   6�   5z      5|      5}      5�      