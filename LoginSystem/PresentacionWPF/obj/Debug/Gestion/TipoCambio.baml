   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	   M+clr-namespace:Vista.Gestion.ModelTipoCambioVista.Gestion.ModelTipoCambio  6+       Vista.TipoCambio   5      n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	   >local1+clr-namespace:Vista.Gestion.ModelTipoCambio     6+   -   5           Vista.Document   Name$  
tipoCambio��5   9      Vista.Document   Loaded$ Window_Loaded��6M      Closing$ Window_Closing��6�    � Title$ 
TipoCambio��6	   $��600.333��6   $	��800��6-    � WindowStartupLocation$ CenterScreen=�6e    � 	Resources 5	         TextBlockStyleValidation �� 
TargetType �� Triggers P� Property	 P� Value
 �� Property �� Value �� RelativeSource �� Path �� UpdateSourceTrigger �� ValidatesOnDataErrors �� NotifyOnValidationError��%�   &	        �� 5   
   " ��61    5      P� 5       �@=�HasError	 . . �5      �� 
 �@�ToolTip 5      ��  �� *Self+$) #(Validation.Errors)[0].ErrorContent�$ PropertyChanged=� .  . 5      5      5       � DataContext 5      3   -Vista.Gestion.ModelTipoCambio.ModelTipoCambio  5   
   .��5"      �� $
��Auto=�6   $
��Auto=�66   .��5#   
   � $��Center=�6   $	��Top=�6,   $��0,20,0,0q�6D   .+�5$      �� -   5         ��Name$ tabControlTipoCambio��5$      $
��Left=�67   $	��469��6R   $	��Top=�6`   $	��729��6x    5%       �� 
TargetType �� CornerRadius ��Name �� Triggers �� 
TargetName��%�  '��       �� 5'      " ��6   .�5(      �� 
 � �� 5)      �� 5*   "   " ��62   .R�5+   &   �� $��Border��6-   $��1,1,1,0q�6;   
�������$ 4,4,0,0��6m   $	��2,0q�6�   ._�5,   *   �� $ ContentSite��6;   $��Center=�5-   )   $��Center=�5.   )   $��Header��5/   )   $
��10,2q�50   )   51   '    52   &   P� 53   *    �@��
IsSelected	 . . �54   .   �� $ Border��65   
 � �� �	#FF2196F36_   �� 55   .   
 � ��
 �����6L   �� 56   .   
 � ��$ 14(�6J   57   +   P� 58   *    �@��
IsSelected	 .  . �59   .   �� $ Border��65   
 � ��
 �����6_   5:   +   5<   #   5>      5?      5@      .@�5A      �� $��Tipos de Cambio��6   $
��Bold"�63   .��5B      � ���	#FFE5E5E5.+�5C      �� -   5         ��Name$ cbMes��5E   �     ComboBoxStyle#��[ 5C   #    �� DisplayMemberPath$ Month��6J    �� SelectedValuePath$
 Code��6d   $
��Left=�5E   �   $��
397,26,0,0q�6�   $	��Top=�6�   $	��132��6�   
�������$��0q�6  $��31��6#  
���   � �� SelectedValue 5C   }   �� $ SelectedValueMonth�$ PropertyChanged=� .  .  � ToolTip 5D   p   ��  �� *Self+$) #(Validation.Errors)[0].ErrorContent�$ PropertyChanged=� .  . 5E   l  �� 5F      -   5        $ cbAno��5F   J   #��[ 6#   $
��Left=�6Y   $��
553,26,0,0q�6t   $	��Top=�6�   $	��132��6�   
�������$��0q�6�   $��31��6�   $ Category��6�   $ Category��5H   �    5F   �   �� $ SelectedValueYear�$ PropertyChanged=� .  .  5G   p   ��  �� *Self+$) #(Validation.Errors)[0].ErrorContent�$ PropertyChanged=� .  . 5H   �   &   System.Windows.Controls.DataGrid  5J      -   5          Name$ dgTipoCambio��5J   $      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6:   $��1q�6K   
�������   CanUserDeleteRows .      CanUserAddRows  .  $
��Left=�6�   $	��338��6�   $��	31,82,0,0q�6�   $	��Top=�6�   $	��654��6�   $!   HorizontalScrollBarVisibility$! Visible=�6  ""   VerticalScrollBarVisibility$" Visible=�6/  #   SelectionMode$# Single=�6U  $   SelectionUnit$
$ Cell=�6l  %   GridLinesVisibility$	% All=�6�  &   VerticalGridLinesBrush
& �����'   HorizontalGridLinesBrush
' �����
���   �$��Right=�6Q  $��Center=�6t  (   CanUserSortColumns( .  )   CanUserReorderColumns) .  *   	CellStyle* 5N      �� 5P   "   *  $System.Windows.Controls.DataGridCell"  6(    5Q   &   P� 5R   *    �@J�IsMouseOver	 . . �5T   .   �� 
 � �� �	#FF74C1FF5U      �� 5V   .   
 � ��
 �   �5W      5Z   +   P� 5[   *    �@ 	IsEditing	 . . �5]   .   �� 
 � �� �	#FF74C1FF5^      �� 5_   .   
 � ��
 �   �5`      5c   +   .�5f   &   �� 
 � ��$ 25��6?   6L   �� 5g   &   
 � ��$ Right=�6S   6c   �� 5h   &   
 �@��TextAlignment$ Right=�6P   6`   �� 5i   &   
 � ��$ Center=�6T   6e   + �� 	Resources+ 5j   &   , �� Color��%�   (��       5k   :   * SystemColors.HighlightBrushKey+)(�� #     5l   :   *$"SystemColors.HighlightTextBrushKey+)�� 5k   *   $, 	LightBlue��6l   �� 5l   *   $, Black��6p   5m   '   5o   #   -   RowStyle- 5r      �� 5s   "   )  #System.Windows.Controls.DataGridRow"  6(    5t   &   P� 5u   *    �@J�IsMouseOver	 . . �5w   .   �� 
 � ��
 �����5x      5{   +   5   #    5�      ��%T   (��       5�   2   * SystemColors.HighlightBrushKey+)�� 6"   $	, Red��5�      5�      5�      5�      5�      5�      �� 5�      -   5        . ��Name$. btnOK��5�      $��OK��6$   $
��Left=�61   $��	0,495,0,0q�6L   $	��Top=�6_   $��99��6w   $��3q�6�   $��16(�6�   6�   �� 5�      -   5        $. btnCancelar��5�      $��Cancelar��6*   $
��Left=�6=   $��126,495,0,0q�6X   $	��Top=�6m   $��99��6�   $��3q�6�   
�������
�������$��16(�6�   6�   5�      5�      5�      