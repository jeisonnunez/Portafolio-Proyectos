   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  !    Vista.ReconciliacionInterna   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Vista        Vista.Converter    Closing$  Window_Closing��   Loaded$ Converter_Loaded�� � Title$ ReconciliacionInterna��$��479.245�� � WindowStartupLocation$ CenterScreen=�$��1070.405��.���� $
��Auto=�$
��Auto=�.��� $��Center=�$	��Top=�$
��1058��.+��� -    ��Name$ lblSN��$
��Bold"�$
��Left=�$��	51,13,0,0q�$
��Wrap=�$��Socio Negocio��$	��Top=��� -   $ 	lblMoneda��$
��Bold"�$
��Left=�$��
749,16,0,0q�$
��Wrap=�$��Moneda��$	��Top=��� -    ��Name$ cbMoneda��   ComboBoxStyle#��[  $��23��
������� �� 
IsReadOnly . 
���   �$
��Left=�$��
878,12,0,0q�$	��Top=�$	��129���� -   $ lblFecha��$
��Bold"�$
��Left=�$��
749,57,0,0q�$
��Wrap=�$��Fecha Reconciliacion��$	��Top=�&   System.Windows.Controls.DataGrid  -     Name$ dgReconciliacion��$��Normal"�$��1q�   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 
�������$
��Left=�$	��208��$��
51,144,0,0q�$	��Top=�$	��956��	   AutoGenerateColumns	 .  
   CanUserDeleteRows
 .     CanUserSortColumns .     SelectionMode$ Single=�$   HorizontalScrollBarVisibility$
 Auto=�"   VerticalScrollBarVisibility$
 Auto=�$��Center=�$��Center=�   GridLinesVisibility$	 All=�   VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   SelectionUnit$ FullRow=����	#FFE5E5E5   	CellStyle ��  �� 
TargetType*  $System.Windows.Controls.DataGridCell"  .���  �� Property � �� �� Value$ 30����  � ��$ Stretch=���  � ��$ Stretch=���  � ��$ Center=���  � ��$ Center=���  �@��TextAlignment$ Center=���  � ��$ Center=�   RowStyle �� )  #System.Windows.Controls.DataGridRow"   �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ���  � ��
 �������  � ��$ Normal"� �� 	Resources  �� Color��%�   (��       * SystemColors.HighlightBrushKey+)(��      *$"SystemColors.HighlightTextBrushKey+)�� $ Transparent���� $ Black�� � 	Resources   TextBoxStyle  TextBoxStyleNotReadOnly��%�   &	       &	 E     �� " ��.���  � �� �	#FF74C1FF��  � ��$ Normal"��� " ��.���  � �� �	#FF74C1FF   Columns 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn   Width$ *     Header$  Seleccionado��-   Seleccionado��  HeaderStyle!   HeaderStyle#! [ "   CellTemplate" �� .R�]� # ]�Name$# dpSeleccionado��.+��� $ ��Name$$ seleccionado��-   $��Center=�% d� 	IsChecked% �� *Seleccionado+& �� UpdateSourceTrigger$& PropertyChanged=�'   CellEditingTemplate' �� .R�]� $# dpSeleccionado��.+��� $$ seleccionado��-   $��Center=�% �� *Seleccionado+$& PropertyChanged=�  $  Nro Operacion��$
 auto -	   nroOperacion��#! [ (   
