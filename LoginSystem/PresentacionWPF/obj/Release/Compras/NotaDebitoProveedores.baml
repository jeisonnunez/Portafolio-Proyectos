   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  !    Vista.NotaDebitoProveedores   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Vista        Vista.Document    Closing$  Window_Closing��   Loaded$ Window_Loaded�� � Title$ Nota Debito Proveedores��$��766.996��$��835.5�� � WindowStartupLocation$ CenterScreen=� � SizeToContent$ WidthAndHeight=� � ContextMenu �� .@�m� -   $��TablaIR��$��Tabla IR�� m� Icon �� $��002-interface.png���� m� -   $��RegistroDiario��$��Registro en el Diario�� �� $��001-division.png�� � 	Resources    ComboBoxButtonStyle �� 
TargetType	 �� Property
 �� Value �� 
TargetType ��Name �� CornerRadius  ComboBoxButtonStyle1  ComboBoxTextBoxStyle ��Name  ComboBoxTextBoxStyle1  ComboBoxStyle � ColumnDefinitions �� 	ClickMode d� 	IsChecked �� Path �� Mode �� RelativeSource �� SelectionBoxItem �� SelectionBoxItemTemplate �� IsDropDownOpen � AllowsTransparency J� SnapsToDevicePixels � ActualWidth �� MaxDropDownHeight K� IsItemsHost-  'System.Windows.Input.KeyboardNavigation   DirectionalNavigation  ComboBoxStyle1��%C  &	        &	 w     &	 �     &	 }    &	     7  7   &	 �    7  7  �� " d�.��� 	 � ��
 �� " d�.R��� $ border��
�������$ 0,3,3,0��$��0,1,1,1q�
�������._��� �� " d�.��� 	 � ��
 �� " d�.R��� $ border�����	#FF2196F3$ 0,3,3,0��$��0,0,0,0q�
�������._��� �� " ��.��� 	 � ��
 �� " ��.R�� .+��� $ 3,0,0,3��$��1,1,0,1q�
�������
�������._��� $ PART_ContentHost���� " ��.��� 	 � ��
 �� " ��.R�� .+��� $ 3,0,0,3��$��0,0,0,0q����	#FF2196F3
�������._��� $ PART_ContentHost���� " ��.��� 	 � ��$
 Center=��� 	 � ��$
 Center=��� 	 � ��
 �� " ��.R��  �� �� $��18��.+��� $��PART_EditableTextBox��8��  $��5,0,0,0q�#��z��$��Center=�$��Center=�d� $��1��$��0q�#��z��8�� |�.  
�������$ Press=� �� $ IsDropDownOpen�$ TwoWay=� �� *TemplatedParent+.��F� $��1��$��Center=�$��Center=�"����        � 	=  	= � z     	
�������� $��ContentSite��#��z #��z #��z��$��Center=�$
��Left=�$��5,0,0,0q�� $��Popup��$��Bottom=�#��z  . |�.  $��Slide=�.��� $��DropDown�� . #��z #��z .+��� $ DropDownBorder��$��1q�$ 3��
�������
��������� $��4,6,4,6q� . .����  . $ 	Contained=��� " ��.��� 	 � ��$
 Center=��� 	 � ��$
 Center=��� 	 � ��
 �� " ��.R��  �� �� $��18��.+��� $��PART_EditableTextBox��8��  $��5,0,0,0q�#��z��
�������$��Center=�$��Center=�d� $��1��$��0q�#��z��8�� |�.  ���	#FF2196F3$ Press=� �� $ IsDropDownOpen�$ TwoWay=� �� *TemplatedParent+.��F� $��1��$��Center=�$��Center=�"����        � 	=  	= � z     	
��������� $��ContentSite��#��z #��z #��z��$��Center=�$
��Left=�$��5,0,0,0q�� $��Popup��$��Bottom=�#��z  . |�.  $��Slide=�.��� $��DropDown�� . #��z #��z .+��� $ DropDownBorder��$��1q�$ 3��
����������	#FF2196F3�� $��4,6,4,6q� . .����  . $ 	Contained=�.���� $
��Auto=�$
��Auto=�.��� $	��715��$��Center=�$	��Top=�$��0,10,0,0q�.+��� -    ��Name$ imgleft�� � Cursor$
 Hand��$��003-anterior-2.png��$
