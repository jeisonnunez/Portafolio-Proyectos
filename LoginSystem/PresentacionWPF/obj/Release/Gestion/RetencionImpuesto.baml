   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista      Vista.RetencionImpuesto   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Vista        Vista.Document    Closing$  Window_Closing��   Loaded$ Window_Loaded�� � Title$ Retencion Impuesto��$��439.333��$��1000.667�� � WindowStartupLocation$ CenterScreen=� J� CommandBindings )  #System.Windows.Input.CommandBinding  -      Command$" local:CustomCommandsRet.Exit��.���� $
��Auto=�$
��Auto=�.��� $��Center=�$	��Top=�$��0,20,0,0q�.+�&   System.Windows.Controls.DataGrid  -     Name$ dgRetencionImp�����	#FFE5E5E5$��1q�
�������   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ *    AutoGenerateColumns .  $
��Left=�$	��311��$	��Top=�$	��922��$	   HorizontalScrollBarVisibility$
	 Auto=�"
   VerticalScrollBarVisibility$

 Auto=�   CanUserDeleteRows .  
���   �$��Center=�$��Center=�   GridLinesVisibility$	 All=�   VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   SelectionMode$ Single=�   SelectionUnit$ FullRow=�   	CellStyle ��  �� 
TargetType*  $System.Windows.Controls.DataGridCell"   �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ���  �� Property � �� �� Value �	#FF74C1FF��  � ��
 �   �.���  � ��$ 25����  � ��$ Center=���  � ��$ Center=���  �@��TextAlignment$ Center=���  � ��$ Center=���  � ��$ Center��   RowStyle �� )  #System.Windows.Controls.DataGridRow"   P�  �@J�IsMouseOver . . ���  � ��
 �������  � ��
 �   �.���  �@�Tag ��  �� RelativeSource ��  �� AncestorType" � �� Path$ DataContext���  �@�ContextMenu ��  � DataContext �� *PlacementTarget.Tag+ �� *Self+.@�m� $��Eliminar�� m� Command$" local:CustomCommandsRet.Exit�� � 	Resources    TextBlockStyle �� Binding  �� Value  CenterCellStyle! �� 
TargetType  TextBoxStyle��%V  &	        &	 L     &	     �� " �� ��  �� *
DataSource+  N.a���  � ��
 ������� "  .���  � �� �� "!  .R�� #��z��.+��� $��Center=�$��Center=�$
��auto�� P�  �@J�IsMouseOver . . ���  � �� �	#FF74C1FF��  � ��
 �   ��� " ��.���  � �� �	#FF74C1FF"   Columns" 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn#   Header$# Codigo Retencion��$   Width$
$ auto -   
codigo��%   CellTemplate% �� .R��� $��CodRetencion��
���   ����� $ WTCode�& �� UpdateSourceTrigger$& PropertyChanged=�'   CellEditingTemplate' �� .R��� $��CodRetencion��
���   �#��[ ���� $ WTCode�$& PropertyChanged=�  $# Inactivo��$
$ auto -   inactivo��% �� .R��� $��	inactivos��-   ( d� IsThreeState( .  $��Center=�$��Center=�$��Center=�$��Center=�) d� 	IsChecked) �� $ Inactive�$& PropertyChanged=�' �� .R��� $��	inactivos��-   ( .  $��Center=�$��Center=�$��Center=�$��Center=�) �� $ Inactive�$& PropertyChanged=�  $# Importe Retencion��$
$ auto -   ImptRetencion��% �� .R��� $��ImptRetencion��
���   ����� $ WTName�$& PropertyChanged=�' �� .R��� $��ImptRetencion��
���   �#��[ ���� $ WTName�$& PropertyChanged=�4	  .System.Windows.Controls.DataGridComboBoxColumn	  -   cbCategoria��$# 	Categoria��$
$ auto *   	CellStyle#* [   ComboBoxStyle+ 	  EditingElementStyle#+ [ , 	  ItemsSource, �� *ListCategoria+- 	  DisplayMemberPath- �� $ Category�. 	  SelectedValueBinding. �� $ Category�$& PropertyChanged=�	  -	   
cbTipoBase��$# 	Tipo Base��$
$ auto #+ [ , �� *ListTipoBase+- �� $ BaseType�. �� $ BaseType�$& PropertyChanged=�  $
$ Auto $# Valido Desde��-
   ValidoDesde��' �� .R�(
  "System.Windows.Controls.DatePicker
  / 
  SelectedDate/ �� $ 	EffecDate�0 �� StringFormat$0 {0:dd/MM/yyyy}��$& PropertyChanged=� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��% �� .R��� ���� $ 	EffecDate�$0 {0:dd/MM/yyyy}��$& PropertyChanged=�  $	# T/C��$
$ auto -   tc��% �� .R��� $��tc��
���   ����� $
 Rate�$& PropertyChanged=�' �� .R��� $��tc��
���   �#��[ ���� $
 Rate�$& PropertyChanged=�  $# % Importe Base��$
$ auto -   importeBase��% �� .R��� $��importeBase��
���   ����� $ 
PrctBsAmnt�$& PropertyChanged=�' �� .R��� $��importeBase��
���   �#��[ ���� $ 
PrctBsAmnt�$& PropertyChanged=�  $# Codigo Oficial��$
$ auto -   codigoOficial��% �� .R��� 1 ��Name$1 codigoOficial��
���   ����� $ 	Offclcode�$& PropertyChanged=�' �� .R��� 2 ��Name$2 codigoOficial��
���   �#��[ ���� $ 	Offclcode�$& PropertyChanged=�  $# Cuenta��$
$ auto -   acctCode��' �� .R��� 3 ��Name$3 bd��$��1q�
�������4 �� CornerRadius$4 3��._�]� 5 ]�Name$5 dp��$��1��$��1��$��Stretch=�$��Stretch=�.+��� 6 ��Name$6 
imgAccount��-   $��Right=�$��lupa.png��$��20��$y�Visible=�7 � Cursor$
7 Hand���� $2 
txtAccount��-   $��10(�$��Stretch=�
���   �#��[ 
�������$��0q�$
��auto������ $ Account�$& PropertyChanged=�% �� .R��� $1 
txtAccount��
���   �#��[  ���� $ Account�$& PropertyChanged=�	  -   cbTipoRetencion��$# Tipo Retencion��$
$ auto #* [ #+ [ , �� *ListTipoRetencion+- �� $ U_IDA_TipoRetencion�$& PropertyChanged=�. �� $ U_IDA_TipoRetencion�$& PropertyChanged=�  $# Base Minima��$
$ auto -   
baseMinima��% �� .R��� $1 
baseMinima��
���   ����� $ U_IDA_BaseMinima�$& PropertyChanged=�' �� .R��� $2 
baseMinima��
���   �#��[ ���� $ U_IDA_BaseMinima�$& PropertyChanged=�  $# 
Sustraendo��$
$ auto -   
sustraendo��% �� .R��� $1 
sustraendo��
���   ����� $ U_IDA_Sustraendo�$& PropertyChanged=�' �� .R��� $2 
sustraendo��
���   �#��[ ���� $ U_IDA_Sustraendo�$& PropertyChanged=��� -   8 ��Name$8 btnOk��$��OK��$
��Left=�$��	0,342,0,0q�$	��Top=�$��85��$��3q�$��16(��� -   $8 btnCancelar��$��Cancelar��$
��Left=�$��108,342,0,0q�$	��Top=�$��89��$��3q�$��16(�
�������
�������