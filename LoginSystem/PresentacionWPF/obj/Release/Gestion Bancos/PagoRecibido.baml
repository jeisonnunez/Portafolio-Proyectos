   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista      Vista.PagoRecibido   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Vista        Vista.Document    Closing$  Window_Closing��   Loaded$ Document_Loaded�� � Title$ Pago Recibido��$	��699��$��853.5�� � WindowStartupLocation$ CenterScreen=� � ContextMenu �� .@�m� -   $��RegistroDiario��$��Registro en el Diario�� m� Icon �� $��001-division.png��.���� $
��Auto=�$
��Auto=�.��� $��Center=�$	��Top=�.+��� -    ��Name$ imgleft�� � Cursor$
 Hand��$��003-anterior-2.png��$
��Left=�$��28��$��
433,10,0,0q�$	��Top=�$��31���� -   $ imgRight��$
 Hand��$��004-proximo.png��$
��Left=�$��28��$��
473,10,0,0q�$	��Top=�$��31�� J� RenderTransformOrigin$ 1.296,0.488&��� -   $ imgCrear��$
 Hand��$��001-texto.png��$
��Left=�$��28��$��
320,10,0,0q�$	��Top=�$��31��$ 1.296,0.488&��� -   $ 	imgBuscar��$
 Hand��$��002-encontrar.png��$
��Left=�$��28��$��
359,10,0,0q�$	��Top=�$��31��$ 1.296,0.488&��� -   $ 	imgInicio��$
 Hand��$��001-anterior.png��$
��Left=�$��28��$��
397,10,0,0q�$	��Top=�$��31��$ 1.296,0.488&��� -   $ imgFin��$
 Hand��$��002-anterior-1.png��$
��Left=�$��28��$��
509,10,0,0q�$	��Top=�$��31��$ 1.296,0.488&��� -   	 ��Name$	 lblNro��$
��Bold"�$
��Left=�$��
545,41,0,0q�$
��Wrap=�$	��Nro��$	��Top=��� -	   
 ��Name$
 txtNro�� �� 
IsReadOnly . ���	#FFE5E5E5$��1q�$
��Left=�$��25��$��
678,38,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��124��.�� � 	Resources  �� 
TargetType �� Property �� Value��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -
   $	 lblContabilizacion��$
