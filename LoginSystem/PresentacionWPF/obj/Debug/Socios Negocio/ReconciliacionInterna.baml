   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	   !    Vista.ReconciliacionInterna   5      n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	      Vista.Converter    Closing$  Window_Closing��5   n      Loaded$ Converter_Loaded��6�    � Title$ ReconciliacionInterna��6	   $��479.245��6'    � WindowStartupLocation$ CenterScreen=�68   $��1070.405��6]   .��5	      �� $
��Auto=�6   $
��Auto=�66   .��5
   
   � $��Center=�6   $	��Top=�6,   $
��1058��6D   .+�5      �� -   5         ��Name$ lblSN��5      $
��Bold"�6'   $
��Left=�69   $��	51,13,0,0q�6T   $
��Wrap=�6g   $��Socio Negocio��6{   $	��Top=�6�   �� 5      -   5        $ 	lblMoneda��5      $
��Bold"�6+   $
��Left=�6=   $��
749,16,0,0q�6X   $
��Wrap=�6l   $��Moneda��6�   $	��Top=�6�   �� 5      -   5         ��Name$ cbMoneda��5         ComboBoxStyle#��[  6)   $��23��6P   
������� �� 
IsReadOnly . 
���   �$
��Left=�6�   $��
878,12,0,0q�6�   $	��Top=�6�   $	��129��6  6%  �� 5      -   5        $ lblFecha��5      $
��Bold"�6*   $
��Left=�6<   $��
749,57,0,0q�6W   $
��Wrap=�6k   $��Fecha Reconciliacion��6   $	��Top=�6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ dgReconciliacion��5      $��Normal"�6`   $��1q�6t      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�   
�������$
��Left=�6�   $	��208��6�   $��
51,144,0,0q�6�   $	��Top=�6�   $	��956��6  	   AutoGenerateColumns	 .  
   CanUserDeleteRows
 .     CanUserSortColumns .     SelectionMode$ Single=�6a  $   HorizontalScrollBarVisibility$
 Auto=�6x  "   VerticalScrollBarVisibility$
 Auto=�6�  $��Center=�6�  $��Center=�6�     GridLinesVisibility$	 All=�6     VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   SelectionUnit$ FullRow=�6_  ���	#FFE5E5E5   	CellStyle 5      �� 5       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6   .�5      ��  �� Property � �� �� Value$ 30��63   6@   �� 5       � ��$ Stretch=�6@   6R   �� 5       � ��$ Stretch=�6>   6P   �� 5       � ��$ Center=�6G   6X   �� 5       � ��$ Center=�6E   6V   �� 5       �@��TextAlignment$ Center=�6D   6U   �� 5       � ��$ Center=�6H   6Y   5         RowStyle 5       �� 5"      )  #System.Windows.Controls.DataGridRow"  6    �� Triggers 5$      P� 5%       P� Property �@J�IsMouseOver P� Value . . �5'   "   ��  � ��
 �����5(      �� 5)   "    � ��$ Normal"�5*      5-       �� 	Resources 51       �� Color��%�   (��       52   .   * SystemColors.HighlightBrushKey+)(�� %     53   .   *$"SystemColors.HighlightTextBrushKey+)�� 52      $ Transparent��6`   �� 53      $ Black��6d   54      56       � 	Resources 59        TextBoxStyle  TextBoxStyleNotReadOnly��%�   &	       &	 }     �� 5:      " ��61   .�5;      ��  � �� �	#FF74C1FF6K   �� 5<       � ��$ Normal"�67   6H   5>      �� 5?      " ��6<   .�5@      ��  � �� �	#FF74C1FF6K   5B      5D         Columns 5E      4  .System.Windows.Controls.DataGridTemplateColumn  5F      ,  &System.Windows.Controls.DataGridColumn   Width$ * 6-       Header$  Seleccionado��67   -   5        Seleccionado��  HeaderStyle!   HeaderStyle#! [ 5F   c   "   CellTemplate" 5H      �� 5I      .R�5J   "   ]� # ]�Name$# dpSeleccionado��6,   .+�5K   &   �� $ ��Name$$ seleccionado��6/   -   5        $��Center=�5K   E   % d� 	IsChecked% 6c   �� *Seleccionado+& �� UpdateSourceTrigger$& PropertyChanged=�6�   5L   #   5M      '   CellEditingTemplate' 5O      �� 5P      .R�5Q   "   ]� $# dpSeleccionado��6,   .+�5R   &   �� $$ seleccionado��6/   -   5        $��Center=�5R   E   % 6c   �� *Seleccionado+$& PropertyChanged=�6�   5S   #   5T      5V        5W      $  Nro Operacion��6-   $
 auto 6D   -	   5        nroOperacion��#! [ 5W   g   (   
IsReadOnly( . " 5X      �� 5Y      .R�5Z   "   ]� $��	dpTransId��6I   $��1��6,   $��1��69   ���	#FFE5E5E5$��Stretch=�6q   $��Stretch=�6�   .+�5[   &   �� $��
imgTransId��6�   -
   5        $
��Left=�5[   p   $��004-proximo.png��6�   $��20��6�   $��0,0,0,-0.333q�6�   $y�Visible=�6�   ) � Cursor$
) Hand��6�   $��Stretch=�6�   $��Stretch=�6  �� 5\   &   $ 
txtTransId��60   ���	#FFE5E5E5$��Stretch=�6[   $��Stretch=�6w   $��0,0,0,-0.333q�6�   $��95��6�   * �� TextAlignment$* Center=�6�   ��6�   �� + �� Path$+ TransId�$& PropertyChanged=�6  5]   #   5^      ' 5`      �� 5a      .R�5b   "   ]� $��	dpTransId��6J   $��1��6,   $��1��69   ���	#FFE5E5E5$��Stretch=�6r   $��Stretch=�6�   .+�5c   &   �� $��
imgTransId��6�   -   5        $
��Left=�5c   o   $��004-proximo.png��6�   $��20��6�   $��0,0,0,-0.333q�6�   $y�Visible=�6�   $
) Hand��6�   $��Stretch=�6�   $��Stretch=�6  �� 5d   &   , ��Name$, 
txtTransId��6/   ���	#FFE5E5E5- �� 
IsReadOnly- . $��0,0,0,-0.333q�6�   $��95��6�   $��Stretch=�6�   $��Stretch=�6�   . �� TextAlignment$. Center=�6
  ��6m   �� $+ TransId�$& PropertyChanged=�6%  5e   #   5f      5h        5i      $  Origen��6-   $ * 6=   -   5        nroDocumento��( . #! [ 5i   o   " 5j      �� 5k      .R�5l   "   ]� $��dpTransType��6I   $��1��6,   $��1��69   $��Stretch=�6\   $��Stretch=�6z   ���	#FFE5E5E5.+�5m   &   �� $��imgTransType��6�   -   5        $
