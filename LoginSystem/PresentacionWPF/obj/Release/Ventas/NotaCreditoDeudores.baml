   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista      Vista.NotaCreditoDeudores   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Vista        Vista.Document    Closing$  Window_Closing��   Loaded$ Window_Loaded�� � Title$ NotaCreditoDeudores��$��766.996��$��835.5�� � WindowStartupLocation$ CenterScreen=� � SizeToContent$ WidthAndHeight=� J� CommandBindings )  #System.Windows.Input.CommandBinding  -      Command$  local:CustomCommands3.Exit�� � ContextMenu �� .@�m� -   $��TablaIR��$��Tabla IR�� m� Icon �� $��002-interface.png���� m� -   $��RegistroDiario��$��Registro en el Diario�� �� $��001-division.png��	 � 	Resources	    ComboBoxButtonStyle
 �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� CornerRadius  ComboBoxButtonStyle1  ComboBoxTextBoxStyle ��Name  ComboBoxTextBoxStyle1  ComboBoxStyle � ColumnDefinitions �� 	ClickMode d� 	IsChecked �� Path �� Mode �� RelativeSource �� SelectionBoxItem �� SelectionBoxItemTemplate �� IsDropDownOpen � AllowsTransparency J� SnapsToDevicePixels � ActualWidth �� MaxDropDownHeight K� IsItemsHost-  'System.Windows.Input.KeyboardNavigation   DirectionalNavigation  ComboBoxStyle1��%C  &	        &	 w     &	 �     &	 }    &	     7  7   &	 �    7  7  �� "
 d�.���  � �� �� " d�.R��� $ border��
�������$ 0,3,3,0��$��0,1,1,1q�
�������._��� �� "
 d�.���  � �� �� " d�.R��� $ border�����	#FF2196F3$ 0,3,3,0��$��0,0,0,0q�
�������._��� �� "
 ��.���  � �� �� " ��.R�� .+��� $ 3,0,0,3��$��1,1,0,1q�
�������
�������._��� $ PART_ContentHost���� "
 ��.���  � �� �� " ��.R�� .+��� $ 3,0,0,3��$��0,0,0,0q����	#FF2196F3
�������._��� $ PART_ContentHost���� "
 ��.���  � ��$ Center=���  � ��$ Center=���  � �� �� " ��.R��  �� �� $��18��.+��� $��PART_EditableTextBox��8��  $��5,0,0,0q�#��z��$��Center=�$��Center=�d� $��1��$��0q�#��z��8�� |�.  
�������$ Press=� �� $ IsDropDownOpen�$ TwoWay=� �� *TemplatedParent+.��F� $��1��$��Center=�$��Center=�"����        � 	=  	= � z     	
�������� $��ContentSite��#��z #��z #��z��$��Center=�$
��Left=�$��5,0,0,0q�� $��Popup��$��Bottom=�#��z  . |�.  $��Slide=�.��� $��DropDown�� . #��z #��z .+��� $ DropDownBorder��$��1q�$ 3��
�������
��������� $��4,6,4,6q� . .����  . $ 	Contained=��� "
 ��.���  � ��$ Center=���  � ��$ Center=���  � �� �� " ��.R��  �� �� $��18��.+��� $��PART_EditableTextBox��8��  $��5,0,0,0q�#��z��
