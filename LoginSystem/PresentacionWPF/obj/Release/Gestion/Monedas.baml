   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista      Vista.Monedas   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Vista     -     � Title$  Monedas��$��452.383��$��456.202�� � WindowStartupLocation$ CenterScreen=� J� CommandBindings )  #System.Windows.Input.CommandBinding  -      Command$  local:CustomCommands1.Exit��.���� $
��Auto=�$
��Auto=�.��� $��Center=�$	��Top=�$��0,10,0,0q�.+�&   System.Windows.Controls.DataGrid  -     Name$ dgMoneda��$��0,20,0,0q�$��1q�   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 
�������$	��311��$	��374��   AutoGenerateColumns .     CanUserDeleteRows .     CanUserSortColumns . 	   SelectionMode$	 Single=�$
   HorizontalScrollBarVisibility$

 Auto=�"   VerticalScrollBarVisibility$
 Auto=�$	��Top=�   GridLinesVisibility$	 All=�   VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   SelectionUnit$ FullRow=����	#FFE5E5E5   	CellStyle ��  �� 
TargetType*  $System.Windows.Controls.DataGridCell"   �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ���  �� Property � �� �� Value �	#FF74C1FF��  � ��
 �   �.���  � ��$ 25����  � ��$ Center=���  � ��$ Center=���  �@��TextAlignment$ Center=���  � ��$ Center=���  � ��$ Center��   RowStyle �� )  #System.Windows.Controls.DataGridRow"   P�  �@J�IsMouseOver . . ���  � ��
 �������  � ��
 �   �.���  �@�Tag ��  �� RelativeSource ��  �� AncestorType" � �� Path$ DataContext���  �@�ContextMenu ��  � DataContext �� *PlacementTarget.Tag+ �� *Self+.@�m� $��Eliminar�� m� Command$  local:CustomCommands1.Exit�� � 	Resources    TaxTextBoxStyle �� Binding �� Value  TextBoxStyle��%	  &	        &	 �     �� " �� ��  �� $ Locked� N.a���  �@��
IsReadOnly .  ��  � �� �	#FF74C1FF��  �� $ Locked� Y.a���  �@��
IsReadOnly . ��  � ��
 � � ��� " ��.���  � �� �	#FF74C1FF    Columns  4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn!   Header$! Codigo��-   
codigo��"   CellTemplate" �� .R��� $��txtCodeCurrency��
���   �$y�Visible=����� $ CurrCode�#   CellEditingTemplate# �� .R��� $��txtCodeCurrency��-   
���   �#��[  $��0q�
������ ���� $ CurrCode�  $! Moneda��-   
moneda��" �� .R��� $��txtCodeCurrency��
���   ����� $ CurrName�# �� .R��� $��txtCodeCurrency��
���   �#��[ ���� $ CurrName�  $! Codigo Internacional��-   codigointernacional��" �� .R��� $��txtCodeCurrency��
���   ����� $ 
DocCurrCod�# �� .R��� $��txtCodeCurrency��
���   �#��[ ���� $ 
DocCurrCod��� -   $ ��Name$$ btnOk��$��OK��$
��Left=�$��	0,365,0,0q�$	��Top=�$��85��$��3q�$��16(��� -	   $$ btnCancelar��$��Cancelar��$
��Left=�$��103,365,0,0q�$	��Top=�$��89��$��3q�$��16(�
�������
�������