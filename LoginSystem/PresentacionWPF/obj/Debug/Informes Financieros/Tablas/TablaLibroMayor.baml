   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	       Vista.TablaLibroMayor   5      n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   %localclr-namespace:Vista     5   	      Vista.Converter    Closing$  Window_Closing��5   i    � Title$ TablaLibroMayor��6	   $��650.717��6"   $��1484.477��63    � WindowStartupLocation$ CenterScreen=�6D    � 	Resources 5          Vista.NameToBrushConverter   NameToBrushConverter!   Vista.NameToBrushConverter1  NameToBrushConverter1   Vista.StyleConverter  StyleConverter   Vista.ColorBrushConverter  ColorBrushConverter��%t   &	        &	      &	 &     &	 9       5   
   6%     5   
   6&     5	   
   6     5
   
   6$   5      .��5      �� $
��Auto=�6   $
��Auto=�66   $
��auto��6[   $��0,0,3.333,0.333q�6i   .��5   
   � $��Center=�6   $	��Top=�6,   $
��1379��6E   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dgLibroMayor��5      $	��400��6-   $��-55,137,-87,0q�6:   $	��Top=�6Q   $
��1297��6i   $��1q�6w      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�   
�������$��Center=�6�      AutoGenerateColumns .     CanUserDeleteRows .     CanUserSortColumns .  	   SelectionMode$	 Extended=�6"  $
   HorizontalScrollBarVisibility$

 Auto=�6;  "   VerticalScrollBarVisibility$
 Auto=�6`  $��Center=�6�  $��Center=�6�     GridLinesVisibility$	 All=�6�     VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   CanUserAddRows .     SelectionUnit$ FullRow=�6B  
�������$
��Bold"�6m  $��10(�6  
���   �$��0q�6�     	CellStyle 5      �� 5       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6    �� Triggers 5      �� 5       �� Binding 6*   ��  �� Path$	 Num� �� Value 16G   .a�5   "   ��  �� Property � �� �� Value �	#FFE5E5E56S   5      �� 5       6*   �� $	 Num� 06G   .a�5   "   ��  � ��
 �����6O   5      .�5      ��  � ��$ 0q�64   6@   5         RowStyle 5       �� 5!      )	  #System.Windows.Controls.DataGridRow" 	 6   .�5"      ��  � ��$ 0q�64   6@   �� 5#       � ��
 �����6O   �� 5$       �@��
IsReadOnly . 6N    �� 	Resources 5'       �� Color��%�   (��       5(   .   * SystemColors.HighlightBrushKey+)(�� %     5)   .   *$"SystemColors.HighlightTextBrushKey+)�� 5(      $ Transparent��6`   �� 5)      $ Black��6d   5*      5,         Columns 50      4
  .System.Windows.Controls.DataGridTemplateColumn
  51      ,  &System.Windows.Controls.DataGridColumn   Width$
 auto 6-      Header$ Fecha Contabilizacion��6:   -   5        refDate��   
IsReadOnly .   
  CellTemplate  52      �� 53      .R�54   "   �� $��
txtRefDate��6�   $��Stretch=�6-   $��Stretch=�6I   $��0q�6g   ! �� TextAlignment$! Center=�6�   ��6s   �� $ RefDate�" �� UpdateSourceTrigger$" PropertyChanged=�6�   55      57      
  59      $
 auto 6-   $ Fecha Vencimiento��6:   -   5        DueDate�� .   5:      �� 5;      .R�5<   "   �� $��
txtDueDate��6�   $��Stretch=�6-   $��Stretch=�6I   $��0q�6g   $! Center=�6�   ��6s   �� $ DueDate�$" PropertyChanged=���6�   �� $ Title�$" PropertyChanged=�# �� 	Converter## [ 6Y  5=      5?      
  5A      $
 auto 6-   $ Fecha Documento��6:   -   5        TaxDate�� .   5B      �� 5C      .R�5D   "   �� $��
