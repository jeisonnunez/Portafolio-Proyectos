   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	       Vista.TablaBalance   5      n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	      Vista.Converter    Closing$  Window_Closing��5   f      Loaded$ Converter_Loaded��6    � Title$ Tabla Balance��6	   $��506.466��6   $��1120.603��60    � WindowStartupLocation$ CenterScreen=�6A   .��5      �� $��0,0,0.333,0q�6   $	��Top=�6)   $
��auto��6A   .��5   
   � $��Center=�6   $	��Top=�6,   $	��543��6D   $
��1162��6Q   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 	dgBalance��5      $	��902��6*   $��0q�66   $��116,0,144,145.667q�6B   $��1q�6_   
�������$��Center=�6�      AutoGenerateColumns .     CanUserDeleteRows .     CanUserSortColumns .     SelectionMode$ Extended=�61  $��Center=�6L  	   GridLinesVisibility$	 Vertical=�6n  
   VerticalGridLinesBrush

 �����   CanUserAddRows .     SelectionUnit$ FullRow=�6�  ���	#FFE5E5E5$
��Bold"�6�  $��12(�6  
���   �$	��335��6%  $��Bottom=�62  $   HorizontalScrollBarVisibility$
 Auto=�6M  "   VerticalScrollBarVisibility$
 Auto=�6r     RowStyle 5      �� 5       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6    �� Triggers 5      P� 5       P� Property �@J�IsMouseOver P� Value . . �5   "   ��  �� Property � �� �� Value �	#FF2196F35      �� 5   "    � ��
 �����5      5      .�5      ��  � ��$ 32��63   �� 5       � ��$ 12(�65   �� 5       �@��
IsReadOnly . 6N   �� 5       �@��TextAlignment$ Right=�6B   6R   �� 5        � ��
 �����67   �� 5!       � ��
 �   �67    �� 	Resources 5$       �� Color��%�   (��       5%   .   * SystemColors.HighlightBrushKey+)(�� %     5&   .   *$"SystemColors.HighlightTextBrushKey+)�� 5%      $ Transparent��6`   �� 5&      $ Black��6d   5'      5)         Columns 5-      4  .System.Windows.Controls.DataGridTemplateColumn  5.      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6-      Header$ Nombre��6:   -   5        
nombre��   CellTemplate 5/      �� 50      .R�51   "   �� $��	txtNombre��6�   $��Stretch=�6-   $��Stretch=�6I   $��0q�6g    �� TextAlignment$ Center=�6�   ��6s   ��  �� Path$
 Name� �� UpdateSourceTrigger$ PropertyChanged=�6�   52      54      0  *System.Windows.Controls.DataGridTextColumn  56      $
 auto 6)   $ Debito (ML)��66   -   5        	debit��   
Visibility$ Hidden=�56   [       
IsReadOnly  . 1  +System.Windows.Controls.DataGridBoundColumn!   Binding! 6o   �� $ Debit�$ PropertyChanged=�6�     57      $
 auto 6)   $ Credito (ML)��66   -   5        
credit��$ Hidden=�57   ]     . ! 6q   �� $ Credit�$ PropertyChanged=�6�     58      $
 auto 6)   $ 
Saldo (ML)��66   -   5        	saldo��$ Hidden=�58   Z     . ! 6n   �� $ Saldo�$ PropertyChanged=�6�     59      $
 auto 6)   $ Debito (ME)��66   $ Hidden=�6K   -   5        FCDebit��  . ! 59   q   �� $ FCDebit�$ PropertyChanged=�6�     5:      $
 auto 6)   $ Credito (ME)��66   $ Hidden=�6L   -   5        FCCredit��  . ! 5:   s   �� $ FCCredit�$ PropertyChanged=�6�     5;      $
 auto 6)   $ 
Saldo (ME)��66   $ Hidden=�6J   -   5        FCSaldo��  . ! 5;   o   �� $ FCSaldo�$ PropertyChanged=�6�     5<      $
 auto 6)   $ Debito (MS)��66   -	   5        
SYSDeb��$ Hidden=�5<   \     . ! 6p   �� $ SYSDeb�$ PropertyChanged=�6�     5=      $
 auto 6)   $ Credito (MS)��66   -
   5        SYSCred��$ Hidden=�5=   ^     . ! 6r   �� $ SYSCred�$ PropertyChanged=�6�     5>      $
 auto 6)   $ 
Saldo (MS)��66   -   5        SYSSaldo��$ Hidden=�5>   ]     . ! 6q   �� $ SaldoSYS�$ PropertyChanged=�6�   5@      �� 5B      -   5        " ��Name$" 
lblDeFecha��5B      $
��Left=�6,   $��
115,27,0,0q�6G   $
��Wrap=�6[   $��De Fecha��6o   $
��Bold"�6   $��14(�6�   $	��Top=�6�   �� 5C      -   5        $" lblHastaFecha��5C      $
��Left=�6/   $��
385,28,0,0q�6J   $
��Wrap=�6^   $��Hasta��6r   $
��Bold"�6   $��14(�6�   $	��Top=�6�   �� 5E      -   5        # ��Name$# btnOk��5E      $��OK��68   $
��Left=�6E   $��116,428,0,0q�6`   $	��Top=�6u   $	��100��6�   (	  "System.Windows.Controls.DatePicker	  5F      -   5        $��dpFechaHasta��5F      $
��Left=�6.   $��
444,24,0,0q�6I   $	��Top=�6]   $	��121��6u   $��25��6�   $ � 	Resources$ 5G      ��%^   '��       �� 5H      " ��6   .�5I      ��  �@��CornerRadius$ 3��69   5K      5L      5M      	  5N      -   5        $��dpFechaDesde��5N      $
��Left=�6.   $��
193,24,0,0q�6I   $	��Top=�6]   $	��121��6u   $��25��6�   $ 5O      ��%^   '��       �� 5P      " ��6   .�5Q      ��  �@��CornerRadius$ 3��69   5S      5T      5U      �� 5V      -   5        % ��Name$% imgExcel��5V   j   $��	excel.png��6U   & � Cursor$
& Hand��6|   $y�Visible=�6�   ' J� RenderTransformOrigin$' 1.591,0.437&�6�   $��40��6�   $��980,20,142,490q�6�   5Y      5Z      5[      