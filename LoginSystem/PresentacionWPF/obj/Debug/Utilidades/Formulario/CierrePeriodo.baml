   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	       Vista.CierrePeriodo   5   	   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	   -   5          � Title$  Cierre Periodo��5   	   $��495.913��6    $	��800��61    � WindowStartupLocation$ CenterScreen=�6V   .��5	      � .+�5
   
   �� -   5         ��Name$ btnEjecutar��5
      $��Ejecutar��6&   $
��Left=�69   $��
34,417,0,0q�6T   $	��Top=�6h   $��94��6�   $��3q�6�   6�   �� 5   
   -   5        $ btnCancelar��5      $��Cancelar��6&   $
��Left=�69   $��151,417,0,0q�6T   $	��Top=�6i   $��94��6�   $��3q�6�   
�������
�������6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgCierrePeriodo��5      $��Normal"�6,   $��1q�6@      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6T   
�������$
��Left=�6|   $	��140��6�   $��
438,53,0,0q�6�   $	��Top=�6�   $	��330��6�      AutoGenerateColumns .     CanUserDeleteRows .     CanUserSortColumns .     SelectionMode$ Single=�6-  $	   HorizontalScrollBarVisibility$
	 Auto=�6D  "
   VerticalScrollBarVisibility$

 Auto=�6i  $��Center=�6�  $��Center=�6�     GridLinesVisibility$	 All=�6�     VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   SelectionUnit$ FullRow=�6+  ���	#FFE5E5E5   	CellStyle 5      �� 5       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6   .�5      ��  �� Property � �� �� Value$ 30��6/   �� 5       � ��$ Center=�6C   �� 5       � ��$ Center=�6A   �� 5       �@��TextAlignment$ Center=�6@   �� 5       � ��$ Center=�6:   �� 5       � �� �	#FFE5E5E563   5         RowStyle 5      �� 5      )  #System.Windows.Controls.DataGridRow"  6    �� 	Resources 5       �� Color��%�   (��       5   *   * SystemColors.HighlightBrushKey+)(�� #     5   *   *$"SystemColors.HighlightTextBrushKey+)�� 5      $ 	#FFE5E5E5��6\   �� 5      $ Black��6`   5      5         Columns 5!      4  .System.Windows.Controls.DataGridTemplateColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Width$ 30 6)   -   5        Seleccionado��   HeaderStyle   HeaderStyle# [  5"   J      Header 5#      �� 5$      -   5         ��Name$ chkSelectAll��5$   #   6X      CellTemplate 5&      �� 5'      .R�5(      �� $ seleccionado��6'   -   5        $��Center=�5(   >    d� 	IsChecked 6\   �� *Seleccionado+ �� UpdateSourceTrigger$ PropertyChanged=�6�   5)         CellEditingTemplate 5+      �� 5,      .R�5-      �� $ seleccionado��6'   -   5        $��Center=�5-   >    6\   �� *Seleccionado+$ PropertyChanged=�6�   5.      50      0  *System.Windows.Controls.DataGridTextColumn  51      $ * 6%   $ Cuenta��6/   -	   5        
cuenta��# [  51   O      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn    Binding  6z   �� *
AcctCode+$ PropertyChanged=�6�     52      $ * 6%   $ Descripcion��6/   # [  6D   -
   5        cuentaDescripcion�� .   52   �   �� *
AcctName+$ PropertyChanged=�6�   54      �� 55   
   -   5        ! ��Name$! cbNivel��55        ComboBoxStyle#��[ 6$   $��23��6K   
�������" �� 
IsReadOnly" . 
���   �$
��Left=�6�   $��
639,10,0,0q�6�   $	��Top=�6�   $	��128��6  �� 56   
   -   5        # ��Name$# lblDPeriodo��56      $
��Bold"�6)   $��12(�6;   
���   �$
��Left=�6\   $��372,242,0,0q�6w   $
��Wrap=�6�   $��Desde��6�   $	��Top=�6�   �� 57   
   -   5        $# lblHPeriodo��57      $
��Bold"�6)   $��12(�6;   
���   �$
��Left=�6\   $��597,243,0,0q�6w   $
��Wrap=�6�   $��Hasta��6�   $	��Top=�6�   �� 58   
   -   5        $ 
cbxCuentas��58      $��Cuenta��6'   $
��Bold"�68   $
��Left=�6J   $��
438,15,0,0q�6e   $	��Top=�6y   6�   �� 59   
   -   5        $ cbxSN��59      $��Socio Negocio��6"   $
��Bold"�6:   $
��Left=�6L   $��	34,10,0,0q�6g   $	��Top=�6z   6�   �� 5:   
   -   5        $# 
lblSNDesde��5:      $
��Bold"�6(   $��12(�6:   
���   �$
��Left=�6[   $��	37,56,0,0q�6v   $
��Wrap=�6�   $��Desde��6�   $	��Top=�6�   �� 5;   
   -   5        $# 
lblSNHasta��5;      $
��Bold"�6(   $��12(�6:   
���   �$
��Left=�6[   $��
234,56,0,0q�6v   $
��Wrap=�6�   $��Hasta��6�   $	��Top=�6�   �� 5<   
   -   5        $! 	cbPeriodo��5<      $ �� DisplayMemberPath$$ Category��6&   % �� SelectedValuePath$% Category��6C   #��[ 6`   $��23��6�   
�������" . $
��Left=�6�   $��173,241,0,0q�6  $	��Top=�6&  $	��162��6>  
���   �6x  �� 5=   
   -   5        $! cbDesde��5=      #��[ 6$   $
$ Code��6K   $
% Code��6d   $��23��6}   
�������" . 
���   �$
��Left=�6�   $��421,241,0,0q�6  $	��Top=�6/  $	��128��6G  �� 5>   
   -   5        $! cbHasta��5>      #��[ 6$   $
$ Code��6K   $
% Code��6d   $��23��6}   
�������" . 
���   �$
��Left=�6�   $��641,241,0,0q�6  $	��Top=�6/  $	��128��6G  �� 5?   
   -   5        $# 
