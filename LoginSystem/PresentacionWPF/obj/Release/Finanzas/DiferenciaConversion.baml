   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista       Vista.DiferenciaConversion   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Vista     -     � Title$  DiferenciaConversion��$��541.667��$	��800�� � WindowStartupLocation$ CenterScreen=�.���� $
��Auto=�$
��Auto=�.��� $��Center=�$	��Top=�$	��503��.+��� -    ��Name$ lblFechaEjecucion��$
��Bold"�$��12(�
���   �$
��Left=�$��
31,240,0,0q�$
��Wrap=�$��Fecha de Ejecucion��$	��Top=�(  "System.Windows.Controls.DatePicker  -   $��dpFechaEjecucion��$
��Left=�$��220,235,0,0q�$	��Top=�$	��138�� � 	Resources  �� 
TargetType �� Property �� Value��%9   '��       �� " ��.���  �@��CornerRadius$ 3���� -    ��Name$ btnEjecutar��$��Ejecutar��$
��Left=�$��34,464,0,-19q�$	��Top=�$��94��$��3q��� -   $ btnCancelar��$��Cancelar��$
��Left=�$��151,464,0,-19q�$	��Top=�$��94��$��3q�
�������
�������&   System.Windows.Controls.DataGrid  -     Name$ dgDiferenciaTipoCambio��$��Normal"�$��1q�	   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 * 
�������$
��Left=�$	��203��$��
438,53,0,0q�$	��Top=�$	��316��
   AutoGenerateColumns
 .     CanUserDeleteRows .     CanUserSortColumns .     SelectionMode$ Single=�$   HorizontalScrollBarVisibility$
 Auto=�"   VerticalScrollBarVisibility$
 Auto=�$��Center=�$��Center=�   GridLinesVisibility$	 All=�   VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   SelectionUnit$ FullRow=����	#FFE5E5E5   	CellStyle �� *  $System.Windows.Controls.DataGridCell"  .���  � ��$ 30����  � ��$ Center=���  � ��$ Center=���  �@��TextAlignment$ Center=���  � ��$ Center=���  � �� �	#FFE5E5E5   RowStyle �� )  #System.Windows.Controls.DataGridRow"   �� 	Resources  �� Color��%�   (��       * SystemColors.HighlightBrushKey+)(��      *$"SystemColors.HighlightTextBrushKey+)�� $ 	#FFE5E5E5���� $ Black��   Columns 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn   Width$ 30 -   Seleccionado��   HeaderStyle   HeaderStyle# [     Header �� -    ��Name$ chkSelectAll��   CellTemplate �� .R��� $ seleccionado��-	   $��Center=� d� 	IsChecked �� *Seleccionado+ �� UpdateSourceTrigger$ PropertyChanged=�    CellEditingTemplate  �� .R��� $ seleccionado��-
   $��Center=� �� *Seleccionado+$ PropertyChanged=�0  *System.Windows.Controls.DataGridTextColumn  $ * $ Cuenta��-   
cuenta��# [  !   
IsReadOnly! . 1	  +System.Windows.Controls.DataGridBoundColumn" 	  Binding" �� *
AcctCode+$ PropertyChanged=�  $ * $ Descripcion��# [  -   cuentaDescripcion��! . " �� *
AcctName+$ PropertyChanged=��� -   # ��Name$# cbNivel��  ComboBoxStyle#��[ $��23��
�������$ �� 
IsReadOnly$ . 
���   �$
��Left=�$��
639,10,0,0q�$	��Top=�$	��128���� -   $ 
cbxCuentas��$��Cuenta��$
��Bold"�$
��Left=�$��
438,15,0,0q�$	��Top=��� -   $ cbxSN��$��Socio Negocio��$
��Bold"�$
��Left=�$��	34,10,0,0q�$	��Top=��� -   $ 
lblSNDesde��$
��Bold"�$��12(�
���   �$
��Left=�$��	37,56,0,0q�$
��Wrap=�$��Desde��$	��Top=��� -   $ 
lblSNHasta��$
��Bold"�$��12(�
���   �$
��Left=�$��
234,56,0,0q�$
��Wrap=�$��Hasta��$	��Top=��� -   % ��Name$% 	bdDesdeSN��$��1q�
�������& �� CornerRadius$& 3��$��	79,52,0,0q�
�������$
��Left=�$	��135��$��25��$	��Top=�._�]� -   ' ]�Name$' 	dpDesdeSN��$��1��$��1��$��4.667,0.667,4.667,0.5q�
�������.+��� -   ( ��Name$( 
imgDesdeSN��$��Right=�$5��//Vista;component/Utilidades/Formulario/lupa.png��$��20��$��0,0,0,-0.333q�$y�Hidden=�) � Cursor$
) Hand���� -   * ��Name$* 
txtDesdeSN��$��12(�$��Normal"�
�������$��0q�$��0,0,0,0.333q�$	��123��
���   �$	��Top=�$��Stretch=�$��Stretch=��� -   $% 	bdHastaSN��$��1q�
�������$& 3��$��
281,52,0,0q�
�������$
��Left=�$	��129��$��25��$	��Top=�._�]� -   $' 	dpHastaSN��$��1��$��1��$��4.667,0.667,4.667,0.5q�
�������.+��� -   $( 
imgHastaSN��$��Right=�$5��//Vista;component/Utilidades/Formulario/lupa.png��$��20��$��0,0,0,-0.333q�$y�Hidden=�$
) Hand���� -   $* 
txtHastaSN��$��12(�$��Normal"�
�������$��0q�$��0,0,0,0.333q�$	��119��
���   �$	��Top=�$��Stretch=�$��Stretch=��� -   $ lblCuentaBeneficioCliente��$
��Bold"�$
��Left=�$��
33,323,0,0q�$
��Wrap=�$!��Cuenta Beneficio (cliente):��$	��Top=��� -   $% bdCuentaBeneficioCliente��$��1q�
�������$& 3��$��221,318,0,0q�
�������$
��Left=�$	��135��$��25��$	��Top=�._�]� -   $' dpCuentaBeneficioCliente��$��1��$��1��$��4.667,0.667,4.667,0.5q�
�������.+��� -   $( imgCuentaBeneficioCliente��$��Right=�$��lupa.png��$��20��$��0,0,0,-0.333q�$y�Hidden=�$
) Hand���� -   $* txtCuentaBeneficioCliente��$��12(�$��Normal"�
�������$��0q�$��0,0,0,0.333q�$	��130��
���   �$	��Top=�$��Stretch=�$��Stretch=��� -   $ lblCuentaPerdidaCliente��$
��Bold"�$
��Left=�$��441,323,0,0q�$
��Wrap=�$��Cuenta Perdida (cliente):��$	��Top=��� -    $% bdCuentaPerdidaCliente��$��1q�
�������$& 3��$��619,318,0,0q�
�������$
��Left=�$	��135��$��25��$	��Top=�._�]� -!   $' dpCuentaPerdidaCliente��$��1��$��1��$��4.667,0.667,4.667,0.5q�
�������.+��� -"   $( imgCuentaPerdidaCliente��$��Right=�$��lupa.png��$��20��$��0,0,0,-0.333q�$y�Hidden=�$
) Hand���� -#   $* txtCuentaPerdidaCliente��$��12(�$��Normal"�
�������$��0q�$��0,0,0,0.333q�$	��130��
���   �$	��Top=�$��Stretch=�$��Stretch=��� -$   $# lblCuentaBeneficioProveedores��$
��Bold"�$
��Left=�$��
33,359,0,0q�$
��Wrap=�$%��Cuenta Beneficio (proveedores):��$	��Top=��� -%   $"% bdCuentaBeneficioProveedores��$��1q�
�������$& 3��$��223,354,0,0q�
�������$
��Left=�$	��135��$��25��$	��Top=�._�]� -&   $"' dpCuentaBeneficioProveedores��$��1��$��1��$��4.667,0.667,4.667,0.5q�
�������.+��� -'   $#( imgCuentaBeneficioProveedores��$��Right=�$��lupa.png��$��20��$��0,0,0,-0.333q�$y�Hidden=�$
) Hand���� -(   $#* txtCuentaBeneficioProveedores��$��12(�$��Normal"�
�������$��0q�$��0,0,0,0.333q�$	��130��
���   �$	��Top=�$��Stretch=�$��Stretch=��� -)   $! lblCuentaPerdidaProveedores��$
��Bold"�$
��Left=�$��441,359,0,0q�$
��Wrap=�$#��Cuenta Perdida (proveedores):��$	��Top=��� -*   $ % bdCuentaPerdidaProveedores��$��1q�
�������$& 3��$��619,354,0,0q�
�������$
��Left=�$	��135��$��25��$	��Top=�._�]� -+   $ ' dpCuentaPerdidaProveedores��$��1��$��1��$��4.667,0.667,4.667,0.5q�
�������.+��� -,   $!( imgCuentaPerdidaProveedores��$��Right=�$��lupa.png��$��20��$��0,0,0,-0.333q�$y�Hidden=�$
) Hand���� --   $!* txtCuentaPerdidaProveedores��$��12(�$��Normal"�
�������$��0q�$��0,0,0,0.333q�$	��130��
���   �$	��Top=�$��Stretch=�$��Stretch=��� -.   $ lblCuentaBeneficioCuenta��$
��Bold"�$
��Left=�$��
33,397,0,0q�$
��Wrap=�$%��Cuenta Beneficio (Libro Mayor):��$	��Top=��� -/   $% bdCuentaBeneficioCuenta��$��1q�
�������$& 3��$��223,392,0,0q�
�������$
��Left=�$	��135��$��25��$	��Top=�._�]� -0   $' dpCuentaBeneficioCuenta��$��1��$��1��$��4.667,0.667,4.667,0.5q�
�������.+��� -1   $( imgCuentaBeneficioCuenta��$��Right=�$��lupa.png��$��20��$��0,0,0,-0.333q�$y�Hidden=�$
) Hand���� -2   $* txtCuentaBeneficioCuenta��$��12(�$��Normal"�
�������$��0q�$��0,0,0,0.333q�$	��130��
���   �$	��Top=�$��Stretch=�$��Stretch=��� -3   $ lblCuentaPerdidaCuenta��$
��Bold"�$
��Left=�$��441,399,0,0q�$
��Wrap=�$#��Cuenta Perdida (libro mayor):��$	��Top=��� -4   $% bdCuentaPerdidaCuenta��$��1q�
�������$& 3��$��619,394,0,0q�
�������$
��Left=�$	��135��$��25��$	��Top=�._�]� -5   $' dpCuentaPerdidaCuenta��$��1��$��1��$��4.667,0.667,4.667,0.5q�
�������.+��� -6   $( imgCuentaPerdidaCuenta��$��Right=�$��lupa.png��$��20��$��0,0,0,-0.333q�$y�Hidden=�$
) Hand���� -7   $* txtCuentaPerdidaCuenta��$��12(�$��Normal"�
�������$��0q�$��0,0,0,0.333q�$	��130��
���   �$	��Top=�$��Stretch=�$��Stretch=