��Left=�5m   q   $��004-proximo.png��6�   $��20��6�   $��0,0,0,-0.333q�6�   $y�Visible=�6�   $
) Hand��6�   $��Stretch=�6�   $��Stretch=�6  �� 5n   &   $ txtTransType��6G   ���	#FFE5E5E5$* Center=�6]   $��Stretch=�6t   $��Stretch=�6�   $��0,0,0,-0.333q�6�   $��95��6
  ��6�   �� $+ 	TransType�$& PropertyChanged=�6  5o   #   5p      ' 5r      �� 5s      .R�5t   "   ]� $��dpTransType��6J   $��1��6,   $��1��69   ���	#FFE5E5E5$��Stretch=�6t   $��Stretch=�6�   .+�5u   &   �� $��imgTransType��6�   -   5        $
��Left=�5u   q   $��004-proximo.png��6�   $��20��6�   $��0,0,0,-0.333q�6�   $y�Visible=�6�   $
) Hand��6�   $��Stretch=�6�   $��Stretch=�6  �� 5v   &   $, txtTransType��6/   ���	#FFE5E5E5$. Center=�6\   - . $��0,0,0,-0.333q�6�   $��95��6�   $��Stretch=�6�   $��Stretch=�6  ��6�   �� $+ 	TransType�$& PropertyChanged=�6)  5w   #   5x      5z        5{      $  
Nro Origen��6-   $ * 6A   -   5        	nroOrigen��( . #! [ 5{   p   " 5}      �� 5~      .R�5   "   ]� $��	dpBaseRef��6a   $��1��6,   $��1��69   ���	#FFE5E5E5$��Stretch=�6r   $��Stretch=�6�   .+�5�   &   �� $ 
txtBaseRef��6G   ���	#FFE5E5E5$* Center=�6[   $��Stretch=�6r   $��Stretch=�6�   $��0,0,0,-0.333q�6�   $��95��6  ��6�   �� $+ BaseRef�$& PropertyChanged=�6  5�   #   5�      ' 5�      �� 5�      .R�5�   "   ]� $��	dpBaseRef��6a   ���	#FFE5E5E5$��1��6C   $��1��6P   $��Stretch=�6r   $��Stretch=�6�   .+�5�   &   �� $, 
txtBaseRef��6/   $. Center=�6C   - . $��0,0,0,-0.333q�6�   $��95��6�   $��Stretch=�6�   $��Stretch=�6�   $��Stretch=�6  $��Stretch=�64  #��[ 6R  ��6m   �� $+ BaseRef�$& PropertyChanged=�6{  5�   #   5�      5�        5�      $  Fecha Contabilizacion��6-   $ * 6L   -   5        refDate��( . #! [ 5�   y   " 5�      �� 5�      .R�5�   "   ]� $��	dpRefDate��6a   ���	#FFE5E5E5$��1��6C   $��1��6P   $��Stretch=�6r   $��Stretch=�6�   .+�5�   &   �� $ 
txtRefDate��6G   ���	#FFE5E5E5$* Center=�6[   $��Stretch=�6r   $��Stretch=�6�   $��0,0,0,-0.333q�6�   $��95��6  ��6�   �� $+ RefDate�$& PropertyChanged=�6  5�   #   5�      ' 5�      �� 5�      .R�5�   "   ]� $��	dpRefDate��6a   ���	#FFE5E5E5$��1��6C   $��1��6P   $��Stretch=�6r   $��Stretch=�6�   .+�5�   &   �� $, 
txtRefDate��6/   ���	#FFE5E5E5$��Stretch=�6Z   $��Stretch=�6   $. Center=�6�   - . $��0,0,0,-0.333q�6  $��95��6$  $��Stretch=�6/  $��Stretch=�6K  ��6�   �� $+ RefDate�$& PropertyChanged=�6m  5�   #   5�      5�        5�      $  Importe��6-   $ * 6>   -   5        importe��( . #! [ 5�   k   " 5�      �� 5�      .R�5�   "   ]� $��	dpImporte��6a   ���	#FFE5E5E5$��1��6C   $��1��6P   $��Stretch=�6r   $��Stretch=�6�   .+�5�   &   �� $ 
txtImporte��6G   ���	#FFE5E5E5$* Center=�6[   $��Stretch=�6r   $��Stretch=�6�   $��0,0,0,-0.333q�6�   $��95��6  ��6�   �� $+ Importe�$& PropertyChanged=�6  5�   #   5�      ' 5�      �� 5�      .R�5�   "   ]� $��	dpImporte��6a   ���	#FFE5E5E5$��1��6C   $��1��6P   $��Stretch=�6r   $��Stretch=�6�   .+�5�   &   �� $, 
txtImporte��6/   $. Center=�6C   - . $��0,0,0,-0.333q�6�   $��95��6�   $��Stretch=�6�   $��Stretch=�6�   ��6m   �� $+ Importe�$& PropertyChanged=�6  5�   #   5�      5�        5�      $  Saldo Vencido��6-   $ * 6D   -   5        saldoVencido��( . #! [ 5�   v   " 5�      �� 5�      .R�5�   "   ]� $��dpSaldoVencido��6a   ���	#FFE5E5E5$��1��6C   $��1��6P   $��Stretch=�6w   $��Stretch=�6�   .+�5�   &   �� $ txtSaldoVencido��6G   ���	#FFE5E5E5$* Center=�6`   $��Stretch=�6w   $��Stretch=�6�   $��0,0,0,-0.333q�6�   $��95��6  ��6�   �� $+ SaldoVencido�$& PropertyChanged=�6  5�   #   5�      ' 5�      �� 5�      .R�5�   "   ]� $��dpSaldoVencido��6a   ���	#FFE5E5E5$��1��6C   $��1��6P   $��Stretch=�6w   $��Stretch=�6�   .+�5�   &   �� $, txtSaldoVencido��6/   $. Center=�6H   - . $��0,0,0,-0.333q�6�   $��95��6�   $��Stretch=�6�   $��Stretch=�6�   ��6r   �� $+ SaldoVencido�$& PropertyChanged=�6  5�   #   5�      5�        5�      $  Importe Reconciliar��6-   $ * 6J   -   5        importeReconciliar��#! [ 5�   q   " 5�      �� 5�      .R�5�   "   ]� $��dpImporteReconciliar��6]   
�������$��1��6?   $��1��6L   $��Stretch=�6y   $��Stretch=�6�   .+�5�   &   �� $ txtImporteReconciliar��6O   
�������/ �� Padding$/ 0q�6C   $* Center=�6n   $��Stretch=�6�   $��Stretch=�6�   $��0,0,0,-0.333q�6  $��95��6$  ��6�   �� $+ ImporteReconciliar�$& PropertyChanged=�64  5�   #   5�      ' 5�      �� 5�      .R�5�   "   ]� $��dpImporteReconciliar��6]   
�������$��1��6?   $��1��6L   $��Stretch=�6y   $��Stretch=�6�   .+�5�   &   �� $, txtImporteReconciliar��6/   -   5        $. Center=�5�   O   $��0,0,0,-0.333q�6�   $��95��6�   $��Stretch=�6�   $��Stretch=�6�   $��Stretch=�6  $��Stretch=�65  #��[ 6X  ��6h   �� $+ ImporteReconciliar�$& PropertyChanged=�6�  5�   #   5�      5�        5�      $  Info Detallada��6-   $ * 6E   -   5        lineMemo��#! [ 5�   a   " 5�      �� 5�      .R�5�   "   ]� $��
dpLineMemo��6a   ���	#FFE5E5E5$��1��6C   $��1��6P   $��Stretch=�6s   $��Stretch=�6�   .+�5�   &   �� $ txtLineMemo��6H   ���	#FFE5E5E5$* Center=�6]   $��Stretch=�6t   $��Stretch=�6�   $��0,0,0,-0.333q�6�   $��95��6	  ��6�   �� $+ LineMemo�$& PropertyChanged=�6  5�   #   5�      ' 5�      �� 5�      .R�5�   "   ]� $��
dpLineMemo��6a   ���	#FFE5E5E5$��1��6C   $��1��6P   $��Stretch=�6s   $��Stretch=�6�   .+�5�   &   �� $, txtLineMemo��6/   $. Center=�6E   $��0,0,0,-0.333q�6�   $��95��6�   $��Stretch=�6�   $��Stretch=�6�   ��6^   �� $+ LineMemo�$& PropertyChanged=�6   5�   #   5�      5�      0  *System.Windows.Controls.DataGridTextColumn  5�      $ * 6)   0   
Visibility$0 Hidden=�63   $  Cuenta��6G   #! [ 6W   -   5        account��( . 1	  +System.Windows.Controls.DataGridBoundColumn1 	  Binding1 5�   �   �� *	Account+$& PropertyChanged=�2 	  ElementStyle2 5�      �� 5�      " ��6$   .�5�   "   ��  �@��TextAlignment$ Center=�6B   5�      5�        5�      $ * 6)   $0 Hidden=�63   $  LineId��6G   #! [ 6W   -   5        
lineId��( . 1 5�   �   �� *	Line_ID+$& PropertyChanged=�2 5�      �� 5�      " ��6$   .�5�   "   ��  �@��TextAlignment$ Center=�6B   5�      5�      5�      �� 5�      -   5        3 ��Name$3 btnReconciliar��5�      $��Reconciliar��6-   $
��Left=�6C   $��58,395,0,-0.333q�6^   $	��Top=�6w   $��95��6�   $��3q�6�   6�   �� 5�      -   5        $3 btnCancelar��5�      $��Cancelar��6*   $
��Left=�6=   $��170,395,0,-0.333q�6X   $	��Top=�6r   $��94��6�   $��3q�6�   
�������
�������6�   �� 5�      -   5        4 ��Name$
4 bdSN��5�   a   $��1q�6   
�������5 �� CornerRadius$5 3��6<   $��
152,10,0,0q�6M   
�������$
��Left=�6�   $	��158��6�   $��25��6�   $	��Top=�6�   ._�5�      ]� -   5        $
# dpSN��5�   Y   $��1��6   $��1��6)   $��4.667,0.667,4.667,0.5q�6:   
�������.+�5�      �� -   5        6 ��Name$6 imgSN��5�   �   $��Right=�6Z   $��lupa.png��6q   $��20��6�   $��0,0,0,-0.333q�6�   $y�Hidden=�6�   $
) Hand��6�   �� 5      -   5        $, txtSN��5      $��12(�6a   $��Normal"�6o   
�������$��0q�6�   $��0,0,0,0.333q�6�   $	��123��6�   
���   �$	��Top=�6  $��Stretch=�67  $��Stretch=�6S  5     5     (
  "System.Windows.Controls.DatePicker
  5     -   5        7 
 Name$7 dpReconciliacion��5  x   $
��Left=�6   $��
878,52,0,0q�64   $	��Top=�6H   $	��129��6`   $��25��6l   $��1q�6�    5     ��%^   '��       �� 5     " ��6   .�5     ��  �@��CornerRadius$ 3��69   5     5	     5
     �� 5     -   5        $, txtTotalReconciliacion��5     $��1q�66   - . $
��Left=�6\   $��23��6w   $��848,395,0,0q�6�   8 �� TextWrapping$
8 Wrap=�6�   $	��Top=�6�   $	��154��6�   .��6�    5     ��%^   '��       �� 5     " ��6   .�5     ��  �@��CornerRadius$ 3��69   5     5     .��6%   5     �� 5     -    5        $ lblTotalReconciliacion��5     $
��Bold"�68   $
��Left=�6J   $��690,399,0,0q�6e   $
��Wrap=�6z   $��Resultado Reconciliacion��6�   $	��Top=�6�   5     5     5     