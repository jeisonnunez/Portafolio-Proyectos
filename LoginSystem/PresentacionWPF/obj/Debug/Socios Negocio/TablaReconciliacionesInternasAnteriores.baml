   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	   3    -Vista.TablaReconciliacionesInternasAnteriores   5      n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	      Vista.Converter    Loaded$  Window_Loaded��5   �      Closing$ Window_Closing��6�    � Title$- 'TablaReconciliacionesInternasAnteriores��6	   $��662.777��69   $��1156.288��6J    � WindowStartupLocation$ CenterScreen=�6[    � 	Resources 5	          Vista.ConverterClosePeriod   ConverterClosePeriod��%   &	          5   
   6%   5      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgHistorialReconciliacion��5      $��Normal"�6t   $��1q�6�      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�   
�������$
��Left=�6�   $	��212��6�   $��	77,64,0,0q�6�   $	��Top=�6�   $
��1012��6     AutoGenerateColumns .     CanUserDeleteRows .  	   CanUserSortColumns	 .  
   SelectionMode$
 Single=�6u  $   HorizontalScrollBarVisibility$
 Auto=�6�  "   VerticalScrollBarVisibility$
 Auto=�6�  $��Center=�6�  $��Center=�6�     GridLinesVisibility$	 All=�6     VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   SelectionUnit$ FullRow=�6s  ���	#FFE5E5E5   	CellStyle 5      �� 5       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6   .�5      ��  �� Property � �� �� Value$ 30��6/   �� 5       � ��$ Center=�6C   �� 5       � ��$ Center=�6A   �� 5       �@��TextAlignment$ Center=�6@   �� 5       � ��$ Center=�6:   �� 5       � �� �	#FFE5E5E563   5         RowStyle 5      �� 5      )  #System.Windows.Controls.DataGridRow"  6    �� 	Resources 5       �� Color��%�   (��       5   *   * SystemColors.HighlightBrushKey+)(�� #     5    *   *$"SystemColors.HighlightTextBrushKey+)�� 5      $ 	#FFE5E5E5��6\   �� 5       $ Black��6`   5!      5"         Columns 5$      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn   Width$	 110 6%      Header$ Nro Reconciliacion��61   -   5        nroReconciliacion��  HeaderStyle   HeaderStyle# [ 5&   i      
IsReadOnly . 1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 6�   �� *
ReconNum+ �� UpdateSourceTrigger$ PropertyChanged=� 	  ElementStyle 5'      �� 5(      " ��6    .�5*      ��  �@��TextAlignment$ Center=�6>   5+      5-        5.      $	 180 6%   $ Importe Reconciliacion��61   -   5        importeReconciliacion��# [ 5.   p    .  6�   �� *Total+$ PropertyChanged=� 5/      �� 50      " ��6    .�51      ��  �@��TextAlignment$ Center=�6>   52      54        55      $	 140 6%   $ Tipo Reconciliacion��61   # [ 6N   -   5        tipoReconciliacion�� .  55   �   �� *	ReconType+$ PropertyChanged=� 56      �� 57      " ��6    .�59      ��  �@��TextAlignment$ Center=�6>   5:      5<        5>      $	 140 6%   $ Fecha Reconciliacion��61   -   5        fechaReconciliacion��# [ 5>   l    .  6�   �� *	ReconDate+$ PropertyChanged=� 5?      �� 5@      " ��6    .�5B      ��  �@��TextAlignment$ Center=�6>   5C      5E        5F      $	 130 6%   $ Fecha Creacion��61   # [ 6I   -   5        fechaCreacion�� .  5F   �   �� *
CreateDate+$ PropertyChanged=� 5G      �� 5H      " ��6    .�5J      ��  �@��TextAlignment$ Center=�6>   5K      5M        5N      $	 130 6%   $  Nro Reconciliacion Anulado��61   # [ 6U   -   5        nroReconciliacionAnulado�� .  5N   �   �� *	CancelAbs+$ PropertyChanged=� 5O      �� 5P      " ��6    .�5R      ��  �@��TextAlignment$ Center=�6>   5S      5U        5V      $	 130 6%   $ Asiento Creado��61   # [ 6I   -   5        asientoCreado�� .  5V   �   �� *	ReconJEId+$ PropertyChanged=� 5W      �� 5X      " ��6    .�5Z      ��  �@��TextAlignment$ Center=�6>   5[      5]      5_      �� 5`   
   -	   5          ��Name$   lblHistorialReconciliacion��5`      $��	Underline{�68   $��14(�6T   $
��Left=�6b   $��	77,17,0,0q�6}   $
��Wrap=�6�   $!��Historial de Reconciliacion��6�   $
��Bold"�6�   $	��Top=�6�     5a   
   -
   5        $ dgDetallesReconciliacion��5a      $��Normal"�65   $��1q�6I   $ * 6]   
�������$
��Left=�6�   $	��212��6�   $��
77,358,0,0q�6�   $	��Top=�6�   $
��1012��6�    .   .  	 .  $
 Single=�67  $
 Auto=�6N  $
 Auto=�6s  $��Center=�6�  $��Center=�6�  $	 All=�6�  
 �����
 �����$ FullRow=�65  ���	#FFE5E5E5 5b      �� 5d      "  6   .�5e      ��  � ��$ 30��6/   �� 5f       � ��$ Center=�6C   �� 5g       � ��$ Center=�6A   �� 5h       �@��TextAlignment$ Center=�6@   �� 5i       � ��$ Center=�6:   �� 5j       � �� �	#FFE5E5E563   5k       5n      �� 5o      "  6    5p      ��%�   (��       5q   *   * SystemColors.HighlightBrushKey+)(�� #     5r   *   *$"SystemColors.HighlightTextBrushKey+)�� 5q      $ 	#FFE5E5E5��6\   �� 5r      $ Black��6`   5s      5t       5v      4
  .System.Windows.Controls.DataGridTemplateColumn
  5w      $ * 6)   $ Origen��63   -   5        