txtTaxDate��6�   $��Stretch=�6-   $��Stretch=�6I   $��0q�6g   $! Center=�6�   ��6s   �� $ TaxDate�$" PropertyChanged=�6�   5E      5G      
  5I      $ Nro Documento��6-   $
 auto 6D   -   5        NroDocumento�� .   5J      �� 5K      .R�5L   "   ]� $��dp��6j   $��1��6,   $��1��69   $��4.667,3.667,4.667,2.667q�6I   $��Stretch=�6t   $��Stretch=�6�   .+�5M   &   �� $	��img��6�   -   5        $
��Left=�5M   h   $��004-proximo.png��6~   $��20��6�   $��15��6�   $��0,0,0,-0.333q�6�   $ � Cursor$
$ Hand��6�   y�6�   �� $ Title�$" PropertyChanged=�## [ �� 5N   &   % ��Name$% txtTransType��60   $��0,0,0,-0.333q�6�   $��95��6�   $! Center=�6�   ��6F   �� $ 	TransType�$" PropertyChanged=�6�   5O   #   5P      5S      0  *System.Windows.Controls.DataGridTextColumn  5T      $
 auto 6*   $ Nro de Asiento��67   -   5        TransId�� . $! Center=�5T   �   1  +System.Windows.Controls.DataGridBoundColumn&   Binding& 6b   �� $ TransId�$" PropertyChanged=�'   ElementStyle' 5U      �� 5V      " ��6$   .�5W   "   ��  �@��TextAlignment$ Center=�6B   5Y      5[        5\      $
 auto 6)   $ 
Comentario��66   -   5        Memo�� . $! Center=�5\   �   & 6Z   �� $
 Memo�$" PropertyChanged=�' 5]      �� 5^      " ��6$   .�5_   "   ��  � �� 6?   �� $ Title�$" PropertyChanged=�## [ �� 5`   "    �@��TextAlignment$ Center=�6B   5a      5c        5d      $
 auto 6)   $ Cuenta de Mayor/SN��66   -	   5        
cuenta�� . $! Center=�5d   �   & 6d   �� $ 	ContraAct�$" PropertyChanged=�' 5e      �� 5f      " ��6$   .�5g   "   ��  �@��TextAlignment$ Center=�6B   5i      5k      
  5m      $ Nombre Cuenta de Mayor/SN��6-   $
 auto 6P   -
   5        nombrec�� .   5n      �� 5o      .R�5q   "   �� $% 	txtNombre��6,   $��0,0,0,-0.333q�6�   $��95��6�   $! Center=�6�   ��6?   �� $ AcctName�$" PropertyChanged=�6�   5s      5v        5w      $
 auto 6)   $ Debito (ML)��66   -   5        	debit��(   
Visibility$( Visible=�5w   [    . $! Right=�6�   & 6p   �� $ Debit�$" PropertyChanged=�' 5x      �� 5y      " ��6$   .�5z   "   ��  �@��TextAlignment$ Right=�6B   5|      5~        5      $
 auto 6)   $ Credito (ML)��66   -   5        
credit��$( Visible=�5   ]    . $! Right=�6�   & 6r   �� $ Credit�$" PropertyChanged=�' 5�      �� 5�      " ��6$   .�5�   "   ��  �@��TextAlignment$ Right=�6B   5�      5�        5�      $
 auto 6)   $ 
Saldo (ML)��66   -   5        	saldo��$( Visible=�5�   Z    . $! Right=�6�   & 6o   �� $ Saldo�$" PropertyChanged=�' 5�      �� 5�      " ��6$   .�5�   "   ��  �@��TextAlignment$ Right=�6B   5�      5�        5�      $
 auto 6)   $ Saldo Acumulado (ML)��66   -   5        	saldoAcum��$( Visible=�5�   h    . $! Right=�6�   & 6}   �� $ 	SaldoAcum�$" PropertyChanged=�' 5�      �� 5�      " ��6$   .�5�   "   ��  �@��TextAlignment$ Right=�6B   5�      5�        5�      $
 auto 6)   $ Debito (ME)��66   $( Visible=�6K   -   5        FCDebit�� . $! Right=�5�   �   & 6r   �� $ FCDebit�$" PropertyChanged=�' 5�      �� 5�      " ��6$   .�5�   "   ��  �@��TextAlignment$ Right=�6B   5�      5�        5�      $
 auto 6)   $ Credito (ME)��66   $( Visible=�6L   -   5        FCCredit�� . $! Right=�5�   �   & 6t   �� $ FCCredit�$" PropertyChanged=�' 5�      �� 5�      " ��6$   .�5�   "   ��  �@��TextAlignment$ Right=�6B   5�      5�        5�      $
 auto 6)   $ 