��Left=�$��28��$��	441,4,0,0q�$	��Top=�$��31���� -   $ imgRight��$
 Hand��$��004-proximo.png��$
��Left=�$��28��$��	481,4,0,0q�$	��Top=�$��31��  J� RenderTransformOrigin$  1.296,0.488&��� -   $ imgCrear��$
 Hand��$��001-texto.png��$
��Left=�$��28��$��	328,4,0,0q�$	��Top=�$��31��$  1.296,0.488&��� -   $ 	imgBuscar��$
 Hand��$��002-encontrar.png��$
��Left=�$��28��$��	367,4,0,0q�$	��Top=�$��31��$  1.296,0.488&��� -   $ 	imgInicio��$
 Hand��$��001-anterior.png��$
��Left=�$��28��$��	405,4,0,0q�$	��Top=�$��31��$  1.296,0.488&��� -   $ imgFin��$
 Hand��$��002-anterior-1.png��$
��Left=�$��28��$��	517,4,0,0q�$	��Top=�$��31��$  1.296,0.488&��� -	   ! ��Name$! tcFacturaProveedores��$
��Left=�$	��244��$��
36,228,0,0q�$	��Top=�$	��772�� " ��Name# �� Triggers$ P� Property% P� Value& �� 
TargetName��%�  '��       �� " ��.��� 	 � ��
 �� " ��.R��� $��Border��$��1,1,1,0q�
�������$ 4,4,0,0��$	��2,0q�._��� $" ContentSite��$��Center=�$��Center=�$��Header��$
��10,2q�# P� $ �@��
IsSelected% . . ��� $& Border��	 � ��
 �	#FF2196F3�� 	 � ��

 ������� 	 � ��$
 14(�P� $ �@��
IsSelected% .  . ��� $& Border��	 � ��

 �����.@��� -
   $��tabContenido��$��	Contenido��$
��Bold"�.��� ���	#FFE5E5E5$��Stretch=�$��Stretch=�.+�&   System.Windows.Controls.DataGrid  -   '  Name$' 
dgServicio��$��Normal"�{�.  $��1q�(   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$( * 
�������$
��Left=�$	��145��$��	10,54,0,0q�$	��Top=�$	��745��)   AutoGenerateColumns) .  *   CanUserDeleteRows* .  +   CanUserSortColumns+ . ,   SelectionMode$, Single=�$-   HorizontalScrollBarVisibility$
- Auto=�".   VerticalScrollBarVisibility$
. Auto=�$��Center=�$��Center=�/   GridLinesVisibility$	/ All=�0   VerticalGridLinesBrush
0 �����1   HorizontalGridLinesBrush
1 �����2   SelectionUnit$2 FullRow=�3   	CellStyle3 �� *  $System.Windows.Controls.DataGridCell"  4 �� Triggers4 P� $ �@J�IsMouseOver% . . ��� 	 � ��
 �	#FF74C1FF�� 	 � ��

 �   ��� 	 � ��$
 Normal"�.��� 	 � ��$
 30���� 	 � ��$
 Center=��� 	 � ��$
 Center=��� 	 �@��TextAlignment$
 Center=��� 	 � ��$
 Center=�5   RowStyle5 �� )  #System.Windows.Controls.DataGridRow"  4 P� $ �@J�IsMouseOver% . . ��� 	 � ��

 ������� 	 � ��$
 Normal"�6 �� 	Resources6 7 �� Color��%�   (��       * SystemColors.HighlightBrushKey+)(��      *$"SystemColors.HighlightTextBrushKey+)�� $7 Transparent���� $7 Black��   TextBoxStyle8 �� Binding9 �� Value  TextBoxStyleNotReadOnly  TextBlockStyle 	 CenterCellStyle��%$  &	       &	 �     &	 �     &		 !    �� " ��.��� 	 � ��
 �	#FF74C1FF�� 	 � ��$
 Normal"�4 �� 8 �� $ 
DataSource�9 N.a��� 	 �@��
IsReadOnly
 . �� 	 � ��

 ������� " ��.��� 	 � ��
 �	#FF74C1FF�� " ��4 �� 8 �� $ 
DataSource�9 N.a��� 	 � ��

 ������� "  .��� 	 � ��
 �� "  .R�� #��z��.+��� $��Center=�$��Center=�$
��auto��4 P� $ �@J�IsMouseOver% . . ��� 	 � ��
 �	#FF74C1FF�� 	 � ��

 �   ��� 	 � ��$
 Normal"�:   Columns: 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn;   Header$; Descripcion��<   Width$