origen�� . # [ 5w   g   ! 
  CellTemplate! 5x      �� 5y      .R�5z      ]� $��dp��6f   $��1��6(   $��1��65   $��4.667,3.667,4.667,2.667q�6E   $��Stretch=�6p   $��Stretch=�6�   .+�5{   "   �� $��imgSrcObjTyp��6�   -   5        $
��Left=�5{   m   $��004-proximo.png��6�   $��20��6�   $��15��6�   $��0,0,0,-0.333q�6�   " � Cursor$
" Hand��6�   �� 5|   "   $  txtSrcObjTyp��6,   $��0,0,0,-0.333q�6�   $��95��6�   # �� TextAlignment$# Center=�6�   ��6B   �� $ �� Path$$ 	SrcObjTyp�$ PropertyChanged=�6�   5}      5~      5�        5�      $ * 6%   $ 
Nro Origen��6/   -   5        	nroOrigen��# [ 5�   V    .  6�   �� *	SrcObjAbs+$ PropertyChanged=� 5�      �� 5�      " ��6    .�5�      ��  �@��TextAlignment$ Center=�6>   5�      5�        5�      $ * 6%   $ Cuenta /Codigo SN��6/   # [ 6J   -   5        	shortName�� .  5�   �   �� *	ShortName+$ PropertyChanged=� 5�      �� 5�      " ��6    .�5�      ��  �@��TextAlignment$ Center=�6>   5�      5�        5�      $ * 6%   $ Cuenta/Nombre SN��6/   -   5        account��# [ 5�   Z    .  6�   �� *	Account+$ PropertyChanged=� 5�      �� 5�      " ��6    .�5�      ��  �@��TextAlignment$ Center=�6>   5�      5�        5�      $ * 6%   $ Importe Aplicado��6/   # [ 6I   -   5        reconSum�� .  5�   �   �� *
ReconSum+$ PropertyChanged=� 5�      �� 5�      " ��6    .�5�      ��  �@��TextAlignment$ Center=�6>   5�      5�      5�      �� 5�   
   -   5        $  lblDetallesReconciliacion��5�      $��	Underline{�67   $��14(�6S   $
��Left=�6a   $��
77,311,0,0q�6|   $
��Wrap=�6�   $ ��Detalles de Reconciliacion��6�   $
��Bold"�6�   $	��Top=�6�   �� 5�   
   $��19��6   $��0,293,0.333,0q�6!   $	��Top=�68   $��Stretch=�6P   $��Stretch=�6u   �� 5�   
   -   5        % ��Name$% btnOk��5�      $��OK��6    $
��Left=�6-   $��136,584,0,0q�6H   $	��Top=�6]   $��94��6u   $��3q�6�   6�   �� 5�   
   -   5        $% btnCancelar��5�      $��Cancelar��6&   $
��Left=�69   $��253,584,0,0q�6T   $	��Top=�6i   $��94��6�   $��3q�6�   
�������
�������6�   �� 5�   
   -   5        & ��Name$& 	imgReturn��5�   �   $2��,/Vista;component/Finanzas/003-anterior-2.png��6R   $
" Hand��6�   $y�Visible=�6�   ' J� RenderTransformOrigin$' 1.591,0.437&�6�   $��40��6�   $��75,584,0,16.333q�6�   $
��Left=�6  �� 5�   
   -   5        $% btnCancelarReconciliacion��5�      $��Cancelar Reconciliacion��64   $
��Left=�6V   $��935,584,0,0q�6q   $	��Top=�6�   $	��152��6�   $��3q�6�   {�.  6�   5�      5�      