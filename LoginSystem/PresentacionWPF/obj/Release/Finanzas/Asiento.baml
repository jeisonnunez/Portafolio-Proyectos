   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista      Vista.Asiento   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Vista        Vista.Document    Closing$  Window_Closing��   Loaded$ Window_Loaded�� � Title$ Asiento��$��548.333��$
��1219�� � WindowStartupLocation$ CenterScreen=� � 	Resources    TextBoxBaseControlTemplate �� 
TargetType ��Name �� CornerRadius ��Name	 �� Triggers
 P� Property P� Value �� Value �� 
TargetName �� Property��%  &	        �� " ��.R��� $ Bd��#��z��
���   �#��z��$ 10��._��� $ PART_ContentHost��	 P� 
 � {� .  . ��� # � ��$ Bd�� � ���� # � �� � ��P� 
 � ��$
 Auto��. ���  � ��$	 100��P� 
 � ��$
 Auto��. ���  � ��$ 20��.���� $
��Auto=�$
��Auto=�.��� $��Center=�$	��Top=�$��0,10,0,0q�.+��� $��Center=�$	��Top=�$	��491��$��0,0,-0.333,0q�.+�&   System.Windows.Controls.DataGrid  -     Name$ 	dgAsiento��$	��205��$��32,199,25.333,0q�$	��Top=�   AutoGenerateColumns .  "   VerticalScrollBarVisibility$
 Auto=�$   HorizontalScrollBarVisibility$ Visible=�   SelectionMode$ Single=�
�������$��1q�   SelectionUnit$ FullRow=�   CanUserDeleteRows .  
���   �$��Center=�$��Center=�   GridLinesVisibility$	 All=�   VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   CanUserResizeRows .    CanUserSortColumns .    CanUserReorderColumns . ���	#FFE5E5E5   	CellStyle ��  �� 
TargetType*  $System.Windows.Controls.DataGridCell"   �� Triggers P� 
 �@J�IsMouseOver . . ���  � �� �	#FF74C1FF.���  � ��$ 30����  � ��$ Center=���  � ��$ Center=���  �@��TextAlignment$ Center=���  � ��$ Center=�   RowStyle �� )  #System.Windows.Controls.DataGridRow"   P� 
 �@J�IsMouseOver . . ���  � ��
 �����  �� 	Resources  ! �� Color��%�   (��       * SystemColors.HighlightBrushKey+)(��      *$"SystemColors.HighlightTextBrushKey+)�� $! Transparent���� $! Black��   TextBoxStyle" �� Binding# �� Path$ �� Value  TextBoxStyleNotReadOnly  TextBlockStyle��%%  &	       &	 �     &	 �     �� " ��.���  � �� �	#FF74C1FF �� " �� $# 
DataSource�$ N.a���  �@��
IsReadOnly . ��  � ��
 ������� " ��.���  � �� �	#FF74C1FF�� " �� �� " �� $# 
DataSource�$ N.a���  � ��
 �����%   Columns% 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn&   Header$& Cuenta de Mayor/Codigo SN��'   Width5  /System.Windows.Controls.DataGridLengthConverter$
' auto -   	shortname��(   CellEditingTemplate( �� .R��� $��bd��$��1q�
�������$ 3��._�]� $��dp��$��1��$��1��$��Stretch=�$��Stretch=�.+��� $��imgShortName��-   $��Right=�$��lupa.png��$��20��$y�Visible=�) � Cursor$
) Hand���� * ��Name$* txtShortName��-   $��12(�$��Stretch=�
���   �#��[ 
�������$��0q�$
��auto������ $# 	ShortName�+ �� UpdateSourceTrigger$+ PropertyChanged=�,   CellTemplate, �� .R��� $��txtShortName��
���   �#��[ ���� $# 	ShortName�  $& Cuenta de Mayor/Nombre SN��$
' auto -   name��( �� .R��� $��txtAcctName��
���   �#��[ ���	#FFE5E5E5- �� 
IsReadOnly- . ���� $# AcctName�$+ PropertyChanged=�, �� .R��� $��txtAcctName��
���   ����	#FFE5E5E5#��[ ���� $# AcctName�  $& Cuenta Asociada��$
' auto -   account��( �� .R��� $��bd��$��1q�
�������$ 3��._�]� $��dp��$��1��$��1��$��Stretch=�$��Stretch=�.+��� $��
imgAccount��-   $��Right=�$��lupa.png��$��20��$y�Visible=�$
) Hand���� $* 
txtAccount��$��12(�$��Stretch=�
���   �#��[ 
�������$��0q�$
��auto������ $# Account�$+ PropertyChanged=�, �� .R��� $��
txtAccount��
���   �#��[ ���� $# Account�  $& Debito (ME)��$
' auto -   debitome��( �� .R��� $��
txtFCDebit��-	   
���   �#��[ ���� $# FCDebit�$+ PropertyChanged=�, �� .R��� $��
txtFCDebit��
���   �#��[ ���� $# FCDebit�  $& Credito (ME)��$
' auto -
   creditme��( �� .R��� $��txtFCCredit��-   
���   �#��[ ���� $# FCCredit�$+ PropertyChanged=�, �� .R��� $��txtFCCredit��
���   �#��[ ���� $# FCCredit�  $&   Debito��$
' auto -   	debit��( �� .R��� $��txtDebit��-   
���   �#��[ ���� $# Debit�$+ PropertyChanged=�, �� .R��� $��txtDebit��
���   �#��[ ���� $# Debit�  $& 	  Credito��$
' auto -   
credit��( �� .R��� $��	txtCredit��-   
���   �#��[ ���� $# Credit�$+ PropertyChanged=�, �� .R��� $��	txtCredit��
���   �#��[ ���� $# Credit�  $& Debito (MS)��$
' auto -   	debitosys��( �� .R��� $��	txtSysDeb��
���   �- . ���	#FFE5E5E5#��[ ���� $# SYSDeb�$+ PropertyChanged=�, �� .R��� $��	txtSysDeb��
���   ����	#FFE5E5E5#��[ ���� $# SYSDeb�  $& Credito (MS)��$
' auto -   
creditosys��( �� .R��� $��
txtSysCred��
���   �- . #��[ ���	#FFE5E5E5���� $# SYSCred�$+ PropertyChanged=�, �� .R��� $��
txtSysCred��
���   ����	#FFE5E5E5#��[ ���� $# SYSCred�  $& 
Comentario��$
' auto -   linememo��( �� .R��� $��txtLineMemo��-   
���   �#��[ ���� $# LineMemo�$+ PropertyChanged=�, �� .R��� $��txtLineMemo��
���   ����� $# LineMemo��� $��Center=�. �� Orientation$. 
Horizontal=�.+�� ���� / �� ElementName$/ 	shortname��$# ActualWidth�.+��� $��Center=�0 �� TextAlignment$0 Right=�$��Right=�� ���� $
/ name��$# ActualWidth�.+��� $��Center=�$0 Right=�$��Right=�� ���� $/ account��$# ActualWidth�.+��� $��Center=�$0 Right=�$��Right=�� ���� $/ debitome��$# ActualWidth�.+��� -   $��
totDebitME��$��Center=�$0 Right=�$��Right=�� ���� $/ creditme��$# ActualWidth�.+��� -   $��totCreditME��$��Center=�$0 Right=�$��Right=�� ���� $/ debit��$# ActualWidth�.+��� -   $��totDebit��$��Center=�$0 Right=�$��Right=�� ���� $/ credit��$# ActualWidth�.+��� -   $��	totCredit��$��Center=�$0 Right=�$��Right=�� ���� $/ 	debitosys��$# ActualWidth�.+��� -   $��totDebitoSys��$��Center=�$0 Right=�$��Right=�� ���� $/ 
creditosys��$# ActualWidth�.+��� -   $��totCreditoSys��$��Center=�$0 Right=�$��Right=�� ���� $/ linememo��$# ActualWidth�.+��� $��Center=�$0 Right=��� -   1 ��Name$1 btnOk��$��Crear��$
��Left=�$��
39,459,0,0q�$	��Top=�$��85��$��3q�$��16(��� -   $1 btnCancelar��$��Cancelar��$
��Left=�$��151,459,0,0q�$	��Top=�$��89��$��3q�$��16(�
�������
��������� -   2 ��Name$2 	lblNumero��$
��Left=�$��	33,64,0,0q�$
��Wrap=�$��Numero��$	��Top=�$
��Bold"��� -   $* 	txtNumero��$��1q�
�������$
��Left=�$��27��$��	33,80,0,0q�3 �� TextWrapping$
3 Wrap=�$	��Top=�$��71��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -   $2 lblFechaContabilizacion��$
��Left=�$��
131,64,0,0q�$
��Wrap=�$��Fecha Contabilizacion��$	��Top=�$
��Bold"��� -   $2 lblFechaVencimiento��$
��Bold"�$
��Left=�$��
299,64,0,0q�$
��Wrap=�$��Fecha Vencimiento��$	��Top=��� -    $2 lblFechaDocumento��$
��Bold"�$
��Left=�$��
457,64,0,0q�$
��Wrap=�$��Fecha Documento��$	��Top=�(  "System.Windows.Controls.DatePicker  -!   $��dpFechaContabilizacion��$
��Left=�$��
133,82,0,0q�$	��Top=�$	��121��$��25�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��  -"   $��dpFechaVencimiento��$
��Left=�$��
301,82,0,0q�$	��Top=�$	��123�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��  -#   $��dpFechaDocumento��$
��Left=�$��
459,82,0,0q�$	��Top=�$	��131�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3���� -$   $2 lblComentario��$
��Bold"�$
��Left=�$��
647,64,0,0q�$
��Wrap=�$��
Comentario��$	��Top=��� -%   $* txtComentario��$��1q�
�������$
��Left=�$��28��$��
647,80,0,0q�$
3 Wrap=�$	��Top=�$	��323��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -&   $2 	lblOrigen��$
��Bold"�$
��Left=�$��
33,124,0,0q�$
��Wrap=�$��Origen��$	��Top=��� -'   $* 	txtOrigen��$��1q�
�������$
��Left=�$��23��$��
33,144,0,0q�$
3 Wrap=�$	��Top=�$��71��- . .�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -(   $2 lblNroOrigen��$
��Bold"�$
��Left=�$��119,124,0,0q�$
��Wrap=�$��Numero de Origen��$	��Top=��� -)   $* txtNroOrigen��$��1q�
�������$
��Left=�$��23��$��119,144,0,0q�$
3 Wrap=�$	��Top=�$	��105��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -*   $2 lblReferencia1��$
��Bold"�$
��Left=�$��241,124,0,0q�$
��Wrap=�$��Referencia 1��$	��Top=��� -+   $* txtReferencia1��$��1q�
�������$
��Left=�$��23��$��241,144,0,0q�$
3 Wrap=�$	��Top=�$��87��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -,   $2 lblReferencia2��$
��Bold"�$
��Left=�$��351,124,0,0q�$
��Wrap=�$��Referencia 2��$	��Top=��� --   $* txtReferencia2��$��1q�
�������$
��Left=�$��23��$��351,144,0,0q�$
3 Wrap=�$	��Top=�$��93��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -.   4 ��Name$4 imgleft��$
) Hand��$��003-anterior-2.png��$
��Left=�$��28��$��
483,10,0,0q�$	��Top=�$��31���� -/   $4 imgRight��$
) Hand��$��004-proximo.png��$
��Left=�$��28��$��
523,10,0,0q�$	��Top=�$��31��5 J� RenderTransformOrigin$5 1.296,0.488&��� -0   $4 imgCrear��$
) Hand��$��001-texto.png��$
��Left=�$��28��$��
370,10,0,0q�$	��Top=�$��31��$5 1.296,0.488&��� -1   $4 	imgBuscar��$
) Hand��$��002-encontrar.png��$
��Left=�$��28��$��
409,10,0,0q�$	��Top=�$��31��$5 1.296,0.488&��� -2   $4 	imgInicio��$
) Hand��$��001-anterior.png��$
��Left=�$��28��$��
447,10,0,0q�$	��Top=�$��31��$5 1.296,0.488&��� -3   $4 imgFin��$
) Hand��$��002-anterior-1.png��$
��Left=�$��28��$��
559,10,0,0q�$	��Top=�$��31��$5 1.296,0.488&