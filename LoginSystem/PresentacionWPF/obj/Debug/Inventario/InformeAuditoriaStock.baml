   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	   !    Vista.InformeAuditoriaStock   5      n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	      Vista.Converter    Closing$  Converter_Closing��5   @      Loaded$ Converter_Loaded��6�    � Title$ InformeAuditoriaStock��6	   $	��380��6'   $	��649��64    � WindowStartupLocation$ CenterScreen=�6\   .��5	      �� $
��Auto=�6   $
��Auto=�66   .��5
   
   � $��Center=�6   $	��Top=�6,   $	��341��6D   .+�5      �� -   5         ��Name$ lblArticulos��5      $
��Left=�6.   $��	14,10,0,0q�6I   $
��Wrap=�6\   $��	Articulos��6p   $��	Underline{�6�   $	��Top=�6�   $
��Bold"�6�   $��14(�6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ dgStock��5      $��Normal"�6(   $��1q�6<      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6P   
�������$��Center=�6x   $	��140��6�   $��0,45,0,0q�6�   $	��Top=�6�   $	��535��6�      AutoGenerateColumns .     CanUserDeleteRows .  	   CanUserSortColumns	 .  
   SelectionMode$
 Single=�6)  $   HorizontalScrollBarVisibility$
 Auto=�6@  "   VerticalScrollBarVisibility$
 Auto=�6e  $��Center=�6�  $��Center=�6�     GridLinesVisibility$	 All=�6�     VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   SelectionUnit$ FullRow=�6'  ���	#FFE5E5E5   	CellStyle 5      �� 5       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6   .�5      ��  �� Property � �� �� Value$ 30��63   6@   �� 5       � ��$ Center=�6G   6X   �� 5       � ��$ Center=�6E   6V   �� 5       �@��TextAlignment$ Center=�6D   6U   �� 5       � ��$ Center=�6H   6Y   �� 5       � �� �	#FFE5E5E56K   5         RowStyle 5      �� 5      )  #System.Windows.Controls.DataGridRow"  6    �� 	Resources 5       �� Color��%�   (��       5   .   * SystemColors.HighlightBrushKey+)(�� #     5   .   *$"SystemColors.HighlightTextBrushKey+)�� 5      $ 	#FFE5E5E5��6`   �� 5      $ Black��6d   5      5         Columns 5!      4  .System.Windows.Controls.DataGridTemplateColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Width$ 30 6-   -   5        Seleccionado��   HeaderStyle   HeaderStyle# [  5"   N      Header 5%      �� 5'      -   5         ��Name$ chkSelectAll��5'   h   $��Center=�6'   $��Center=�6D   6�      CellTemplate 5)      �� 5*      .R�5+   "   �� $ seleccionado��6+   -   5        $��Center=�5+   �    d� 	IsChecked 6A   �� *Seleccionado+ �� UpdateSourceTrigger$ PropertyChanged=�6�   5,          CellEditingTemplate  5.      �� 5/      .R�50   "   �� $ seleccionado��6+   -   5         50   A   �� *Seleccionado+$ PropertyChanged=�6�   51      53      0  *System.Windows.Controls.DataGridTextColumn  54      $ * 6)   # [  63   $ Articulo��6^   -   5        
cuenta��!   
IsReadOnly! . 1	  +System.Windows.Controls.DataGridBoundColumn" 	  Binding" 54   �   �� *
ItemCode+$ PropertyChanged=�56        57      $ * 6)   # [  63   $ Descripcion��6^   -   5        cuentaDescripcion��! . " 57   �   �� *
ItemName+$ PropertyChanged=�6�   59      �� 5:      -	   5        $ lblDFechaContabilizacion��5:      $
��Bold"�6:   $��12(�6L   
���   �$
��Left=�6m   $��163,210,0,0q�6�   $
��Wrap=�6�   $��Desde��6�   $	��Top=�6�   (
  "System.Windows.Controls.DatePicker
  5;      -
   5        # 
 Name$# dpDFechaContabilizacion��5;   m   $
��Left=�6   $��207,206,0,0q�64   $	��Top=�6I   $	��132��6a   $ � 	Resources$ 5<      ��%^   '��       �� 5=      " ��6   .�5>      ��  �@��CornerRadius$ 3��69   5@      5A      5B      �� 5C      -   5        $ lblHFechaContabilizacion��5C      $
��Bold"�6:   $��12(�6L   
���   �$
��Left=�6m   $��364,211,0,0q�6�   $
��Wrap=�6�   $��Hasta��6�   $	��Top=�6�   
  5D      -   5        $# dpHFechaContabilizacion��5D   m   $
��Left=�6   $��406,206,0,0q�64   $	��Top=�6I   $	��132��6a   $ 5E      ��%^   '��       �� 5F      " ��6   .�5G      ��  �@��CornerRadius$ 3��69   5I      5J      5K      �� 5L      -   5        $ cbxFechaContabilizacion��5L      $��Fecha Contabilizacion ��68   $
��Bold"�6Y   $
��Left=�6k   $��	3,208,0,0q�6�   $	��Top=�6�   �� 5M      -   5        % ��Name$% btnEjecutar��5M      $��OK��6*   $
��Left=�67   $��	3,297,0,0q�6R   $	��Top=�6e   $��94��6}   $��3q�6�   6�   �� 5N      -   5        $% btnCancelar��5N      $��Cancelar��6*   $
��Left=�6=   $��119,299,0,0q�6X   $	��Top=�6m   $��94��6�   $��3q�6�   
�������
�������6�   �� 5O      -   5        $ 
cbxCompras��5O      $��Compras ��6+   $
��Bold"�6>   $
��Left=�6P   $��461,252,0,0q�6k   $	��Top=�6�   �� 5P      -   5        $ 	cbxVentas��5P      $��Ventas ��6*   $
��Bold"�6<   $
��Left=�6N   $��461,275,0,0q�6i   $	��Top=�6~   5R      5S      5T      