< auto -   
codigo��=   CellEditingTemplate= �� .R��� $��txtDscription��
���   �#��[ ���� $ 
Dscription�> �� UpdateSourceTrigger$> PropertyChanged=�?   CellTemplate? �� .R��� $��txtDscription��$��Normal"�
���   ����� $ 
Dscription�$> PropertyChanged=�  $; Cuenta de Mayor��$
< auto -   cuentademayor��= �� .R��� $��bd��$��1q�
�������$ 3��._�]� $��dp��$��1��$��1��$��Stretch=�$��Stretch=�.+��� $��imgAcctCode��-   $��Right=�$��lupa.png��$��20��$y�Visible=�$
 Hand���� @ ��Name$@ txtAcctCode��$��12(�$��Stretch=�
���   �#��[ 
�������$��0q�$
��auto������ $ AcctCode�$> PropertyChanged=�? �� .R��� $��txtAcctCode��$��Normal"�#��[ 
���   ����� $ AcctCode�$> PropertyChanged=�  $; Nombre Cuenta de Mayor��$
< auto -   nombrecuentamayor��= �� .R��� $��txtAcctName��
���   �A �� 
IsReadOnlyA . ���	#FFE5E5E5#��[ ���� $ AcctName�$> PropertyChanged=�? �� .R��� $��txtAcctName��$��Normal"�#��[ 
���   ����	#FFE5E5E5���� $ AcctName�$> PropertyChanged=�  $; Indicador de Impuesto��$
< auto -   indicadorimpuestoml��= �� .R��� $��bd��$��1q�
�������$ 3��._�]� $��dp��$��1��$��1��$��Stretch=�$��Stretch=�.+��� $��
imgTaxCode��-   $��Right=�$��lupa.png��$��20��$y�Visible=�$
 Hand���� $@ 
txtTaxCode��-   $��12(�$��Stretch=�
���   �#��[ 
�������$��0q�$
��auto������ $ VatGroup�$> PropertyChanged=�? �� .R��� $��
txtTaxCode��$��Normal"�#��[ 
���   ����� $ VatGroup�$> PropertyChanged=�4	  .System.Windows.Controls.DataGridComboBoxColumn	  -   cbSujetoRetencion��$!; Sujeto a Retencion Impuesto��$
< auto B   	CellStyle#B [	 C 	  ItemsSourceC �� *ListSujetoRetencion+D 	  DisplayMemberPathD �� *
WtLiable+E 	  SelectedValueBindingE �� *
WtLiable+  $; 	Total(ML)��$
< auto -   dttotals��= �� .R��� $��txtLineTotal��-   
���   �#��[ ���� $ 	LineTotal�$> PropertyChanged=�.��? �� .R��� $��txtLineTotal��$��Normal"�
���   ����� $ 	LineTotal�$> PropertyChanged=�  $; 	Total(ME)��$
< auto -   
dttotalmes��F   
Visibility$F Hidden=�= �� .R��� $��txtTotalFrgn��-   
���   �#��[ ���� *	TotalFrgn+$> PropertyChanged=�? �� .R��� $��txtTotalFrgn��$��Normal"�
���   ����� $ 	TotalFrgn�$> PropertyChanged=�0
  *System.Windows.Controls.DataGridTextColumn
  $F Hidden=�1  +System.Windows.Controls.DataGridBoundColumnG   BindingG �� $ VatSum�$> PropertyChanged=�
  $F Hidden=�G �� $ 
VatSumFrgn�$> PropertyChanged=�
  $F Hidden=�G �� $ VatSumSy�$> PropertyChanged=�
  $F Hidden=�G �� $ 
TotalSumSy�$> PropertyChanged=�
  $F Hidden=�G �� $ VatPrcnt�$> PropertyChanged=�
  $F Hidden=�G �� $ GTotal�$> PropertyChanged=�
  $F Hidden=�G �� $ GTotalFC�$> PropertyChanged=�
  $F Hidden=�G �� $ GTotalSC�$> PropertyChanged=�  -   $' 
dgArticulo��$��Normal"�{�.  $y�Hidden=�$��1q�$( * 
�������$
��Left=�$	��145��$��	10,54,0,0q�$	��Top=�$	��745��) .  * .  + . $, Single=�$
- Auto=�$
. Auto=�$��Center=�$��Center=�$	/ All=�
0 �����
1 �����$2 FullRow=�3 �� "  4 P� $ �@J�IsMouseOver% . . ��� 	 � ��
 �	#FF74C1FF�� 	 � ��

 �   ��� 	 � ��$
 Normal"�.��� 	 � ��$
 30���� 	 � ��$
 Center=��� 	 � ��$
 Center=��� 	 �@��TextAlignment$
 Center=��� 	 � ��$
 Center=�5 �� "  4 P� $ �@J�IsMouseOver% . . ��� 	 � ��

 ������� 	 � ��$
 Normal"�6 ��%�   (��       * SystemColors.HighlightBrushKey+)(��      *$"SystemColors.HighlightTextBrushKey+)�� $7 Transparent���� $7 Black�� ��%
  &	       &	 �     &	 �     &		 !    �� " ��.��� 	 � ��
 �	#FF74C1FF�� 	 � ��$
 Normal"�4 �� 8 �� $ 
