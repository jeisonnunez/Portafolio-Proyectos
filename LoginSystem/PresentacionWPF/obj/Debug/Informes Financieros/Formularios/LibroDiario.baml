   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	       Vista.LibroDiario   5   	   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	   -   5          � Title$  LibroDiario��5   	   $��488.667��6   $	��800��6.    � WindowStartupLocation$ CenterScreen=�6S   .��5	      � .+�5
   
   �� -   5         ��Name$ 
txtSNDesde��5
      $��1q�6&   
�������$
��Left=�6�   $��23��6�   $��	83,53,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��129��6�   .��6�    � 	Resources 5       �� 
TargetType �� Property �� Value��%^   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 3��65   5      5      .��6!   5      �� 5   
   -   5         ��Name$ btnEjecutar��5      $��OK��6&   $
��Left=�63   $��
34,404,0,0q�6N   $	��Top=�6b   $��94��6z   $��3q�6�   6�   �� 5   
   -   5        $ btnCancelar��5      $��Cancelar��6&   $
��Left=�69   $��151,404,0,0q�6T   $	��Top=�6i   $��94��6�   $��3q�6�   
�������
�������6�   &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 dgDiario��5      $��Normal"�6%   $��1q�69   
   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 * 6M   
�������$
��Left=�6u   $	��140��6�   $��
438,53,0,0q�6�   $	��Top=�6�   $	��330��6�      AutoGenerateColumns .     CanUserDeleteRows .     CanUserSortColumns .     SelectionMode$ Single=�6&  $   HorizontalScrollBarVisibility$
 Auto=�6=  "   VerticalScrollBarVisibility$
 Auto=�6b  $��Center=�6�  $��Center=�6�     GridLinesVisibility$	 All=�6�     VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   SelectionUnit$ FullRow=�6$  ���	#FFE5E5E5   	CellStyle 5      �� 5      *  $System.Windows.Controls.DataGridCell"  6   .�5      ��  � ��$ 30��6/   6<   �� 5       � ��$ Center=�6C   6T   �� 5       � ��$ Center=�6A   6R   �� 5       �@��TextAlignment$ Center=�6@   6Q   �� 5       � ��$ Center=�6D   6U   �� 5       � �� �	#FFE5E5E56G   5         RowStyle 5!      �� 5"      )  #System.Windows.Controls.DataGridRow"  6    �� 	Resources 5#       �� Color��%�   (��       5$   *   * SystemColors.HighlightBrushKey+)(�� #     5%   *   *$"SystemColors.HighlightTextBrushKey+)�� 5$      $ 	#FFE5E5E5��6\   �� 5%      $ Black��6`   5&      5'         Columns 5)      4  .System.Windows.Controls.DataGridTemplateColumn  5*      ,  &System.Windows.Controls.DataGridColumn   Width$ 30 6)   -   5        Seleccionado��   HeaderStyle   HeaderStyle# [  5*   J      Header 5+      �� 5,      -   5        $��chkSelectAll��5,   #   $��Center=�67   6�      CellTemplate 5.      �� 5/      .R�50      �� $��seleccionado��6'   -   5        $��Center=�50   ;    d� 	IsChecked 6X   ��  �� Path$ Seleccionado�  �� UpdateSourceTrigger$  PropertyChanged=�51      52      !   CellEditingTemplate! 54      �� 55      .R�56      �� $��seleccionado��6'   -	   5         56   ;   �� $ Seleccionado�$  PropertyChanged=�57      58      5:      0  *System.Windows.Controls.DataGridTextColumn  5;      $ * 6%   # [  6/   $ Cuenta��6Z   -
   5        
cuenta��"   
IsReadOnly" . 1  +System.Windows.Controls.DataGridBoundColumn#   Binding# 5;   z   �� $ AcctCode�$  PropertyChanged=�6�     5<      $ * 6%   # [  6/   $ Descripcion��6Z   -   5        cuentaDescripcion��" . # 5<   �   �� $ AcctName�$  PropertyChanged=�6�   5>      �� 5?   
   -   5        $ ��Name$$ cbNivel��5?        ComboBoxStyle#��[ 6$   $��23��6K   