IsReadOnly( . " �� .R�]� $��	dpTransId��$��1��$��1�����	#FFE5E5E5$��Stretch=�$��Stretch=�.+��� $��
imgTransId��-
   $
��Left=�$��004-proximo.png��$��20��$��0,0,0,-0.333q�$y�Visible=�) � Cursor$
) Hand��$��Stretch=�$��Stretch=��� $ 
txtTransId�����	#FFE5E5E5$��Stretch=�$��Stretch=�$��0,0,0,-0.333q�$��95��* �� TextAlignment$* Center=����� + �� Path$+ TransId�$& PropertyChanged=�' �� .R�]� $��	dpTransId��$��1��$��1�����	#FFE5E5E5$��Stretch=�$��Stretch=�.+��� $��
imgTransId��-   $
��Left=�$��004-proximo.png��$��20��$��0,0,0,-0.333q�$y�Visible=�$
) Hand��$��Stretch=�$��Stretch=��� , ��Name$, 
txtTransId�����	#FFE5E5E5- �� 
IsReadOnly- . $��0,0,0,-0.333q�$��95��$��Stretch=�$��Stretch=�. �� TextAlignment$. Center=����� $+ TransId�$& PropertyChanged=�  $  Origen��$ * -   nroDocumento��( . #! [ " �� .R�]� $��dpTransType��$��1��$��1��$��Stretch=�$��Stretch=����	#FFE5E5E5.+��� $��imgTransType��-   $
��Left=�$��004-proximo.png��$��20��$��0,0,0,-0.333q�$y�Visible=�$
) Hand��$��Stretch=�$��Stretch=��� $ txtTransType�����	#FFE5E5E5$* Center=�$��Stretch=�$��Stretch=�$��0,0,0,-0.333q�$��95������ $+ 	TransType�$& PropertyChanged=�' �� .R�]� $��dpTransType��$��1��$��1�����	#FFE5E5E5$��Stretch=�$��Stretch=�.+��� $��imgTransType��-   $
��Left=�$��004-proximo.png��$��20��$��0,0,0,-0.333q�$y�Visible=�$
) Hand��$��Stretch=�$��Stretch=��� $, txtTransType�����	#FFE5E5E5$. Center=�- . $��0,0,0,-0.333q�$��95��$��Stretch=�$��Stretch=����� $+ 	TransType�$& PropertyChanged=�  $  
Nro Origen��$ * -   	nroOrigen��( . #! [ " �� .R�]� $��	dpBaseRef��$��1��$��1�����	#FFE5E5E5$��Stretch=�$��Stretch=�.+��� $ 
txtBaseRef�����	#FFE5E5E5$* Center=�$��Stretch=�$��Stretch=�$��0,0,0,-0.333q�$��95������ $+ BaseRef�$& PropertyChanged=�' �� .R�]� $��	dpBaseRef�����	#FFE5E5E5$��1��$��1��$��Stretch=�$��Stretch=�.+��� $, 
txtBaseRef��$. Center=�- . $��0,0,0,-0.333q�$��95��$��Stretch=�$��Stretch=�$��Stretch=�$��Stretch=�#��[ ���� $+ BaseRef�$& PropertyChanged=�  $  Fecha Contabilizacion��$ * -   refDate��( . #! [ " �� .R�]� $��	dpRefDate�����	#FFE5E5E5$��1��$��1��$��Stretch=�$��Stretch=�.+��� $ 
txtRefDate�����	#FFE5E5E5$* Center=�$��Stretch=�$��Stretch=�$��0,0,0,-0.333q�$��95������ $+ RefDate�$& PropertyChanged=�' �� .R�]� $��	dpRefDate�����	#FFE5E5E5$��1��$��1��$��Stretch=�$��Stretch=�.+��� $, 
txtRefDate�����	#FFE5E5E5$��Stretch=�$��Stretch=�$. Center=�- . $��0,0,0,-0.333q�$��95��$��Stretch=�$��Stretch=����� $+ RefDate�$& PropertyChanged=�  $  Importe��$ * -   importe��( . #! [ " �� .R�]� $��	dpImporte�����	#FFE5E5E5$��1��$��1��$��Stretch=�$��Stretch=�.+��� $ 
txtImporte�����	#FFE5E5E5$* Center=�$��Stretch=�$��Stretch=�$��0,0,0,-0.333q�$��95������ $+ Importe�$& PropertyChanged=�' �� .R�]� $��	dpImporte�����	#FFE5E5E5$��1��$��1��$��Stretch=�$��Stretch=�.+��� $, 
txtImporte��$. Center=�- . $��0,0,0,-0.333q�$��95��$��Stretch=�$��Stretch=����� $+ Importe�$& PropertyChanged=�  $  Saldo Vencido��$ * -   saldoVencido��( . #! [ " �� .R�]� $��dpSaldoVencido�����	#FFE5E5E5$��1��$��1��$��Stretch=�$��Stretch=�.+��� $ txtSaldoVencido�����	#FFE5E5E5$* Center=�$��Stretch=�$��Stretch=�$��0,0,0,-0.333q�$��95������ $+ SaldoVencido�$& PropertyChanged=�' �� .R�]� $��dpSaldoVencido�����	#FFE5E5E5$��1��$��1��$��Stretch=�$��Stretch=�.+��� $, txtSaldoVencido��$. Center=�- . $��0,0,0,-0.333q�$��95��$��Stretch=�$��Stretch=����� $+ SaldoVencido�$& PropertyChanged=�  $  Importe Reconciliar��$ * -   importeReconciliar��#! [ " �� .R�]� $��dpImporteReconciliar��
�������$��1��$��1��$��Stretch=�$��Stretch=�.+��� $ txtImporteReconciliar��
�������/ �� Padding$/ 0q�$* Center=�$��Stretch=�$��Stretch=�$��0,0,0,-0.333q�$��95������ $+ ImporteReconciliar�$& PropertyChanged=�' �� .R�]� $��dpImporteReconciliar��
�������$��1��$��1��$��Stretch=�$��Stretch=�.+��� $, txtImporteReconciliar��-   $. Center=�$��0,0,0,-0.333q�$��95��$��Stretch=�$��Stretch=�$��Stretch=�$��Stretch=�#��[ ���� $+ ImporteReconciliar�$& PropertyChanged=�  $  Info Detallada��$ * -   lineMemo��#! [ " �� .R�]� $��
dpLineMemo�����	#FFE5E5E5$��1��$��1��$��Stretch=�$��Stretch=�.+��� $ txtLineMemo�����	#FFE5E5E5$* Center=�$��Stretch=�$��Stretch=�$��0,0,0,-0.333q�$��95������ $+ LineMemo�$& PropertyChanged=�' �� .R�]� $��
dpLineMemo�����	#FFE5E5E5$��1��$��1��$��Stretch=�$��Stretch=�.+��� $, txtLineMemo��$. Center=�$��0,0,0,-0.333q�$��95��$��Stretch=�$��Stretch=����� $+ LineMemo�$& PropertyChanged=�0  *System.Windows.Controls.DataGridTextColumn  $ * 0   
Visibility$0 Hidden=�$  Cuenta��#! [ -   account��( . 1	  +System.Windows.Controls.DataGridBoundColumn1 	  Binding1 �� *	Account+$& PropertyChanged=�2 	  ElementStyle2 �� " ��.���  �@��TextAlignment$ Center=�  $ * $0 Hidden=�$  LineId��#! [ -   
lineId��( . 1 �� *	Line_ID+$& PropertyChanged=�2 �� " ��.���  �@��TextAlignment$ Center=��� -   3 ��Name$3 btnReconciliar��$��Reconciliar��$
��Left=�$��58,395,0,-0.333q�$	��Top=�$��95��$��3q��� -   $3 btnCancelar��$��Cancelar��$
��Left=�$��170,395,0,-0.333q�$	��Top=�$��94��$��3q�
�������
��������� -   4 ��Name$
4 bdSN��$��1q�
�������5 �� CornerRadius$5 3��$��
152,10,0,0q�
�������$
��Left=�$	��158��$��25��$	��Top=�._�]� -   $
# dpSN��$��1��$��1��$��4.667,0.667,4.667,0.5q�
�������.+��� -   6 ��Name$6 imgSN��$��Right=�$��lupa.png��$��20��$��0,0,0,-0.333q�$y�Hidden=�$
) Hand���� -   $, txtSN��$��12(�$��Normal"�
�������$��0q�$��0,0,0,0.333q�$	��123��
���   �$	��Top=�$��Stretch=�$��Stretch=�(
  "System.Windows.Controls.DatePicker
  -   7 
 Name$7 dpReconciliacion��$
��Left=�$��
878,52,0,0q�$	��Top=�$	��129��$��25��$��1q� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3���� -   $, txtTotalReconciliacion��$��1q�- . $
��Left=�$��23��$��848,395,0,0q�8 �� TextWrapping$
8 Wrap=�$	��Top=�$	��154��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -    $ lblTotalReconciliacion��$
��Bold"�$
��Left=�$��690,399,0,0q�$
��Wrap=�$��Resultado Reconciliacion��$	��Top=