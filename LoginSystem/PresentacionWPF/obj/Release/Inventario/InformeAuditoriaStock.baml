   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  !    Vista.InformeAuditoriaStock   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Vista        Vista.Converter    Closing$  Converter_Closing��   Loaded$ Converter_Loaded�� � Title$ InformeAuditoriaStock��$	��354��$	��585�� � WindowStartupLocation$ CenterScreen=�.���� $
��Auto=�$
��Auto=�.��� $��Center=�$	��Top=�.+��� -    ��Name$ lblArticulos��$
��Left=�$��	14,10,0,0q�$
��Wrap=�$��	Articulos��$��	Underline{�$	��Top=�$
��Bold"�$��14(�&   System.Windows.Controls.DataGrid  -     Name$ dgStock��$��Normal"�$��1q�   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 
�������$��Center=�$	��140��$��0,45,0,0q�$	��Top=�$	��535��   AutoGenerateColumns .     CanUserDeleteRows .  	   CanUserSortColumns	 .  
   SelectionMode$
 Single=�$   HorizontalScrollBarVisibility$
 Auto=�"   VerticalScrollBarVisibility$
 Auto=�$��Center=�$��Center=�   GridLinesVisibility$	 All=�   VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   SelectionUnit$ FullRow=����	#FFE5E5E5   	CellStyle ��  �� 
TargetType*  $System.Windows.Controls.DataGridCell"  .���  �� Property � �� �� Value$ 30����  � ��$ Center=���  � ��$ Center=���  �@��TextAlignment$ Center=���  � ��$ Center=���  � �� �	#FFE5E5E5   RowStyle �� )  #System.Windows.Controls.DataGridRow"   �� 	Resources  �� Color��%�   (��       * SystemColors.HighlightBrushKey+)(��      *$"SystemColors.HighlightTextBrushKey+)�� $ 	#FFE5E5E5���� $ Black��   Columns 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn   Width$ 30 -   Seleccionado��   HeaderStyle   HeaderStyle# [     Header �� -    ��Name$ chkSelectAll��$��Center=�$��Center=�   CellTemplate �� .R��� $ seleccionado��-   $��Center=� d� 	IsChecked �� *Seleccionado+ �� UpdateSourceTrigger$ PropertyChanged=�    CellEditingTemplate  �� .R��� $ seleccionado��-    �� *Seleccionado+$ PropertyChanged=�0  *System.Windows.Controls.DataGridTextColumn  $ * # [  $ Articulo��-   
cuenta��!   
IsReadOnly! . 1	  +System.Windows.Controls.DataGridBoundColumn" 	  Binding" �� *
ItemCode+$ PropertyChanged=�  $ * # [  $ Descripcion��-   cuentaDescripcion��! . " �� *
ItemName+$ PropertyChanged=��� -	   $ lblDFechaContabilizacion��$
��Bold"�$��12(�
���   �$
��Left=�$��163,210,0,0q�$
��Wrap=�$��Desde��$	��Top=�(
  "System.Windows.Controls.DatePicker
  -
   # 
 Name$# dpDFechaContabilizacion��$
��Left=�$��207,206,0,0q�$	��Top=�$	��132��$ � 	Resources$ ��%9   '��       �� " ��.���  �@��CornerRadius$ 3���� -   $ lblHFechaContabilizacion��$
��Bold"�$��12(�
���   �$
��Left=�$��364,211,0,0q�$
��Wrap=�$��Hasta��$	��Top=�
  -   $# dpHFechaContabilizacion��$
��Left=�$��406,206,0,0q�$	��Top=�$	��132��$ ��%9   '��       �� " ��.���  �@��CornerRadius$ 3���� -   $ cbxFechaContabilizacion��$��Fecha Contabilizacion ��$
��Bold"�$
��Left=�$��	3,208,0,0q�$	��Top=��� -   % ��Name$% btnEjecutar��$��OK��$
��Left=�$��	3,271,0,0q�$	��Top=�$��94��$��3q��� -   $% btnCancelar��$��Cancelar��$
��Left=�$��119,271,0,0q�$	��Top=�$��94��$��3q�
�������
�������