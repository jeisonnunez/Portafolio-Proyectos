   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  %    Vista.TablaDiferenciaTipoCambio   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Vista        Vista.Converter    Closing$  Window_Closing��   Loaded$ Converter_Loaded�� � Title$ TablaDiferenciaTipoCambio��$	��450��$��902.231�� � 	Resources     Vista.ConverterClosePeriod   ConverterClosePeriod��%   &	          .��� .+�&   System.Windows.Controls.DataGrid  -     Name$ dgDiferenciaTipoCambio��$��Normal"�$��1q�   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 
�������$
��Left=�$	��212��$��
17,144,0,0q�$	��Top=�$	��844��   AutoGenerateColumns .     CanUserDeleteRows .     CanUserSortColumns .  	   SelectionMode$	 Single=�$
   HorizontalScrollBarVisibility$

 Auto=�"   VerticalScrollBarVisibility$
 Auto=�$��Center=�$��Center=�   GridLinesVisibility$	 All=�   VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   SelectionUnit$ FullRow=����	#FFE5E5E5   	CellStyle ��  �� 
TargetType*  $System.Windows.Controls.DataGridCell"  .���  �� Property � �� �� Value$ 30����  � ��$ Center=���  � ��$ Center=���  �@��TextAlignment$ Center=���  � ��$ Center=���  � �� �	#FFE5E5E5   RowStyle �� )  #System.Windows.Controls.DataGridRow"   �� 	Resources  �� Color��%�   (��       * SystemColors.HighlightBrushKey+)(��      *$"SystemColors.HighlightTextBrushKey+)�� $ 	#FFE5E5E5���� $ Black��   Columns 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn   Width$ 30 -   Seleccionado��  HeaderStyle   HeaderStyle# [    Header �� -    ��Name$ chkSelectAll��   CellTemplate �� .R��� $ seleccionado��-   $��Center=� d� 	IsChecked �� *Seleccionado+ �� UpdateSourceTrigger$ PropertyChanged=�   CellEditingTemplate �� .R��� $ seleccionado��-   $��Center=� �� *Seleccionado+$ PropertyChanged=�0	  *System.Windows.Controls.DataGridTextColumn	  $	 110 $ Cuenta Asociada��-   cuentaAsociada��# [     
IsReadOnly  . 1
  +System.Windows.Controls.DataGridBoundColumn! 
  Binding! �� *	ShortName+$ PropertyChanged=�" 
  ElementStyle" �� " ��.���  � �� �� *	ActType+# �� 	Converter## [  $ PropertyChanged=���  �@��TextAlignment$ Center=�	  $	 150 $ Cuenta de Mayor��-   cuentaMayor��# [   . ! �� *	Account+$ PropertyChanged=�" �� " ��.���  � �� �� *	ActType+## [  $ PropertyChanged=���  �@��TextAlignment$ Center=�	  $	 100 $ Cuenta /Nombre SN��# [ -   cuentaDescripcion��  . ! �� *
AcctName+$ PropertyChanged=�" �� " ��.���  � �� �� *	ActType+## [  $ PropertyChanged=���  �@��TextAlignment$ Center=�	  $ 80 $ Moneda��# [ -	   
moneda��  . ! �� *
FCCurrency+$ PropertyChanged=�" �� " ��.���  � �� �� *	ActType+## [  $ PropertyChanged=���  �@��TextAlignment$ Center=�	  $ 90 $ 
Saldo (ML)��-
   saldoML��# [   . ! �� *Saldo+$ PropertyChanged=�" �� " ��.���  � �� �� *	ActType+## [  $ PropertyChanged=���  �@��TextAlignment$ Center=�	  $ 90 $ 
Saldo (ME)��# [ -   saldoME��  . ! �� *	SaldoME+$ PropertyChanged=�" �� " ��.���  � �� �� *	ActType+## [  $ PropertyChanged=���  �@��TextAlignment$ Center=�	  $ 90 $
 Tasa��# [ -   rate��  . ! �� *Rate+$ PropertyChanged=�" �� " ��.���  �@��TextAlignment$ Center=�	  $ 90 $ 
Diferencia��# [ -   
diferencia��  . ! �� *
Diferencia+$ PropertyChanged=�" �� " ��.���  �@��TextAlignment$ Center=��� -   $ ��Name$$ btnEjecutar��$��Ejecutar��$
��Left=�$��
78,372,0,0q�$	��Top=�$��94��$��3q��� -   $$ btnCancelar��$��Cancelar��$
��Left=�$��195,372,0,0q�$	��Top=�$��94��$��3q�
�������
��������� -   % ��Name$% 	imgReturn��$��003-anterior-2.png��& � Cursor$
& Hand��$y�Visible=�' J� RenderTransformOrigin$' 1.591,0.437&�$��40��$��17,372,0,15.667q�$
��Left=��� -   ( ��Name$( lblFechaEjecucion��$
��Left=�$��	17,10,0,0q�$
��Wrap=�$��Fecha Ejecucion��$
��Bold"�$	��Top=��� -   $( lblFechaEjecucionValue��$
��Left=�$��
123,10,0,0q�$
��Wrap=�$�� ��$��Normal"�$	��Top=��� $
��Left=�$��8��$��	18,26,0,0q�$	��Top=�$	��868��$' 0.5,0.5&�z�V� .~��� �� �� ) �� Angle$) -0.146Q�T� �� -   $( lblMonedaSocioNegocio��$
��Left=�$��
609,10,0,0q�$
��Wrap=�$��Moneda��$
��Bold"�$	��Top=��� -   * ��Name$* 	txtMoneda��+ �� 
IsReadOnly+ . $��1q�
�������$
��Left=�$��23��$��	674,5,0,0q�, �� TextWrapping$
, Wrap=�$	��Top=�$	��145��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -   $( lblInfoDetallada��$��	Underline{�$��14(�$
��Left=�$��	17,50,0,0q�$
��Wrap=�$&�� Info detallada sobre operaciones��$
��Bold"�$	��Top=��� -   $( lblReferencia1_SI��$
��Left=�$��	17,85,0,0q�$
��Wrap=�$��Referencia 1��$	��Top=��� -   $* txtReferencia1_SI��$��1q�
�������$
��Left=�$��23��$��
17,106,0,0q�$
, Wrap=�$	��Top=�$��98��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -   $( lblReferencia2_SI��$
��Left=�$��
137,85,0,0q�$
��Wrap=�$��Referencia 2��$	��Top=��� -   $* txtReferencia2_SI��$��1q�
�������$
��Left=�$��23��$��137,106,0,0q�$
, Wrap=�$	��Top=�$��98��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -   $( lblComentarios_SI��$
��Left=�$��
259,85,0,0q�$
��Wrap=�$��Comentarios��$	��Top=��� -   $* txtComentario_SI��$��1q�
�������$
��Left=�$��23��$��259,106,0,0q�$
, Wrap=�$	��Top=�$	��260��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.��