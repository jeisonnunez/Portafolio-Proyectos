   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista      Vista.EntregaMercancia   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Vista        Vista.Document    Closing$  Window_Closing��   Loaded$ Window_Loaded�� � Title$ EntregaMercancia��$��766.996��$��835.5�� � WindowStartupLocation$ CenterScreen=� � SizeToContent$ WidthAndHeight=� � 	Resources    ComboBoxButtonStyle �� 
TargetType �� Property �� Value	 �� 
TargetType
 ��Name �� CornerRadius  ComboBoxButtonStyle1  ComboBoxTextBoxStyle ��Name  ComboBoxTextBoxStyle1  ComboBoxStyle � ColumnDefinitions �� 	ClickMode d� 	IsChecked �� Path �� Mode �� RelativeSource �� SelectionBoxItem �� SelectionBoxItemTemplate �� IsDropDownOpen � AllowsTransparency J� SnapsToDevicePixels � ActualWidth �� MaxDropDownHeight K� IsItemsHost-  'System.Windows.Input.KeyboardNavigation   DirectionalNavigation  ComboBoxStyle1��%C  &	        &	 w     &	 �     &	 }    &	     7  7   &	 �    7  7  �� " d�.���  � �� �� "	 d�.R��� $
 border��
�������$ 0,3,3,0��$��0,1,1,1q�
�������._��� �� " d�.���  � �� �� "	 d�.R��� $
 border�����	#FF2196F3$ 0,3,3,0��$��0,0,0,0q�
�������._��� �� " ��.���  � �� �� "	 ��.R�� .+��� $ 3,0,0,3��$��1,1,0,1q�
�������
�������._��� $ PART_ContentHost���� " ��.���  � �� �� "	 ��.R�� .+��� $ 3,0,0,3��$��0,0,0,0q����	#FF2196F3
�������._��� $ PART_ContentHost���� " ��.���  � ��$ Center=���  � ��$ Center=���  � �� �� "	 ��.R��  �� �� $��18��.+��� $��PART_EditableTextBox��8��  $��5,0,0,0q�#��z��$��Center=�$��Center=�d� $��1��$��0q�#��z��8�� |�.  
�������$ Press=� �� $ IsDropDownOpen�$ TwoWay=� �� *TemplatedParent+.��F� $��1��$��Center=�$��Center=�"����        � 	=  	= � z     	
�������� $��ContentSite��#��z #��z #��z��$��Center=�$
��Left=�$��5,0,0,0q�� $��Popup��$��Bottom=�#��z  . |�.  $��Slide=�.��� $��DropDown�� . #��z #��z .+��� $
 DropDownBorder��$��1q�$ 3��
�������
��������� $��4,6,4,6q� . .����  . $ 	Contained=��� " ��.���  � ��$ Center=���  � ��$ Center=���  � �� �� "	 ��.R��  �� �� $��18��.+��� $��PART_EditableTextBox��8��  $��5,0,0,0q�#��z��
�������$��Center=�$��Center=�d� $��1��$��0q�#��z��8�� |�.  ���	#FF2196F3$ Press=� �� $ IsDropDownOpen�$ TwoWay=� �� *TemplatedParent+.��F� $��1��$��Center=�$��Center=�"����        � 	=  	= � z     	
��������� $��ContentSite��#��z #��z #��z��$��Center=�$
��Left=�$��5,0,0,0q�� $��Popup��$��Bottom=�#��z  . |�.  $��Slide=�.��� $��DropDown�� . #��z #��z .+��� $
 DropDownBorder��$��1q�$ 3��
����������	#FF2196F3�� $��4,6,4,6q� . .����  . $ 	Contained=� � ContextMenu �� .@�m� -   $��RegistroDiario��$��Registro en el Diario�� m� Icon �� $��001-division.png��.���� $
��Auto=�$
��Auto=�.��� $	��715��$��Center=�$	��Top=�.+��� -    ��Name$ imgleft�� � Cursor$
 Hand��$��003-anterior-2.png��$
��Left=�$��28��$��	441,4,0,0q�$	��Top=�$��31���� -   $ imgRight��$
 Hand��$��004-proximo.png��$
��Left=�$��28��$��	481,4,0,0q�$	��Top=�$��31��  J� RenderTransformOrigin$  1.296,0.488&��� -   $ imgCrear��$
 Hand��$��001-texto.png��$
��Left=�$��28��$��	328,4,0,0q�$	��Top=�$��31��$  1.296,0.488&��� -   $ 	imgBuscar��$
 Hand��$��002-encontrar.png��$
