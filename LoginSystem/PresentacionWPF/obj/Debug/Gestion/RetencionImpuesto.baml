   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	       Vista.RetencionImpuesto   5      n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	      Vista.Document    Closing$  Window_Closing��5   l      Loaded$ Window_Loaded��6�    � Title$ Retencion Impuesto��6	   $��439.333��6$   $��1000.667��65    � WindowStartupLocation$ CenterScreen=�6G    J� CommandBindings 5	      )  #System.Windows.Input.CommandBinding  5
   
   -   5           Command$" local:CustomCommandsRet.Exit��5
      6d   .��5      �� $
��Auto=�6   $
��Auto=�66   .��5   
   � $��Center=�6   $	��Top=�6,   $��0,20,0,0q�6D   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dgRetencionImp��5   .   ���	#FFE5E5E5$��1q�6F   
�������   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6r      AutoGenerateColumns .  $
��Left=�6�   $	��311��6�   $	��Top=�6�   $	��922��6�   $	   HorizontalScrollBarVisibility$
	 Auto=�6�   "
   VerticalScrollBarVisibility$

 Auto=�6     CanUserDeleteRows .  
���   �$��Center=�6�  $��Center=�6�     GridLinesVisibility$	 All=�6�     VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   SelectionMode$ Single=�6+     SelectionUnit$ FullRow=�6B     	CellStyle 5      �� 5       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6    �� Triggers 5      P� 5       P� Property �@J�IsMouseOver P� Value . . �5   "   ��  �� Property � �� �� Value �	#FF74C1FF5      �� 5   "    � ��
 �   �5      5      .�5      ��  � ��$ 25��63   6@   �� 5        � ��$ Center=�6G   6X   �� 5!       � ��$ Center=�6E   6V   �� 5"       �@��TextAlignment$ Center=�6D   6U   �� 5#       � ��$ Center=�6H   6Y   �� 5$       � ��$ Center��64   6E   5(         RowStyle 5,      �� 5-      )  #System.Windows.Controls.DataGridRow"  6    5.      P� 5/       �@J�IsMouseOver . . �51   "   ��  � ��
 �����52      �� 53   "    � ��
 �   �54      56      .�5;      ��  �@�Tag 5<      ��  �� RelativeSource ��  �� AncestorType" � �� Path$ DataContext��� 5>       �@�ContextMenu 5?      �� 5@   "    � DataContext 6.   �� *PlacementTarget.Tag+ �� *Self+.@�5C   &   m� $��Eliminar��6/    m� Command$" local:CustomCommandsRet.Exit��6A   5D   #   5F      5H       � 	Resources 5K         TextBlockStyle �� Binding  �� Value  CenterCellStyle! �� 
TargetType  TextBoxStyle��%�  &	        &	 �     &	     �� 5L      " ��63    5N      �� 5O       6*   �� *
DataSource+  N6I   .a�5P   "   ��  � ��
 �����6?   5Q      5T      �� 5V      "  64   .�5W      ��  � �� 5X      �� 5Y   "   "!  62   .R�5Z   &   � #��z��6+   .+�5[   *   �� $��Center=�6;   $��Center=�6X   $
��auto��6s   6�   5\   '   5]   #   5_       5`      P� 5a       �@J�IsMouseOver . . �5c   "   ��  � �� �	#FF74C1FF5d      �� 5e   "    � ��
 �   �5f      5i      5k      �� 5p      " ��61   .�5q      ��  � �� �	#FF74C1FF6K   5r      5s      "   Columns" 5t      4  .System.Windows.Controls.DataGridTemplateColumn  5u      ,  &System.Windows.Controls.DataGridColumn#   Header$# Codigo Retencion��6-   $   Width$