��Bold"�$
��Left=�$��
547,75,0,0q�$
��Wrap=�$��Fecha Contabilizacion��$	��Top=�(  "System.Windows.Controls.DatePicker  -     Name$ dpContabilizacion��$
��Left=�$��
678,70,0,0q�$	��Top=�$	��124��$��1q� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3���� -   $	 lblVencimiento��$
��Bold"�$
��Left=�$��547,109,0,0q�$
��Wrap=�$��Fecha Vencimiento��$	��Top=�  -   $ dpVencimiento��$
��Left=�$��678,104,0,0q�$	��Top=�$	��124��$��23�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3���� -   $	 lblDocumento��$
��Bold"�$
��Left=�$��547,139,0,0q�$
��Wrap=�$��Fecha Documento��$	��Top=�  -   $ dpDocumento��$
��Left=�$��678,134,0,0q�$	��Top=�$	��124��$��23�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3���� -   $	 lblReferencia��$
��Bold"�$
��Left=�$��547,179,0,0q�$
��Wrap=�$��
Referencia��$	��Top=��� -   $
 txtReferencia��$��1q�$
��Left=�$��23��$��678,172,0,0q�$
 Wrap=�$	��Top=�$	��124��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -   $	 lblNroOperacion��$
��Bold"�$
��Left=�$��547,211,0,0q�$
��Wrap=�$��Numero Operacion��$	��Top=��� -   $
 txtNroOperacion�� . ���	#FFE5E5E5$��1q�$
��Left=�$��23��$��678,204,0,0q�$
 Wrap=�$	��Top=�$	��124��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -   $	 lblProveedor��$
��Bold"�$
��Left=�$��	27,43,0,0q�$
��Wrap=�$��Codigo��$	��Top=��� -   $��bdProveedor��$��1q�
������� �� CornerRadius$ 3��$��	94,38,0,0q�
�������$
��Left=�$	��147��$��25��$	��Top=�._�]� -   $��dpProveedor��$��1��$��1��$��4.667,0.667,4.667,0.5q�
�������.+��� -   $��imgProveedor��$��Right=�$��lupa.png��$��20��$��0,0,0,-0.333q�$y�Hidden=�$
 Hand���� -   $
 txtProveedor��$��12(�$��Normal"�
�������$��0q�$��0,0,0,0.333q�$	��130��
���   �$	��Top=�$��Stretch=�$��Stretch=��� -   $	 	lblNombre��$
��Bold"�$
��Left=�$��	26,79,0,0q�$
��Wrap=�$��Nombre��$	��Top=��� -   $
 	txtNombre��$��1q�$
��Left=�$��23��$��	94,72,0,0q�$
 Wrap=�$	��Top=�$	��147��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.��&   System.Windows.Controls.DataGrid  -     Name$ dgPagoRecibido��$	��202��$��
31,247,0,0q�$	��Top=�$	��771��$��Normal"�$��1q�   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 
�������$
��Left=�   AutoGenerateColumns .     CanUserDeleteRows .     CanUserSortColumns .    SelectionMode$ Single=�$   HorizontalScrollBarVisibility$
 Auto=�"   VerticalScrollBarVisibility$
 Auto=�$��Center=�$��Center=�   GridLinesVisibility$	 All=�   VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   SelectionUnit$ FullRow=����	#FFE5E5E5   	CellStyle �� *  $System.Windows.Controls.DataGridCell"  .���  � ��$ 30����  � ��$ Stretch=���  � ��$ Stretch=���  � ��$ Center=���  � ��$ Center=���  �@��TextAlignment$ Center=���  � ��$ Center=�    RowStyle  �� )  #System.Windows.Controls.DataGridRow"  ! �� Triggers! P� " P� Property" �@J�IsMouseOver# P� Value# . . ���  � ��
 �������  � ��$ Normal"�$ �� 	Resources$ % �� Color��%�   (��       * SystemColors.HighlightBrushKey+)(��      *$"SystemColors.HighlightTextBrushKey+)�� $% Transparent���� $% Black��    TextBoxStyle  TextBoxStyleNotReadOnly��%�   &	        &	 E     �� " ��.���  � �� �	#FF74C1FF��  � ��$ Normal"��� " ��.���  � �� �	#FF74C1FF&   Columns& 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn'   Header$' Seleccionado��(   Width$
( auto -   seleccionado��)   CellTemplate) �� .R�]� * ]�Name$* 
dpCheckBox��.+��� $��seleccionado��-   $��Center=�$��Center=�+ d� 	IsChecked+ �� *Seleccionado+, �� UpdateSourceTrigger$, PropertyChanged=�-   CellEditingTemplate- �� .R�]� $* 
dpCheckBox��.+��� $��seleccionado��-   $��Center=�$��Center=�+ �� *Seleccionado+$, PropertyChanged=�  $' Nro Documento��$
( auto -   nroDocumento��.   
IsReadOnly. . ) �� .R�]� $��dp��$��1��$��1��$��Stretch=�$��Stretch=�.+��� $��imgDocumento��-    $
��Left=�$��004-proximo.png��$��20��$��0,0,0,-0.333q�$y�Visible=�$
 Hand��$��Stretch=�$��Stretch=��� $	 	txtDocNum��$��Stretch=�$��Stretch=�$��0,0,0,-0.333q�$��95������ / �� Path$/ DocNum�$, PropertyChanged=�- �� .R�]� $��dp��$��1��$��1��$��Stretch=�$��Stretch=�.+��� $��imgDocumento��-!   $
��Left=�$��004-proximo.png��$��20��$��0,0,0,-0.333q�$y�Visible=�$
 Hand��$��Stretch=�$��Stretch=��� $
 	txtDocNum�� . $��0,0,0,-0.333q�$��95��$��Stretch=�$��Stretch=����� $/ DocNum�$, PropertyChanged=�  $' Clase Documento��$
