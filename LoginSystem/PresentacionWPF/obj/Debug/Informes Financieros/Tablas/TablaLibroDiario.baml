   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5      clr-namespace:VistaVista  5   	       Vista.TablaLibroDiario   5      localclr-namespace:Vista  n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "myclr-namespace:Vista     5   	      Vista.Converter    Closing$  Window_Closing��5   i    � Title$ TablaLibroDiario��6	   $��642.716��6"   $��1104.373��63    � WindowStartupLocation$ CenterScreen=�6D    � 	Resources 5	         Vista.StyleConverter   StyleConverter��%   &	          5   
   6   5      .��5      �� $
��Auto=�6   $
��Auto=�66   .��5   
   � $��Center=�6   $	��Top=�6,   $	��602��6D   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dgLibroDiario��5      $	��438��6.   $	��Top=�6;   $
��1000��6S   $��1q�6a      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6u   
�������$
��Left=�6�      AutoGenerateColumns .     CanUserDeleteRows .     CanUserSortColumns .  	   SelectionMode$	 Extended=�6
  $
   HorizontalScrollBarVisibility$

 Auto=�6#  "   VerticalScrollBarVisibility$
 Auto=�6H  $��Right=�6k  $��Center=�6�     GridLinesVisibility$	 All=�6�     VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   CanUserAddRows .     SelectionUnit$ FullRow=�6)  
