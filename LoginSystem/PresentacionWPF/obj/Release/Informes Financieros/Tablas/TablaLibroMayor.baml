   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista      Vista.TablaLibroMayor   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     %localclr-namespace:Vista        Vista.Converter    Closing$  Window_Closing�� � Title$ TablaLibroMayor��$��650.717��$��1484.477�� � WindowStartupLocation$ CenterScreen=� � 	Resources     Vista.NameToBrushConverter   NameToBrushConverter!   Vista.NameToBrushConverter1  NameToBrushConverter1   Vista.StyleConverter  StyleConverter   Vista.ColorBrushConverter  ColorBrushConverter��%<   &	        &	      &	 
     &	              .���� $
��Auto=�$
��Auto=�$
��auto��$��0,0,3.333,0.333q�.��� $��Center=�$	��Top=�$
��1379��.+�&   System.Windows.Controls.DataGrid  -     Name$ dgLibroMayor��$	��400��$��-55,137,-87,0q�$	��Top=�$
��1297��$��1q�   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 
�������$��Center=�   AutoGenerateColumns .     CanUserDeleteRows .     CanUserSortColumns .  	   SelectionMode$	 Extended=�$
   HorizontalScrollBarVisibility$

 Auto=�"   VerticalScrollBarVisibility$
 Auto=�$��Center=�$��Center=�   GridLinesVisibility$	 All=�   VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   CanUserAddRows .     SelectionUnit$ FullRow=�
�������$
��Bold"�$��10(�
���   �$��0q�   	CellStyle ��  �� 
TargetType*  $System.Windows.Controls.DataGridCell"   �� Triggers ��  �� Binding ��  �� Path$	 Num� �� Value 1.a���  �� Property � �� �� Value �	#FFE5E5E5��  �� $	 Num� 0.a���  � ��
 �����.���  � ��$ 0q�   RowStyle �� )	  #System.Windows.Controls.DataGridRow" 	 .���  � ��$ 0q���  � ��
 �������  �@��
IsReadOnly .  �� 	Resources  �� Color��%�   (��       * SystemColors.HighlightBrushKey+)(��      *$"SystemColors.HighlightTextBrushKey+)�� $ Transparent���� $ Black��   Columns 4
  .System.Windows.Controls.DataGridTemplateColumn
  ,  &System.Windows.Controls.DataGridColumn   Width$
 auto    Header$ Fecha Contabilizacion��-   refDate��   
IsReadOnly .   
  CellTemplate  �� .R��� $��
txtRefDate��$��Stretch=�$��Stretch=�$��0q�! �� TextAlignment$! Center=����� $ RefDate�" �� UpdateSourceTrigger$" PropertyChanged=�
  $
 auto $ Fecha Vencimiento��-   DueDate�� .   �� .R��� $��
txtDueDate��$��Stretch=�$��Stretch=�$��0q�$! Center=����� $ DueDate�$" PropertyChanged=����� $ Title�$" PropertyChanged=�# �� 	Converter## [ 
  $
 auto $ Fecha Documento��-   TaxDate�� .   �� .R��� $��
txtTaxDate��$��Stretch=�$��Stretch=�$��0q�$! Center=����� $ TaxDate�$" PropertyChanged=�
  $ Nro Documento��$
 auto -   NroDocumento�� .   �� .R�]� $��dp��$��1��$��1��$��4.667,3.667,4.667,2.667q�$��Stretch=�$��Stretch=�.+��� $	��img��-   $
��Left=�$��004-proximo.png��$��20��$��15��$��0,0,0,-0.333q�$ � Cursor$
$ Hand��y��� $ Title�$" PropertyChanged=�## [ �� % ��Name$% txtTransType��$��0,0,0,-0.333q�$��95��$! Center=����� $ 	TransType�$" PropertyChanged=�0  *System.Windows.Controls.DataGridTextColumn  $
 auto $ Nro de Asiento��-   TransId�� . $! Center=�1  +System.Windows.Controls.DataGridBoundColumn&   Binding& �� $ TransId�$" PropertyChanged=�'   ElementStyle' �� " ��.���  �@��TextAlignment$ Center=�  $
 auto $ 
