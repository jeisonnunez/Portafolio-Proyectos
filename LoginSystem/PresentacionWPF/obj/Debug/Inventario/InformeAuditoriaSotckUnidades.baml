   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	   )    #Vista.InformeAuditoriaSotckUnidades   5      n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	      Vista.Converter    Closing$  Window_Closing��5   P      Loaded$ Window_Loaded��6i    � Title$# InformeAuditoriaSotckUnidades��6	   $��559.295��6/   $��916.042��6@    � WindowStartupLocation$ CenterScreen=�6�    � 	Resources 5	         Vista.StyleConverter   StyleConverter��%   &	          5   
   6   5      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgInformeStockUnidades��5         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 63   $��Stretch=�6C   $��0��6h   $��0��6u   $	��285��6�   $��77,136,93.333,0q�6�   $��1q�6�   
�������   AutoGenerateColumns .     CanUserDeleteRows .  	   CanUserSortColumns	 .  
   SelectionMode$
 Extended=�6+  $   HorizontalScrollBarVisibility$
 Auto=�6D  "   VerticalScrollBarVisibility$
 Auto=�6i  $	��Top=�6�     GridLinesVisibility$	 All=�6�     VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   CanUserAddRows .     SelectionUnit$ FullRow=�6   $
��Bold"�68  $��10(�6J  
���   ����	#FFE5E5E5$��0q�6�     	CellStyle 5      �� 5       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6   .�5      ��  �� Property � �� �� Value$ 0q�60    �� Triggers 5      �� 5       �� Binding 6&   �� *Num+ �� Value 16>   .a�5      ��  � �� �	#FFE5E5E56;   5      �� 5       6&   �� *Num+ 06>   .a�5      ��  � ��
 �����6;   5      5         RowStyle 5      �� 5       )  #System.Windows.Controls.DataGridRow"  6    �� 	Resources 5#       �� Color��%�   (��       5$   *   * SystemColors.HighlightBrushKey+)(�� %     5%   *   *$"SystemColors.HighlightTextBrushKey+)�� 5$      $ Transparent��6\   �� 5%      $ Black��6`   5&      .�5(      ��  � ��$ 0q�60   �� 5)       � ��
 �����63   �� 5*       �@��
IsReadOnly . 6?   �� 5+       � ��$ 20��6/   5.         Columns 52      4  .System.Windows.Controls.DataGridTemplateColumn  53      ,  &System.Windows.Controls.DataGridColumn   Width$ * 6)      Header$ Nro Articulo��63   -   5        nroarticulo��   
IsReadOnly .     CellTemplate  54      �� 55      .R�56      �� ! ��Name$! 
txtTransId��6�   $��Stretch=�6)   $��Stretch=�6E   $��0q�6c   " �� TextAlignment$" Center=�6�   ��6o   �� *
ItemCode+# �� UpdateSourceTrigger$# PropertyChanged=�6�   57      59        5:      $ * 6)   $ Descripcion��63   -   5        descripcion�� .   5;      �� 5<      .R�5=      �� $! 
txtTransId��6�   $��Stretch=�6)   $��Stretch=�6E   $��0q�6c   $" Center=�6�   ��6o   �� *
Dscription+$# PropertyChanged=�6�   5>      5@        5B      $ * 6)   $ Cantidad��63   -   5        cantidad�� .   5C      �� 5D      .R�5E      �� $! txtQuantity��6�   $��Stretch=�6)   $��Stretch=�6E   $��0q�6c   $" Center=�6�   ��6o   �� *
Quantity+$# PropertyChanged=�6�   5F      5H        5J      $ * 6)   $ Unidad Medida Alternativa��63   -   5        unidadAlternativa�� .   5K      �� 5L      .R�5M      �� $! txtQuantity��6�   $��Stretch=�6)   $��Stretch=�6E   $��0q�6c   $" Center=�6�   ��6o   �� *	UomCode+$# PropertyChanged=�6�   5N      5P      5T      �� 5U   
   -   5        $! 
lblDeFecha��5U      $
��Left=�6(   $��	74,27,0,0q�6C   $
��Wrap=�6V   $��De Fecha��6j   $
��Bold"�6z   $��14(�6�   $	��Top=�6�   �� 5V   
   -   5        $! lblHastaFecha��5V      $
��Left=�6+   $��
344,28,0,0q�6F   $
��Wrap=�6Z   $��Hasta��6n   $
��Bold"�6{   $��14(�6�   $	��Top=�6�   (	  "System.Windows.Controls.DatePicker	  5X   
   -   5        $ 	 Name$$ dpFechaHasta��5X      $
��Left=�6,   $��
403,24,0,0q�6G   $	��Top=�6[   $	��121��6s   $��25��6    5Y      ��%^   '��       �� 5Z      " ��6   .�5[      ��  �@��CornerRadius$ 3��65   5]      5^      5_      	  5`   
   -	   5        $$ dpFechaDesde��5`      $
��Left=�6,   $��
152,24,0,0q�6G   $	��Top=�6[   $	��121��6s   $��25��6    5a      ��%^   '��       �� 5b      " ��6   .�5c      ��  �@��CornerRadius$ 3��65   5e      5f      5g      �� 5h   
   -
   5        % ��Name$% btnOk��5h      $��OK��64   $
��Left=�6A   $��
77,457,0,0q�6\   $	��Top=�6p   $	��100��6�   �� 5i   
   -   5        & ��Name$& imgExcel��5i   e   $��	excel.png��6Q   ' � Cursor$
' Hand��6w   $y�Visible=�6�   ( J� RenderTransformOrigin$( 1.591,0.437&�6�   $��40��6�   $��40��6�   $��744,28,62,0q�6�   $	��Top=�6�   �� 5j   
   -   5        $% btnCancelar��5j      $��Cancelar��6@   $
��Left=�6S   $��208,457,0,0q�6n   $	��Top=�6�   $	��100��6�   
�������
�������6�   5l      5m      