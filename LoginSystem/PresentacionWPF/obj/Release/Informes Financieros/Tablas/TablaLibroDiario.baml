   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  clr-namespace:VistaVista      Vista.TablaLibroDiario   localclr-namespace:Vista  n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     "myclr-namespace:Vista        Vista.Converter    Closing$  Window_Closing�� � Title$ TablaLibroDiario��$��642.716��$��1104.373�� � WindowStartupLocation$ CenterScreen=� � 	Resources    Vista.StyleConverter   StyleConverter��%   &	          .���� $
��Auto=�$
��Auto=�.��� $��Center=�$	��Top=�$	��602��.+�&   System.Windows.Controls.DataGrid  -     Name$ dgLibroDiario��$	��438��$	��Top=�$
��1000��$��1q�   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 
�������$
��Left=�   AutoGenerateColumns .     CanUserDeleteRows .     CanUserSortColumns .  	   SelectionMode$	 Extended=�$
   HorizontalScrollBarVisibility$

 Auto=�"   VerticalScrollBarVisibility$
 Auto=�$��Right=�$��Center=�   GridLinesVisibility$	 All=�   VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   CanUserAddRows .     SelectionUnit$ FullRow=�
�������$
��Bold"�$��10(�
���   �$��0q�$��	0,103,0,0q�   	CellStyle ��  �� 
TargetType*  $System.Windows.Controls.DataGridCell"  .���  �� Property � �� �� Value$ 0q� �� Triggers ��  �� Binding �� *Num+ �� Value 1.a���  � �� �	#FFE5E5E5��  �� *Num+ 0.a���  � ��
 �����   RowStyle �� )  #System.Windows.Controls.DataGridRow"   �� 	Resources  �� Color��%�   (��       * SystemColors.HighlightBrushKey+)(��      *$"SystemColors.HighlightTextBrushKey+)�� $ Transparent���� $ Black��.���  � ��$ 0q���  � ��
 �������  �@��
IsReadOnly .    Columns 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn   Width$
 auto    Header$ Nro Transaccion��-   nrotransaccion��   
IsReadOnly .    CellTemplate �� .R���   ��Name$  
txtTransId��$��Stretch=�$��Stretch=�$��0q�! �� TextAlignment$! Center=����� " �� Path$" TransId�# �� UpdateSourceTrigger$# PropertyChanged=�  $
 auto $ Fecha Contabilizacion��-   refDate�� .  �� .R��� $  
txtRefDate��$��Stretch=�$��Stretch=�$��0q�$! Center=����� $" RefDate�$# PropertyChanged=�  $ Nro Documento��$
 auto -   NroDocumento�� .  �� .R�]� $ ]�Name$$ dp��$��1��$��1��$��4.667,3.667,4.667,2.667q�$��Stretch=�$��Stretch=�.+��� % ��Name$	% img��-   $
��Left=�$��004-proximo.png��$��20��$��15��$��0,0,0,-0.333q�& � Cursor$
& Hand��y��� $" Title�' �� 	Converter#' [  $# PropertyChanged=��� $  txtTransType��$��0,0,0,-0.333q�$��95��$! Center=����� $" 	TransType�$# PropertyChanged=�0	  *System.Windows.Controls.DataGridTextColumn	  $
 auto $ Cuenta de Mayor/SN��-   
cuenta�� . $
! Left=�1
  +System.Windows.Controls.DataGridBoundColumn( 
  Binding( �� $" 	ShortName�$# PropertyChanged=�) 
  ElementStyle) �� " ��.���  �@��TextAlignment$ Center=�	  $
 auto $ Nombre Cuenta de Mayor/SN��-   
nombre�� . $
! Left=�( �� $" AcctName�$# PropertyChanged=�) �� " ��.���  �@��TextAlignment$ Center=�	  $
 auto $ 
Comentario��-   LineMemo�� . $
! Left=�( �� $" LineMemo�$# PropertyChanged=�) �� " ��.���  �@��TextAlignment$ Center=�	  $
 auto $ Debito (ML)��-	   	debit��*   
Visibility$* Visible=� . $! Right=�( �� $" Debit�$# PropertyChanged=�) �� " ��.���  �@��TextAlignment$ Right=�	  $
 auto $ Credito (ML)��-
   
credit��$* Visible=� . $! Right=�( �� $" Credit�$# PropertyChanged=�) �� " ��.���  �@��TextAlignment$ Right=�	  $
 auto $ 
Saldo (ML)��-   	saldo��$* Visible=� . $! Right=�( �� $" Saldo�$# PropertyChanged=�) �� " ��.���  �@��TextAlignment$ Right=�	  $
 auto $ Debito (ME)��$* Visible=�-   FCDebit�� . $! Right=�( �� $" FCDebit�$# PropertyChanged=�) �� " ��.���  �@��TextAlignment$ Right=�	  $
 auto $ Credito (ME)��$* Visible=�-   FCCredit�� . $! Right=�( �� $" FCCredit�$# PropertyChanged=�) �� " ��.���  �@��TextAlignment$ Right=�	  $
 auto $ 
Saldo (ME)��$* Visible=�-   FCSaldo�� . $! Right=�( �� $" FCSaldo�$# PropertyChanged=�) �� " ��.���  �@��TextAlignment$ Right=�	  $
 auto $ Debito (MS)��-   
SYSDeb��$* Visible=� . $! Right=�( �� $" SYSDeb�$# PropertyChanged=�) �� " ��.���  �@��TextAlignment$ Right=�	  $
 auto $ Credito (MS)��-   SYSCred��$* Visible=� . $! Right=�( �� $" SYSCred�$# PropertyChanged=�) �� " ��.���  �@��TextAlignment$ Right=�	  $
 auto $ 
Saldo (MS)��-   SYSSaldo��$* Visible=� . $! Right=�( �� $" SaldoSYS�$# PropertyChanged=�) �� " ��.���  �@��TextAlignment$ Right=��� -   $  
lblDeFecha��$
��Left=�$��	38,27,0,0q�$
��Wrap=�$��De Fecha��$
��Bold"�$��14(�$	��Top=��� -   $  lblHastaFecha��$
��Left=�$��
308,28,0,0q�$
��Wrap=�$��Hasta��$
��Bold"�$��14(�$	��Top=��� -   + ��Name$+ btnOk��$��OK��$
��Left=�$��	0,560,0,0q�$	��Top=�$	��100��(  "System.Windows.Controls.DatePicker  -   ,  Name$, dpFechaHasta��$
��Left=�$��
367,24,0,0q�$	��Top=�$	��121��$��25�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��  -   $, dpFechaDesde��$
��Left=�$��
116,24,0,0q�$	��Top=�$	��121��$��25�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3���� -   $% imgExcel��$��	excel.png��$��956,17,0,553q�$
& Hand��$y�Visible=�- J� RenderTransformOrigin$- 1.591,0.437&