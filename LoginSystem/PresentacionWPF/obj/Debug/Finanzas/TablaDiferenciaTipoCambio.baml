   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	   %    Vista.TablaDiferenciaTipoCambio   5      n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	      Vista.Converter    Closing$  Window_Closing��5   I      Loaded$ Converter_Loaded��6b    � Title$ TablaDiferenciaTipoCambio��6	   $	��450��6+   $��902.231��68    � 	Resources 5	          Vista.ConverterClosePeriod   ConverterClosePeriod��%   &	          5   
   6%   5      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgDiferenciaTipoCambio��5      $��Normal"�63   $��1q�6G      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6[   
�������$
��Left=�6�   $	��212��6�   $��
17,144,0,0q�6�   $	��Top=�6�   $	��844��6�      AutoGenerateColumns .     CanUserDeleteRows .     CanUserSortColumns .  	   SelectionMode$	 Single=�64  $
   HorizontalScrollBarVisibility$

 Auto=�6K  "   VerticalScrollBarVisibility$
 Auto=�6p  $��Center=�6�  $��Center=�6�     GridLinesVisibility$	 All=�6�     VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   SelectionUnit$ FullRow=�62  ���	#FFE5E5E5   	CellStyle 5      �� 5       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6   .�5      ��  �� Property � �� �� Value$ 30��6/   �� 5       � ��$ Center=�6C   �� 5       � ��$ Center=�6A   �� 5       �@��TextAlignment$ Center=�6@   �� 5       � ��$ Center=�6:   �� 5       � �� �	#FFE5E5E563   5         RowStyle 5      �� 5      )  #System.Windows.Controls.DataGridRow"  6    �� 	Resources 5       �� Color��%�   (��       5   *   * SystemColors.HighlightBrushKey+)(�� #     5    *   *$"SystemColors.HighlightTextBrushKey+)�� 5      $ 	#FFE5E5E5��6\   �� 5       $ Black��6`   5!      5"         Columns 5$      4  .System.Windows.Controls.DataGridTemplateColumn  5%      ,  &System.Windows.Controls.DataGridColumn   Width$ 30 6)   -   5        Seleccionado��  HeaderStyle   HeaderStyle# [ 5%   J      Header 5&      �� 5'      -   5         ��Name$ chkSelectAll��5'   #   6X      CellTemplate 5)      �� 5*      .R�5+      �� $ seleccionado��6'   -   5        $��Center=�5+   =    d� 	IsChecked 6[   �� *Seleccionado+ �� UpdateSourceTrigger$ PropertyChanged=�6�   5,         CellEditingTemplate 5.      �� 5/      .R�50      �� $ seleccionado��6'   -   5        $��Center=�50   =    6[   �� *Seleccionado+$ PropertyChanged=�6�   51      53      0	  *System.Windows.Controls.DataGridTextColumn	  54      $	 110 6%   $ Cuenta Asociada��61   -   5        cuentaAsociada��# [ 54   c       
IsReadOnly  . 1
  +System.Windows.Controls.DataGridBoundColumn! 
  Binding! 6�   �� *	ShortName+$ PropertyChanged=�" 
  ElementStyle" 55      �� 56      " ��6    .�57      ��  � �� 6;   �� *	ActType+# �� 	Converter## [  $ PropertyChanged=��� 58       �@��TextAlignment$ Center=�6>   59      5;      	  5<      $	 150 6%   $ Cuenta de Mayor��61   -   5        cuentaMayor��# [ 5<   _     . ! 6�   �� *	Account+$ PropertyChanged=�" 5=      �� 5>      " ��6    .�5?      ��  � �� 6;   �� *	ActType+## [  $ PropertyChanged=��� 5@       �@��TextAlignment$ Center=�6>   5A      5C      	  5D      $	 100 6%   $ Cuenta /Nombre SN��61   # [ 6L   -   5        cuentaDescripcion��  . ! 5D   �   �� *