Comentario��-   Memo�� . $! Center=�& �� $
 Memo�$" PropertyChanged=�' �� " ��.���  � �� �� $ Title�$" PropertyChanged=�## [ ��  �@��TextAlignment$ Center=�  $
 auto $ Cuenta de Mayor/SN��-	   
cuenta�� . $! Center=�& �� $ 	ContraAct�$" PropertyChanged=�' �� " ��.���  �@��TextAlignment$ Center=�
  $ Nombre Cuenta de Mayor/SN��$
 auto -
   nombrec�� .   �� .R��� $% 	txtNombre��$��0,0,0,-0.333q�$��95��$! Center=����� $ AcctName�$" PropertyChanged=�  $
 auto $ Debito (ML)��-   	debit��(   
Visibility$( Visible=� . $! Right=�& �� $ Debit�$" PropertyChanged=�' �� " ��.���  �@��TextAlignment$ Right=�  $
 auto $ Credito (ML)��-   
credit��$( Visible=� . $! Right=�& �� $ Credit�$" PropertyChanged=�' �� " ��.���  �@��TextAlignment$ Right=�  $
 auto $ 
Saldo (ML)��-   	saldo��$( Visible=� . $! Right=�& �� $ Saldo�$" PropertyChanged=�' �� " ��.���  �@��TextAlignment$ Right=�  $
 auto $ Saldo Acumulado (ML)��-   	saldoAcum��$( Visible=� . $! Right=�& �� $ 	SaldoAcum�$" PropertyChanged=�' �� " ��.���  �@��TextAlignment$ Right=�  $
 auto $ Debito (ME)��$( Visible=�-   FCDebit�� . $! Right=�& �� $ FCDebit�$" PropertyChanged=�' �� " ��.���  �@��TextAlignment$ Right=�  $
 auto $ Credito (ME)��$( Visible=�-   FCCredit�� . $! Right=�& �� $ FCCredit�$" PropertyChanged=�' �� " ��.���  �@��TextAlignment$ Right=�  $
 auto $ 
Saldo (ME)��$( Visible=�-   FCSaldo�� . $! Right=�& �� $ FCSaldo�$" PropertyChanged=�' �� " ��.���  �@��TextAlignment$ Right=�  $
 auto $ Saldo Acumulado (ME)��-   FCSaldoAcum��$( Visible=� . $! Right=�& �� $ FCSaldoAcum�$" PropertyChanged=�' �� " ��.���  �@��TextAlignment$ Right=�  $
 auto $ Debito (MS)��-   
SYSDeb��$( Visible=� . $! Right=�& �� $ SYSDeb�$" PropertyChanged=�' �� " ��.���  �@��TextAlignment$ Right=�  $
 auto $ Credito (MS)��-   SYSCred��$( Visible=� . $! Right=�& �� $ SYSCred�$" PropertyChanged=�' �� " ��.���  �@��TextAlignment$ Right=�  $
 auto $ 
Saldo (MS)��-   SYSSaldo��$( Visible=� . $! Right=�& �� $ SaldoSYS�$" PropertyChanged=�' �� " ��.���  �@��TextAlignment$ Right=�  $
 auto $ Saldo Acumulado (MS)��-   SaldoSYSAcoum��$( Visible=� . $! Right=�& �� $ SaldoSYSAcum�$" PropertyChanged=�' �� " ��.���  �@��TextAlignment$ Right=��� -   $% 
lblDeFecha��$
��Left=�$��	65,23,0,0q�$
��Wrap=�$��De Fecha��$
��Bold"�$��14(�$	��Top=��� -   $% lblHastaFecha��$
��Left=�$��
334,24,0,0q�$
��Wrap=�$��Hasta��$
��Bold"�$��14(�$	��Top=��� -   ) ��Name$) btnOk��$��OK��$
��Left=�$��	0,566,0,0q�$	��Top=�$	��100��* J� RenderTransformOrigin$* 0.887,0.417&�(  "System.Windows.Controls.DatePicker  -   $��dpFechaHasta��$
��Left=�$��
393,20,0,0q�$	��Top=�$	��121��$��25�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��  -   $��dpFechaDesde��$
��Left=�$��
142,20,0,0q�$	��Top=�$	��121��$��25�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3���� -   + ��Name$+ imgExcel��$��	excel.png��$��1313,20,26,588q�$
$ Hand��$y�Visible=�$* 1.591,0.437&�$��40��