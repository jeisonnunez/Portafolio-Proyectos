   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista      Vista.CodigosFiscales   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Vista        Vista.Document    Closing$  Window_Closing��   Loaded$ Window_Loaded�� � Title$ CodigosFiscales��$	��450��$	��800�� � WindowStartupLocation$ CenterScreen=� � ContextMenu �� .@�m� -   $��Deleted��$��Eliminar��.��� .+��� -    ��Name$ imgleft�� � Cursor$
 Hand��$��003-anterior-2.png��$
��Left=�$��28��$��	377,6,0,0q�$	��Top=�$��31���� -   $ imgRight��$
 Hand��$��004-proximo.png��$
��Left=�$��28��$��	417,6,0,0q�$	��Top=�$��31�� J� RenderTransformOrigin$ 1.296,0.488&��� -   $ imgCrear��$
 Hand��$��001-texto.png��$
��Left=�$��28��$��	264,6,0,0q�$	��Top=�$��31��$ 1.296,0.488&��� -   $ 	imgBuscar��$
 Hand��$��002-encontrar.png��$
��Left=�$��28��$��	303,6,0,0q�$	��Top=�$��31��$ 1.296,0.488&��� -   $ 	imgInicio��$
 Hand��$��001-anterior.png��$
��Left=�$��28��$��	341,6,0,0q�$	��Top=�$��31��$ 1.296,0.488&��� -   $ imgFin��$
 Hand��$��002-anterior-1.png��$
��Left=�$��28��$��	453,6,0,0q�$	��Top=�$��31��$ 1.296,0.488&�&   System.Windows.Controls.DataGrid  -     Name$ dgCodigosFiscales��$��1q�
�������	   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 * 
   CanUserResizeRows
 .    CanUserSortColumns .    CanUserReorderColumns .    AutoGenerateColumns .     CanUserAddRows .  $
