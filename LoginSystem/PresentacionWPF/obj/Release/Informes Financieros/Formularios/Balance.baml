   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista      Vista.Balance   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Vista     -     � Title$  Balance��$��495.913��$	��800�� � WindowStartupLocation$ CenterScreen=�.��� .+��� -    ��Name$ 
txtSNDesde��$��1q�
�������$
��Left=�$��23��$��	83,53,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��129��.�� � 	Resources  �� 
TargetType �� Property �� Value��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -    ��Name$ btnEjecutar��$��OK��$
��Left=�$��
34,417,0,0q�$	��Top=�$��94��$��3q��� -   $ btnCancelar��$��Cancelar��$
��Left=�$��151,417,0,0q�$	��Top=�$��94��$��3q�
�������
�������&   System.Windows.Controls.DataGrid  -   	  Name$	 	dgBalance��$��Normal"�$��1q�
   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 * 
�������$
��Left=�$	��140��$��
438,53,0,0q�$	��Top=�$	��330��   AutoGenerateColumns .     CanUserDeleteRows .     CanUserSortColumns .     SelectionMode$ Single=�$   HorizontalScrollBarVisibility$
 Auto=�"   VerticalScrollBarVisibility$
 Auto=�$��Center=�$��Center=�   GridLinesVisibility$	 All=�   VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   SelectionUnit$ FullRow=����	#FFE5E5E5   	CellStyle �� *  $System.Windows.Controls.DataGridCell"  .���  � ��$ 30����  � ��$ Center=���  � ��$ Center=���  �@��TextAlignment$ Center=���  � ��$ Center=���  � �� �	#FFE5E5E5   RowStyle �� )  #System.Windows.Controls.DataGridRow"   �� 	Resources  �� Color��%�   (��       * SystemColors.HighlightBrushKey+)(��      *$"SystemColors.HighlightTextBrushKey+)�� $ 	#FFE5E5E5���� $ Black��   Columns 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn   Width$ 30 -   Seleccionado��   HeaderStyle   HeaderStyle# [     Header �� -   $��chkSelectAll��   CellTemplate �� .R��� $��seleccionado��-   $��Center=� d� 	IsChecked ��  �� Path$ Seleccionado�  �� UpdateSourceTrigger$  PropertyChanged=�!   CellEditingTemplate! �� .R��� $��seleccionado��-	   $��Center=� �� $ Seleccionado�$  PropertyChanged=�0  *System.Windows.Controls.DataGridTextColumn  $ * $ Cuenta��-
   
cuenta��# [  "   
IsReadOnly" . 1  +System.Windows.Controls.DataGridBoundColumn#   Binding# �� $ AcctCode�$  PropertyChanged=�  $ * $ Descripcion��# [  -   cuentaDescripcion��" . # �� $ AcctName�$  PropertyChanged=��� -   $ ��Name$$ cbNivel��  ComboBoxStyle#��[ $��23��
�������% �� 
IsReadOnly% . 
���   �$
��Left=�$��
639,10,0,0q�$	��Top=�$	��128���� -   & ��Name$& lblDFechaContabilizacion��$
��Bold"�$��12(�
���   �$
��Left=�$��358,242,0,0q�$
��Wrap=�$��Desde��$	��Top=�(	  "System.Windows.Controls.DatePicker	  -   ' 	 Name$' dpDFechaContabilizacion��$
��Left=�$��420,238,0,0q�$	��Top=�$	��132�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3���� -   $& lblHFechaContabilizacion��$
��Bold"�$��12(�
���   �$
��Left=�$��583,243,0,0q�$
��Wrap=�$��Hasta��$	��Top=�	  -   $' dpHFechaContabilizacion��$
��Left=�$��639,238,0,0q�$	��Top=�$	��132�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3���� -   ( ��Name$( 
cbxCuentas��$��Cuenta��$
��Bold"�$
��Left=�$��
438,15,0,0q�$	��Top=��� -   $( cbxSN��$��Socio Negocio��$
��Bold"�$
��Left=�$��	34,10,0,0q�$	��Top=��� -   $& 
lblSNDesde��$
��Bold"�$��12(�
���   �$
��Left=�$��	37,56,0,0q�$
��Wrap=�$��Desde��$	��Top=��� -   $& 
lblSNHasta��$
��Bold"�$��12(�
���   �$
��Left=�$��
234,56,0,0q�$
��Wrap=�$��Hasta��$	��Top=��� -   $ 
txtSNHasta��$��1q�
�������$
��Left=�$��23��$��
281,52,0,0q�$
 Wrap=�$	��Top=�$	��129��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -   $( cbxMonedaExtranjera��$��Moneda extranjera��$
��Bold"�$
��Left=�$��
37,284,0,0q�$	��Top=��� -   $( cbxMonedaSistema��$��Moneda del sistema��$
��Bold"�$
��Left=�$��
37,309,0,0q�$	��Top=��� -   $( cbxMonedaLocalySystema��$��Moneda local y de sistema��$
��Bold"�$
��Left=�$��
37,333,0,0q�$	��Top=��� -   $$ cbFecha��#��[ $��23��
�������% . 
���   �$
��Left=�$��189,241,0,0q�$	��Top=�$	��128���� -   $( cbxCuentasCero��$)��#Ocultar cuentas sin contabilizacion��$
��Bold"�$
��Left=�$��
74,364,0,0q�$	��Top=�$
 TrueY