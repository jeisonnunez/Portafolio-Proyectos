   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	       Vista.TablaAuditoriaStock   5      n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	      Vista.Converter    Closing$  Window_Closing��5   l      Loaded$ Converter_Loaded��6�    � Title$ TablaAuditoriaStock��6	   $��666.716��6%   $��1447.038��66    � WindowStartupLocation$ CenterScreen=�6G    � 	Resources 5	         Vista.StyleConverter   StyleConverter��%   &	          5   
   6   5      .��5      �� $
��Auto=�6   $
��Auto=�66   .��5   
   � $��Stretch=�6   $��Stretch=�6-   $
��1429��6I    � ColumnDefinitions 5      �� 5      $��* �6#   6/    � RowDefinitions 5      �� 5      $��* �6    6-   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dgInformeStock��5         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6/   $��Stretch=�6?   $��0��6d   $��0��6q   $	��400��6�   $��77,136,77,0q�6�   $��1q�6�   
�������	   AutoGenerateColumns	 .  
   CanUserDeleteRows
 .     CanUserSortColumns .     SelectionMode$ Extended=�6#  $   HorizontalScrollBarVisibility$
 Auto=�6<  "   VerticalScrollBarVisibility$
 Auto=�6a  $	��Top=�6�     GridLinesVisibility$	 All=�6�     VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   CanUserAddRows .     SelectionUnit$ FullRow=�6  $
��Bold"�60  $��10(�6B  
���   ����	#FFE5E5E5$��0q�6|     	CellStyle 5      �� 5       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6   .�5      ��  �� Property � �� �� Value$ 0q�64    �� Triggers 5      �� 5       �� Binding 6*   �� *Num+ �� Value 16B   .a�5   "   ��  � �� �	#FFE5E5E56?   5      �� 5        6*   �� *Num+ 06B   .a�5!   "   ��  � ��
 �����6?   5"      5$         RowStyle 5'      �� 5(      )  #System.Windows.Controls.DataGridRow"  6    �� 	Resources 5+       �� Color��%�   (��       5,   .   * SystemColors.HighlightBrushKey+)(�� %     5-   .   *$"SystemColors.HighlightTextBrushKey+)�� 5,      $ Transparent��6`   �� 5-      $ Black��6d   5.      .�50      ��  � ��$ 0q�64   �� 51       � ��
 �����67   �� 52       �@��
IsReadOnly . 6C   55         Columns 59      4  .System.Windows.Controls.DataGridTemplateColumn  5:      ,  &System.Windows.Controls.DataGridColumn   Width$
 auto 6-       Header$  Nro Articulo��6:   -   5        nroarticulo��!   
IsReadOnly! . "   CellTemplate" 5;      �� 5<      .R�5=   "   �� # ��Name$# 
txtTransId��6�   $��Stretch=�6-   $��Stretch=�6I   $��0q�6g   $ �� TextAlignment$$ Center=�6�   ��6s   �� % �� Path$% ItemCode�& �� UpdateSourceTrigger$& PropertyChanged=�6�   5>      5@        5A      $
 auto 6-   $  Descripcion��6:   -   5        descripcion��! . " 5B      �� 5C      .R�5D   "   �� $# 
txtTransId��6�   $��Stretch=�6-   $��Stretch=�6I   $��0q�6g   $$ Center=�6�   ��6s   �� $% 
Dscription�$& PropertyChanged=�6�   5E      5G        5H      $
 auto 6-   $  Existencias Iniciales��6:   -   5        existenciasIniciales��! . " 5I      �� 5J      .R�5K   "   �� $# 
txtTransId��6�   $��Stretch=�6-   $��Stretch=�6I   $��0q�6g   $$ Center=�6�   ��6s   �� $% 
Dscription�$& PropertyChanged=�6�   5L      5N        5O      $
 auto 6-   $  Fecha Contabilizacion��6:   -   5        refDate��! . " 5P      �� 5Q      .R�5R   "   �� $# 
txtRefDate��6�   $��Stretch=�6-   $��Stretch=�6I   $��0q�6g   $$ Center=�6�   ��6s   �� $% DocDate�$& PropertyChanged=�6�   5S      5U        5X      $  	Documento��6-   $
 auto 6@   -   5        NroDocumento��! . " 5Y      �� 5Z      .R�5[   "   ]� ' ]�Name$' dp��6j   $��1��6,   $��1��69   $��4.667,3.667,4.667,2.667q�6I   $��Stretch=�6v   $��Stretch=�6�   .+�5\   &   �� ( ��Name$	( img��6�   -   5        $
��Left=�5\   h   $��004-proximo.png��6~   $��20��6�   $��15��6�   $��0,0,0,-0.333q�6�   ) � Cursor$
) Hand��6�   y�6�   �� $% Title�* �� 	Converter#* [  $& PropertyChanged=��� 5]   &   $# txtTransType��60   $��0,0,0,-0.333q�6�   $��95��6�   $$ Center=�6�   ��6F   �� $% 	TransType�$& PropertyChanged=�6�   5^   #   5_      5b        5c      $
 auto 6-   $  Cantidad��6:   -   5        cantidad��! . " 5d      �� 5e      .R�5f   "   �� $# txtQuantity��6�   $��Stretch=�6-   $��Stretch=�6I   $��0q�6g   $$ Center=�6�   ��6s   �� $% Quantity�$& PropertyChanged=�6�   5g      5i        5j      $
 auto 6-   $  Costos��6:   -	   5        
