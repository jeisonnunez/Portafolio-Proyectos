   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	       Vista.LogMensajes   5   	   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	   -   5          � Title$  LogMensajes��5   	   $��356.65��6   $��647.33��6-    � WindowStartupLocation$ CenterScreen=�6S   
 � Tag$ LogMensajesWindow��6x   .��5	      � $��Stretch=�6   $��Stretch=�6)    � ColumnDefinitions 5
   
   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $��* �6   6)   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgLogs��5      $��Stretch=�6#   $��0��6H   $��0��6X   $   HorizontalScrollBarVisibility$ Visible=�6f      AutoGenerateColumns .  "   VerticalScrollBarVisibility$ Visible=�6�   $	��250��6�   $��32,30,32.333,0q�6�   $	��Top=�6�   	   
IsReadOnly	 . {�. 
   SelectionMode$
 Single=�62     GridLinesVisibility$	 All=�6I     VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   CanUserReorderColumns .    CanUserSortColumns . $��0q�6�     CanUserResizeColumns . $��1q�6   
�������   CanUserDeleteRows .     CanUserAddRows .     RowStyle 5      �� 5       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6   .�5      ��  �� Property � �� �� Value
 �����5       �� 	Resources 5       �� Color��%�   (��       5   *   * SystemColors.HighlightBrushKey+)(�� %     5   *   *$"SystemColors.HighlightTextBrushKey+)�� 5      $ Transparent��6\   �� 5      $ Black��6`   5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 61   -   5        ID��1  +System.Windows.Controls.DataGridBoundColumn   Binding 5    >   ��  �� Path$ ID�6i   4  .System.Windows.Controls.DataGridTemplateColumn  5"      $
 auto 6)   $ Image��66      CellTemplate 5#      �� 5$      .R�5%      �� $��20��6$   $��30��60   $��Center=�6Y   ��6;   �� $ Image�6y   5&      5(        5)      $
 auto 6B   $ Mensaje��6O    6%   �� $	 Msg�6c     5*      $ Fecha��6%   $
 auto 64   -   5        Date�� 5*   A   �� $
 Date�6p   5/      50      51      