   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista      Vista.Articulos   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Vista        Vista.Document    Closing$  Window_Closing��   Loaded$ Window_Loaded�� � Title$ 	Articulos��$	��527��$��868.5�� � WindowStartupLocation$ CenterScreen=� � ContextMenu �� .@�m� -   $��Deleted��$��Eliminar��.���� $
��Auto=�$
��Auto=�.��� $��Center=�$	��Top=�.+��� -    ��Name$ imgleft�� � Cursor$
 Hand��$��003-anterior-2.png��$
��Left=�$��28��$��	473,6,0,0q�$	��Top=�$��31���� -   $ imgRight��$
 Hand��$��004-proximo.png��$
��Left=�$��28��$��	513,6,0,0q�$	��Top=�$��31�� J� RenderTransformOrigin$ 1.296,0.488&��� -   $ imgCrear��$
 Hand��$��001-texto.png��$
��Left=�$��28��$��	360,7,0,0q�$	��Top=�$��31��$ 1.296,0.488&��� -   $ 	imgBuscar��$
 Hand��$��002-encontrar.png��$
��Left=�$��28��$��	399,7,0,0q�$	��Top=�$��31��$ 1.296,0.488&��� -   $ 	imgInicio��$
 Hand��$��001-anterior.png��$
��Left=�$��28��$��	437,7,0,0q�$	��Top=�$��31��$ 1.296,0.488&��� -   $ imgFin��$
 Hand��$��002-anterior-1.png��$
��Left=�$��28��$��	549,7,0,0q�$	��Top=�$��31��$ 1.296,0.488&��� -    ��Name$ lblNroActiculo��$
��Bold"�$
��Left=�$��	41,59,0,0q�$
��Wrap=�$��Numero de articulo��$	��Top=��� -	   	 ��Name$	 txtNroArticulo��$��1q�
�������$
��Left=�$��26��$��
156,54,0,0q�
 �� TextWrapping$

 Wrap=�$	��Top=�$	��186��.�� � 	Resources  �� 
TargetType �� Property �� Value��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -
   $ lblDescripcion��$
��Bold"�$
��Left=�$��	41,91,0,0q�$
��Wrap=�$��Descripcion��$	��Top=��� -   $	 txtDescripcion��$��1q�
�������$
��Left=�$��25��$��
156,85,0,0q�$

 Wrap=�$	��Top=�$	��448��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -   $ lblPrecioUnidad��$
��Bold"�$
��Left=�$��525,128,0,0q�$
��Wrap=�$��Precio por unidad��$	��Top=��� -    ��Name$ cbPrecioUnidad��   ComboBoxStyle#��[  $��23��
������� �� 
IsReadOnly . 
���   �$
��Left=�$��633,125,0,0q�$	��Top=�$��94���� -    ��Name$ btnCrear��$��Crear��$
��Left=�$��
41,431,0,0q�$	��Top=�$��95��$��3q��� -   $ btnCancelar��$��Cancelar��$
��Left=�$��163,431,0,0q�$	��Top=�$��94��$��3q�
�������
��������� -   $ lblListaPrecio��$
��Bold"�$
��Left=�$��
41,128,0,0q�$
��Wrap=�$��Lista de precio��$	��Top=��� -   $ cbListaPrecio��#��[  $��23��
������� . 
���   �$
��Left=�$��156,123,0,0q�$	��Top=�$	��186���� -   $	 	txtPrecio��$��1q�
�������$
��Left=�$��23��$��734,125,0,0q�$

 Wrap=�$	��Top=�$��94��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -    ��Name$ cbxInventario��$��Articulo de inventario��$