��Left=�$	��196��$��
32,150,0,0q�$	��Top=�$	��730��   VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   SelectionMode$ Single=�   SelectionUnit$ FullRow=�   CanUserDeleteRows .  
���   �$��Center=�$��Center=�   GridLinesVisibility$	 All=�   	CellStyle ��  �� 
TargetType*  $System.Windows.Controls.DataGridCell"   �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ���  �� Property � �� �� Value �	#FF74C1FF.���  � ��$ 30����  � ��$ Center=���  � ��$ Center=���  �@��TextAlignment$ Center=���  � ��$ Center=�   RowStyle �� )  #System.Windows.Controls.DataGridRow"   P�  �@J�IsMouseOver . . ���  � ��
 ����� �� 	Resources  �� Color��%�   (��       * SystemColors.HighlightBrushKey+)(��      *$"SystemColors.HighlightTextBrushKey+)�� $ Transparent���� $ Black�� � 	Resources    TextBoxStyle  TextBoxStyleNotReadOnly  TextBlockStyle  �� Binding! �� Path" �� Value��%�   &	        &	 +     &	 V     �� " ��.���  � �� �	#FF74C1FF�� " ��.���  � �� �	#FF74C1FF�� " �� ��   �� $! 
DataSource�" N.a���  � ��
 �����#   Columns# 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn$   Header$$ Codigo��-	   code��%   Width$% * &   CellTemplate& �� .R��� ' ��Name$	' txt��-
   $��12(�$��Stretch=�
���   �$
��auto������ $
! Code�( �� UpdateSourceTrigger$( PropertyChanged=�)   CellEditingTemplate) �� .R��� $��bd��$��1q�
�������* �� CornerRadius$* 3��._�]� $��dp��$��1��$��1��$��Stretch=�$��Stretch=�.+��� $	��img��-   $��Right=�$��lupa.png��$��20��$y�Visible=�$
 Hand���� + ��Name$	+ txt��-   $��12(�$��Stretch=�
���   �#��[  
�������$��0q�$
��auto������ $
! Code�$( PropertyChanged=�  $% * $$ Nombre��-   name��,   
IsReadOnly, . & �� .R�]� $��dp��$��1��$��1�����	#FFE5E5E5$��Stretch=�$��Stretch=�.+��� $' txtName�����	#FFE5E5E5$��12(�$��Stretch=�$��0,0,0,-0.333q�$��95������ $
! Name�$( PropertyChanged=�) �� .R��� $��txtName��-   
���   �- �� 
IsReadOnly- . ���	#FFE5E5E5#��[  $��Stretch=�$��Stretch=�$��Stretch=�$��Stretch=����� $
! Name�$( PropertyChanged=�  $% * $	$ T/C��-   TC��, . & �� .R�]� $��dp��$��1��$��1�����	#FFE5E5E5$��Stretch=�$��Stretch=�.+��� $' txtRate�����	#FFE5E5E5$��12(�$��Stretch=�$��Stretch=�$��0,0,0,-0.333q�$��95������ $
! Rate�$( PropertyChanged=�  $% * $$ Cuenta Impuesto Ventas��-   	ImpVentas��, . & �� .R�]� $��dp��$��1��$��1�����	#FFE5E5E5$��Stretch=�$��Stretch=�.+��� $' txtSalesTax�����	#FFE5E5E5$��12(�$��Stretch=�$��0,0,0,-0.333q�$��95������ $! SalesTax�$( PropertyChanged=�  $% * $$ Cuenta Impuesto Compras��-   
ImpCompras��, . & �� .R�]� $��dp��$��1��$��1�����	#FFE5E5E5$��Stretch=�$��Stretch=�.+��� $' txtPurchTax�����	#FFE5E5E5$��12(�$��Stretch=�$��0,0,0,-0.333q�$��95������ $! PurchTax�$( PropertyChanged=��� -   . ��Name$. btnOk��$��Crear��$
��Left=�$��
32,365,0,0q�$	��Top=�$��85��$��3q�$��16(��� -   $. btnCancelar��$��Cancelar��$
��Left=�$��144,365,0,0q�$	��Top=�$��89��$��3q�$��16(�
�������
��������� -   $' 	lblCodigo��$
��Bold"�$
��Left=�$��	34,35,0,0q�$
��Wrap=�$��Codigo��$	��Top=��� -   $+ 	txtCodigo��$��1q�
�������$
��Left=�$��23��$��	35,56,0,0q�/ �� TextWrapping$
/ Wrap=�$	��Top=�$	��120������ *Code+.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -   $' 	lblNombre��$
��Bold"�$
��Left=�$��
176,35,0,0q�$
��Wrap=�$��Nombre��$	��Top=��� -   $+ 	txtNombre��$��1q�
�������$
��Left=�$��23��$��
177,56,0,0q�$
/ Wrap=�$	��Top=�$	��286������ *Name+.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -   $' lblTipoImpositivo��$
��Bold"�$
��Left=�$��
486,35,0,0q�$
��Wrap=�$��Tipo Impositivo��$	��Top=��� -   $+ txtTipoImpositivo��$��1q�
�������- . $
��Left=�$��23��$��
487,56,0,0q�$
/ Wrap=�$	��Top=�$	��120������ *Rate+.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -   0 ��Name$0 	cbxVentas��$��Ventas��$
��Left=�$��
486,97,0,0q�$	��Top=�$
��Bold"��� -   $0 
cbxCompras��$��Compras��$
��Left=�$��
594,97,0,0q�$	��Top=�$
��Bold"��� -   $0 cbxInactivo��$��Inactivo��$
��Left=�$��
622,17,0,0q�$	��Top=�$
��Bold"��� -   $' lblAlicuota��$
��Bold"�$
��Left=�$��
34,119,0,0q�$
��Wrap=�$��Alicuota��$	��Top=��� -   1 ��Name$1 
cbAlicuota��  ComboBoxStyle#��[ $
��Left=�$��100,113,0,0q�$	��Top=�$	��133��$��26��2 �� DisplayMemberPath$
2 Code��3 �� SelectedValuePath$
3 Name���� -   $' 	lblValido��$
��Left=�$��
376,97,0,0q�$
��Wrap=�$��Valido para��$
��Bold"�$	��Top=