costos��! . " 5k      �� 5l      .R�5m   "   �� $# txtQuantity��6�   $��Stretch=�6-   $��Stretch=�6I   $��0q�6g   $$ Center=�6�   ��6s   �� $% 	CalcPrice�$& PropertyChanged=�6�   5n      5p        5q      $
 auto 6-   $  Valor Trans��6:   -
   5        
valorTrans��! . " 5r      �� 5s      .R�5t   "   �� $# txtQuantity��6�   $��Stretch=�6-   $��Stretch=�6I   $��0q�6g   $$ Center=�6�   ��6s   �� $% 
TransValue�$& PropertyChanged=�6�   5u      5w        5x      $
 auto 6-   $  Cantidad Acumulada��6:   -   5        cantidadAcumulada��! . " 5y      �� 5z      .R�5{   "   �� $# txtQuantity��6�   $��Stretch=�6-   $��Stretch=�6I   $��0q�6g   $$ Center=�6�   ��6s   �� $% QuantityAcum�$& PropertyChanged=�6�   5|      5~        5      $
 auto 6-   $  Valor Acumulado��6:   -   5        valorAcumulado��! . " 5�      �� 5�      .R�5�   "   �� $# 
txtBalance��6�   $��Stretch=�6-   $��Stretch=�6I   $��0q�6g   $$ Center=�6�   ��6s   �� $% Balance�$& PropertyChanged=�6�   5�      5�        5�      $
 auto 6-   $  Unidad Recuento��6:   -   5        unidadRecuento��! . " 5�      �� 5�      .R�5�   "   �� $# txtInvntryUomCode��6�   $��Stretch=�6-   $��Stretch=�6I   $��0q�6g   $$ Center=�6�   ��6s   �� $% InvntryUomCode�$& PropertyChanged=�6�   5�      5�        5�      $
 auto 6-   $  Unidad Registro��6:   -   5        unidadRegistro��! . " 5�      �� 5�      .R�5�   "   �� $# 
txtUomCode��6�   $��Stretch=�6-   $��Stretch=�6I   $��0q�6g   $$ Center=�6�   ��6s   �� $% UomCode�$& PropertyChanged=�6�   5�      5�        5�      $
 auto 6-   $  Unidad Base��6:   -   5        unidadComparativa��! . " 5�      �� 5�      .R�5�   "   �� $# txtUomCode2��6�   $��Stretch=�6-   $��Stretch=�6I   $��0q�6g   $$ Center=�6�   ��6s   �� $% UomCode2�$& PropertyChanged=�6�   5�      5�        5�      $
 auto 6-   $  Entradas��6:   -   5        entrada��! . " 5�      �� 5�      .R�5�   "   �� $# txtUomCode2��6�   $��Stretch=�6-   $��Stretch=�6I   $��0q�6g   $$ Center=�6�   ��6s   �� $% InQty�$& PropertyChanged=�6�   5�      5�        5�      $
 auto 6-   $  Entradas (ML)��6:   -   5        	entradaBS��! . " 5�      �� 5�      .R�5�   "   �� $# txtUomCode2��6�   $��Stretch=�6-   $��Stretch=�6I   $��0q�6g   $$ Center=�6�   ��6s   �� $% InValue�$& PropertyChanged=�6�   5�      5�        5�      $
 auto 6-   $  Salida��6:   -   5        
salida��! . " 5�      �� 5�      .R�5�   "   �� $# txtUomCode2��6�   $��Stretch=�6-   $��Stretch=�6I   $��0q�6g   $$ Center=�6�   ��6s   �� $% OutQty�$& PropertyChanged=�6�   5�      5�        5�      $
 auto 6-   $  Salidas (ML)��6:   -   5        salidaML��! . " 5�      �� 5�      .R�5�   "   �� $# txtUomCode2��6�   $��Stretch=�6-   $��Stretch=�6I   $��0q�6g   $$ Center=�6�   ��6s   �� $% OutValue�$& PropertyChanged=�6�   5�      5�        5�      $
 auto 6-   $  Salida Acumulada��6:   -   5        salidaAcumulada��! . " 5�      �� 5�      .R�5�   "   �� $# txtQuantity��6�   $��Stretch=�6-   $��Stretch=�6I   $��0q�6g   $$ Center=�6�   ��6s   �� $% 