��Bold"�$
��Left=�$��
696,38,0,0q�$	��Top=��� -   $ 	cbxCompra��$��Articulo de compra��$
��Bold"�$
��Left=�$��
696,58,0,0q�$	��Top=��� -   $ cbxVenta��$��Articulo venta��$
��Bold"�$
��Left=�$��
696,78,0,0q�$	��Top=��� -    ��Name$ 	tcGeneral��$
��Left=�$	��225��$��
41,188,0,0q�$	��Top=�$	��786��  �� 
TargetType �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  '��       �� " ��.���  � �� �� " ��.R��� $��Border��$��1,1,1,0q�
�������$ 4,4,0,0��$	��2,0q�._��� $ ContentSite��$��Center=�$��Center=�$��Header��$
��10,2q� P�  �@��
IsSelected . . ��� $ Border�� � �� �	#FF2196F3��  � ��
 �������  � ��$ 14(�P�  �@��
IsSelected .  . ��� $ Border�� � ��
 �����.@��� -   $��
tabGeneral��$��General��$
��Bold"�.��� ���	#FFE5E5E5$��Stretch=�$��Stretch=�.+��� -   $ cbxImpuesto��
���   �$��Sujeto a impuesto��$
��Bold"�$
��Left=�$��	10,17,0,0q�$	��Top=�&   System.Windows.Controls.DataGrid  -     Name$ dgItems��
�������$��1q�
�������   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * $
��Left=�$	��127��$��	10,56,0,0q�$	��Top=�$	��378��   CanUserResizeRows .    CanUserSortColumns .    CanUserReorderColumns .     AutoGenerateColumns  .  !   CanUserDeleteRows! .  
���   �$��Center=�$��Center=�"   GridLinesVisibility$	" All=�#   VerticalGridLinesBrush
# �����$   HorizontalGridLinesBrush
$ �����%   SelectionMode$% Extended=�&   SelectionUnit$& FullRow=�'   CanUserAddRows' .  (   
IsReadOnly( . )   	CellStyle) �� *  $System.Windows.Controls.DataGridCell"  * �� Triggers* P�  �@J�IsMouseOver . . ���  � �� �	#FF74C1FF��  � ��
 �   �.���  � ��$ 30����  � ��$ Center=���  � ��$ Center=���  �@��TextAlignment$ Center=���  � ��$ Center=�+   RowStyle+ �� )  #System.Windows.Controls.DataGridRow"  * P�  �@J�IsMouseOver . . ���  � ��
 �����, �� 	Resources, - �� Color��%�   (��       * SystemColors.HighlightBrushKey+)(��      *$"SystemColors.HighlightTextBrushKey+)�� $- Transparent���� $- Black��   TextBoxStyle��%5   &	       �� " ��.���  � �� �	#FF74C1FF.   Columns. 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn/   Header$/ En Stock��0   Width$
0 auto -   
codigo��1   CellTemplate1 �� .R��� $��txtCodeCurrency��
���   ����� *OnHand+2 �� StringFormat$2 
{0:#,0.00}��3 �� UpdateSourceTrigger$3 PropertyChanged=�  $/ Pedido��$
0 auto -   name��1 �� .R��� 
���   ����� *
OnOrders+$2 
{0:#,0.00}��  $/ Comprometido��$
0 auto -   tasa��1 �� .R��� 
���   ����� *
IsCommited+$2 
{0:#,0.00}��  $/ Stock Value��$
0 auto -   	stock��1 �� .R��� $��txtCodeCurrency��
���   ����� *
StockValue+$2 
{0:#,0.00}���� -   $��
tabFinanza��$��Finanzas��$
��Bold"�.��� ���	#FFE5E5E5$��Stretch=�$��Stretch=�.+�  -   $ 	dgCuentas��
�������$��1q�
�������$ * $
��Left=�$	��173��$��	10,10,0,0q�$	��Top=�$	��321�� .  .  .   .  ! .  
���   �$��Center=�$��Center=�$	" All=�
# �����
$ �����$% Extended=�$& FullRow=�' .  $��10(�$��Normal"�) �� "  * P�  �@J�IsMouseOver . . ���  � �� �	#FF74C1FF.���  � ��$ 30����  � ��$ Center=���  � ��$ Center=���  �@��TextAlignment$ Center=���  � ��$ Center=�+ �� "  * P�  �@J�IsMouseOver . . ���  � ��
 �����, ��%�   (��       * SystemColors.HighlightBrushKey+)(��      *$"SystemColors.HighlightTextBrushKey+)�� $- Transparent���� $- Black�� 4 �� Binding5 �� Path6 �� Value  TextBoxStyleNotReadOnly  TextBlockStyle��%%  &	       &	 �     &	 �     �� " ��.���  � �� �	#FF74C1FF* �� 4 �� $5 
DataSource�6 N.a���  �@��
IsReadOnly . ��  � ��
 ������� " ��.���  � �� �	#FF74C1FF�� " ��* �� 4 �� $5 
DataSource�6 N.a���  � ��
 �����.   $/ #��$
0 auto 7   
IsReadOnly7 . -    ID��8   CellEditingTemplate8 �� .R��� $��txtAcctName��
���   �#��[ ���	#FFE5E5E59 �� 
IsReadOnly9 . ���� $5 ID�$3 PropertyChanged=�1 �� .R��� 
���   ����	#FFE5E5E5#��[ ���� $5 ID�$3 PropertyChanged=�  $/ Cuenta��$
0 auto -!   acctCode��8 �� .R��� $��bd��$��1q�
�������$ 3��._�]� $��dp��$��1��$��1��$��Stretch=�$��Stretch=�.+��� $��
imgAccount��-"   $��Right=�$��lupa.png��$��20��$y�Visible=�$
 Hand���� $	 
txtAccount��$��10(�$��Stretch=�
���   �#��[ 
�������$��0q�$
��auto������ $5 AcctCode�$3 PropertyChanged=�1 �� .R��� $��
txtAccount��
���   �#��[ ���� $5 AcctCode�  $/ Nombre de Cuenta��$
0 auto 7 . -#   
nameCuenta��8 �� .R��� $��txtAcctName��
���   �#��[ ���	#FFE5E5E59 . ���� $5 AcctName�$3 PropertyChanged=�1 �� .R��� $��txtAcctName��
���   ����	#FFE5E5E5#��[ ���� $5 AcctName�$3 PropertyChanged=