�������$
��Bold"�6T  $��10(�6f  
���   �$��0q�6�  $��	0,103,0,0q�6�     	CellStyle 5      �� 5       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6   .�5      ��  �� Property � �� �� Value$ 0q�64    �� Triggers 5      �� 5       �� Binding 6*   �� *Num+ �� Value 16B   .a�5   "   ��  � �� �	#FFE5E5E56?   5      �� 5       6*   �� *Num+ 06B   .a�5   "   ��  � ��
 �����6?   5      5         RowStyle 5!      �� 5"      )  #System.Windows.Controls.DataGridRow"  6    �� 	Resources 5%       �� Color��%�   (��       5&   .   * SystemColors.HighlightBrushKey+)(�� %     5'   .   *$"SystemColors.HighlightTextBrushKey+)�� 5&      $ Transparent��6`   �� 5'      $ Black��6d   5(      .�5*      ��  � ��$ 0q�64   �� 5+       � ��
 �����67   �� 5,       �@��
IsReadOnly . 6C   5/         Columns 53      4  .System.Windows.Controls.DataGridTemplateColumn  54      ,  &System.Windows.Controls.DataGridColumn   Width$
 auto 6-      Header$ Nro Transaccion��6:   -   5        nrotransaccion��   
IsReadOnly .    CellTemplate 55      �� 56      .R�57   "   ��   ��Name$  
txtTransId��6�   $��Stretch=�6-   $��Stretch=�6I   $��0q�6g   ! �� TextAlignment$! Center=�6�   ��6s   �� " �� Path$" TransId�# �� UpdateSourceTrigger$# PropertyChanged=�6�   58      5:        5;      $
 auto 6-   $ Fecha Contabilizacion��6:   -   5        refDate�� .  5<      �� 5=      .R�5>   "   �� $  
txtRefDate��6�   $��Stretch=�6-   $��Stretch=�6I   $��0q�6g   $! Center=�6�   ��6s   �� $" RefDate�$# PropertyChanged=�6�   5?      5A        5D      $ Nro Documento��6-   $
 auto 6D   -   5        NroDocumento�� .  5E      �� 5F      .R�5G   "   ]� $ ]�Name$$ dp��6j   $��1��6,   $��1��69   $��4.667,3.667,4.667,2.667q�6I   $��Stretch=�6v   $��Stretch=�6�   .+�5H   &   �� % ��Name$	% img��6�   -   5        $
��Left=�5H   h   $��004-proximo.png��6~   $��20��6�   $��15��6�   $��0,0,0,-0.333q�6�   & � Cursor$
& Hand��6�   y�6�   �� $" Title�' �� 	Converter#' [  $# PropertyChanged=��� 5I   &   $  txtTransType��60   $��0,0,0,-0.333q�6�   $��95��6�   $! Center=�6�   ��6F   �� $" 	TransType�$# PropertyChanged=�6�   5J   #   5K      5N      0	  *System.Windows.Controls.DataGridTextColumn	  5O      $
 auto 6)   $ Cuenta de Mayor/SN��66   -   5        
cuenta�� . $
! Left=�5O   �   1
  +System.Windows.Controls.DataGridBoundColumn( 
  Binding( 6d   �� $" 	ShortName�$# PropertyChanged=�) 
  ElementStyle) 5P      �� 5Q      " ��6$   .�5R   "   ��  �@��TextAlignment$ Center=�6B   5T      5V      	  5W      $
 auto 6)   $ Nombre Cuenta de Mayor/SN��66   -   5        
nombre�� . $
! Left=�5W   �   ( 6k   �� $" AcctName�$# PropertyChanged=�) 5X      �� 5Y      " ��6$   .�5Z   "   ��  �@��TextAlignment$ Center=�6B   5\      5^      	  5_      $
 auto 6)   $ Cuenta Asociada��66   -   5        cuentaAsociada�� . $
! Left=�5_   �   ( 6i   �� $" Account�$# PropertyChanged=�) 5`      �� 5a      " ��6$   .�5b   "   ��  �@��TextAlignment$ Center=�6B   5d      5f      	  5h      $
 auto 6)   $ 
Comentario��66   -	   5        LineMemo�� . $
! Left=�5h   �   ( 6^   �� $" LineMemo�$# PropertyChanged=�) 5i      �� 5j      " ��6$   .�5k   "   ��  �@��TextAlignment$ Center=�6B   5m      5o      	  5q      $
 auto 6)   $ Debito (ML)��66   -
   5        	debit��*   
Visibility$* Visible=�5q   [    . $! Right=�6�   ( 6p   �� $" Debit�$# PropertyChanged=�) 5r      �� 5s      " ��6$   .�5t   "   ��  �@��TextAlignment$ Right=�6B   5v      5x      	  5y      $
 auto 6)   $ Credito (ML)��66   -   5        
credit��$* Visible=�5y   ]    . $! Right=�6�   ( 6r   �� $" Credit�$# PropertyChanged=�) 5z      �� 5{      " ��6$   .�5|   "   ��  �@��TextAlignment$ Right=�6B   5~      5�      	  5�      $
 auto 6)   $ 
Saldo (ML)��66   -   5        	saldo��$* Visible=�5�   Z    . $! Right=�6�   ( 6o   �� $" Saldo�$# PropertyChanged=�) 5�      �� 5�      " ��6$   .�5�   "   ��  �@��TextAlignment$ Right=�6B   5�      5�      	  5�      $
 auto 6)   $ Debito (ME)��66   $* Visible=�6K   -   5        FCDebit�� . $! Right=�5�   �   ( 6r   �� $" FCDebit�$# PropertyChanged=�) 5�      �� 5�      " ��6$   .�5�   "   ��  �@��TextAlignment$ Right=�6B   5�      5�      	  5�      $
 auto 6)   $ Credito (ME)��66   $* Visible=�6L   -   5        FCCredit�� . $! Right=�5�   �   ( 6t   �� $" FCCredit�$# PropertyChanged=�) 5�      �� 5�      " ��6$   .�5�   "   ��  �@��TextAlignment$ Right=�6B   5�      5�      	  5�      $
 auto 6)   $ 
Saldo (ME)��66   $* Visible=�6J   -   5        FCSaldo�� . $! Right=�5�   �   ( 6p   �� $" FCSaldo�$# PropertyChanged=�) 5�      �� 5�      " ��6$   .�5�   "   ��  �@��TextAlignment$ Right=�6B   5�      5�      	  5�      $
 auto 6)   $ Debito (MS)��66   -   5        
SYSDeb��$* Visible=�5�   \    . $! Right=�6�   ( 6q   �� $" SYSDeb�$# PropertyChanged=�) 5�      �� 5�      " ��6$   .�5�   "   ��  �@��TextAlignment$ Right=�6B   5�      5�      	  5�      $
 auto 6)   $ Credito (MS)��66   -   5        SYSCred��$* Visible=�5�   ^    . $! Right=�6�   ( 6s   �� $" SYSCred�$# PropertyChanged=�) 5�      �� 5�      " ��6$   .�5�   "   ��  �@��TextAlignment$ Right=�6B   5�      5�      	  5�      $
 auto 6)   $ 
Saldo (MS)��66   -   5        SYSSaldo��$* Visible=�5�   ]    . $! Right=�6�   ( 6r   �� $" SaldoSYS�$# PropertyChanged=�) 5�      �� 5�      " ��6$   .�5�   "   ��  �@��TextAlignment$ Right=�6B   5�      5�      5�      �� 5�      -   5        $  
lblDeFecha��5�      $
��Left=�6,   $��	38,27,0,0q�6G   $
��Wrap=�6Z   $��De Fecha��6n   $
��Bold"�6~   $��14(�6�   $	��Top=�6�   �� 5�      -   5        $  lblHastaFecha��5�      $
��Left=�6/   $��
308,28,0,0q�6J   $
��Wrap=�6^   $��Hasta��6r   $
��Bold"�6   $��14(�6�   $	��Top=�6�   �� 5�      -   5        + ��Name$+ btnOk��5�      $��OK��68   $
��Left=�6E   $��	0,560,0,0q�6`   $	��Top=�6s   $	��100��6�   (  "System.Windows.Controls.DatePicker  5�      -   5        ,  Name$, dpFechaHasta��5�      $
��Left=�60   $��
367,24,0,0q�6K   $	��Top=�6_   $	��121��6w   $��25��6�    5�      ��%^   '��       �� 5�      " ��6   .�5�      ��  �@��CornerRadius$ 3��69   5�      5�      5�        5�      -   5        $, dpFechaDesde��5�      $
��Left=�60   $��
116,24,0,0q�6K   $	��Top=�6_   $	��121��6w   $��25��6�    5�      ��%^   '��       �� 5�      " ��6   .�5�      ��  �@��CornerRadius$ 3��69   5�      5�      5�      �� 5�      -   5        $% imgExcel��5�      $��	excel.png��6U   $��956,17,0,553q�6i   $
& Hand��6�   $y�Visible=�6�   - J� RenderTransformOrigin$- 1.591,0.437&�6�   5�      5�      5�      