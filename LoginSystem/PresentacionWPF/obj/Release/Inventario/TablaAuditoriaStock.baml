   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista      Vista.TablaAuditoriaStock   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Vista        Vista.Converter    Closing$  Window_Closing�� � Title$ TablaAuditoriaStock��$��656.049��$��1097.706�� � WindowStartupLocation$ CenterScreen=� � 	Resources    Vista.StyleConverter   StyleConverter��%   &	          .���� $
��Auto=�$
��Auto=�.��� $��Center=�$	��Top=�.+�&   System.Windows.Controls.DataGrid  -     Name$ dgInformeStock��$	��400��$��	0,136,0,0q�$	��Top=�$
��1000��$��1q�   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 
�������$��Center=�   AutoGenerateColumns .     CanUserDeleteRows .     CanUserSortColumns .  	   SelectionMode$	 Extended=�$
   HorizontalScrollBarVisibility$

 Auto=�"   VerticalScrollBarVisibility$
 Auto=�$��Right=�$��Center=�   GridLinesVisibility$	 All=�   VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   CanUserAddRows .     SelectionUnit$ FullRow=�$
��Bold"�$��10(�
���   ����	#FFE5E5E5$��0q�   	CellStyle ��  �� 
TargetType*  $System.Windows.Controls.DataGridCell"  .���  �� Property � �� �� Value$ 0q� �� Triggers ��  �� Binding �� *Num+ �� Value 1.a���  � �� �	#FFE5E5E5��  �� *Num+ 0.a���  � ��
 �����   RowStyle �� )  #System.Windows.Controls.DataGridRow"   �� 	Resources  �� Color��%�   (��       * SystemColors.HighlightBrushKey+)(��      *$"SystemColors.HighlightTextBrushKey+)�� $ Transparent���� $ Black��.���  � ��$ 0q���  � ��
 �������  �@��
IsReadOnly .    Columns 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn   Width$
 auto    Header$ Nro Articulo��-   nroarticulo��   
IsReadOnly .    CellTemplate �� .R���   ��Name$  
txtTransId��$��Stretch=�$��Stretch=�$��0q�! �� TextAlignment$! Center=����� " �� Path$" ItemCode�# �� UpdateSourceTrigger$# PropertyChanged=�  $
 auto $ Descripcion��-   descripcion�� .  �� .R��� $  
txtTransId��$��Stretch=�$��Stretch=�$��0q�$! Center=����� $" 
Dscription�$# PropertyChanged=�  $
 auto $ Fecha Contabilizacion��-   refDate�� .  �� .R��� $  
txtRefDate��$��Stretch=�$��Stretch=�$��0q�$! Center=����� $" DocDate�$# PropertyChanged=�  $ 	Documento��$
 auto -   NroDocumento�� .  �� .R�]� $ ]�Name$$ dp��$��1��$��1��$��4.667,3.667,4.667,2.667q�$��Stretch=�$��Stretch=�.+��� % ��Name$	% img��-   $
��Left=�$��004-proximo.png��$��20��$��15��$��0,0,0,-0.333q�& � Cursor$
& Hand��y��� $" Title�' �� 	Converter#' [  $# PropertyChanged=��� $  txtTransType��$��0,0,0,-0.333q�$��95��$! Center=����� $" 	TransType�$# PropertyChanged=�  $
 auto $ Cantidad��-   cantidad�� .  �� .R��� $  txtQuantity��$��Stretch=�$��Stretch=�$��0q�$! Center=����� $" Quantity�$# PropertyChanged=�  $
 auto $ Costos��-   
costos�� .  �� .R��� $  txtQuantity��$��Stretch=�$��Stretch=�$��0q�$! Center=����� $" 	CalcPrice�$# PropertyChanged=�  $
 auto $ Valor Trans��-	   
valorTrans�� .  �� .R��� $  txtQuantity��$��Stretch=�$��Stretch=�$��0q�$! Center=����� $" 
TransValue�$# PropertyChanged=�  $
 auto $ Cantidad Acumulada��-
   cantidadAcumulada�� .  �� .R��� $  txtQuantity��$��Stretch=�$��Stretch=�$��0q�$! Center=����� $" QuantityAcum�$# PropertyChanged=�  $
 auto $ Valor Acumulado��-   valorAcumulado�� .  �� .R��� $  txtQuantity��$��Stretch=�$��Stretch=�$��0q�$! Center=����� $" Balance�$# PropertyChanged=��� -   $  
lblDeFecha��$
��Left=�$��	38,27,0,0q�$
��Wrap=�$��De Fecha��$
��Bold"�$��14(�$	��Top=��� -   $  lblHastaFecha��$
��Left=�$��
308,28,0,0q�$
��Wrap=�$��Hasta��$
��Bold"�$��14(�$	��Top=�(	  "System.Windows.Controls.DatePicker	  -   ( 	 Name$( dpFechaHasta��$
��Left=�$��
367,24,0,0q�$	��Top=�$	��121��$��25�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��	  -   $( dpFechaDesde��$
��Left=�$��
116,24,0,0q�$	��Top=�$	��121��$��25�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3���� -   ) ��Name$) btnOk��$��OK��$
��Left=�$��4,563,0,-1.667q�$	��Top=�$	��100���� -   $% imgExcel��$��	excel.png��$
& Hand��$y�Visible=�* J� RenderTransformOrigin$* 1.591,0.437&�$��40��$��40��$��950,-260,10,260.333q