�������$��Center=�$��Center=�d� $��1��$��0q�#��z��8�� |�.  ���	#FF2196F3$ Press=� �� $ IsDropDownOpen�$ TwoWay=� �� *TemplatedParent+.��F� $��1��$��Center=�$��Center=�"����        � 	=  	= � z     	
��������� $��ContentSite��#��z #��z #��z��$��Center=�$
��Left=�$��5,0,0,0q�� $��Popup��$��Bottom=�#��z  . |�.  $��Slide=�.��� $��DropDown�� . #��z #��z .+��� $ DropDownBorder��$��1q�$ 3��
����������	#FF2196F3�� $��4,6,4,6q� . .����  . $ 	Contained=�.���� $
��Auto=�$
��Auto=�.��� $	��715��$��Center=�$	��Top=�.+��� -     ��Name$  imgleft��! � Cursor$
! Hand��$��003-anterior-2.png��$
��Left=�$��28��$��	441,4,0,0q�$	��Top=�$��31���� -   $  imgRight��$
! Hand��$��004-proximo.png��$
��Left=�$��28��$��	481,4,0,0q�$	��Top=�$��31��" J� RenderTransformOrigin$" 1.296,0.488&��� -   $  imgCrear��$
! Hand��$��001-texto.png��$
��Left=�$��28��$��	328,4,0,0q�$	��Top=�$��31��$" 1.296,0.488&��� -   $  	imgBuscar��$
! Hand��$��002-encontrar.png��$
��Left=�$��28��$��	367,4,0,0q�$	��Top=�$��31��$" 1.296,0.488&��� -   $  	imgInicio��$
! Hand��$��001-anterior.png��$
��Left=�$��28��$��	405,4,0,0q�$	��Top=�$��31��$" 1.296,0.488&��� -	   $  imgFin��$
! Hand��$��002-anterior-1.png��$
��Left=�$��28��$��	517,4,0,0q�$	��Top=�$��31��$" 1.296,0.488&��� -
   # ��Name$# tcFacturaProveedores��$
��Left=�$	��244��$��
36,228,0,0q�$	��Top=�$	��772��	 $ ��Name% �� Triggers& P� Property' P� Value( �� 
TargetName��%�  '��       �� "
 ��.���  � �� �� " ��.R��� $��Border��$��1,1,1,0q�
�������$ 4,4,0,0��$	��2,0q�._��� $$ ContentSite��$��Center=�$��Center=�$��Header��$
��10,2q�% P� & �@��
IsSelected' . . ��� $( Border�� � �� �	#FF2196F3��  � ��
 �������  � ��$ 14(�P� & �@��
IsSelected' .  . ��� $( Border�� � ��
 �����.@��� -   $��tabContenido��$��	Contenido��$
��Bold"�.��� ���	#FFE5E5E5$��Stretch=�$��Stretch=�.+�&   System.Windows.Controls.DataGrid  -   )  Name$) 
dgServicio��$��Normal"�{�.  $��1q�*   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$* * 
�������$
��Left=�$	��145��$��	10,54,0,0q�$	��Top=�$	��745��+   AutoGenerateColumns+ .  ,   CanUserDeleteRows, .  -   CanUserSortColumns- . .   SelectionMode$. Single=�$/   HorizontalScrollBarVisibility$
/ Auto=�"0   VerticalScrollBarVisibility$
0 Auto=�$��Center=�$��Center=�1   GridLinesVisibility$	1 All=�2   VerticalGridLinesBrush
2 �����3   HorizontalGridLinesBrush
3 �����4   SelectionUnit$4 FullRow=�5   	CellStyle5 �� *  $System.Windows.Controls.DataGridCell"
  6 �� Triggers6 P� & �@J�IsMouseOver' . . ���  � �� �	#FF74C1FF��  � ��
 �   ���  � ��$ Normal"�.���  � ��$ 30����  � ��$ Center=���  � ��$ Center=���  �@��TextAlignment$ Center=���  � ��$ Center=�7   RowStyle7 �� )  #System.Windows.Controls.DataGridRow"
  6 P� & �@J�IsMouseOver' . . ���  � ��
 �������  � ��$ Normal"�8 �� 	Resources8 9 �� Color��%�   (��       * SystemColors.HighlightBrushKey+)(��      *$"SystemColors.HighlightTextBrushKey+)�� $9 Transparent���� $9 Black��.���  �@�Tag ��  �� : �� AncestorType": �$ DataContext���  �@�ContextMenu �� ; � DataContext; �� *PlacementTarget.Tag+ �� *Self+.@�m� $��Eliminar��< m� Command$ < local:CustomCommands3.Exit��	   TextBoxStyle= �� Binding> �� Value  TextBoxStyleNotReadOnly  TextBlockStyle 	 CenterCellStyle��%$  &	       &	 �     &	 �     &		 !    �� "
 ��.���  � �� �	#FF74C1FF��  � ��$ Normal"�6 �� = �� $ 
