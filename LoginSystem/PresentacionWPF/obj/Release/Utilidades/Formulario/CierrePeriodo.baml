   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista      Vista.CierrePeriodo   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Vista     -     � Title$  Cierre Periodo��$��495.913��$	��800�� � WindowStartupLocation$ CenterScreen=�.��� .+��� -    ��Name$ btnEjecutar��$��Ejecutar��$
��Left=�$��
34,417,0,0q�$	��Top=�$��94��$��3q��� -   $ btnCancelar��$��Cancelar��$
��Left=�$��151,417,0,0q�$	��Top=�$��94��$��3q�
�������
�������&   System.Windows.Controls.DataGrid  -     Name$ dgCierrePeriodo��$��Normal"�$��1q�   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 
�������$
��Left=�$	��140��$��
438,53,0,0q�$	��Top=�$	��330��   AutoGenerateColumns .     CanUserDeleteRows .     CanUserSortColumns .     SelectionMode$ Single=�$	   HorizontalScrollBarVisibility$
	 Auto=�"
   VerticalScrollBarVisibility$

 Auto=�$��Center=�$��Center=�   GridLinesVisibility$	 All=�   VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   SelectionUnit$ FullRow=����	#FFE5E5E5   	CellStyle ��  �� 
TargetType*  $System.Windows.Controls.DataGridCell"  .���  �� Property � �� �� Value$ 30����  � ��$ Center=���  � ��$ Center=���  �@��TextAlignment$ Center=���  � ��$ Center=���  � �� �	#FFE5E5E5   RowStyle �� )  #System.Windows.Controls.DataGridRow"   �� 	Resources  �� Color��%�   (��       * SystemColors.HighlightBrushKey+)(��      *$"SystemColors.HighlightTextBrushKey+)�� $ 	#FFE5E5E5���� $ Black��   Columns 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn   Width$ 30 -   Seleccionado��   HeaderStyle   HeaderStyle# [     Header �� -    ��Name$ chkSelectAll��   CellTemplate �� .R��� $ seleccionado��-   $��Center=� d� 	IsChecked �� *Seleccionado+ �� UpdateSourceTrigger$ PropertyChanged=�   CellEditingTemplate �� .R��� $ seleccionado��-   $��Center=� �� *Seleccionado+$ PropertyChanged=�0  *System.Windows.Controls.DataGridTextColumn  $ * $ Cuenta��-	   
cuenta��# [     
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn    Binding  �� *
AcctCode+$ PropertyChanged=�  $ * $ Descripcion��# [  -
   cuentaDescripcion�� .   �� *
AcctName+$ PropertyChanged=��� -   ! ��Name$! cbNivel��  ComboBoxStyle#��[ $��23��
�������" �� 
IsReadOnly" . 
���   �$
��Left=�$��
639,10,0,0q�$	��Top=�$	��128���� -   # ��Name$# lblDPeriodo��$
��Bold"�$��12(�
���   �$
��Left=�$��372,242,0,0q�$
��Wrap=�$��Desde��$	��Top=��� -   $# lblHPeriodo��$
��Bold"�$��12(�
���   �$
��Left=�$��597,243,0,0q�$
��Wrap=�$��Hasta��$	��Top=��� -   $ 
cbxCuentas��$��Cuenta��$
��Bold"�$
��Left=�$��
438,15,0,0q�$	��Top=��� -   $ cbxSN��$��Socio Negocio��$
��Bold"�$
��Left=�$��	34,10,0,0q�$	��Top=��� -   $# 
lblSNDesde��$
��Bold"�$��12(�
���   �$
��Left=�$��	37,56,0,0q�$
��Wrap=�$��Desde��$	��Top=��� -   $# 
lblSNHasta��$
��Bold"�$��12(�
���   �$
��Left=�$��
234,56,0,0q�$
��Wrap=�$��Hasta��$	��Top=��� -   $! 	cbPeriodo��$ �� DisplayMemberPath$$ Category��% �� SelectedValuePath$% Category��#��[ $��23��
�������" . $
��Left=�$��173,241,0,0q�$	��Top=�$	��162��
���   ��� -   $! cbDesde��#��[ $
$ Code��$
% Code��$��23��
�������" . 
���   �$
��Left=�$��421,241,0,0q�$	��Top=�$	��128���� -   $! cbHasta��#��[ $
$ Code��$
% Code��$��23��
�������" . 
���   �$
��Left=�$��641,241,0,0q�$	��Top=�$	��128���� -   $# 
lblPeriodo��$
��Bold"�$��12(�
���   �$
��Left=�$��
34,242,0,0q�$
��Wrap=�$��Periodo Contable:��$	��Top=��� -   $# lblCuentaArrastre��$
��Bold"�$
��Left=�$��
33,323,0,0q�$
��Wrap=�$��Cuenta Arrastre Saldo:��$	��Top=��� -   & ��Name$& bdCuentaArrastre��$��1q�
�������' �� CornerRadius$' 3��$��173,318,0,0q�
�������$
��Left=�$	��162��$��25��$	��Top=�._�]� -   ( ]�Name$( dpCuentaArrastre��$��1��$��1��$��4.667,0.667,4.667,0.5q�
�������.+��� -   ) ��Name$) imgCuentaArrastre��$��Right=�$��lupa.png��$��20��$��0,0,0,-0.333q�$y�Hidden=�* � Cursor$
* Hand���� -   + ��Name$+ txtCuentaArrastre��$��12(�$��Normal"�
�������$��0q�$��0,0,0,0.333q�$	��130��
���   �$	��Top=�$��Stretch=�$��Stretch=��� -   $# lblCuentaCierre��$
��Bold"�$
��Left=�$��
33,365,0,0q�$
��Wrap=�$��Cuenta Cierre Periodo:��$	��Top=��� -   $& bdCuentaCierre��$��1q�
�������$' 3��$��173,360,0,0q�
�������$
��Left=�$	��162��$��25��$	��Top=�._�]� -   $( dpCuentaCierre��$��1��$��1��$��4.667,0.667,4.667,0.5q�
�������.+��� -   $) imgCuentaCierre��$��Right=�$��lupa.png��$��20��$��0,0,0,-0.333q�$y�Hidden=�$
* Hand���� -   $+ txtCuentaCierre��$��12(�$��Normal"�
�������$��0q�$��0,0,0,0.333q�$	��130��
���   �$	��Top=�$��Stretch=�$��Stretch=��� -    $# lblCuentaArrastreNombre��$
��Bold"�$
��Left=�$��359,323,0,0q�$
��Wrap=�$�� ��$y�Hidden=�$	��Top=��� -!   $# lblCuentaCierreNombre��$
��Bold"�$
��Left=�$��359,365,0,0q�$
��Wrap=�$�� ��$y�Hidden=�$	��Top=��� -"   $& 	bdDesdeSN��$��1q�
�������$' 3��$��	79,52,0,0q�
�������$
��Left=�$	��135��$��25��$	��Top=�._�]� -#   $( 	dpDesdeSN��$��1��$��1��$��4.667,0.667,4.667,0.5q�
�������.+��� -$   $) 
imgDesdeSN��$��Right=�$��lupa.png��$��20��$��0,0,0,-0.333q�$y�Hidden=�$
* Hand���� -%   $+ 
txtDesdeSN��$��12(�$��Normal"�
�������$��0q�$��0,0,0,0.333q�$	��123��
���   �$	��Top=�$��Stretch=�$��Stretch=��� -&   $& 	bdHastaSN��$��1q�
�������$' 3��$��
281,52,0,0q�
�������$
��Left=�$	��129��$��25��$	��Top=�._�]� -'   $( 	dpHastaSN��$��1��$��1��$��4.667,0.667,4.667,0.5q�
�������.+��� -(   $) 
imgHastaSN��$��Right=�$��lupa.png��$��20��$��0,0,0,-0.333q�$y�Hidden=�$
* Hand���� -)   $+ 
txtHastaSN��$��12(�$��Normal"�
�������$��0q�$��0,0,0,0.333q�$	��119��
���   �$	��Top=�$��Stretch=�$��Stretch=