��Left=�$��28��$��	367,4,0,0q�$	��Top=�$��31��$  1.296,0.488&��� -   $ 	imgInicio��$
 Hand��$��001-anterior.png��$
��Left=�$��28��$��	405,4,0,0q�$	��Top=�$��31��$  1.296,0.488&��� -   $ imgFin��$
 Hand��$��002-anterior-1.png��$
��Left=�$��28��$��	517,4,0,0q�$	��Top=�$��31��$  1.296,0.488&��� -   ! ��Name$! tcFacturaProveedores��$
��Left=�$	��244��$��
36,228,0,0q�$	��Top=�$	��772�� " ��Name# �� Triggers$ P� Property% P� Value& �� 
TargetName��%�  '��       �� " ��.���  � �� �� "	 ��.R��� $��Border��$��1,1,1,0q�
�������$ 4,4,0,0��$	��2,0q�._��� $" ContentSite��$��Center=�$��Center=�$��Header��$
��10,2q�# P� $ �@��
IsSelected% . . ��� $& Border�� � �� �	#FF2196F3��  � ��
 �������  � ��$ 14(�P� $ �@��
IsSelected% .  . ��� $& Border�� � ��
 �����.@��� -	   $��tabContenido��$��	Contenido��$
��Bold"�.��� ���	#FFE5E5E5$��Stretch=�$��Stretch=�.+�&   System.Windows.Controls.DataGrid  -
   '  Name$' 
dgArticulo��$��Normal"�{�.  $y�Visible=�$��1q�(   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$( * 
�������$
��Left=�$	��145��$��	10,54,0,0q�$	��Top=�$	��745��)   AutoGenerateColumns) .  *   CanUserDeleteRows* .  +   CanUserSortColumns+ . ,   SelectionMode$, Single=�$-   HorizontalScrollBarVisibility$
- Auto=�".   VerticalScrollBarVisibility$
. Auto=�$��Center=�$��Center=�/   GridLinesVisibility$	/ All=�0   VerticalGridLinesBrush
0 �����1   HorizontalGridLinesBrush
1 �����2   SelectionUnit$2 FullRow=�3   	CellStyle3 �� *  $System.Windows.Controls.DataGridCell"  4 �� Triggers4 P� $ �@J�IsMouseOver% . . ���  � �� �	#FF74C1FF��  � ��
 �   ���  � ��$ Normal"�.���  � ��$ 30����  � ��$ Center=���  � ��$ Center=���  �@��TextAlignment$ Center=���  � ��$ Center=�5   RowStyle5 �� )  #System.Windows.Controls.DataGridRow"  4 P� $ �@J�IsMouseOver% . . ���  � ��
 �������  � ��$ Normal"�6 �� 	Resources6 7 �� Color��%�   (��       * SystemColors.HighlightBrushKey+)(��      *$"SystemColors.HighlightTextBrushKey+)�� $7 Transparent���� $7 Black��   TextBoxStyle8 �� Binding9 �� Value  TextBoxStyleNotReadOnly  TextBlockStyle 	 CenterCellStyle��%
  &	       &	 �     &	 �     &		 !    �� " ��.���  � �� �	#FF74C1FF��  � ��$ Normal"�4 �� 8 �� $ 
DataSource�9 N.a���  �@��
IsReadOnly . ��  � ��
 ������� " ��.���  � �� �	#FF74C1FF�� " ��4 �� 8 �� $ 
DataSource�9 N.a���  � ��
 ������� "  .���  � �� �� "	  .R�� #��z��.+��� $��Center=�$��Center=�$
��auto��4 P� $ �@J�IsMouseOver% . . ���  � �� �	#FF74C1FF��  � ��
 �   �:   Columns: 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn;   Header$; Numero de Articulo��<   Width$