OutQtyAcum�$& PropertyChanged=�6�   5�      5�        5�      $
 auto 6-   $  Salida Acumulada (ML)��6:   -   5        salidaAcumuladaML��! . " 5�      �� 5�      .R�5�   "   �� $# txtQuantity��6�   $��Stretch=�6-   $��Stretch=�6I   $��0q�6g   $$ Center=�6�   ��6s   �� $% OutValueAcum�$& PropertyChanged=�6�   5�      5�        5�      $
 auto 6-   $  Entrada Acumulada ��6:   -   5        entradaAcumulada��! . " 5�      �� 5�      .R�5�   "   �� $# txtQuantity��6�   $��Stretch=�6-   $��Stretch=�6I   $��0q�6g   $$ Center=�6�   ��6s   �� $% 	InQtyAcum�$& PropertyChanged=�6�   5�      5�        5�      $
 auto 6-   $  Entrada Acumulada (ML) ��6:   -   5        entradaAcumuladaML��! . " 5�      �� 5�      .R�5�   "   �� $# txtQuantity��6�   $��Stretch=�6-   $��Stretch=�6I   $��0q�6g   $$ Center=�6�   ��6s   �� $% InValueAcum�$& PropertyChanged=�6�   5�      5�        5�      $
 auto 6-   $  Saldo Inicial��6:   -   5        saldoInicial��! . " 5�      �� 5�      .R�5�   "   �� $# txtSaldoInicial��6�   $��Stretch=�6-   $��Stretch=�6I   $��0q�6g   $$ Center=�6�   ��6s   �� $% SaldoInicial�$& PropertyChanged=�6�   5�      5�        5�      $
 auto 6-   $  Cantidad Inicial��6:   -   5        cantidadInicial��! . " 5�      �� 5�      .R�5�   "   �� $# txtCantidadInicial��6�   $��Stretch=�6-   $��Stretch=�6I   $��0q�6g   $$ Center=�6�   ��6s   �� $% CantidadInicial�$& PropertyChanged=�6�   5�      5�        5�      $
 auto 6-   +   
Visibility$+ Hidden=�6:   -   5        ugpEntry��! . " 5�      �� 5�      .R�5�   "   �� $# txtUgpEntry��6�   $��Stretch=�6-   $��Stretch=�6I   $��0q�6g   $$ Center=�6�   ��6s   �� $% UgpEntry�$& PropertyChanged=�6�   5�      5�      5�      �� 5�      -   5        $# 
lblDeFecha��5�      $
��Left=�6,   $��	74,27,0,0q�6G   $
��Wrap=�6Z   $��De Fecha��6n   $
��Bold"�6~   $��14(�6�   $	��Top=�6�   �� 5�      -   5        $# lblHastaFecha��5�      $
��Left=�6/   $��
344,28,0,0q�6J   $
��Wrap=�6^   $��Hasta��6r   $
��Bold"�6   $��14(�6�   $	��Top=�6�   (	  "System.Windows.Controls.DatePicker	  5�      -   5        , 	 Name$, dpFechaHasta��5�      $
��Left=�60   $��
403,24,0,0q�6K   $	��Top=�6_   $	��121��6w   $��25��6�    5�      ��%^   '��       �� 5�      " ��6   .�5�      ��  �@��CornerRadius$ 3��69   5�      5�      5�      	  5�      -   5        $, dpFechaDesde��5�      $
��Left=�60   $��
152,24,0,0q�6K   $	��Top=�6_   $	��121��6w   $��25��6�    5�      ��%^   '��       �� 5�      " ��6   .�5�      ��  �@��CornerRadius$ 3��69   5�      5�      5�      �� 5      -   5        - ��Name$- btnOk��5      $��OK��68   $
��Left=�6E   $��
78,563,0,0q�6`   $	��Top=�6t   $	��100��6�   �� 5     -    5        $( imgExcel��5  �   $��0��6U   $��0��6b   $��	excel.png��6r   $
) Hand��6�   $y�Visible=�6�   . J� RenderTransformOrigin$. 1.591,0.437&�6�   $��40��6�   $��40��6�   $��1312,28,77.333,0q�6�   $	��Top=�6  �� 5     -!   5        $- btnCancelar��5     $��Cancelar��6D   $
��Left=�6W   $��208,563,0,0q�6r   $	��Top=�6�   $	��100��6�   
�������
�������6�   �� 5     -"   5        $- btnStockUnidadesMedida��5     $��Stock Unidades Medida��6Z   $��0,558,77.333,30q�6z   $��32��6�   $��Right=�6�   $	��182��6�   �� 5     -#   5        / ��Name$/ cbxOcultarDetalle��5     0 d� 	IsChecked$
0 TrueY�62   
���   �$
��Bold"�6V   $��Mostrar detalles��6h   $
��Left=�6�   $��	74,73,0,0q�6�   $	��Top=�6�   5     5     5	     