DataSource�> N.a���  �@��
IsReadOnly . ��  � ��
 ������� "
 ��.���  � �� �	#FF74C1FF�� "
 ��6 �� = �� $ 
DataSource�> N.a���  � ��
 ������� "
  .���  � �� �� "  .R�� #��z��.+��� $��Center=�$��Center=�$
��auto��6 P� & �@J�IsMouseOver' . . ���  � �� �	#FF74C1FF��  � ��
 �   ���  � ��$ Normal"�?   Columns? 4  .System.Windows.Controls.DataGridTemplateColumn  ,	  &System.Windows.Controls.DataGridColumn@ 	  Header$@ Descripcion��A 	  Width$
A auto -   
codigo��B   CellEditingTemplateB �� .R��� $��txtDscription��
���   �#��[ ���� $ 
Dscription�C �� UpdateSourceTrigger$C PropertyChanged=�D   CellTemplateD �� .R��� $��txtDscription��$��Normal"�
���   ����� $ 
Dscription�$C PropertyChanged=�  $@ Cuenta de Mayor��$
A auto -   cuentademayor��B �� .R��� $��bd��$��1q�
�������$ 3��._�]� $��dp��$��1��$��1��$��Stretch=�$��Stretch=�.+��� $��imgAcctCode��-   $��Right=�$��lupa.png��$��20��$y�Visible=�$
! Hand���� E ��Name$E txtAcctCode��$��12(�$��Stretch=�
���   �#��[ 
�������$��0q�$
��auto������ $ AcctCode�$C PropertyChanged=�D �� .R��� $��txtAcctCode��$��Normal"�#��[ 
���   ����� $ AcctCode�$C PropertyChanged=�  $@ Nombre Cuenta de Mayor��$
A auto -   nombrecuentamayor��B �� .R��� $��txtAcctName��
���   �F �� 
IsReadOnlyF . ���	#FFE5E5E5#��[ ���� $ AcctName�$C PropertyChanged=�D �� .R��� $��txtAcctName��$��Normal"�#��[ 
���   ����	#FFE5E5E5���� $ AcctName�$C PropertyChanged=�  $@ Indicador de Impuesto��$
A auto -   indicadorimpuestoml��B �� .R��� $��bd��$��1q�
�������$ 3��._�]� $��dp��$��1��$��1��$��Stretch=�$��Stretch=�.+��� $��
imgTaxCode��-   $��Right=�$��lupa.png��$��20��$y�Visible=�$
! Hand���� $E 
txtTaxCode��-   $��12(�$��Stretch=�
���   �#��[ 
�������$��0q�$
��auto������ $ VatGroup�$C PropertyChanged=�D �� .R��� $��
txtTaxCode��$��Normal"�#��[ 
���   ����� $ VatGroup�$C PropertyChanged=�4
  .System.Windows.Controls.DataGridComboBoxColumn
  -   cbSujetoRetencion��$!@ Sujeto a Retencion Impuesto��$
A auto G 
  EditingElementStyle#G [ H 
  ItemsSourceH �� *ListSujetoRetencion+I 
  DisplayMemberPathI �� *
WtLiable+J 
  SelectedValueBindingJ �� *
WtLiable+  $@ 	Total(ML)��$
A auto -   dttotals��B �� .R��� $��txtLineTotal��-   
���   �#��[ ���� $ 	LineTotal�$C PropertyChanged=�.��D �� .R��� $��txtLineTotal��$��Normal"�
���   ����� $ 	LineTotal�$C PropertyChanged=�  $@ 	Total(ME)��$
A auto -   
dttotalmes��K 	  
Visibility$K Hidden=�B �� .R��� $��txtTotalFrgn��-   
���   �#��[ ���� *	TotalFrgn+$C PropertyChanged=�D �� .R��� $��txtTotalFrgn��$��Normal"�
���   ����� $ 	TotalFrgn�$C PropertyChanged=�0  *System.Windows.Controls.DataGridTextColumn  $K Hidden=�1  +System.Windows.Controls.DataGridBoundColumnL   BindingL �� $ VatSum�$C PropertyChanged=�  $K Hidden=�L �� $ 
VatSumFrgn�$C PropertyChanged=�  $K Hidden=�L �� $ VatSumSy�$C PropertyChanged=�  $K Hidden=�L �� $ 
TotalSumSy�$C PropertyChanged=�  $K Hidden=�L �� $ VatPrcnt�$C PropertyChanged=�  $K Hidden=�L �� $ GTotal�$C PropertyChanged=�  $K Hidden=�L �� $ GTotalFC�$C PropertyChanged=�  $K Hidden=�L �� $ GTotalSC�$C PropertyChanged=�  -   $) 
dgArticulo��$��Normal"�{�.  $y�Hidden=�$��1q�$* * 
�������$
��Left=�$	��145��$��	10,54,0,0q�$	��Top=�$	��745��+ .  , .  - . $. Single=�$
/ Auto=�$
0 Auto=�$��Center=�$��Center=�$	1 All=�
2 �����
3 �����$4 FullRow=�5 �� "
  6 P� & �@J�IsMouseOver' . . ���  � �� �	#FF74C1FF��  � ��
 �   ���  � ��$ Normal"�.���  � ��$ 30����  � ��$ Center=���  � ��$ Center=���  �@��TextAlignment$ Center=���  � ��$ Center=�7 �� "
  6 P� & �@J�IsMouseOver' . . ���  � ��
 �������  � ��$ Normal"�8 ��%�   (��       * SystemColors.HighlightBrushKey+)(��      *$"SystemColors.HighlightTextBrushKey+)�� $9 Transparent���� $9 Black��.���  �@�Tag ��  �� ": �$ DataContext���  �@�ContextMenu �� ; �� *PlacementTarget.Tag+ �� *Self+.@�m� $��Eliminar��$ < local:CustomCommands3.Exit��	 ��%
  &	       &	 �     &	 �     &		 !    �� "
 ��.���  � �� �	#FF74C1FF��  � ��$ Normal"�6 �� = �� $ 