lblPeriodo��5?      $
��Bold"�6(   $��12(�6:   
���   �$
��Left=�6[   $��
34,242,0,0q�6v   $
��Wrap=�6�   $��Periodo Contable:��6�   $	��Top=�6�   �� 5@   
   -   5        $# lblCuentaArrastre��5@      $
��Bold"�6/   $
��Left=�6A   $��
33,323,0,0q�6\   $
��Wrap=�6p   $��Cuenta Arrastre Saldo:��6�   $	��Top=�6�   �� 5A   
   -   5        & ��Name$& bdCuentaArrastre��5A   ^   $��1q�6   
�������' �� CornerRadius$' 3��68   $��173,318,0,0q�6I   
�������$
��Left=�6�   $	��162��6�   $��25��6�   $	��Top=�6�   ._�5B      ]� -   5        ( ]�Name$( dpCuentaArrastre��5B   U   $��1��6   $��1��6%   $��4.667,0.667,4.667,0.5q�66   
�������.+�5C      �� -   5        ) ��Name$) imgCuentaArrastre��5C   �   $��Right=�6b   $��lupa.png��6y   $��20��6�   $��0,0,0,-0.333q�6�   $y�Hidden=�6�   * � Cursor$
* Hand��6�   �� 5D      -   5        + ��Name$+ txtCuentaArrastre��5D      $��12(�65   $��Normal"�6C   
�������$��0q�6�   $��0,0,0,0.333q�6�   $	��130��6�   
���   �$	��Top=�6�   $��Stretch=�6  $��Stretch=�6/  5E      5F      �� 5G   
   -   5        $# lblCuentaCierre��5G      $
��Bold"�6-   $
��Left=�6?   $��
33,365,0,0q�6Z   $
��Wrap=�6n   $��Cuenta Cierre Periodo:��6�   $	��Top=�6�   �� 5H   
   -   5        $& bdCuentaCierre��5H   ^   $��1q�6   
�������$' 3��68   $��173,360,0,0q�6I   
�������$
��Left=�6�   $	��162��6�   $��25��6�   $	��Top=�6�   ._�5I      ]� -   5        $( dpCuentaCierre��5I   U   $��1��6   $��1��6%   $��4.667,0.667,4.667,0.5q�66   
�������.+�5J      �� -   5        $) imgCuentaCierre��5J   �   $��Right=�6`   $��lupa.png��6w   $��20��6�   $��0,0,0,-0.333q�6�   $y�Hidden=�6�   $
* Hand��6�   �� 5K      -   5        $+ txtCuentaCierre��5K      $��12(�63   $��Normal"�6A   
�������$��0q�6�   $��0,0,0,0.333q�6�   $	��130��6�   
���   �$	��Top=�6�   $��Stretch=�6  $��Stretch=�6-  5L      5M      �� 5N   
   -    5        $# lblCuentaArrastreNombre��5N      $
��Bold"�65   $
��Left=�6G   $��359,323,0,0q�6b   $
��Wrap=�6w   $�� ��6�   $y�Hidden=�6�   $	��Top=�6�   �� 5O   
   -!   5        $# lblCuentaCierreNombre��5O      $
��Bold"�63   $
��Left=�6E   $��359,365,0,0q�6`   $
��Wrap=�6u   $�� ��6�   $y�Hidden=�6�   $	��Top=�6�   �� 5P   
   -"   5        $& 	bdDesdeSN��5P   \   $��1q�6   
�������$' 3��68   $��	79,52,0,0q�6I   
�������$
��Left=�6�   $	��135��6�   $��25��6�   $	��Top=�6�   ._�5Q      ]� -#   5        $( 	dpDesdeSN��5Q   U   $��1��6   $��1��6%   $��4.667,0.667,4.667,0.5q�66   
�������.+�5R      �� -$   5        $) 
imgDesdeSN��5R   �   $��Right=�6[   $��lupa.png��6r   $��20��6�   $��0,0,0,-0.333q�6�   $y�Hidden=�6�   $
* Hand��6�   �� 5S      -%   5        $+ 
txtDesdeSN��5S      $��12(�6.   $��Normal"�6<   
�������$��0q�6�   $��0,0,0,0.333q�6�   $	��123��6�   
���   �$	��Top=�6�   $��Stretch=�6  $��Stretch=�6   5T      5U      �� 5V   
   -&   5        $& 	bdHastaSN��5V   ]   $��1q�6   
�������$' 3��68   $��
281,52,0,0q�6I   
�������$
��Left=�6�   $	��129��6�   $��25��6�   $	��Top=�6�   ._�5W      ]� -'   5        $( 	dpHastaSN��5W   U   $��1��6   $��1��6%   $��4.667,0.667,4.667,0.5q�66   
�������.+�5X      �� -(   5        $) 
imgHastaSN��5X   �   $��Right=�6[   $��lupa.png��6r   $��20��6�   $��0,0,0,-0.333q�6�   $y�Hidden=�6�   $
* Hand��6�   �� 5Y      -)   5        $+ 
txtHastaSN��5Y      $��12(�6.   $��Normal"�6<   
�������$��0q�6�   $��0,0,0,0.333q�6�   $	��119��6�   
���   �$	��Top=�6�   $��Stretch=�6  $��Stretch=�6   5Z      5[      5]      5^      