DataSource�9 N.a��� 	 �@��
IsReadOnly
 . �� 	 � ��

 ������� " ��.��� 	 � ��
 �	#FF74C1FF�� " ��4 �� 8 �� $ 
DataSource�9 N.a��� 	 � ��

 ������� "  .��� 	 � ��
 �� "  .R�� #��z��.+��� $��Center=�$��Center=�$
��auto��4 P� $ �@J�IsMouseOver% . . ��� 	 � ��
 �	#FF74C1FF�� 	 � ��

 �   �:   $; Numero de Articulo��$
< auto -   numeroarticulo��= �� .R��� $��bd��$��1q�
�������$ 3��._�]� $��dp��$��1��$��1��$��Stretch=�$��Stretch=�.+��� $��imgItemCode��-   $��Right=�$��lupa.png��$��20��$y�Visible=�$
 Hand���� $@ txtItemCode��$��12(�$��Stretch=�
���   �#��[ 
�������$��0q�$
��auto������ $ ItemCode�$> PropertyChanged=�? �� .R��� $��txtItemCode��#��[ $��Normal"�
���   ����� $ ItemCode�$> PropertyChanged=�  $; Cantidad��$
< auto -   cantidad��= �� .R��� $��txtQuantity��
���   �#��[ ���� $ Quantity�$> PropertyChanged=�? �� .R��� $��txtQuantity��$��Normal"�
���   �#��[ ���� $ Quantity�$> PropertyChanged=�  $; Precio por Unidad��$
< auto -   preciounidad��= �� .R��� $��txtPrice��
���   �#��[ ���� $ Price�$> PropertyChanged=�? �� .R��� $��txtPrice��$��Normal"�
���   �#��[ ���� $ Price�$> PropertyChanged=�  $; Indicador de Impuesto��$
< auto -   indicadorimpuestoitem��= �� .R��� $��bd��$��1q�
�������$ 3��._�]� $��dp��$��1��$��1��$��Stretch=�$��Stretch=�.+��� $��imgTaxCodeItem��-   $��Right=�$��lupa.png��$��20��$y�Visible=�$
 Hand���� $@ txtTaxCodeItem��-   $��12(�$��Stretch=�
���   �#��[ 
�������$��0q�$
��auto������ $ VatGroup�$> PropertyChanged=�? �� .R��� $��txtTaxCodeItem��$��Normal"�#��[ 
���   ����� $ VatGroup�$> PropertyChanged=�	  -    cbSujetoRetencionItem��$!; Sujeto a Retencion Impuesto��$
< auto H 	  EditingElementStyle#H [ C �� *ListSujetoRetencion+D �� *
WtLiable+E �� *
WtLiable+  $; 	Total(ML)��$
< auto -!   dttotali��$F Visible=�= �� .R��� $��txtLineTotal��-"   
���   �#��[ ���� $ 	LineTotal�$> PropertyChanged=�? �� .R��� $��txtLineTotal��$��Normal"�
���   �#��[ ���� $ 	LineTotal�$> PropertyChanged=�  $; 	Total(ME)��$
< auto -#   
dttotalmei��$F Hidden=�= �� .R��� $��txtTotalFrgn��-$   
���   �#��[ ���� $ 	TotalFrgn�$> PropertyChanged=�? �� .R��� $��txtTotalFrgn��$��Normal"�
���   �#��[ ���� $ 	TotalFrgn�$> PropertyChanged=�  $; Cuenta de Mayor��$
< auto -%   cuentademayorItem��= �� .R��� $��bd��$��1q�
�������$ 3��._�]� $��dp��$��1��$��1��$��Stretch=�$��Stretch=�.+��� $��imgAcctCode��-&   $��Right=�$��lupa.png��$��20��$y�Visible=�$
 Hand���� $@ txtAcctCode��$��12(�$��Stretch=�
���   �#��[ 
�������$��0q�$
��auto������ $ AcctCode�$> PropertyChanged=�? �� .R��� $��txtAcctCode��$��Normal"�
���   �#��[ ���� $ AcctCode�$> PropertyChanged=�  $; Nombre Cuenta de Mayor��$
< auto -'   nombrecuentamayorItem��= �� .R��� $��txtAcctName��
���   �A . ���	#FFE5E5E5#��[ ���� $ AcctName�$> PropertyChanged=�? �� .R��� $��txtAcctName��
���   ����	#FFE5E5E5$��Normal"�#��[ ���� $ AcctName�$> PropertyChanged=�
  $F Hidden=�G �� $ VatSum�$> PropertyChanged=�
  $F Hidden=�G �� $ 
VatSumFrgn�$> PropertyChanged=�
  $F Hidden=�G �� $ VatSumSy�$> PropertyChanged=�
  $F Hidden=�G �� $ 
TotalSumSy�$> PropertyChanged=�
  $F Hidden=�G �� $ VatPrcnt�$> PropertyChanged=�
  $F Hidden=�G �� $ GTotal�$> PropertyChanged=�
  $F Hidden=�G �� $ GTotalFC�$> PropertyChanged=�
  $F Hidden=�G �� $ GTotalSC�$> PropertyChanged=��� -(   I ��Name$I cbClase��#��[ $��23��
�������J �� 
IsReadOnlyJ . 
���   �$��1q�$
��Left=�$��	142,5,0,0q�$	��Top=�$	��103��$��12(�$��Normal"�K �� DisplayMemberPathK �� *ClaseFactura+L �� SelectedValuePathL �� *ClaseFactura+���� *ListClaseFactura+�� -)   M ��Name$M lblClase��$
��Bold"�$
��Left=�$��	10,10,0,0q�$
��Wrap=�$��Clase Articulo/Servicio��$	��Top=�$��11(�
���   ��� -*   $��tabLogistica��$��	Logistica��$
��Bold"�.��� ���	#FFE5E5E5.+��� -+   $M 
lblDestino��
���   �$��12(�$
��Bold"�$
��Left=�$��	16,14,0,0q�$
��Wrap=�$��Destino��$	��Top=��� -,   $@ 
txtDestino��$��12(�$��Normal"�
���   �$��1q�
�������$
��Left=�$��82��$��
131,10,0,0q�N �� TextWrapping$
N Wrap=�$	��Top=�$	��162��.�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��.���� --   $M lblPagar��
���   �$��12(�$
��Bold"�$
��Left=�$��
16,123,0,0q�$
��Wrap=�$��Pagar a��$	��Top=��� -.   $@ txtPagar��$��1q�$��12(�$��Normal"�
���   �
�������$
��Left=�$��82��$��131,119,0,0q�$
N Wrap=�$	��Top=�$	��162��.�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��.���� -/   $��tabFinanzas��$��Finanzas��$
��Bold"�.��� ���	#FFE5E5E5.+��� -0   $M lblEntradaDiario��$��12(�
���   �$
��Bold"�$
��Left=�$��	24,24,0,0q�$
��Wrap=�$��Entrada Diario��$	��Top=�$��95���� -1   $@ txtEntradaDiario��$��1q�
�������$
��Left=�$��23��$��
140,20,0,0q�$
N Wrap=�$	��Top=�$	��164��$��12(�$��Normal"�
���   �.�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��.���� -2   $M lblCuentaAsociada��$��12(�
���   �$
��Bold"�$
��Left=�$��	24,54,0,0q�$
��Wrap=�$��Cuenta Asociada��$	��Top=�$��95���� -3   $��bdCuentaAsociada��$��1q�
�������$ 3��$��140,50,462.333,138.333q�
�������._�]� -4   $��dpCuentaAsociada��$��1��$��1��$��4.667,1.5,4.667,1q�$��Stretch=�$��Stretch=�
�������.+��� -5   $��imgCuentaAsociada��$��Right=�$��lupa.png��$��20��$��0,0,0,-0.333q�$y�Hidden=�$
 Hand���� -6   $@ txtCuentaAsociada��$��12(�$��Normal"�$��Stretch=�
�������$��0q�$��0,0,0,-0.333q�$	��130��
���   �$	��Top=��� -7   $M lblRIF��$��12(�
���   �$
��Bold"�$
��Left=�$��	24,84,0,0q�$
��Wrap=�$	��RIF��$	��Top=�$	��111���� -8   $@ txtRIF��$��1q�
�������$
��Left=�$��23��$��
140,80,0,0q�$
N Wrap=�$	��Top=�$	��164��$��12(�$��Normal"�
���   �.�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��.���� -9   $M lblProveedor��$
��Bold"�$
��Left=�$��	41,33,0,0q�$
��Wrap=�$��	Proveedor��$	��Top=��� -:   $��bdProveedor��$��1q�
�������$ 3��$��
156,26,0,0q�
�������$
��Left=�$	��162��$��25��$	��Top=�._�]� -;   $��dpProveedor��$��1��$��1��$��4.667,0.667,4.667,0.5q�
�������.+��� -<   $��imgProveedor��$��Right=�$��lupa.png��$��20��$��0,0,0,-0.333q�$y�Hidden=�$
 Hand���� -=   $@ txtProveedor��$��12(�$��Normal"�
�������$��0q�$��0,0,0,0.333q�$	��130��
���   �$	��Top=�$��Stretch=�$��Stretch=��� ->   $M 	lblNombre��$
��Bold"�$
��Left=�$��	41,63,0,0q�$
��Wrap=�$��Nombre��$	��Top=��� -?   $@ 	txtNombre��$��1q�
�������$
��Left=�$��23��$��
156,59,0,0q�$
N Wrap=�$	��Top=�$	��162��.�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��.���� -@   $M lblNroFactura��$
��Bold"�$
��Left=�$��	41,93,0,0q�$
��Wrap=�$��Nro Factura��$	��Top=��� -A   $@ txtNroFactura��$��1q�
�������$
��Left=�$��23��$��
156,89,0,0q�$
N Wrap=�$	��Top=�$	��162��.�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��.���� -B   $M lblNroControl��$
��Bold"�$
��Left=�$��
41,123,0,0q�$
��Wrap=�$��Nro Control��$	��Top=��� -C   $@ txtNroControl��$��1q�
�������$
��Left=�$��23��$��156,119,0,0q�$
N Wrap=�$	��Top=�$	��162��.�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��.���� -D   $I cbMoneda��#��[ $K CurrName��$L CurrCode��$��23��
�������J . 
���   �$��1q�$
��Left=�$��156,185,0,0q�$	��Top=�$	��162���� -E   $M lblTipoTransaccion��$
��Bold"�$
��Left=�$��
41,153,0,0q�$
��Wrap=�$��Tipo Transaccion��$	��Top=��� -F   $I cbTipoTransaccion��#��[ $��23��
�������J . 
���   �$
��Left=�$��156,151,0,0q�$	��Top=�$	��162������ *ListTipoTransacction+K �� *TipoTransaccion+L �� *TipoTransaccion+�� -G   $M lblNro��$
��Bold"�$
��Left=�$��
545,33,0,0q�$
��Wrap=�$	��Nro��$	��Top=��� -H   $@ txtNro��A . ���	#FFE5E5E5$��1q�$
��Left=�$��23��$��
674,29,0,0q�$
N Wrap=�$	��Top=�$	��128��.�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��.���� -I   $M 	lblEstado��$
��Bold"�$
��Left=�$��
547,63,0,0q�$
��Wrap=�$��Estado��$	��Top=��� -J   $@ 	txtEstado��$��1q�A . ���	#FFE5E5E5$
��Left=�$��23��$��
674,59,0,0q�$
N Wrap=�$	��Top=�$	��128��.�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��.���� -K   $M lblContabilizacion��$
��Bold"�$
��Left=�$��
547,94,0,0q�$
��Wrap=�$��Fecha Contabilizacion��$	��Top=�(  "System.Windows.Controls.DatePicker  -L   O  Name$O dpContabilizacion��$
��Left=�$��
674,89,0,0q�$	��Top=�$	��128�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3���� -M   $M lblVencimiento��$
��Bold"�$
��Left=�$��547,128,0,0q�$
��Wrap=�$��Fecha Vencimiento��$	��Top=�  -N   $O dpVencimiento��$
��Left=�$��674,123,0,0q�$	��Top=�$	��128�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3���� -O   $M lblDocumento��$
��Bold"�$
��Left=�$��547,158,0,0q�$
��Wrap=�$��Fecha Documento��$	��Top=�  -P   $O dpDocumento��$
��Left=�$��674,153,0,0q�$	��Top=�$	��128�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3���� -Q   P ��Name$P btnCrear��$��Crear��$
��Left=�$��
36,679,0,0q�$	��Top=�$��95��$��3q��� -R   $P btnCancelar��$��Cancelar��$
��Left=�$��158,679,0,0q�$	��Top=�$��94��$��3q�
�������
��������� -S   $I 
cbCopiarDe��#��[ $��3q�$��30��J . $��1q�$
��Left=�$��528,679,0,0q�$	��Top=�$	��111��Q �� Text$Q 	Copiar de��R �� 
IsEditableR . $
��Bold"�$��Center=�$��Center=�.@��� ���	#FF2196F3$
��Bold"�$��Entrada Mercancia��
��������� -T   $I 	cbCopiarA��#��[ $��3q�$��30��J . $��1q�$
��Left=�$��674,679,0,0q�$	��Top=�$	��107��
�������$Q Copiar a��R . $
��Bold"�$��Center=�$��Center=�.@��� ���	#FF2196F3$
��Bold"�$��Nota Credito Proveedores��
��������� -U   $M lblComentario��$
��Bold"�$
��Left=�$��
39,495,0,0q�$
��Wrap=�$��
Comentario��$	��Top=��� -V   $@ txtComentario��$��1q�
�������$
��Left=�$��82��$��154,491,0,0q�$
N Wrap=�$	��Top=�$	��162��.�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��.���� -W   $M lblImpuesto��$
��Bold"�$
��Left=�$��528,510,0,0q�$
��Wrap=�$��Impuesto��$	��Top=�$��59���� -X   $@ txtImpuesto��$��1q����	#FFE5E5E5A . $
��Left=�$��23��$��644,506,0,0q�$
N Wrap=�$	��Top=�$	��164��.�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��.���� -Y   $M lblRetenciones��$
��Bold"�$
��Left=�$��528,540,0,0q�$
��Wrap=�$��Retenciones��$	��Top=�$��68���� -Z   $@ txtRetenciones��$��1q����	#FFE5E5E5A . $
��Left=�$��23��$��644,536,0,0q�$
N Wrap=�$	��Top=�$	��164��.�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��.���� -[   $M lblTotalDocumento��$
��Bold"�$
��Left=�$��528,570,0,0q�$
��Wrap=�$��Total��$	��Top=�$	��111���� -\   $@ txtTotalDocumento��$��1q����	#FFE5E5E5A . $
��Left=�$��23��$��644,566,0,0q�$
N Wrap=�$	��Top=�$	��164��.�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��.���� -]   $M 
lblImporte��$
��Bold"�$
��Left=�$��528,600,0,0q�$
��Wrap=�$��Importe aplicado��$	��Top=�$	��111���� -^   $@ 
txtImporte��$��1q����	#FFE5E5E5A . $
��Left=�$��23��$��644,596,0,0q�$
N Wrap=�$	��Top=�$	��164��.�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��.���� -_   $M lblSaldo��$
��Bold"�$
��Left=�$��528,628,0,0q�$
��Wrap=�$��Saldo Pendiente��$	��Top=�$	��111���� -`   $@ txtSaldo��$��1q����	#FFE5E5E5A . $
��Left=�$��23��$��644,624,0,0q�$
N Wrap=�$	��Top=�$	��164��.�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��.���� -a   $M lblMonedaSN��$
��Bold"�$
��Left=�$��
41,189,0,0q�$
��Wrap=�$��	Moneda SN��$	��Top=��� -b   $M lblTotalAntesDescuento��$
��Bold"�$
��Left=�$��528,482,0,0q�$
��Wrap=�$��SubTotal��$	��Top=�$��59���� -c   $@ txtTotalAntesDescuento��$��1q����	#FFE5E5E5A . $
��Left=�$��23��$��644,478,0,0q�$
N Wrap=�$	��Top=�$	��164��.�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��.��