< auto -   numeroarticulo��=   CellEditingTemplate= �� .R��� $��bd��$��1q�
�������$ 3��._�]� $��dp��$��1��$��1��$��Stretch=�$��Stretch=�.+��� $��imgItemCode��-   $��Right=�$��lupa.png��$��20��$y�Visible=�$
 Hand���� > ��Name$> txtItemCode��$��12(�$��Stretch=�
���   �#��[ 
�������$��0q�$
��auto������ $ ItemCode�? �� UpdateSourceTrigger$? PropertyChanged=�@   CellTemplate@ �� .R��� $��txtItemCode��#��[ $��Normal"�
���   ����� $ ItemCode�$? PropertyChanged=�  $; Cantidad��$
< auto -   cantidad��= �� .R��� $��txtQuantity��
���   �#��[ ���� $ Quantity�$? PropertyChanged=�@ �� .R��� $��txtQuantity��$��Normal"�
���   �#��[ ���� $ Quantity�$? PropertyChanged=�  $; Precio por Unidad��$
< auto -   preciounidad��= �� .R��� $��txtPrice��
���   �#��[ ���� $ Price�$? PropertyChanged=�@ �� .R��� $��txtPrice��$��Normal"�
���   �#��[ ���� $ Price�$? PropertyChanged=�  $; Indicador de Impuesto��$
< auto -   indicadorimpuestoitem��= �� .R��� $��bd��$��1q�
�������$ 3��._�]� $��dp��$��1��$��1��$��Stretch=�$��Stretch=�.+��� $��imgTaxCodeItem��-   $��Right=�$��lupa.png��$��20��$y�Visible=�$
 Hand���� $> txtTaxCodeItem��-   $��12(�$��Stretch=�
���   �#��[ 
�������$��0q�$
��auto������ $ VatGroup�$? PropertyChanged=�@ �� .R��� $��txtTaxCodeItem��$��Normal"�#��[ 
���   ����� $ VatGroup�$? PropertyChanged=�4	  .System.Windows.Controls.DataGridComboBoxColumn	  -   cbSujetoRetencionItem��$!; Sujeto a Retencion Impuesto��$
< auto A   	CellStyle#A [	 B 	  ItemsSourceB �� *ListSujetoRetencion+C 	  DisplayMemberPathC �� *
WtLiable+D 	  SelectedValueBindingD �� *
WtLiable+  $; 	Total(ML)��$
< auto -   dttotali��E   
Visibility$E Visible=�= �� .R��� $��txtLineTotal��-   
���   �#��[ ���� $ 	LineTotal�$? PropertyChanged=�@ �� .R��� $��txtLineTotal��$��Normal"�
���   �#��[ ���� $ 	LineTotal�$? PropertyChanged=�  $; 	Total(ME)��$
< auto -   
dttotalmei��$E Hidden=�= �� .R��� $��txtTotalFrgn��-   
���   �#��[ ���� $ 	TotalFrgn�$? PropertyChanged=�@ �� .R��� $��txtTotalFrgn��$��Normal"�
���   �#��[ ���� $ 	TotalFrgn�$? PropertyChanged=�  $; Cuenta de Mayor��$
< auto -   cuentademayorItem��= �� .R��� $��bd��$��1q�
�������$ 3��._�]� $��dp��$��1��$��1��$��Stretch=�$��Stretch=�.+��� $��imgAcctCode��-   $��Right=�$��lupa.png��$��20��$y�Visible=�$
 Hand���� $> txtAcctCode��$��12(�$��Stretch=�
���   �#��[ 
�������$��0q�$
��auto������ $ AcctCode�$? PropertyChanged=�@ �� .R��� $��txtAcctCode��$��Normal"�
���   �#��[ ���� $ AcctCode�$? PropertyChanged=�  $; Nombre Cuenta de Mayor��$
< auto -   nombrecuentamayorItem��= �� .R��� $��txtAcctName��
���   �F �� 
IsReadOnlyF . ���	#FFE5E5E5#��[ ���� $ AcctName�$? PropertyChanged=�@ �� .R��� $��txtAcctName��
���   ����	#FFE5E5E5$��Normal"�#��[ ���� $ AcctName�$? PropertyChanged=�0
  *System.Windows.Controls.DataGridTextColumn
  $E Hidden=�1  +System.Windows.Controls.DataGridBoundColumnG   BindingG �� $ VatSum�$? PropertyChanged=�
  $E Hidden=�G �� $ 
VatSumFrgn�$? PropertyChanged=�
  $E Hidden=�G �� $ VatSumSy�$? PropertyChanged=�
  $E Hidden=�G �� $ 
TotalSumSy�$? PropertyChanged=�
  $E Hidden=�G �� $ VatPrcnt�$? PropertyChanged=�
  $E Hidden=�G �� $ GTotal�$? PropertyChanged=�
  $E Hidden=�G �� $ GTotalFC�$? PropertyChanged=�
  $E Hidden=�G �� $ GTotalSC�$? PropertyChanged=��� -   H ��Name$H cbClase��#��[ $��23��
�������I �� 
IsReadOnlyI . 
���   �$��1q�$
��Left=�$��	142,5,0,0q�$	��Top=�$	��103��$��12(�$��Normal"�J �� DisplayMemberPathJ �� *ClaseFactura+K �� SelectedValuePathK �� *ClaseFactura+���� *ListClaseFactura+�� -   L ��Name$L lblClase��$
��Bold"�$
��Left=�$��	10,10,0,0q�$
��Wrap=�$��Clase Articulo/Servicio��$	��Top=�$��11(�
���   ��� -   $��tabLogistica��$��	Logistica��$
��Bold"�.��� ���	#FFE5E5E5.+��� -   $L 
lblDestino��
���   �$��12(�$
��Bold"�$
��Left=�$��	16,14,0,0q�$
��Wrap=�$��Destino��$	��Top=��� -   $> 
txtDestino��$��12(�$��Normal"�
���   �$��1q�
�������$
��Left=�$��82��$��
131,10,0,0q�M �� TextWrapping$
M Wrap=�$	��Top=�$	��162��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -   $L lblPagar��
���   �$��12(�$
��Bold"�$
��Left=�$��
16,123,0,0q�$
��Wrap=�$��Pagar a��$	��Top=��� -    $> txtPagar��$��1q�$��12(�$��Normal"�
���   �
�������$
��Left=�$��82��$��131,119,0,0q�$
M Wrap=�$	��Top=�$	��162��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -!   $��tabFinanzas��$��Finanzas��$
��Bold"�.��� ���	#FFE5E5E5.+��� -"   $L lblEntradaDiario��$��12(�
���   �$
��Bold"�$
��Left=�$��	24,24,0,0q�$
��Wrap=�$��Entrada Diario��$	��Top=�$��95���� -#   $> txtEntradaDiario��$��1q�
�������$
��Left=�$��23��$��
140,20,0,0q�$
M Wrap=�$	��Top=�$	��164��$��12(�$��Normal"�
���   �.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -$   $L lblProveedor��$
��Bold"�$
��Left=�$��	41,33,0,0q�$
��Wrap=�$��Cliente��$	��Top=��� -%   $��bdProveedor��$��1q�
�������$ 3��$��
156,26,0,0q�
�������$
��Left=�$	��162��$��25��$	��Top=�._�]� -&   $��dpProveedor��$��1��$��1��$��4.667,0.667,4.667,0.5q�
�������.+��� -'   $��imgProveedor��$��Right=�$��lupa.png��$��20��$��0,0,0,-0.333q�$y�Hidden=�$
 Hand���� -(   $> txtProveedor��$��12(�$��Normal"�
�������$��0q�$��0,0,0,0.333q�$	��130��
���   �$	��Top=�$��Stretch=�$��Stretch=��� -)   $L 	lblNombre��$
��Bold"�$
��Left=�$��	41,63,0,0q�$
��Wrap=�$��Nombre��$	��Top=��� -*   $> 	txtNombre��$��1q�
�������$
��Left=�$��23��$��
156,59,0,0q�$
M Wrap=�$	��Top=�$	��162��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -+   $L lblNroFactura��$
��Bold"�$
��Left=�$��	41,93,0,0q�$
��Wrap=�$��Nro Entrega��$	��Top=��� -,   $> txtNroFactura��$��1q�
�������$
��Left=�$��23��$��
156,89,0,0q�$
M Wrap=�$	��Top=�$	��162��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� --   $H cbMoneda��#��[ $J CurrName��$K CurrCode��$��23��
�������I . 
���   �$��1q�$
��Left=�$��156,123,0,0q�$	��Top=�$	��162���� -.   $L lblNro��$
��Bold"�$
��Left=�$��
545,33,0,0q�$
��Wrap=�$	��Nro��$	��Top=��� -/   $> txtNro��F . ���	#FFE5E5E5$��1q�$
��Left=�$��23��$��
674,29,0,0q�$
M Wrap=�$	��Top=�$	��128��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -0   $L 	lblEstado��$
��Bold"�$
��Left=�$��
547,63,0,0q�$
��Wrap=�$��Estado��$	��Top=��� -1   $> 	txtEstado��$��1q�F . ���	#FFE5E5E5$
��Left=�$��23��$��
674,59,0,0q�$
M Wrap=�$	��Top=�$	��128��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -2   $L lblContabilizacion��$
��Bold"�$
��Left=�$��
547,94,0,0q�$
��Wrap=�$��Fecha Contabilizacion��$	��Top=�(  "System.Windows.Controls.DatePicker  -3   N  Name$N dpContabilizacion��$
��Left=�$��
674,89,0,0q�$	��Top=�$	��128�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3���� -4   $L lblVencimiento��$
��Bold"�$
��Left=�$��547,128,0,0q�$
��Wrap=�$��Fecha Vencimiento��$	��Top=�  -5   $N dpVencimiento��$
��Left=�$��674,123,0,0q�$	��Top=�$	��128�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3���� -6   $L lblDocumento��$
��Bold"�$
��Left=�$��547,158,0,0q�$
��Wrap=�$��Fecha Documento��$	��Top=�  -7   $N dpDocumento��$
��Left=�$��674,153,0,0q�$	��Top=�$	��128�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3���� -8   O ��Name$O btnCrear��$��Crear��$
��Left=�$��
36,679,0,0q�$	��Top=�$��95��$��3q��� -9   $O btnCancelar��$��Cancelar��$
��Left=�$��158,679,0,0q�$	��Top=�$��94��$��3q�
�������
��������� -:   $H 
cbCopiarDe��#��[ $��3q�$��30��I . $��1q�$
��Left=�$��528,679,0,0q�$	��Top=�$	��111��P �� Text$P 	Copiar de��Q �� 
IsEditableQ . $
��Bold"�$��Center=�$��Center=�.@��� ���	#FF2196F3$
��Bold"�$��Entrada Mercancia��
��������� -;   $H 	cbCopiarA��#��[ $��3q�$��30��I . $��1q�$
��Left=�$��674,679,0,0q�$	��Top=�$	��107��
�������$P Copiar a��Q . $
��Bold"�$��Center=�$��Center=�.@��� ���	#FF2196F3$
��Bold"�$��Nota Credito Proveedores��
��������� -<   $L lblComentario��$
��Bold"�$
��Left=�$��
39,495,0,0q�$
��Wrap=�$��
Comentario��$	��Top=��� -=   $> txtComentario��$��1q�
�������$
��Left=�$��82��$��154,491,0,0q�$
M Wrap=�$	��Top=�$	��162��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� ->   $L lblImpuesto��$
��Bold"�$
��Left=�$��528,510,0,0q�$
��Wrap=�$��Impuesto��$	��Top=�$��59���� -?   $> txtImpuesto��$��1q����	#FFE5E5E5F . $
��Left=�$��23��$��644,506,0,0q�$
M Wrap=�$	��Top=�$	��164��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -@   $L lblRetenciones��$
��Bold"�$
��Left=�$��528,540,0,0q�$
��Wrap=�$��Retenciones��$	��Top=�$��68���� -A   $> txtRetenciones��$��1q����	#FFE5E5E5F . $
��Left=�$��23��$��644,536,0,0q�$
M Wrap=�$	��Top=�$	��164��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -B   $L lblTotalDocumento��$
��Bold"�$
��Left=�$��528,570,0,0q�$
��Wrap=�$��Total��$	��Top=�$	��111���� -C   $> txtTotalDocumento��$��1q����	#FFE5E5E5F . $
��Left=�$��23��$��644,566,0,0q�$
M Wrap=�$	��Top=�$	��164��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -D   $L 
lblImporte��$
��Bold"�$
��Left=�$��528,600,0,0q�$
��Wrap=�$��Importe aplicado��$	��Top=�$	��111���� -E   $> 
txtImporte��$��1q����	#FFE5E5E5F . $
��Left=�$��23��$��644,596,0,0q�$
M Wrap=�$	��Top=�$	��164��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -F   $L lblSaldo��$
��Bold"�$
��Left=�$��528,628,0,0q�$
��Wrap=�$��Saldo Pendiente��$	��Top=�$	��111���� -G   $> txtSaldo��$��1q����	#FFE5E5E5F . $
��Left=�$��23��$��644,624,0,0q�$
M Wrap=�$	��Top=�$	��164��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -H   $L lblMonedaSN��$
��Bold"�$
��Left=�$��
41,127,0,0q�$
��Wrap=�$��	Moneda SN��$	��Top=��� -I   $L lblTotalAntesDescuento��$
��Bold"�$
��Left=�$��528,482,0,0q�$
��Wrap=�$��SubTotal��$	��Top=�$��59���� -J   $> txtTotalAntesDescuento��$��1q����	#FFE5E5E5F . $
��Left=�$��23��$��644,478,0,0q�$
M Wrap=�$	��Top=�$	��164��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.��