Saldo (ME)��66   $( Visible=�6J   -   5        FCSaldo�� . $! Right=�5�   �   & 6p   �� $ FCSaldo�$" PropertyChanged=�' 5�      �� 5�      " ��6$   .�5�   "   ��  �@��TextAlignment$ Right=�6B   5�      5�        5�      $
 auto 6)   $ Saldo Acumulado (ME)��66   -   5        FCSaldoAcum��$( Visible=�5�   j    . $! Right=�6�   & 6   �� $ FCSaldoAcum�$" PropertyChanged=�' 5�      �� 5�      " ��6$   .�5�   "   ��  �@��TextAlignment$ Right=�6B   5�      5�        5�      $
 auto 6)   $ Debito (MS)��66   -   5        
SYSDeb��$( Visible=�5�   \    . $! Right=�6�   & 6q   �� $ SYSDeb�$" PropertyChanged=�' 5�      �� 5�      " ��6$   .�5�   "   ��  �@��TextAlignment$ Right=�6B   5�      5�        5�      $
 auto 6)   $ Credito (MS)��66   -   5        SYSCred��$( Visible=�5�   ^    . $! Right=�6�   & 6s   �� $ SYSCred�$" PropertyChanged=�' 5�      �� 5�      " ��6$   .�5�   "   ��  �@��TextAlignment$ Right=�6B   5�      5�        5�      $
 auto 6)   $ 
Saldo (MS)��66   -   5        SYSSaldo��$( Visible=�5�   ]    . $! Right=�6�   & 6r   �� $ SaldoSYS�$" PropertyChanged=�' 5�      �� 5�      " ��6$   .�5�   "   ��  �@��TextAlignment$ Right=�6B   5�      5�        5�      $
 auto 6)   $ Saldo Acumulado (MS)��66   -   5        SaldoSYSAcoum��$( Visible=�5�   l    . $! Right=�6�   & 6�   �� $ SaldoSYSAcum�$" PropertyChanged=�' 5�      �� 5�      " ��6$   .�5�   "   ��  �@��TextAlignment$ Right=�6B   5�      5�      5�      �� 5�      -   5        $% 
lblDeFecha��5�      $
��Left=�6,   $��	65,23,0,0q�6G   $
��Wrap=�6Z   $��De Fecha��6n   $
��Bold"�6~   $��14(�6�   $	��Top=�6�   �� 5�      -   5        $% lblHastaFecha��5�      $
��Left=�6/   $��
334,24,0,0q�6J   $
��Wrap=�6^   $��Hasta��6r   $
��Bold"�6   $��14(�6�   $	��Top=�6�   �� 5�      -   5        ) ��Name$) btnOk��5�      $��OK��68   $
��Left=�6E   $��	0,566,0,0q�6`   $	��Top=�6s   $	��100��6�   * J� RenderTransformOrigin$* 0.887,0.417&�6�   (  "System.Windows.Controls.DatePicker  5�      -   5        $��dpFechaHasta��5�      $
��Left=�6.   $��
393,20,0,0q�6I   $	��Top=�6]   $	��121��6u   $��25��6�    5�      ��%^   '��       �� 5�      " ��6   .�5�      ��  �@��CornerRadius$ 3��69   5�      5�      5�        5�      -   5        $��dpFechaDesde��5�      $
��Left=�6.   $��
142,20,0,0q�6I   $	��Top=�6]   $	��121��6u   $��25��6�    5�      ��%^   '��       �� 5�      " ��6   .�5�      ��  �@��CornerRadius$ 3��69   5�      5�      5�      �� 5�      -   5        + ��Name$+ imgExcel��5�   �   $��	excel.png��6U   $��1313,20,26,588q�6i   $
$ Hand��6�   $y�Visible=�6�   $* 1.591,0.437&�6�   $��40��6�   5�      5�      5�      