   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista      Vista.NroComprobante   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Vista        Vista.Document    Loaded$  Window_Loaded��   Closing$ Window_Closing�� � Title$ NroComprobante��$��447.333��$��662.667�� � WindowStartupLocation$ CenterScreen=� J� CommandBindings )  #System.Windows.Input.CommandBinding  -      Command$ local:CustomCommands.Exit��.���� $
��Auto=�$
��Auto=�.��� $��Center=�$	��Top=�$��0,20,0,0q�.+�&   System.Windows.Controls.DataGrid  -     Name$ dgComprobante��$��1q�
�������   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ *    SelectionMode$ Single=�	   SelectionUnit$	 FullRow=�
   GridLinesVisibility$	
 All=�   VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   AutoGenerateColumns .  $
��Left=�$	��311��$	��Top=�$	��566��   CanUserResizeRows .    CanUserSortColumns .    CanUserDeleteRows .  
���   �$��Right=�$��Center=����	#FFE5E5E5   	CellStyle ��  �� 
TargetType*  $System.Windows.Controls.DataGridCell"   �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ���  �� Property � �� �� Value �	#FF74C1FF��  � ��
 �   �.���  � ��$ 25����  � ��$ Center=���  � ��$ Center=���  �@��TextAlignment$ Center=���  � ��$ Center=���  � ��$ Center��   RowStyle �� )  #System.Windows.Controls.DataGridRow"   P�  �@J�IsMouseOver . . ���  � ��
 �������  � ��
 �   �.���  �@�Tag ��  �� RelativeSource ��  �� AncestorType" � �� Path$ DataContext���  �@�ContextMenu ��  � DataContext �� *PlacementTarget.Tag+ �� *Self+.@�m� $��Eliminar�� m� Command$ local:CustomCommands.Exit�� � 	Resources    TaxTextBoxStyle �� Binding  �� Value  TextBoxStyle  CenterCellStyle! �� 
TargetType��%�  &	        &	 �     &	      �� " ��.���  � �� �	#FF74C1FF ��  �� $ Canceled�  N.a���  �@��
IsReadOnly .  ��  � �� �	#FF74C1FF��  �� $ Canceled�  Y.a���  �@��
IsReadOnly . ��  � �� �	#FF74C1FF�� " ��.���  � �� �	#FF74C1FF�� "  .���  � �� �� "!  .R�� #��z��.+��� $��Center=�$��Center=�$
��auto�� P�  �@J�IsMouseOver . . ���  � �� �	#FF74C1FF��  � ��
 �   �"   Columns" 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn#   Header$# Codigo��$   Width$
$ auto -   
codigo��%   CellEditingTemplate% �� .R��� $��txtCodeCurrency��-   
���   �#��[  ���� $
 Code�&   CellTemplate& �� .R��� $��txtCodeCurrency��
���   ����� $
 Code�  $# Nombre de Serie��$
$ Auto -   name��% �� .R��� 
���   �#��[ ���� $ NombreSerie�& �� .R��� 
���   ����� $ NombreSerie�4	  .System.Windows.Controls.DataGridComboBoxColumn	  -   cbTipoSerie��$# 
Tipo Serie��$
$ auto '   	CellStyle#' [   ComboBoxStyle( 	  EditingElementStyle#( [ ) 	  ItemsSource) �� *ListTipoSerie+* 	  DisplayMemberPath* �� *	TipoSerie++ 	  SelectedValueBinding+ �� *	TipoSerie+  $# Inicio��$
$ Auto -   
inicio��% �� .R��� 
���   �#��[ ���� $ Inicio�& �� .R��� 
���   ����� $ Inicio�  $# 	Siguiente��$
$ Auto -   	siguiente��% �� .R��� 
���   �#��[ ���� $ 	Siguiente�& �� .R��� 
���   ����� $ 	Siguiente�  $	# Fin��$
$ Auto -	   fin��% �� .R��� 
���   �#��[ ���� $	 Fin�& �� .R��� 
���   ����� $	 Fin�  $# Activo��$
$ auto -
   activos��& �� .R��� $��activo��-   $��Center=�$��Center=�$��Center=�$��Center=�, d� IsThreeState, .  - d� 	IsChecked- �� $ Activo�% �� .R��� $��activo��-   $��Center=�$��Center=�$��Center=�$��Center=�, .  - �� $ Activo��� -   . ��Name$. btnOk��$��OK��$
��Left=�$��	0,342,0,0q�$	��Top=�$��85��$��3q�$��16(��� -   $. btnCancelar��$��Cancelar��$
��Left=�$��110,342,0,0q�$	��Top=�$��89��$��3q�$��16(�
�������
�������