   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	        Vista.DiferenciaTipoCambio   5   	   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	   -   5          � Title$  DiferenciaTipoCambio��5   	   $��541.667��6&   $	��800��67    � WindowStartupLocation$ CenterScreen=�6\   .��5	      �� $
��Auto=�6   $
��Auto=�66   .��5
   
   � $��Center=�6   $	��Top=�6,   $	��503��6D   .+�5      �� -   5         ��Name$ lblFechaEjecucion��5      $
��Bold"�63   $��12(�6E   
���   �$
��Left=�6f   $��
31,216,0,0q�6�   $
��Wrap=�6�   $��Fecha de Ejecucion��6�   $	��Top=�6�   (  "System.Windows.Controls.DatePicker  5      -   5        $��dpFechaEjecucion��5   m   $
��Left=�6   $��220,211,0,0q�64   $	��Top=�6I   $	��138��6a    � 	Resources 5       �� 
TargetType �� Property �� Value��%^   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 3��69   5      5      5      �� 5      -   5        $ 	lblMoneda��5      $
��Bold"�6+   $
��Left=�6=   $��439,216,0,0q�6X   $
��Wrap=�6m   $��Moneda��6�   $	��Top=�6�   �� 5      -   5         ��Name$ cbMoneda��5         ComboBoxStyle#��[  6)   $��25��6P   
������� �� 
IsReadOnly . 
���   �$
��Left=�6�   $��619,214,0,0q�6�   $	��Top=�6   $	��132��6  	 �� DisplayMemberPath$	 CurrName��6$  
 �� SelectedValuePath$
 CurrCode��6A  6`  �� 5      -   5         ��Name$ btnEjecutar��5      $��Ejecutar��6*   $
��Left=�6=   $��34,464,0,-19q�6X   $	��Top=�6n   $��94��6�   $��3q�6�   6�   �� 5      -   5        $ btnCancelar��5      $��Cancelar��6*   $
��Left=�6=   $��151,464,0,-19q�6X   $	��Top=�6o   $��94��6�   $��3q�6�   
�������
�������6�   �� 5      -   5        $ lblDFechaVencimiento��5      $
��Bold"�66   $��12(�6H   
���   �$
��Left=�6i   $��
31,255,0,0q�6�   $
��Wrap=�6�   $��Fecha Vencimiento Desde��6�   $	��Top=�6�     5      -	   5          Name$ dpDFechaVencimiento��5   m   $
��Left=�6   $��220,249,0,0q�64   $	��Top=�6I   $	��138��6a    5      ��%^   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 3��69   5      5      5       �� 5!      -
   5        $ lblHFechaVencimiento��5!      $
��Bold"�66   $��12(�6H   
���   �$
��Left=�6i   $��439,253,0,0q�6�   $
��Wrap=�6�   $��Fecha Vencimiento Hasta��6�   $	��Top=�6�     5"      -   5        $ dpHFechaVencimiento��5"   m   $
��Left=�6   $��619,249,0,0q�64   $	��Top=�6I   $	��132��6a    5#      ��%^   '��       �� 5$      " ��6   .�5%      ��  �@��CornerRadius$ 3��69   5'      5(      5)      &   System.Windows.Controls.DataGrid  5*      -   5          Name$ dgDiferenciaTipoCambio��5*      $��Normal"�67   $��1q�6K      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6_   
�������$
��Left=�6�   $	��140��6�   $��
438,53,0,0q�6�   $	��Top=�6�   $	��316��6�      AutoGenerateColumns .     CanUserDeleteRows .     CanUserSortColumns .     SelectionMode$ Single=�68  $   HorizontalScrollBarVisibility$
 Auto=�6O  "   VerticalScrollBarVisibility$
 Auto=�6t  $��Center=�6�  $��Center=�6�     GridLinesVisibility$	 All=�6�     VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   SelectionUnit$ FullRow=�66  ���	#FFE5E5E5   	CellStyle 5+      �� 5-      *  $System.Windows.Controls.DataGridCell"  6   .�5.      ��  � ��$ 30��63   �� 5/       � ��$ Center=�6G   �� 50       � ��$ Center=�6E   �� 51       �@��TextAlignment$ Center=�6D   �� 52       � ��$ Center=�6>   �� 53       � �� �	#FFE5E5E567   54         RowStyle 57      �� 58      )  #System.Windows.Controls.DataGridRow"  6    �� 	Resources 59       �� Color��%�   (��       5:   .   * SystemColors.HighlightBrushKey+)(�� #     5;   .   *$"SystemColors.HighlightTextBrushKey+)�� 5:      $ 	#FFE5E5E5��6`   �� 5;      $ Black��6d   5<      5=         Columns 5?      4  .System.Windows.Controls.DataGridTemplateColumn  5@      ,  &System.Windows.Controls.DataGridColumn   Width$ 30 6-   -   5        Seleccionado��  HeaderStyle   HeaderStyle# [ 5@   N       Header  5A      �� 5B      -   5        ! ��Name$! chkSelectAll��5B   '   6\   "   CellTemplate" 5D      �� 5E      .R�5F   "   �� $! seleccionado��6+   -   5        $��Center=�5F   B   # d� 	IsChecked# 6`   �� *Seleccionado+$ �� UpdateSourceTrigger$$ PropertyChanged=�6�   5G      %   CellEditingTemplate% 5I      �� 5J      .R�5K   "   �� $! seleccionado��6+   -   5        $��Center=�5K   B   # 6`   �� *Seleccionado+$$ PropertyChanged=�6�   5L      5N      0  *System.Windows.Controls.DataGridTextColumn  5O      $ * 6)   $  Cuenta��63   -   5        
cuenta��# [ 5O   S   &   
IsReadOnly& . 1	  +System.Windows.Controls.DataGridBoundColumn' 	  Binding' 6~   �� *
AcctCode+$$ PropertyChanged=�6�     5P      $ * 6)   $  Descripcion��63   # [ 6H   -   5        cuentaDescripcion��& . ' 5P   �   �� *
AcctName+$$ PropertyChanged=�6�   5R      �� 5S      -   5        $ cbNivel��5S      #��[  6(   $��23��6O   
������� . 
���   �$
��Left=�6�   $��
639,10,0,0q�6�   $	��Top=�6�   $	��128��6  �� 5T      -   5        $! 
cbxCuentas��5T      $��Cuenta��6+   $
��Bold"�6<   $
��Left=�6N   $��
438,15,0,0q�6i   $	��Top=�6}   6�   �� 5U      -   5        $! cbxSN��5U      $��Socio Negocio��6&   $
��Bold"�6>   $
��Left=�6P   $��	34,10,0,0q�6k   $	��Top=�6~   6�   �� 5V      -   5        $ 
lblSNDesde��5V      $
��Bold"�6,   $��12(�6>   
���   �$
��Left=�6_   $��	37,56,0,0q�6z   $
��Wrap=�6�   $��Desde��6�   $	��Top=�6�   �� 5W      -   5        $ 
lblSNHasta��5W      $
��Bold"�6,   $��12(�6>   
���   �$
��Left=�6_   $��
234,56,0,0q�6z   $
��Wrap=�6�   $��Hasta��6�   $	��Top=�6�   �� 5X      -   5        ( ��Name$( 	bdDesdeSN��5X   `   $��1q�6   
�������) �� CornerRadius$) 3��6<   $��	79,52,0,0q�6M   
�������$
��Left=�6�   $	��135��6�   $��25��6�   $	��Top=�6�   ._�5Y      ]� -   5        * ]�Name$* 	dpDesdeSN��5Y   Y   $��1��6   $��1��6)   $��4.667,0.667,4.667,0.5q�6:   
�������.+�5Z      �� -   5        + ��Name$+ 
imgDesdeSN��5Z   �   $��Right=�6_   $5��//Vista;component/Utilidades/Formulario/lupa.png��6v   $��20��6�   $��0,0,0,-0.333q�6�   $y�Hidden=�6�   , � Cursor$
, Hand��6�   �� 5[      -   5        - ��Name$- 
txtDesdeSN��5[      $��12(�62   $��Normal"�6@   
�������$��0q�6�   $��0,0,0,0.333q�6�   $	��123��6�   
���   �$	��Top=�6�   $��Stretch=�6  $��Stretch=�6$  5\      5]      �� 5^      -   5        $( 	bdHastaSN��5^   a   $��1q�6   
�������$) 3��6<   $��
281,52,0,0q�6M   
�������$
��Left=�6�   $	��129��6�   $��25��6�   $	��Top=�6�   ._�5_      ]� -   5        $* 	dpHastaSN��5_   Y   $��1��6   $��1��6)   $��4.667,0.667,4.667,0.5q�6:   
�������.+�5`      �� -   5        $+ 
imgHastaSN��5`   �   $��Right=�6_   $5��//Vista;component/Utilidades/Formulario/lupa.png��6v   $��20��6�   $��0,0,0,-0.333q�6�   $y�Hidden=�6�   $
, Hand��6�   �� 5a      -   5        $- 
txtHastaSN��5a      $��12(�62   $��Normal"�6@   
�������$��0q�6�   $��0,0,0,0.333q�6�   $	��119��6�   
���   �$	��Top=�6�   $��Stretch=�6  $��Stretch=�6$  5b      5c      �� 5d      -    5        $ lblCuentaBeneficioCliente��5d      $
��Bold"�6;   $
��Left=�6M   $��
33,323,0,0q�6h   $
��Wrap=�6|   $!��Cuenta Beneficio (cliente):��6�   $	��Top=�6�   �� 5e      -!   5        $( bdCuentaBeneficioCliente��5e   b   $��1q�6   
�������$) 3��6<   $��221,318,0,0q�6M   
�������$
��Left=�6�   $	��135��6�   $��25��6�   $	��Top=�6�   ._�5f      ]� -"   5        $* dpCuentaBeneficioCliente��5f   Y   $��1��6   $��1��6)   $��4.667,0.667,4.667,0.5q�6:   
�������.+�5g      �� -#   5        $+ imgCuentaBeneficioCliente��5g   �   $��Right=�6n   $��lupa.png��6�   $��20��6�   $��0,0,0,-0.333q�6�   $y�Hidden=�6�   $
, Hand��6�   �� 5h      -$   5        $- txtCuentaBeneficioCliente��5h      $��12(�6A   $��Normal"�6O   
�������$��0q�6�   $��0,0,0,0.333q�6�   $	��130��6�   
���   �$	��Top=�6   $��Stretch=�6  $��Stretch=�6;  5i      5j      �� 5k      -%   5        $ lblCuentaPerdidaCliente��5k      $
��Bold"�69   $
��Left=�6K   $��441,323,0,0q�6f   $
��Wrap=�6{   $��Cuenta Perdida (cliente):��6�   $	��Top=�6�   �� 5l      -&   5        $( bdCuentaPerdidaCliente��5l   b   $��1q�6   
�������$) 3��6<   $��619,318,0,0q�6M   
�������$
��Left=�6�   $	��135��6�   $��25��6�   $	��Top=�6�   ._�5m      ]� -'   5        $* dpCuentaPerdidaCliente��5m   Y   $��1��6   $��1��6)   $��4.667,0.667,4.667,0.5q�6:   
�������.+�5n      �� -(   5        $+ imgCuentaPerdidaCliente��5n   �   $��Right=�6l   $��lupa.png��6�   $��20��6�   $��0,0,0,-0.333q�6�   $y�Hidden=�6�   $
, Hand��6�   �� 5o      -)   5        $- txtCuentaPerdidaCliente��5o      $��12(�6?   $��Normal"�6M   
�������$��0q�6�   $��0,0,0,0.333q�6�   $	��130��6�   
���   �$	��Top=�6�   $��Stretch=�6  $��Stretch=�69  5p      5q      �� 5r      -*   5        $# lblCuentaBeneficioProveedores��5r      $
��Bold"�6?   $
��Left=�6Q   $��
33,359,0,0q�6l   $
��Wrap=�6�   $%��Cuenta Beneficio (proveedores):��6�   $	��Top=�6�   �� 5s      -+   5        $"( bdCuentaBeneficioProveedores��5s   b   $��1q�6   
�������$) 3��6<   $��223,354,0,0q�6M   
�������$
��Left=�6�   $	��135��6�   $��25��6�   $	��Top=�6�   ._�5t      ]� -,   5        $"* dpCuentaBeneficioProveedores��5t   Y   $��1��6   $��1��6)   $��4.667,0.667,4.667,0.5q�6:   
�������.+�5u      �� --   5        $#+ imgCuentaBeneficioProveedores��5u   �   $��Right=�6r   $��lupa.png��6�   $��20��6�   $��0,0,0,-0.333q�6�   $y�Hidden=�6�   $
, Hand��6�   �� 5v      -.   5        $#- txtCuentaBeneficioProveedores��5v      $��12(�6E   $��Normal"�6S   
�������$��0q�6�   $��0,0,0,0.333q�6�   $	��130��6�   
���   �$	��Top=�6  $��Stretch=�6#  $��Stretch=�6?  5w      5x      �� 5y      -/   5        $! lblCuentaPerdidaProveedores��5y      $
��Bold"�6=   $
��Left=�6O   $��441,359,0,0q�6j   $
��Wrap=�6   $#��Cuenta Perdida (proveedores):��6�   $	��Top=�6�   �� 5z      -0   5        $ ( bdCuentaPerdidaProveedores��5z   b   $��1q�6   
�������$) 3��6<   $��619,354,0,0q�6M   
�������$
��Left=�6�   $	��135��6�   $��25��6�   $	��Top=�6�   ._�5{      ]� -1   5        $ * dpCuentaPerdidaProveedores��5{   Y   $��1��6   $��1��6)   $��4.667,0.667,4.667,0.5q�6:   
�������.+�5|      �� -2   5        $!+ imgCuentaPerdidaProveedores��5|   �   $��Right=�6p   $��lupa.png��6�   $��20��6�   $��0,0,0,-0.333q�6�   $y�Hidden=�6�   $
, Hand��6�   �� 5}      -3   5        $!- txtCuentaPerdidaProveedores��5}      $��12(�6C   $��Normal"�6Q   
�������$��0q�6�   $��0,0,0,0.333q�6�   $	��130��6�   
���   �$	��Top=�6  $��Stretch=�6!  $��Stretch=�6=  5~      5      �� 5�      -4   5        $ lblCuentaBeneficioCuenta��5�      $
��Bold"�6:   $
��Left=�6L   $��
33,397,0,0q�6g   $
��Wrap=�6{   $%��Cuenta Beneficio (Libro Mayor):��6�   $	��Top=�6�   �� 5�      -5   5        $( bdCuentaBeneficioCuenta��5�   b   $��1q�6   
�������$) 3��6<   $��223,392,0,0q�6M   
�������$
��Left=�6�   $	��135��6�   $��25��6�   $	��Top=�6�   ._�5�      ]� -6   5        $* dpCuentaBeneficioCuenta��5�   Y   $��1��6   $��1��6)   $��4.667,0.667,4.667,0.5q�6:   
�������.+�5�      �� -7   5        $+ imgCuentaBeneficioCuenta��5�   �   $��Right=�6m   $��lupa.png��6�   $��20��6�   $��0,0,0,-0.333q�6�   $y�Hidden=�6�   $
, Hand��6�   �� 5�      -8   5        $- txtCuentaBeneficioCuenta��5�      $��12(�6@   $��Normal"�6N   
�������$��0q�6�   $��0,0,0,0.333q�6�   $	��130��6�   
���   �$	��Top=�6�   $��Stretch=�6  $��Stretch=�6:  5�      5�      �� 5�      -9   5        $ lblCuentaPerdidaCuenta��5�      $
��Bold"�68   $
��Left=�6J   $��441,399,0,0q�6e   $
��Wrap=�6z   $#��Cuenta Perdida (libro mayor):��6�   $	��Top=�6�   �� 5�      -:   5        $( bdCuentaPerdidaCuenta��5�   b   $��1q�6   
�������$) 3��6<   $��619,394,0,0q�6M   
�������$
��Left=�6�   $	��135��6�   $��25��6�   $	��Top=�6�   ._�5�      ]� -;   5        $* dpCuentaPerdidaCuenta��5�   Y   $��1��6   $��1��6)   $��4.667,0.667,4.667,0.5q�6:   
�������.+�5�      �� -<   5        $+ imgCuentaPerdidaCuenta��5�   �   $��Right=�6k   $��lupa.png��6�   $��20��6�   $��0,0,0,-0.333q�6�   $y�Hidden=�6�   $
, Hand��6�   �� 5�      -=   5        $- txtCuentaPerdidaCuenta��5�      $��12(�6>   $��Normal"�6L   
�������$��0q�6�   $��0,0,0,0.333q�6�   $	��130��6�   
���   �$	��Top=�6�   $��Stretch=�6  $��Stretch=�68  5�      5�      5�      5�      5�      