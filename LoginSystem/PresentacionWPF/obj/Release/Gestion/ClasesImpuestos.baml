   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista      Vista.ClasesImpuestos   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Vista        Vista.Document    Closing$  Window_Closing��   Loaded$ Window_Loaded�� � Title$ ClasesImpuestos��$	��450��$	��664�� � WindowStartupLocation$ CenterScreen=� J� CommandBindings )  #System.Windows.Input.CommandBinding  -      Command$ local:CustomCommands.Exit�� � 	Resources    TextBlockStyleValidation �� 
TargetType �� Triggers	 P� Property
 P� Value �� Property �� Value �� RelativeSource �� Path��%�   &	        �� " �� P� 	 �@=�HasError
 . . ���  �@�ToolTip ��  �� *Self+$) #(Validation.Errors)[0].ErrorContent�.���� $
��Auto=�$
��Auto=�.��� $��Center=�$	��Top=�$��0,10,0,0q�.+�&   System.Windows.Controls.DataGrid  -     Name$ dgClasesImpuestos�����	#FFE5E5E5$��1q�
�������   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * $��Center=�$	��311��$��0,30,0,0q�$	��Top=�$	��575��   CanUserResizeRows .    CanUserSortColumns .    CanUserReorderColumns .    AutoGenerateColumns .     CanUserDeleteRows .  
���   �$��Center=�$��Center=�   GridLinesVisibility$	 All=�   VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   SelectionMode$ Extended=�   SelectionUnit$ FullRow=����� *ClasesImpuestos+   	CellStyle �� *  $System.Windows.Controls.DataGridCell"   P� 	 �@J�IsMouseOver
 . . ���  � �� �	#FF74C1FF��  � ��
 �   �.���  � ��$ 30����  � ��$ Center=���  � ��$ Center=���  �@��TextAlignment$ Center=���  � ��$ Center=�   RowStyle �� )  #System.Windows.Controls.DataGridRow"   P� 	 �@J�IsMouseOver
 . . ���  � ��
 ����� �� 	Resources  �� Color��%�   (��       * SystemColors.HighlightBrushKey+)(��      *$"SystemColors.HighlightTextBrushKey+)�� $ Transparent���� $ Black��.���  �@�Tag ��  ��  �� AncestorType" �$ DataContext���  �@�ContextMenu ��   � DataContext  �� *PlacementTarget.Tag+ �� *Self+.@�m� $��Eliminar��! m� Command$! local:CustomCommands.Exit����  �@ ValidationErrorTemplate Z�    TextBoxStyle��%5   &	       �� " ��.���  � �� �	#FF74C1FF"   Columns" 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn#   Header$# Codigo��$   Width$
$ auto -   
codigo��%   CellEditingTemplate% �� .R��� $��txtCodeCurrency��
���   �#��[ ���� $
 Code�& �� UpdateSourceTrigger$& PropertyChanged=�'   CellTemplate' �� .R��� $��txtCodeCurrency��#��[  
���   ����� $
 Code�$& PropertyChanged=�( �� ValidatesOnDataErrors( . ) �� NotifyOnValidationError) .   $# Nombre��$
$ auto -   name��% �� .R��� $��txtName��
���   �#��[ ���� $
 Name�$& PropertyChanged=�' �� .R��� $��txtName��#��[  
���   ����� $
 Name�$& PropertyChanged=�( . ) .   $
# Tasa��$
$ auto -   tasa��% �� .R��� 
���   �#��[ ���� $
 Rate�$& PropertyChanged=�' �� .R��� #��[  
���   ����� $
 Rate�$& PropertyChanged=�( . ) .   $# Cuenta Impuesto de Venta��$
$ auto -   salestax��% �� .R��� $��bd��$��1q�
�������* �� CornerRadius$* 3��._�]� $��dp��$��1��$��1��$��Stretch=�$��Stretch=�.+��� $	��img��-   $��Right=�$��lupa.png��$��20��$y�Visible=�+ � Cursor$
+ Hand���� , ��Name$, txtSalesTax��$��12(�$��Stretch=�
���   �#��[ 
�������$��0q�$
��auto������ $ SalesTax�$& PropertyChanged=�' �� .R��� $��txtSalesTax��
���   �#��[  ���� $ SalesTax�$& PropertyChanged=�( . ) .   $# Cuenta Impuesto de Compra��$
$ auto -   purchtax��% �� .R��� $��bd��$��1q�
�������$* 3��._�]� $��dp��$��1��$��1��$��Stretch=�$��Stretch=�.+��� $��
imgPuchTax��-	   $��Right=�$��lupa.png��$��20��$y�Visible=�$
+ Hand���� $, txtPurchTax��$��12(�$��Stretch=�
���   �#��[ 
�������$��0q�$
��auto������ $ PurchTax�$& PropertyChanged=�' �� .R��� 
���   �#��[  ���� $ PurchTax�$& PropertyChanged=�( . ) . �� -
   - ��Name$- btnOk��$��OK��$
��Left=�$��	0,365,0,0q�$	��Top=�$��85��$��3q�$��16(��� -   $- btnCancelar��$��Cancelar��$
��Left=�$��104,365,0,0q�$	��Top=�$��89��$��3q�$��16(�
�������
�������