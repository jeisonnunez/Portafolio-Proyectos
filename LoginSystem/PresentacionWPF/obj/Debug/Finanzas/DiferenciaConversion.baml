   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	        Vista.DiferenciaConversion   5   	   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	   -   5          � Title$  DiferenciaConversion��5   	   $��541.667��6&   $	��800��67    � WindowStartupLocation$ CenterScreen=�6\   .��5	      �� $
��Auto=�6   $
��Auto=�66   .��5
   
   � $��Center=�6   $	��Top=�6,   $	��503��6D   .+�5      �� -   5         ��Name$ lblFechaEjecucion��5      $
��Bold"�63   $��12(�6E   
���   �$
��Left=�6f   $��
31,240,0,0q�6�   $
��Wrap=�6�   $��Fecha de Ejecucion��6�   $	��Top=�6�   (  "System.Windows.Controls.DatePicker  5      -   5        $��dpFechaEjecucion��5   m   $
��Left=�6   $��220,235,0,0q�64   $	��Top=�6I   $	��138��6a    � 	Resources 5       �� 
TargetType �� Property �� Value��%^   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 3��69   5      5      5      �� 5      -   5         ��Name$ btnEjecutar��5      $��Ejecutar��6*   $
��Left=�6=   $��34,464,0,-19q�6X   $	��Top=�6n   $��94��6�   $��3q�6�   6�   �� 5      -   5        $ btnCancelar��5      $��Cancelar��6*   $
��Left=�6=   $��151,464,0,-19q�6X   $	��Top=�6o   $��94��6�   $��3q�6�   
�������
�������6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ dgDiferenciaTipoCambio��5      $��Normal"�67   $��1q�6K   	   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 * 6_   
�������$
��Left=�6�   $	��203��6�   $��
438,53,0,0q�6�   $	��Top=�6�   $	��316��6�   
   AutoGenerateColumns
 .     CanUserDeleteRows .     CanUserSortColumns .     SelectionMode$ Single=�68  $   HorizontalScrollBarVisibility$
 Auto=�6O  "   VerticalScrollBarVisibility$
 Auto=�6t  $��Center=�6�  $��Center=�6�     GridLinesVisibility$	 All=�6�     VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   SelectionUnit$ FullRow=�66  ���	#FFE5E5E5   	CellStyle 5      �� 5      *  $System.Windows.Controls.DataGridCell"  6   .�5      ��  � ��$ 30��63   �� 5       � ��$ Center=�6G   �� 5       � ��$ Center=�6E   �� 5       �@��TextAlignment$ Center=�6D   �� 5       � ��$ Center=�6>   �� 5       � �� �	#FFE5E5E567   5          RowStyle 5#      �� 5$      )  #System.Windows.Controls.DataGridRow"  6    �� 	Resources 5%       �� Color��%�   (��       5&   .   * SystemColors.HighlightBrushKey+)(�� #     5'   .   *$"SystemColors.HighlightTextBrushKey+)�� 5&      $ 	#FFE5E5E5��6`   �� 5'      $ Black��6d   5(      5)         Columns 5+      4  .System.Windows.Controls.DataGridTemplateColumn  5,      ,  &System.Windows.Controls.DataGridColumn   Width$ 30 6-   -   5        Seleccionado��   HeaderStyle   HeaderStyle# [  5,   N      Header 5-      �� 5.      -   5         ��Name$ chkSelectAll��5.   '   6\      CellTemplate 50      �� 51      .R�52   "   �� $ seleccionado��6+   -	   5        $��Center=�52   B    d� 	IsChecked 6`   �� *Seleccionado+ �� UpdateSourceTrigger$ PropertyChanged=�6�   53          CellEditingTemplate  55      �� 56      .R�57   "   �� $ seleccionado��6+   -
   5        $��Center=�57   B    6`   �� *Seleccionado+$ PropertyChanged=�6�   58      5:      0  *System.Windows.Controls.DataGridTextColumn  5;      $ * 6)   $ Cuenta��63   -   5        
cuenta��# [  5;   S   !   
IsReadOnly! . 1	  +System.Windows.Controls.DataGridBoundColumn" 	  Binding" 6~   �� *
AcctCode+$ PropertyChanged=�6�     5<      $ * 6)   $ Descripcion��63   # [  6H   -   5        cuentaDescripcion��! . " 5<   �   �� *
AcctName+$ PropertyChanged=�6�   5>      �� 5?      -   5        # ��Name$# cbNivel��5?        ComboBoxStyle#��[ 6(   $��23��6O   
�������$ �� 
IsReadOnly$ . 
���   �$
��Left=�6�   $��
639,10,0,0q�6�   $	��Top=�6�   $	��128��6  �� 5@      -   5        $ 
cbxCuentas��5@      $��Cuenta��6+   $
��Bold"�6<   $
��Left=�6N   $��
438,15,0,0q�6i   $	��Top=�6}   6�   �� 5A      -   5        $ cbxSN��5A      $��Socio Negocio��6&   $
��Bold"�6>   $
��Left=�6P   $��	34,10,0,0q�6k   $	��Top=�6~   6�   �� 5B      -   5        $ 
lblSNDesde��5B      $
��Bold"�6,   $��12(�6>   
���   �$
��Left=�6_   $��	37,56,0,0q�6z   $
��Wrap=�6�   $��Desde��6�   $	��Top=�6�   �� 5C      -   5        $ 
lblSNHasta��5C      $
��Bold"�6,   $��12(�6>   
���   �$
��Left=�6_   $��
234,56,0,0q�6z   $
��Wrap=�6�   $��Hasta��6�   $	��Top=�6�   �� 5D      -   5        % ��Name$% 	bdDesdeSN��5D   `   $��1q�6   
�������& �� CornerRadius$& 3��6<   $��	79,52,0,0q�6M   
�������$
��Left=�6�   $	��135��6�   $��25��6�   $	��Top=�6�   ._�5E      ]� -   5        ' ]�Name$' 	dpDesdeSN��5E   Y   $��1��6   $��1��6)   $��4.667,0.667,4.667,0.5q�6:   
�������.+�5F      �� -   5        ( ��Name$( 
imgDesdeSN��5F   �   $��Right=�6_   $5��//Vista;component/Utilidades/Formulario/lupa.png��6v   $��20��6�   $��0,0,0,-0.333q�6�   $y�Hidden=�6�   ) � Cursor$
) Hand��6�   �� 5G      -   5        * ��Name$* 
txtDesdeSN��5G      $��12(�62   $��Normal"�6@   
�������$��0q�6�   $��0,0,0,0.333q�6�   $	��123��6�   
���   �$	��Top=�6�   $��Stretch=�6  $��Stretch=�6$  5H      5I      �� 5J      -   5        $% 	bdHastaSN��5J   a   $��1q�6   
�������$& 3��6<   $��
281,52,0,0q�6M   
�������$
��Left=�6�   $	��129��6�   $��25��6�   $	��Top=�6�   ._�5K      ]� -   5        $' 	dpHastaSN��5K   Y   $��1��6   $��1��6)   $��4.667,0.667,4.667,0.5q�6:   
�������.+�5L      �� -   5        $( 
imgHastaSN��5L   �   $��Right=�6_   $5��//Vista;component/Utilidades/Formulario/lupa.png��6v   $��20��6�   $��0,0,0,-0.333q�6�   $y�Hidden=�6�   $
) Hand��6�   �� 5M      -   5        $* 
txtHastaSN��5M      $��12(�62   $��Normal"�6@   
�������$��0q�6�   $��0,0,0,0.333q�6�   $	��119��6�   
���   �$	��Top=�6�   $��Stretch=�6  $��Stretch=�6$  5N      5O      �� 5P      -   5        $ lblCuentaBeneficioCliente��5P      $
��Bold"�6;   $
��Left=�6M   $��
33,323,0,0q�6h   $
��Wrap=�6|   $!��Cuenta Beneficio (cliente):��6�   $	��Top=�6�   �� 5Q      -   5        $% bdCuentaBeneficioCliente��5Q   b   $��1q�6   
�������$& 3��6<   $��221,318,0,0q�6M   
�������$
��Left=�6�   $	��135��6�   $��25��6�   $	��Top=�6�   ._�5R      ]� -   5        $' dpCuentaBeneficioCliente��5R   Y   $��1��6   $��1��6)   $��4.667,0.667,4.667,0.5q�6:   
�������.+�5S      �� -   5        $( imgCuentaBeneficioCliente��5S   �   $��Right=�6n   $��lupa.png��6�   $��20��6�   $��0,0,0,-0.333q�6�   $y�Hidden=�6�   $
) Hand��6�   �� 5T      -   5        $* txtCuentaBeneficioCliente��5T      $��12(�6A   $��Normal"�6O   
�������$��0q�6�   $��0,0,0,0.333q�6�   $	��130��6�   
���   �$	��Top=�6   $��Stretch=�6  $��Stretch=�6;  5U      5V      �� 5W      -   5        $ lblCuentaPerdidaCliente��5W      $
��Bold"�69   $
��Left=�6K   $��441,323,0,0q�6f   $
��Wrap=�6{   $��Cuenta Perdida (cliente):��6�   $	��Top=�6�   �� 5X      -    5        $% bdCuentaPerdidaCliente��5X   b   $��1q�6   
�������$& 3��6<   $��619,318,0,0q�6M   
�������$
��Left=�6�   $	��135��6�   $��25��6�   $	��Top=�6�   ._�5Y      ]� -!   5        $' dpCuentaPerdidaCliente��5Y   Y   $��1��6   $��1��6)   $��4.667,0.667,4.667,0.5q�6:   
�������.+�5Z      �� -"   5        $( imgCuentaPerdidaCliente��5Z   �   $��Right=�6l   $��lupa.png��6�   $��20��6�   $��0,0,0,-0.333q�6�   $y�Hidden=�6�   $
) Hand��6�   �� 5[      -#   5        $* txtCuentaPerdidaCliente��5[      $��12(�6?   $��Normal"�6M   
�������$��0q�6�   $��0,0,0,0.333q�6�   $	��130��6�   
���   �$	��Top=�6�   $��Stretch=�6  $��Stretch=�69  5\      5]      �� 5^      -$   5        $# lblCuentaBeneficioProveedores��5^      $
��Bold"�6?   $
��Left=�6Q   $��
33,359,0,0q�6l   $
��Wrap=�6�   $%��Cuenta Beneficio (proveedores):��6�   $	��Top=�6�   �� 5_      -%   5        $"% bdCuentaBeneficioProveedores��5_   b   $��1q�6   
�������$& 3��6<   $��223,354,0,0q�6M   
�������$
��Left=�6�   $	��135��6�   $��25��6�   $	��Top=�6�   ._�5`      ]� -&   5        $"' dpCuentaBeneficioProveedores��5`   Y   $��1��6   $��1��6)   $��4.667,0.667,4.667,0.5q�6:   
�������.+�5a      �� -'   5        $#( imgCuentaBeneficioProveedores��5a   �   $��Right=�6r   $��lupa.png��6�   $��20��6�   $��0,0,0,-0.333q�6�   $y�Hidden=�6�   $
) Hand��6�   �� 5b      -(   5        $#* txtCuentaBeneficioProveedores��5b      $��12(�6E   $��Normal"�6S   
�������$��0q�6�   $��0,0,0,0.333q�6�   $	��130��6�   
���   �$	��Top=�6  $��Stretch=�6#  $��Stretch=�6?  5c      5d      �� 5e      -)   5        $! lblCuentaPerdidaProveedores��5e      $
��Bold"�6=   $
��Left=�6O   $��441,359,0,0q�6j   $
��Wrap=�6   $#��Cuenta Perdida (proveedores):��6�   $	��Top=�6�   �� 5f      -*   5        $ % bdCuentaPerdidaProveedores��5f   b   $��1q�6   
�������$& 3��6<   $��619,354,0,0q�6M   
�������$
��Left=�6�   $	��135��6�   $��25��6�   $	��Top=�6�   ._�5g      ]� -+   5        $ ' dpCuentaPerdidaProveedores��5g   Y   $��1��6   $��1��6)   $��4.667,0.667,4.667,0.5q�6:   
�������.+�5h      �� -,   5        $!( imgCuentaPerdidaProveedores��5h   �   $��Right=�6p   $��lupa.png��6�   $��20��6�   $��0,0,0,-0.333q�6�   $y�Hidden=�6�   $
) Hand��6�   �� 5i      --   5        $!* txtCuentaPerdidaProveedores��5i      $��12(�6C   $��Normal"�6Q   
�������$��0q�6�   $��0,0,0,0.333q�6�   $	��130��6�   
���   �$	��Top=�6  $��Stretch=�6!  $��Stretch=�6=  5j      5k      �� 5l      -.   5        $ lblCuentaBeneficioCuenta��5l      $
��Bold"�6:   $
��Left=�6L   $��
33,397,0,0q�6g   $
��Wrap=�6{   $%��Cuenta Beneficio (Libro Mayor):��6�   $	��Top=�6�   �� 5m      -/   5        $% bdCuentaBeneficioCuenta��5m   b   $��1q�6   
�������$& 3��6<   $��223,392,0,0q�6M   
�������$
��Left=�6�   $	��135��6�   $��25��6�   $	��Top=�6�   ._�5n      ]� -0   5        $' dpCuentaBeneficioCuenta��5n   Y   $��1��6   $��1��6)   $��4.667,0.667,4.667,0.5q�6:   
�������.+�5o      �� -1   5        $( imgCuentaBeneficioCuenta��5o   �   $��Right=�6m   $��lupa.png��6�   $��20��6�   $��0,0,0,-0.333q�6�   $y�Hidden=�6�   $
) Hand��6�   �� 5p      -2   5        $* txtCuentaBeneficioCuenta��5p      $��12(�6@   $��Normal"�6N   
�������$��0q�6�   $��0,0,0,0.333q�6�   $	��130��6�   
���   �$	��Top=�6�   $��Stretch=�6  $��Stretch=�6:  5q      5r      �� 5s      -3   5        $ lblCuentaPerdidaCuenta��5s      $
��Bold"�68   $
��Left=�6J   $��441,399,0,0q�6e   $
��Wrap=�6z   $#��Cuenta Perdida (libro mayor):��6�   $	��Top=�6�   �� 5t      -4   5        $% bdCuentaPerdidaCuenta��5t   b   $��1q�6   
�������$& 3��6<   $��619,394,0,0q�6M   
�������$
��Left=�6�   $	��135��6�   $��25��6�   $	��Top=�6�   ._�5u      ]� -5   5        $' dpCuentaPerdidaCuenta��5u   Y   $��1��6   $��1��6)   $��4.667,0.667,4.667,0.5q�6:   
�������.+�5v      �� -6   5        $( imgCuentaPerdidaCuenta��5v   �   $��Right=�6k   $��lupa.png��6�   $��20��6�   $��0,0,0,-0.333q�6�   $y�Hidden=�6�   $
) Hand��6�   �� 5w      -7   5        $* txtCuentaPerdidaCuenta��5w      $��12(�6>   $��Normal"�6L   
�������$��0q�6�   $��0,0,0,0.333q�6�   $	��130��6�   
���   �$	��Top=�6�   $��Stretch=�6  $��Stretch=�68  5x      5y      5z      5{      5|      