$ auto 6G   -   5        
codigo��%   CellTemplate% 5v      �� 5w      .R�5x   "   �� $��CodRetencion��6�   
���   ���6?   �� $ WTCode�& �� UpdateSourceTrigger$& PropertyChanged=�6�   5y      '   CellEditingTemplate' 5{      �� 5|      .R�5}   "   �� $��CodRetencion��6~   
���   �#��[ 6�   ��6=   �� $ WTCode�$& PropertyChanged=�6�   5~      5�        5�      $# Inactivo��6-   $
$ auto 6?   -   5        inactivo��% 5�      �� 5�      .R�5�   "   �� $��	inactivos��6+   -   5        ( d� IsThreeState( .  $��Center=�5�     $��Center=�62  $��Center=�6O  $��Center=�6q  ) d� 	IsChecked) 6<   �� $ Inactive�$& PropertyChanged=�5�   #   5�      ' 5�      �� 5�      .R�5�   "   �� $��	inactivos��6+   -   5        ( .  $��Center=�5�     $��Center=�62  $��Center=�6O  $��Center=�6q  ) 6<   �� $ Inactive�$& PropertyChanged=�5�   #   5�      5�        5�      $# Importe Retencion��6-   $
$ auto 6H   -   5        ImptRetencion��% 5�      �� 5�      .R�5�   "   �� $��ImptRetencion��6�   
���   ���6?   �� $ WTName�$& PropertyChanged=�6�   5�      ' 5�      �� 5�      .R�5�   "   �� $��ImptRetencion��6~   
���   �#��[ 6�   ��6=   �� $ WTName�$& PropertyChanged=�6�   5�      5�      4	  .System.Windows.Controls.DataGridComboBoxColumn	  5�      -   5        cbCategoria��$# 	Categoria��5�   h   $
$ auto 6{   *   	CellStyle#* [ 6    ComboBoxStyle+ 	  EditingElementStyle#+ [ 64  , 	  ItemsSource, 6B   �� *ListCategoria+- 	  DisplayMemberPath- 6�   �� $ Category�. 	  SelectedValueBinding. 6�   �� $ Category�$& PropertyChanged=�5�      	  5�      -	   5        
cbTipoBase��$# 	Tipo Base��5�   f   $
$ auto 6y   #+ [ 6  , 6A   �� *ListTipoBase+- 6�   �� $ BaseType�. 6�   �� $ BaseType�$& PropertyChanged=�5�        5�      $
$ Auto 6-   $# Valido Desde��6:   -
   5        ValidoDesde��' 5�      �� 5�      .R�5�   "   (
  "System.Windows.Controls.DatePicker
  / 
  SelectedDate/ 6-   �� $ 	EffecDate�0 �� StringFormat$0 {0:dd/MM/yyyy}��$& PropertyChanged=� 5�   &   ��%^   '��       �� 5�   *   " ��60   .�5�   .   ��  �@��CornerRadius$ 3��6M   5�   +   5�   '   5�   #   5�      % 5�      �� 5�      .R�5�   "   �� ��6,   �� $ 	EffecDate�$0 {0:dd/MM/yyyy}��$& PropertyChanged=�5�      5�        5�      $	# T/C��6-   $
$ auto 6:   -   5        tc��% 5�      �� 5�      .R�5�   "   �� $��tc��6~   
���   ���6?   �� $
 Rate�$& PropertyChanged=�6�   5�      ' 5�      �� 5�      .R�5�   "   �� $��tc��6|   
���   �#��[ 6�   ��6=   �� $
 Rate�$& PropertyChanged=�6�   5�      5�        5�      $# % Importe Base��6-   $
$ auto 6E   -   5        importeBase��% 5�      �� 5�      .R�5�   "   �� $��importeBase��6�   
���   ���6?   �� $ 
PrctBsAmnt�$& PropertyChanged=�6�   5�      ' 5�      �� 5�      .R�5�   "   �� $��importeBase��6�   
���   �#��[ 6�   ��6=   �� $ 
PrctBsAmnt�$& PropertyChanged=�6�   5�      5�        5�      $# Codigo Oficial��6-   $
$ auto 6E   -   5        codigoOficial��% 5�      �� 5�      .R�5�   "   �� 1 ��Name$1 codigoOficial��6�   
���   ���6?   �� $ 	Offclcode�$& PropertyChanged=�6�   5�      ' 5�      �� 5�      .R�5�   "   �� 2 ��Name$2 codigoOficial��6�   
���   �#��[ 6�   ��6=   �� $ 	Offclcode�$& PropertyChanged=�6�   5�      5�        5�      $# Cuenta��6-   $
$ auto 6=   -   5        acctCode��' 5�      �� 5�      .R�5�   "   �� 3 ��Name$3 bd��6a   $��1q�6)   
�������4 �� CornerRadius$4 3��6P   ._�5�   &   ]� 5 ]�Name$5 dp��6M   $��1��60   $��1��6=   $��Stretch=�6Y   $��Stretch=�6w   .+�5�   *   �� 6 ��Name$6 
imgAccount��6�   -   5        $��Right=�5�   s   $��lupa.png��6�   $��20��6�   $y�Visible=�6�   7 � Cursor$
7 Hand��6�   �� 5�   *   $2 
txtAccount��62   -   5        $��10(�5�   F   $��Stretch=�6T   
���   �#��[ 6�   
�������$��0q�6  $
��auto��6  ��6�   �� $ Account�$& PropertyChanged=�6%  5�   '   5�   #   5�      % 5�      �� 5�      .R�5�   "   �� $1 
txtAccount��6�   
���   �#��[  6�   ��6?   �� $ Account�$& PropertyChanged=�6�   5�      5�      	  5�      -   5        cbTipoRetencion��$# Tipo Retencion��5�   p   $
$ auto 6A  #* [ 6N  #+ [ 6{  , 6F   �� *ListTipoRetencion+- 6�   �� $ U_IDA_TipoRetencion�$& PropertyChanged=�. 6�   �� $ U_IDA_TipoRetencion�$& PropertyChanged=�5�        5�      $# Base Minima��6-   $
$ auto 6B   -   5        
baseMinima��% 5�      �� 5�      .R�5�   "   �� $1 
baseMinima��6�   
���   ���6?   �� $ U_IDA_BaseMinima�$& PropertyChanged=�6�   5�      ' 5�      �� 5      .R�5  "   �� $2 
baseMinima��6�   
���   �#��[ 6�   ��6=   �� $ U_IDA_BaseMinima�$& PropertyChanged=�6�   5     5       5     $# 
Sustraendo��6-   $
$ auto 6A   -   5        
sustraendo��% 5     �� 5     .R�5	  "   �� $1 
sustraendo��6�   
���   ���6?   �� $ U_IDA_Sustraendo�$& PropertyChanged=�6�   5
     ' 5     �� 5     .R�5  "   �� $2 
sustraendo��6�   
���   �#��[ 6�   ��6=   �� $ U_IDA_Sustraendo�$& PropertyChanged=�6�   5     5     5     �� 5     -   5        8 ��Name$8 btnOk��5     $��OK��6$   $
��Left=�61   $��	0,342,0,0q�6L   $	��Top=�6_   $��85��6w   $��3q�6�   $��16(�6�   6�   �� 5     -   5        $8 btnCancelar��5     $��Cancelar��6*   $
��Left=�6=   $��108,342,0,0q�6X   $	��Top=�6m   $��89��6�   $��3q�6�   $��16(�6�   
�������
�������6�   5     5     5     