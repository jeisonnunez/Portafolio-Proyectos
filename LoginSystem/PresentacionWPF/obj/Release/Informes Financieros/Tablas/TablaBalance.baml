   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista      Vista.TablaBalance   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Vista        Vista.Converter    Closing$  Window_Closing�� � Title$ Tabla Balance��$��510.466��$��1208.603�� � WindowStartupLocation$ CenterScreen=�.���� $��0,0,0.333,0q�$	��Top=�$
��auto��.��� $��Center=�$	��Top=�$	��543��$
��1162��.+�&   System.Windows.Controls.DataGrid  -     Name$ 	dgBalance��$	��902��$��0q�$��116,0,144,145.667q�$��1q�
�������$��Center=�   AutoGenerateColumns .     CanUserDeleteRows .     CanUserSortColumns .     SelectionMode$ Extended=�$��Center=�   GridLinesVisibility$ Vertical=�	   VerticalGridLinesBrush
	 �����
   CanUserAddRows
 .     SelectionUnit$ FullRow=����	#FFE5E5E5$
��Bold"�$��12(�
���   �$	��335��$��Bottom=�$   HorizontalScrollBarVisibility$
 Auto=�"   VerticalScrollBarVisibility$
 Auto=�   RowStyle ��  �� 
TargetType)  #System.Windows.Controls.DataGridRow"   �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ���  �� Property � �� �� Value �	#FF2196F3��  � ��
 �����.���  � ��$ 32����  � ��$ 12(���  �@��
IsReadOnly . ��  �@��TextAlignment$ Right=���  � ��
 �������  � ��
 �   � �� 	Resources  �� Color��%�   (��       * SystemColors.HighlightBrushKey+)(��      *$"SystemColors.HighlightTextBrushKey+)�� $ Transparent���� $ Black��   Columns 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto    Header$ Nombre��-   
nombre��   CellTemplate �� .R��� $��	txtNombre��$��Stretch=�$��Stretch=�$��0q� �� TextAlignment$ Center=�����  �� Path$
 Name� �� UpdateSourceTrigger$ PropertyChanged=�0  *System.Windows.Controls.DataGridTextColumn  $
 auto $ Debito (ML)��-   	debit��   
Visibility$ Hidden=�   
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn    Binding  �� $ Debit�$ PropertyChanged=�  $
 auto $ Credito (ML)��-   
credit��$ Hidden=� .   �� $ Credit�$ PropertyChanged=�  $
 auto $ 
Saldo (ML)��-   	saldo��$ Hidden=� .   �� $ Saldo�$ PropertyChanged=�  $
 auto $ Debito (ME)��$ Hidden=�-   FCDebit�� .   �� $ FCDebit�$ PropertyChanged=�  $
 auto $ Credito (ME)��$ Hidden=�-   FCCredit�� .   �� $ FCCredit�$ PropertyChanged=�  $
 auto $ 
Saldo (ME)��$ Hidden=�-   FCSaldo�� .   �� $ FCSaldo�$ PropertyChanged=�  $
 auto $ Debito (MS)��-	   
SYSDeb��$ Hidden=� .   �� $ SYSDeb�$ PropertyChanged=�  $
 auto $ Credito (MS)��-
   SYSCred��$ Hidden=� .   �� $ SYSCred�$ PropertyChanged=�  $
 auto $ 
Saldo (MS)��-   SYSSaldo��$ Hidden=� .   �� $ SaldoSYS�$ PropertyChanged=��� -   ! ��Name$! 
lblDeFecha��$
��Left=�$��
115,27,0,0q�$
��Wrap=�$��De Fecha��$
��Bold"�$��14(�$	��Top=��� -   $! lblHastaFecha��$
��Left=�$��
385,28,0,0q�$
��Wrap=�$��Hasta��$
��Bold"�$��14(�$	��Top=��� -   " ��Name$" btnOk��$��OK��$
��Left=�$��116,428,0,0q�$	��Top=�$	��100��(	  "System.Windows.Controls.DatePicker	  -   $��dpFechaHasta��$
��Left=�$��
444,24,0,0q�$	��Top=�$	��121��$��25��# � 	Resources# ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��	  -   $��dpFechaDesde��$
��Left=�$��
193,24,0,0q�$	��Top=�$	��121��$��25��# ��%9   '��       �� " ��.���  �@��CornerRadius$ 3���� -   $ ��Name$$ imgExcel��$��	excel.png��% � Cursor$
% Hand��$y�Visible=�& J� RenderTransformOrigin$& 1.591,0.437&�$��40��$��978,24,144,486q