( auto -"   claseDocumento��. . - �� .R�]� $��1��$��1��$��Stretch=�$��Stretch=�.+��� $��
txtObjType��
���   � . ���	#FFE5E5E5#��[  ���� $/ ObjType�$, PropertyChanged=�) �� .R�]� $��1��$��1��$��Stretch=�$��Stretch=�.+��� $��
txtObjType��$��Normal"�
���   ����	#FFE5E5E5���� $/ ObjType�$, PropertyChanged=�  $' Fecha��-#   	fecha��$
( auto . . ) �� .R�]� $��1��$��1��$��Stretch=�$��Stretch=�.+��� $��dpFecha��
���   ����	#FFE5E5E5���� $/ DocDate�0 �� StringFormat$0 {0:dd/MM/yyyy}��$, PropertyChanged=�- �� .R�]� $��1��$��1��$��Stretch=�$��Stretch=�.+�  $��dpFecha��
���   ����	#FFE5E5E51   SelectedDate1 �� $/ DocDate�$0 {0:dd/MM/yyyy}��$, PropertyChanged=�  $' Total��$
( auto -$   	total��- �� .R�]� $��1��$��1��$��Stretch=�$��Stretch=�.+��� $��txtDocTotal��
���   �#��[   . ���	#FFE5E5E5���� $/ DocTotal�$, PropertyChanged=�) �� .R�]� $��1��$��1��$��Stretch=�$��Stretch=�.+��� $��txtDocTotal�����	#FFE5E5E5$��Normal"�
���   ����� $/ DocTotal�$, PropertyChanged=�  $' WImporte Retencion��$
( auto -%   WImporteRetencion��- �� .R�]� $��1��$��1��$��Stretch=�$��Stretch=�.+��� $��txtWTImporteRetencion��
���   �#��[  ���� $/ WTImporteRetencion�$, PropertyChanged=�) �� .R�]� $��1��$��1��$��Stretch=�$��Stretch=�.+��� $��txtWTImporteRetencion��$��Normal"�
���   ����� $/ WTImporteRetencion�$, PropertyChanged=�  $' Saldo Vencido��$
( auto -&   saldoVencido��. . - �� .R�]� $��1��$��1��$��Stretch=�$��Stretch=�.+��� $��txtSaldoVencido��
���   � . ���	#FFE5E5E5#��[  ���� $
/ Paid�$, PropertyChanged=�) �� .R�]� $��1��$��1��$��Stretch=�$��Stretch=�.+��� $��txtSaldoVencido��$��Normal"�
���   ����	#FFE5E5E5���� $
/ Paid�$, PropertyChanged=�  $' NroComprobante IVA��$
( auto -'   numeroComprobante��- �� .R�]� $��1��$��1��$��Stretch=�$��Stretch=�.+��� $��txtU_IDA_CompIVA��
���   �#��[  ���� $/ U_IDA_CompIVA�$, PropertyChanged=�) �� .R�]� $��1��$��1��$��Stretch=�$��Stretch=�.+��� $��txtU_IDA_CompIVA��$��Normal"�
���   ����� $/ U_IDA_CompIVA�$, PropertyChanged=�  $
( Auto $' Fecha Comprobante��-(   fechaComprobante��- �� .R�]� $��1��$��1��$��Stretch=�$��Stretch=�.+�  $��txtU_IDA_FechaComp��1 �� $/ U_IDA_FechaComp�$, PropertyChanged=�$0 {0:dd/MM/yyyy}�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��) �� .R�]� $��1��$��1��$��Stretch=�$��Stretch=�.+��� $��txtU_IDA_FechaComp������ $/ U_IDA_FechaComp�$, PropertyChanged=�$0 {0:dd/MM/yyyy}��  $' Monto Comprobante��$
( auto -)   montoComprobanteIVA��- �� .R�]� $��1��$��1��$��Stretch=�$��Stretch=�.+��� $��txtU_IDA_MontoCompIVA��
���   �#��[  ���� $/ U_IDA_MontoCompIVA�$, PropertyChanged=�) �� .R�]� $��1��$��1��$��Stretch=�$��Stretch=�.+��� $��txtU_IDA_MontoCompIVA��$��Normal"�
���   ����� $/ U_IDA_MontoCompIVA�$, PropertyChanged=�  $' NroComprobante ISLR��$
( auto -*   numeroComprobanteISLR��- �� .R�]� $��1��$��1��$��Stretch=�$��Stretch=�.+��� $��txtU_IDA_CompISLR��
���   �#��[  ���� $/ U_IDA_CompISLR�$, PropertyChanged=�) �� .R�]� $��1��$��1��$��Stretch=�$��Stretch=�.+��� $��txtU_IDA_CompISLR��$��Normal"�
���   ����� $/ U_IDA_CompISLR�$, PropertyChanged=�  $
( Auto $' Fecha ComprobanteISLR��-+   fechaComprobanteISLR��- �� .R�]� $��1��$��1��$��Stretch=�$��Stretch=�.+�  $��txtU_IDA_DateCompISLR��1 �� $/ U_IDA_DateCompISLR�$, PropertyChanged=�$0 {0:dd/MM/yyyy}�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��) �� .R�]� $��1��$��1��$��Stretch=�$��Stretch=�.+��� $��txtU_IDA_DateCompISLR������ $/ U_IDA_DateCompISLR�$, PropertyChanged=�$0 {0:dd/MM/yyyy}���� -,   $	 lblComentarios��$
��Bold"�$
��Left=�$��
24,535,0,0q�$
��Wrap=�$��Comentarios��$	��Top=��� --   $
 txtComentario��$��1q�$
��Left=�$��23��$��135,532,0,0q�$
 Wrap=�$	��Top=�$	��124��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -.   $	 lblCuentaAsociada��$y�Hidden=�$
��Bold"�$
��Left=�$��
24,570,0,0q�$
��Wrap=�$��Cuenta Asociada��$	��Top=��� -/   $
 txtCuentaAsociada��$y�Hidden=�$��1q�$
��Left=�$��23��$��134,566,0,0q�$
 Wrap=�$	��Top=�$	��124��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -0   $
 txtPagoCuenta��$��1q�$
��Left=�$��23��$��588,477,0,0q�$
 Wrap=�$	��Top=�$	��214��$
��0.00��$��Right=� . ���	#FFE5E5E5.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -1   2 ��Name$2 cbxPagoCuenta��$��Pago a cuenta��$
��Bold"�$
��Left=�$��449,481,0,0q�$	��Top=��� -2   $	 lblImporteVencido��$
��Bold"�$
��Left=�$��447,517,0,0q�$
��Wrap=�$��Importe Vencido��$	��Top=��� -3   $
 txtImporteVencido�����	#FFE5E5E5$��1q� . $
��Left=�$��23��$��588,510,0,0q�$
 Wrap=�$	��Top=�$	��213��$��Right=�.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -4   $	 lblSaldoPendiente��$
��Bold"�$
��Left=�$��448,590,0,0q�$
��Wrap=�$��Saldo Pendiente��$	��Top=��� -5   $
 txtSaldoPendiente�����	#FFE5E5E5$��1q�$
��Left=�$��23��$��588,583,0,0q�$
 Wrap=�$	��Top=�$	��214��$��Right=� . .�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -6   $ imgMoney��$
 Hand��$��
dinero.png��$
��Left=�$��28��$��808,508,0,0q�$	��Top=�$��31���� -7   3 ��Name$3 btnCrear��$��Crear��$
��Left=�$��
26,617,0,0q�$	��Top=�$��95��$��3q��� -8   $3 btnCancelar��$��Cancelar��$
��Left=�$��147,617,0,0q�$	��Top=�$��94��$��3q�
�������
��������� -9   $	 	lblPagarA��$
��Bold"�$
��Left=�$��
27,112,0,0q�$
��Wrap=�$��Pagar a��$	��Top=��� -:   $
 	txtPagarA��$��1q�$
��Left=�$��87��$��
94,108,0,0q�$
 Wrap=�$	��Top=�$	��147��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -;   $	 lblImporteVencido_ME��$y�Hidden=�$
��Bold"�$
��Left=�$��447,553,0,0q�$
��Wrap=�$��Importe Vencido (ME)��$	��Top=��� -<   $
 txtImporteVencido_ME�����	#FFE5E5E5$y�Hidden=�$��1q� . $
��Left=�$��23��$��588,546,0,0q�$
 Wrap=�$	��Top=�$	��213��$��Right=�.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.��