DataSource�> N.a���  �@��
IsReadOnly . ��  � ��
 ������� "
 ��.���  � �� �	#FF74C1FF�� "
 ��6 �� = �� $ 
DataSource�> N.a���  � ��
 ������� "
  .���  � �� �� "  .R�� #��z��.+��� $��Center=�$��Center=�$
��auto��6 P� & �@J�IsMouseOver' . . ���  � �� �	#FF74C1FF��  � ��
 �   �?   $@ Numero de Articulo��$
A auto -   numeroarticulo��B �� .R��� $��bd��$��1q�
�������$ 3��._�]� $��dp��$��1��$��1��$��Stretch=�$��Stretch=�.+��� $��imgItemCode��-   $��Right=�$��lupa.png��$��20��$y�Visible=�$
! Hand���� $E txtItemCode��$��12(�$��Stretch=�
���   �#��[ 
�������$��0q�$
��auto������ $ ItemCode�$C PropertyChanged=�D �� .R��� $��txtItemCode��#��[ $��Normal"�
���   ����� $ ItemCode�$C PropertyChanged=�  $@ Cantidad��$
A auto -   cantidad��B �� .R��� $��txtQuantity��
���   �#��[ ���� $ Quantity�$C PropertyChanged=�D �� .R��� $��txtQuantity��$��Normal"�
���   �#��[ ���� $ Quantity�$C PropertyChanged=�  $@ Precio por Unidad��$
A auto -   preciounidad��B �� .R��� $��txtPrice��
���   �#��[ ���� $ Price�$C PropertyChanged=�D �� .R��� $��txtPrice��$��Normal"�
���   �#��[ ���� $ Price�$C PropertyChanged=�  $@ Indicador de Impuesto��$
A auto -   indicadorimpuestoitem��B �� .R��� $��bd��$��1q�
�������$ 3��._�]� $��dp��$��1��$��1��$��Stretch=�$��Stretch=�.+��� $��imgTaxCodeItem��-   $��Right=�$��lupa.png��$��20��$y�Visible=�$
! Hand���� $E txtTaxCodeItem��-    $��12(�$��Stretch=�
���   �#��[ 
�������$��0q�$
��auto������ $ VatGroup�$C PropertyChanged=�D �� .R��� $��txtTaxCodeItem��$��Normal"�#��[ 
���   ����� $ VatGroup�$C PropertyChanged=�
  -!   cbSujetoRetencionItem��$!@ Sujeto a Retencion Impuesto��$
A auto #G [ H �� *ListSujetoRetencion+I �� *
WtLiable+J �� *
WtLiable+  $@ 	Total(ML)��$
A auto -"   dttotali��$K Visible=�B �� .R��� $��txtLineTotal��-#   
���   �#��[ ���� $ 	LineTotal�$C PropertyChanged=�D �� .R��� $��txtLineTotal��$��Normal"�
���   �#��[ ���� $ 	LineTotal�$C PropertyChanged=�  $@ 	Total(ME)��$
A auto -$   
dttotalmei��$K Hidden=�B �� .R��� $��txtTotalFrgn��-%   
���   �#��[ ���� $ 	TotalFrgn�$C PropertyChanged=�D �� .R��� $��txtTotalFrgn��$��Normal"�
���   �#��[ ���� $ 	TotalFrgn�$C PropertyChanged=�  $@ Cuenta de Mayor��$
A auto -&   cuentademayorItem��B �� .R��� $��bd��$��1q�
�������$ 3��._�]� $��dp��$��1��$��1��$��Stretch=�$��Stretch=�.+��� $��imgAcctCode��-'   $��Right=�$��lupa.png��$��20��$y�Visible=�$
! Hand���� $E txtAcctCode��$��12(�$��Stretch=�
���   �#��[ 
�������$��0q�$
��auto������ $ AcctCode�$C PropertyChanged=�D �� .R��� $��txtAcctCode��$��Normal"�
���   �#��[ ���� $ AcctCode�$C PropertyChanged=�  $@ Nombre Cuenta de Mayor��$
A auto -(   nombrecuentamayorItem��B �� .R��� $��txtAcctName��
���   �F . ���	#FFE5E5E5#��[ ���� $ AcctName�$C PropertyChanged=�D �� .R��� $��txtAcctName��
���   ����	#FFE5E5E5$��Normal"�#��[ ���� $ AcctName�$C PropertyChanged=�  $K Hidden=�L �� $ VatSum�$C PropertyChanged=�  $K Hidden=�L �� $ 
VatSumFrgn�$C PropertyChanged=�  $K Hidden=�L �� $ VatSumSy�$C PropertyChanged=�  $K Hidden=�L �� $ 
TotalSumSy�$C PropertyChanged=�  $K Hidden=�L �� $ VatPrcnt�$C PropertyChanged=�  $K Hidden=�L �� $ GTotal�$C PropertyChanged=�  $K Hidden=�L �� $ GTotalFC�$C PropertyChanged=�  $K Hidden=�L �� $ GTotalSC�$C PropertyChanged=��� -)   M ��Name$M cbClase��#��[ $��23��
�������N �� 
IsReadOnlyN . 
���   �$��1q�$
��Left=�$��	142,5,0,0q�$	��Top=�$	��103��$��12(�$��Normal"�O �� DisplayMemberPathO �� *ClaseFactura+P �� SelectedValuePathP �� *ClaseFactura+���� *ListClaseFactura+�� -*   Q ��Name$Q lblClase��$
��Bold"�$
��Left=�$��	10,10,0,0q�$
��Wrap=�$��Clase Articulo/Servicio��$	��Top=�$��11(�
���   ��� -+   $��tabLogistica��$��	Logistica��$
��Bold"�.��� ���	#FFE5E5E5.+��� -,   $Q 
lblDestino��
���   �$��12(�$
��Bold"�$
��Left=�$��	16,14,0,0q�$
��Wrap=�$��Destino��$	��Top=��� --   $E 
txtDestino��$��12(�$��Normal"�
���   �$��1q�
�������$
��Left=�$��82��$��
131,10,0,0q�R �� TextWrapping$
R Wrap=�$	��Top=�$	��162��.��	 ��%9   '��       �� "
 ��.���  �@��CornerRadius$ 3��.���� -.   $Q lblPagar��
���   �$��12(�$
��Bold"�$
��Left=�$��
16,123,0,0q�$
��Wrap=�$��Pagar a��$	��Top=��� -/   $E txtPagar��$��1q�$��12(�$��Normal"�
���   �
�������$
��Left=�$��82��$��131,119,0,0q�$
R Wrap=�$	��Top=�$	��162��.��	 ��%9   '��       �� "
 ��.���  �@��CornerRadius$ 3��.���� -0   $��tabFinanzas��$��Finanzas��$
��Bold"�.��� ���	#FFE5E5E5.+��� -1   $Q lblEntradaDiario��$��12(�
���   �$
��Bold"�$
��Left=�$��	24,24,0,0q�$
��Wrap=�$��Entrada Diario��$	��Top=�$��95���� -2   $E txtEntradaDiario��$��1q�
�������$
��Left=�$��23��$��
140,20,0,0q�$
R Wrap=�$	��Top=�$	��164��$��12(�$��Normal"�
���   �.��	 ��%9   '��       �� "
 ��.���  �@��CornerRadius$ 3��.���� -3   $Q lblCuentaAsociada��$��12(�
���   �$
��Bold"�$
��Left=�$��	24,54,0,0q�$
��Wrap=�$��Cuenta Asociada��$	��Top=�$��95���� -4   $��bdCuentaAsociada��$��1q�
�������$ 3��$��140,50,462.333,138.333q�
�������._�]� -5   $��dpCuentaAsociada��$��1��$��1��$��4.667,1.5,4.667,1q�$��Stretch=�$��Stretch=�
�������.+��� -6   $��imgCuentaAsociada��$��Right=�$��lupa.png��$��20��$��0,0,0,-0.333q�$y�Hidden=�$
! Hand���� -7   $E txtCuentaAsociada��$��12(�$��Normal"�$��Stretch=�
�������$��0q�$��0,0,0,-0.333q�$	��130��
���   �$	��Top=��� -8   $Q lblRIF��$��12(�
���   �$
��Bold"�$
��Left=�$��	24,84,0,0q�$
��Wrap=�$	��RIF��$	��Top=�$	��111���� -9   $E txtRIF��$��1q�
�������$
��Left=�$��23��$��
140,80,0,0q�$
R Wrap=�$	��Top=�$	��164��$��12(�$��Normal"�
���   �.��	 ��%9   '��       �� "
 ��.���  �@��CornerRadius$ 3��.���� -:   $Q 
lblCliente��$
��Bold"�$
��Left=�$��	41,33,0,0q�$
��Wrap=�$��Cliente��$	��Top=��� -;   $��	bdCliente��$��1q�
�������$ 3��$��
156,26,0,0q�
�������$
��Left=�$	��162��$��25��$	��Top=�._�]� -<   $��	dpCliente��$��1��$��1��$��4.667,0.667,4.667,0.5q�
�������.+��� -=   $��
imgCliente��$��Right=�$��lupa.png��$��20��$��0,0,0,-0.333q�$y�Hidden=�$
! Hand���� ->   $E 
txtCliente��$��12(�$��Normal"�
�������$��0q�$��0,0,0,0.333q�$	��130��
���   �$	��Top=�$��Stretch=�$��Stretch=��� -?   $Q 	lblNombre��$
��Bold"�$
��Left=�$��	41,63,0,0q�$
��Wrap=�$��Nombre��$	��Top=��� -@   $E 	txtNombre��$��1q�
�������$
��Left=�$��23��$��
156,59,0,0q�$
R Wrap=�$	��Top=�$	��162��.��	 ��%9   '��       �� "
 ��.���  �@��CornerRadius$ 3��.���� -A   $Q lblNroFactura��$
��Bold"�$
��Left=�$��	41,93,0,0q�$
��Wrap=�$��Nro Nota Credito��$	��Top=��� -B   $E txtNroFactura��$��1q�
�������$
��Left=�$��23��$��
156,89,0,0q�$
R Wrap=�$	��Top=�$	��162��.��	 ��%9   '��       �� "
 ��.���  �@��CornerRadius$ 3��.���� -C   $Q lblNroControl��$
��Bold"�$
��Left=�$��
41,123,0,0q�$
��Wrap=�$��Nro Control��$	��Top=��� -D   $E txtNroControl��$��1q�
�������$
��Left=�$��23��$��156,119,0,0q�$
R Wrap=�$	��Top=�$	��162��.��	 ��%9   '��       �� "
 ��.���  �@��CornerRadius$ 3��.���� -E   $M cbMoneda��#��[ $O CurrName��$P CurrCode��$��23��
�������N . 
���   �$��1q�$
��Left=�$��156,185,0,0q�$	��Top=�$	��162���� -F   $Q lblTipoTransaccion��$
��Bold"�$
��Left=�$��
41,153,0,0q�$
��Wrap=�$��Tipo Transaccion��$	��Top=��� -G   $M cbTipoTransaccion��#��[ $��23��
�������N . 
���   �$
��Left=�$��156,151,0,0q�$	��Top=�$	��162������ *ListTipoTransacction+O �� *TipoTransaccion+P �� *TipoTransaccion+�� -H   $Q lblNro��$
��Bold"�$
��Left=�$��
545,33,0,0q�$
��Wrap=�$	��Nro��$	��Top=��� -I   $E txtNro��F . ���	#FFE5E5E5$��1q�$
��Left=�$��23��$��
674,29,0,0q�$
R Wrap=�$	��Top=�$	��128��.��	 ��%9   '��       �� "
 ��.���  �@��CornerRadius$ 3��.���� -J   $Q 	lblEstado��$
��Bold"�$
��Left=�$��
547,63,0,0q�$
��Wrap=�$��Estado��$	��Top=��� -K   $E 	txtEstado��$��1q�F . ���	#FFE5E5E5$
��Left=�$��23��$��
674,59,0,0q�$
R Wrap=�$	��Top=�$	��128��.��	 ��%9   '��       �� "
 ��.���  �@��CornerRadius$ 3��.���� -L   $Q lblContabilizacion��$
��Bold"�$
��Left=�$��
547,94,0,0q�$
��Wrap=�$��Fecha Contabilizacion��$	��Top=�(  "System.Windows.Controls.DatePicker  -M   S  Name$S dpContabilizacion��$
��Left=�$��
674,89,0,0q�$	��Top=�$	��128��	 ��%9   '��       �� "
 ��.���  �@��CornerRadius$ 3���� -N   $Q lblVencimiento��$
��Bold"�$
��Left=�$��547,128,0,0q�$
��Wrap=�$��Fecha Vencimiento��$	��Top=�  -O   $S dpVencimiento��$
��Left=�$��674,123,0,0q�$	��Top=�$	��128��	 ��%9   '��       �� "
 ��.���  �@��CornerRadius$ 3���� -P   $Q lblDocumento��$
��Bold"�$
��Left=�$��547,158,0,0q�$
��Wrap=�$��Fecha Documento��$	��Top=�  -Q   $S dpDocumento��$
��Left=�$��674,153,0,0q�$	��Top=�$	��128��	 ��%9   '��       �� "
 ��.���  �@��CornerRadius$ 3���� -R   T ��Name$T btnCrear��$��Crear��$
��Left=�$��
36,679,0,0q�$	��Top=�$��95��$��3q��� -S   $T btnCancelar��$��Cancelar��$
��Left=�$��158,679,0,0q�$	��Top=�$��94��$��3q�
�������
��������� -T   $M 
cbCopiarDe��#��[ $��3q�$��30��N . $��1q�$
��Left=�$��528,679,0,0q�$	��Top=�$	��111��U �� Text$U 	Copiar de��V �� 
IsEditableV . $
��Bold"�$��Center=�$��Center=�.@��� ���	#FF2196F3$
��Bold"�$��Entrada Mercancia��
��������� -U   $M 	cbCopiarA��#��[ $��3q�$��30��N . $��1q�$
��Left=�$��674,679,0,0q�$	��Top=�$	��107��
�������$U Copiar a��V . $
��Bold"�$��Center=�$��Center=�.@��� ���	#FF2196F3$
��Bold"�$��Nota Credito Proveedores��
��������� -V   $Q lblComentario��$
��Bold"�$
��Left=�$��
39,495,0,0q�$
��Wrap=�$��
Comentario��$	��Top=��� -W   $E txtComentario��$��1q�
�������$
��Left=�$��82��$��154,491,0,0q�$
R Wrap=�$	��Top=�$	��162��.��	 ��%9   '��       �� "
 ��.���  �@��CornerRadius$ 3��.���� -X   $Q lblImpuesto��$
��Bold"�$
��Left=�$��528,510,0,0q�$
��Wrap=�$��Impuesto��$	��Top=�$��59���� -Y   $E txtImpuesto��$��1q����	#FFE5E5E5F . $
��Left=�$��23��$��644,506,0,0q�$
R Wrap=�$	��Top=�$	��164��.��	 ��%9   '��       �� "
 ��.���  �@��CornerRadius$ 3��.���� -Z   $Q lblRetenciones��$
��Bold"�$
��Left=�$��528,540,0,0q�$
��Wrap=�$��Retenciones��$	��Top=�$��68���� -[   $E txtRetenciones��$��1q����	#FFE5E5E5F . $
��Left=�$��23��$��644,536,0,0q�$
R Wrap=�$	��Top=�$	��164��.��	 ��%9   '��       �� "
 ��.���  �@��CornerRadius$ 3��.���� -\   $Q lblTotalDocumento��$
��Bold"�$
��Left=�$��528,570,0,0q�$
��Wrap=�$��Total��$	��Top=�$	��111���� -]   $E txtTotalDocumento��$��1q����	#FFE5E5E5F . $
��Left=�$��23��$��644,566,0,0q�$
R Wrap=�$	��Top=�$	��164��.��	 ��%9   '��       �� "
 ��.���  �@��CornerRadius$ 3��.���� -^   $Q 
lblImporte��$
��Bold"�$
��Left=�$��528,600,0,0q�$
��Wrap=�$��Importe aplicado��$	��Top=�$	��111���� -_   $E 
txtImporte��$��1q����	#FFE5E5E5F . $
��Left=�$��23��$��644,596,0,0q�$
R Wrap=�$	��Top=�$	��164��.��	 ��%9   '��       �� "
 ��.���  �@��CornerRadius$ 3��.���� -`   $Q lblSaldo��$
��Bold"�$
��Left=�$��528,628,0,0q�$
��Wrap=�$��Saldo Pendiente��$	��Top=�$	��111���� -a   $E txtSaldo��$��1q����	#FFE5E5E5F . $
��Left=�$��23��$��644,624,0,0q�$
R Wrap=�$	��Top=�$	��164��.��	 ��%9   '��       �� "
 ��.���  �@��CornerRadius$ 3��.���� -b   $Q lblMonedaSN��$
��Bold"�$
��Left=�$��
41,189,0,0q�$
��Wrap=�$��	Moneda SN��$	��Top=��� -c   $Q lblTotalAntesDescuento��$
��Bold"�$
��Left=�$��528,482,0,0q�$
��Wrap=�$��SubTotal��$	��Top=�$��59���� -d   $E txtTotalAntesDescuento��$��1q����	#FFE5E5E5F . $
��Left=�$��23��$��644,478,0,0q�$
R Wrap=�$	��Top=�$	��164��.��	 ��%9   '��       �� "
 ��.���  �@��CornerRadius$ 3��.���� -e   $Q lblFacturaAfectada��$
��Bold"�$
��Left=�$��547,193,0,0q�$
��Wrap=�$��Factura Afectada��$	��Top=��� -f   $E txtFacturaAfectada��$��1q�
�������$
��Left=�$��23��$��674,189,0,0q�$
R Wrap=�$	��Top=�$	��128��.��	 ��%9   '��       �� "
 ��.���  �@��CornerRadius$ 3��.��