�������% �� 
IsReadOnly% . 
���   �$
��Left=�6�   $��
639,10,0,0q�6�   $	��Top=�6�   $	��128��6  �� 5@   
   -   5        & ��Name$& lblDFechaContabilizacion��5@      $
��Bold"�66   $��12(�6H   
���   �$
��Left=�6i   $��358,242,0,0q�6�   $
��Wrap=�6�   $��Desde��6�   $	��Top=�6�   (	  "System.Windows.Controls.DatePicker	  5A   
   -   5        ' 	 Name$' dpDFechaContabilizacion��5A   i   $
��Left=�6   $��420,238,0,0q�60   $	��Top=�6E   $	��132��6]    5B      ��%^   '��       �� 5C      " ��6   .�5D      ��  �@��CornerRadius$ 3��65   5F      5G      5H      �� 5I   
   -   5        $& lblHFechaContabilizacion��5I      $
��Bold"�66   $��12(�6H   
���   �$
��Left=�6i   $��583,243,0,0q�6�   $
��Wrap=�6�   $��Hasta��6�   $	��Top=�6�   	  5J   
   -   5        $' dpHFechaContabilizacion��5J   i   $
��Left=�6   $��639,238,0,0q�60   $	��Top=�6E   $	��132��6]    5K      ��%^   '��       �� 5L      " ��6   .�5M      ��  �@��CornerRadius$ 3��65   5O      5P      5Q      �� 5R   
   -   5        ( ��Name$( cbxFechaContabilizacion��5R      $��Fecha Contabilizacion ��64   $
��Bold"�6U   $
��Left=�6g   $��154,240,0,0q�6�   $	��Top=�6�   6�   �� 5S   
   -   5        $( 
cbxCuentas��5S      $��Cuenta��6'   $
��Bold"�68   $
��Left=�6J   $��
438,15,0,0q�6e   $	��Top=�6y   6�   �� 5T   
   -   5        $( cbxSN��5T      $��Socio Negocio��6"   $
��Bold"�6:   $
��Left=�6L   $��	34,10,0,0q�6g   $	��Top=�6z   6�   �� 5U   
   -   5        $& 
lblSNDesde��5U      $
��Bold"�6(   $��12(�6:   
���   �$
��Left=�6[   $��	37,56,0,0q�6v   $
��Wrap=�6�   $��Desde��6�   $	��Top=�6�   �� 5V   
   -   5        $& 
lblSNHasta��5V      $
��Bold"�6(   $��12(�6:   
���   �$
��Left=�6[   $��
234,56,0,0q�6v   $
��Wrap=�6�   $��Hasta��6�   $	��Top=�6�   �� 5W   
   -   5        $ 
txtSNHasta��5W      $��1q�6&   
�������$
��Left=�6�   $��23��6�   $��
281,52,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��129��6�   .��6�    5X      ��%^   '��       �� 5Y      " ��6   .�5Z      ��  �@��CornerRadius$ 3��65   5\      5]      .��6!   5^      �� 5_   
   -   5        $( cbxMonedaExtranjera��5_      $��Moneda extranjera��60   $
��Bold"�6L   $
��Left=�6^   $��
37,292,0,0q�6y   $	��Top=�6�   6�   �� 5`   
   -   5        $( cbxMonedaSistema��5`      $��Moneda del sistema��6-   $
��Bold"�6J   $
��Left=�6\   $��
37,317,0,0q�6w   $	��Top=�6�   6�   �� 5a   
   -   5        $( cbxMonedaLocalySystema��5a      $��Moneda local y de sistema��63   $
��Bold"�6W   $
��Left=�6i   $��
37,341,0,0q�6�   $	��Top=�6�   6�   5b      5c      