AcctName+$ PropertyChanged=�" 5E      �� 5F      " ��6    .�5G      ��  � �� 6;   �� *	ActType+## [  $ PropertyChanged=��� 5H       �@��TextAlignment$ Center=�6>   5I      5K      	  5L      $ 80 6%   $ Moneda��60   # [ 6@   -	   5        
moneda��  . ! 5L   {   �� *
FCCurrency+$ PropertyChanged=�" 5M      �� 5N      " ��6    .�5O      ��  � �� 6;   �� *	ActType+## [  $ PropertyChanged=��� 5P       �@��TextAlignment$ Center=�6>   5Q      5S      	  5T      $ 90 6%   $ 
Saldo (ML)��60   -
   5        saldoML��# [ 5T   U     . ! 6�   �� *Saldo+$ PropertyChanged=�" 5U      �� 5V      " ��6    .�5W      ��  � �� 6;   �� *	ActType+## [  $ PropertyChanged=��� 5X       �@��TextAlignment$ Center=�6>   5Y      5[      	  5\      $ 90 6%   $ 
Saldo (ME)��60   # [ 6D   -   5        saldoME��  . ! 5\   �   �� *	SaldoME+$ PropertyChanged=�" 5]      �� 5^      " ��6    .�5_      ��  � �� 6;   �� *	ActType+## [  $ PropertyChanged=��� 5`       �@��TextAlignment$ Center=�6>   5a      5c      	  5d      $ 90 6%   $
 Tasa��60   # [ 6>   -   5        rate��  . ! 5d   w   �� *Rate+$ PropertyChanged=�" 5e      �� 5f      " ��6    .�5h      ��  �@��TextAlignment$ Center=�6>   5i      5k      	  5l      $ 90 6%   $ 
Diferencia��60   # [ 6D   -   5        
diferencia��  . ! 5l   �   �� *
Diferencia+$ PropertyChanged=�" 5m      �� 5n      " ��6    .�5p      ��  �@��TextAlignment$ Center=�6>   5q      5s      5u      �� 5v   
   -   5        $ ��Name$$ btnEjecutar��5v      $��Ejecutar��6&   $
��Left=�69   $��
78,372,0,0q�6T   $	��Top=�6h   $��94��6�   $��3q�6�   6�   �� 5w   
   -   5        $$ btnCancelar��5w      $��Cancelar��6&   $
��Left=�69   $��195,372,0,0q�6T   $	��Top=�6i   $��94��6�   $��3q�6�   
�������
�������6�   �� 5x   
   -   5        % ��Name$% 	imgReturn��5x   p   $��003-anterior-2.png��6R   & � Cursor$
& Hand��6�   $y�Visible=�6�   ' J� RenderTransformOrigin$' 1.591,0.437&�6�   $��40��6�   $��17,372,0,15.667q�6�   $
��Left=�6�   �� 5y   
   -   5        ( ��Name$( lblFechaEjecucion��5y      $
��Left=�6/   $��	17,10,0,0q�6J   $
��Wrap=�6]   $��Fecha Ejecucion��6q   $
��Bold"�6�   $	��Top=�6�   �� 5z   
   -   5        $( lblFechaEjecucionValue��5z      $
��Left=�64   $��
123,10,0,0q�6O   $
��Wrap=�6c   $�� ��6w   $��Normal"�6   $	��Top=�6�   �� 5{   
   $
��Left=�6   $��8��6/   $��	18,26,0,0q�6:   $	��Top=�6M   $	��868��6e   $' 0.5,0.5&�6q   z�5|      V� 5}      .~�5~      �� �� 5      �� 5�      ) �� Angle$) -0.146Q�6&   T� 5�      5�      5�      �� 5�   
   -   5        $( lblMonedaSocioNegocio��5�      $
��Left=�63   $��
609,10,0,0q�6N   $
��Wrap=�6b   $��Moneda��6v   $
��Bold"�6�   $	��Top=�6�   �� 5�   
   -   5        * ��Name$* 	txtMoneda��5�      + �� 
IsReadOnly+ . $��1q�67   
�������$
��Left=�6c   $��23��6~   $��	674,5,0,0q�6�   , �� TextWrapping$
, Wrap=�6�   $	��Top=�6�   $	��145��6�   .��6�    5�      ��%^   '��       �� 5�      " ��6   .�5�      ��  �@��CornerRadius$ 3��65   5�      5�      .��6!   5�      �� 5�   
   -   5        $( lblInfoDetallada��5�      $��	Underline{�6.   $��14(�6J   $
��Left=�6X   $��	17,50,0,0q�6s   $
��Wrap=�6�   $&�� Info detallada sobre operaciones��6�   $
��Bold"�6�   $	��Top=�6�   �� 5�   
   -   5        $( lblReferencia1_SI��5�      $
��Left=�6/   $��	17,85,0,0q�6J   $
��Wrap=�6]   $��Referencia 1��6q   $	��Top=�6�   �� 5�   
   -   5        $* txtReferencia1_SI��5�      $��1q�6-   
�������$
��Left=�6�   $��23��6�   $��
17,106,0,0q�6�   $
, Wrap=�6�   $	��Top=�6�   $��98��6�   .��6    5�      ��%^   '��       �� 5�      " ��6   .�5�      ��  �@��CornerRadius$ 3��65   5�      5�      .��6!   5�      �� 5�   
   -   5        $( lblReferencia2_SI��5�      $
��Left=�6/   $��
137,85,0,0q�6J   $
��Wrap=�6^   $��Referencia 2��6r   $	��Top=�6�   �� 5�   
   -   5        $* txtReferencia2_SI��5�      $��1q�6-   
�������$
��Left=�6�   $��23��6�   $��137,106,0,0q�6�   $
, Wrap=�6�   $	��Top=�6�   $��98��6�   .��6   5�      ��%^   '��       �� 5�      " ��6   .�5�      ��  �@��CornerRadius$ 3��65   5�      5�      .��6!   5�      �� 5�   
   -   5        $( lblComentarios_SI��5�      $
��Left=�6/   $��
259,85,0,0q�6J   $
��Wrap=�6^   $��Comentarios��6r   $	��Top=�6�   �� 5�   
   -   5        $* txtComentario_SI��5�      $��1q�6,   
�������$
��Left=�6�   $��23��6�   $��259,106,0,0q�6�   $
, Wrap=�6�   $	��Top=�6�   $	��260��6�   .��6   5�      ��%^   '��       �� 5�      " ��6   .�5�      ��  �@��CornerRadius$ 3��65   5�      5�      .��6!   5�      5�      5�      