   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	   "    Vista.TablaRetencionImpuesto   5      n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	      Vista.Document    Loaded$  Document_Loaded��5   D      Closing$ Document_Closing��6]    � Title$ TablaRetencionImpuesto��6	   $��403.14��6(   $	��895��68   .��5	      �� $
��Auto=�6   $
��Auto=�66   .��5
   
   � $��Center=�6   $	��Top=�6,   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dgRetenciones��5      $��1q�6.      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6B   
�������$
��Left=�6j   $	��236��6�   $��	25,54,0,0q�6�   $	��Top=�6�   $	��839��6�      AutoGenerateColumns .     CanUserDeleteRows .     CanUserSortColumns .    SelectionMode$ Single=�6  $	   HorizontalScrollBarVisibility$
	 Auto=�60  "
   VerticalScrollBarVisibility$

 Auto=�6U  $��Center=�6x  $��Center=�6�     GridLinesVisibility$	 All=�6�     VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   SelectionUnit$ FullRow=�6     CanUserAddRows .    	CellStyle 5      �� 5       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6    �� Triggers 5      P� 5       P� Property �@J�IsMouseOver P� Value . . �5   "   ��  �� Property � �� �� Value �	#FF74C1FF5      �� 5   "    � ��
 �   �5      5      .�5      ��  � ��$ 30��63   6@   �� 5       � ��$ Center=�6G   6X   �� 5       � ��$ Center=�6E   6V   �� 5       �@��TextAlignment$ Center=�6D   6U   �� 5       � ��$ Center=�6H   6Y   5         RowStyle 5"      �� 5#      )  #System.Windows.Controls.DataGridRow"  6    5$      P� 5%       �@J�IsMouseOver . . �5'   "   ��  � ��
 �����5(      5+       �� 	Resources 5-       �� Color��%�   (��       5.   .   * SystemColors.HighlightBrushKey+)(�� %     5/   .   *$"SystemColors.HighlightTextBrushKey+)�� 5.      $ Transparent��6`   �� 5/      $ Black��6d   50      52       � 	Resources 55         TextBoxStyle��%Z   &	        �� 56      " ��61   .�57      ��  � �� �	#FF74C1FF6K   58      59         Columns 5:      4  .System.Windows.Controls.DataGridTemplateColumn  5<      ,  &System.Windows.Controls.DataGridColumn   Header$ Codigo��6-      Width$
 auto 6=   -   5        
codigo��   CellEditingTemplate 5=      �� 5>      .R�5?   "   �� $��bd��6a   $��1q�6)   
������� �� CornerRadius$ 3��6P   ._�5@   &   ]� $��dp��6M   $��1��60   $��1��6=   $��Stretch=�6W   $��Stretch=�6u   .+�5A   *   �� $��	imgWTCode��6�   -   5        $��Right=�5A   r   $��lupa.png��6�   $��20��6�   $y�Visible=�6�     � Cursor$
  Hand��6�   �� 5B   *   ! ��Name$! 	txtWTCode��62   -   5        $��12(�5B   E   $��Stretch=�6S   
���   �#��[  6�   
�������$��0q�6   $
��auto��6  ��6�   �� " �� Path$" WTCode�# �� UpdateSourceTrigger$# PropertyChanged=�6A  5C   '   5D   #   5E      $   CellTemplate$ 5G      �� 5H      .R�5I   "   �� $��	txtWTCode��6�   
���   ���6?   �� $" WTCode�$# PropertyChanged=�6�   5J      5M        5N      $ Nombre��6-   $
 auto 6=   -   5        
nombre�� 5O      �� 5P      .R�5Q   "   �� $! 	txtWTName��6*   % �� 
IsReadOnly% . ���	#FFE5E5E5$��12(�6f   $��Stretch=�6t   
���   �#��[  6�   
�������$��0q�6!  $
��auto��66  ��6�   �� $" WTName�$# PropertyChanged=�6F  5R      $ 5T      �� 5U      .R�5V   "   �� $��	txtWTName��6�   
���   ����	#FFE5E5E5��6V   �� $" WTName�$# PropertyChanged=�6�   5W      5Y        5[      $
 Tasa��6-   $
 auto 6;   -   5        tasa�� 5\      �� 5]      .R�5^   "   �� $��txtRate��6�   
���   �% . ���	#FFE5E5E5#��[  6�   ��6f   �� $
" Rate�& �� StringFormat$& 
{0:#,0.00}��$# PropertyChanged=�6�   5_      $ 5a      �� 5b      .R�5c   "   �� $��txtRate��6�   
���   ����	#FFE5E5E5��6W   �� $
" Rate�$& 
{0:#,0.00}��$# PropertyChanged=�6�   5d      5f        5h      $ Importe Base��6-   $
 auto 6C   -   5        importebase�� 5i      �� 5j      .R�5k   "   �� $��txtBaseAmnt��6�   
���   �% . ���	#FFE5E5E5#��[  6�   ��6f   �� $" BaseAmnt�$& 
{0:#,0.00}��$# PropertyChanged=�6  5l      $ 5n      �� 5o      .R�5p   "   �� $��txtBaseAmnt��6�   
���   ����	#FFE5E5E5��6V   �� $" BaseAmnt�$& 
{0:#,0.00}��$# PropertyChanged=�6�   5q      5s        5u      $ Importe Base FC��6-   $
 auto 6F   -   5        importebaseFC��'   
Visibility$' Hidden=�5u   k    5v      �� 5w      .R�5x   "   �� $��txtBaseAmntFC��6�   
���   �% . ���	#FFE5E5E5#��[  6�   ��6f   �� $" 
BaseAmntFC�$& 
{0:#,0.00}��$# PropertyChanged=�6  5y      $ 5{      �� 5|      .R�5}   "   �� $��txtBaseAmntFC��6�   
���   ����	#FFE5E5E5��6V   �� $" 
BaseAmntFC�$& 
{0:#,0.00}��$# PropertyChanged=�6�   5~      5�        5�      $ 
PrctBsAmnt��6-   $
 auto 6A   -	   5        
PrctBsAmnt��$' Hidden=�5�   c    5�      �� 5�      .R�5�   "   �� $! txtPrctBsAmnt��6*   % . ���	#FFE5E5E5$��12(�6j   $��Stretch=�6x   
���   �#��[  6�   
�������$��0q�6)  $
��auto��6>  ��6�   �� $" 
PrctBsAmnt�$# PropertyChanged=�6N  5�      $ 5�      �� 5�      .R�5�   "   �� $��txtPrctBsAmnt��6�   
���   ����	#FFE5E5E5��6V   �� $" 
PrctBsAmnt�$& 
{0:#,0.00}��$# PropertyChanged=�6�   5�      5�        5�      $ Imp. Sujeto a Retencion��6-   $
 auto 6N   -
   5        importeSujeto��$' Visible=�5�   s    5�      �� 5�      .R�5�   "   �� $��txtTaxbleAmnt��6�   -   5        
���   �#��[  5�   �   ��6=   �� $" 
TaxbleAmnt�$& 
{0:#,0.00}��$# PropertyChanged=�6  5�      $ 5�      �� 5�      .R�5�   "   �� $��txtTaxbleAmnt��6�   
���   ���6?   �� $" 
TaxbleAmnt�$& 
{0:#,0.00}��$# PropertyChanged=�6�   5�      5�        5�      $ Imp. Sujeto a RetencionFC��6-   $
 auto 6P   -   5        importeSujetoFC��$' Hidden=�5�   w    5�      �� 5�      .R�5�   "   �� $��txtTaxbleAmntFC��6�   -   5        
���   �#��[  5�   �   ��6=   �� $" TaxbleAmntFC�$& 
{0:#,0.00}��$# PropertyChanged=�6  5�      $ 5�      �� 5�      .R�5�   "   �� $��txtTaxbleAmntFC��6�   
���   ���6?   �� $" TaxbleAmntFC�$& 
{0:#,0.00}��$# PropertyChanged=�6�   5�      5�        5�      $ WImpte. Retencion��6-   $
 auto 6H   -   5        wimporte�� 5�      �� 5�      .R�5�   "   �� $��	txtWTAmnt��6�   -   5        
���   �#��[  5�   �   ��6=   �� $" WTAmnt�$& 
{0:#,0.00}��$# PropertyChanged=�6  5�      $ 5�      �� 5�      .R�5�   "   �� $��	txtWTAmnt��6�   
���   ���6?   �� $" WTAmnt�$& 
{0:#,0.00}��$# PropertyChanged=�6�   5�      5�        5�      $ WImpte. RetencionFC��6-   $
 auto 6J   -   5        
wimporteFC��$' Hidden=�5�   l    5�      �� 5�      .R�5�   "   �� $��txtWTAmntFC��6�   -   5        
���   �#��[  5�   �   ��6=   �� $" WTAmntFC�$& 
{0:#,0.00}��$# PropertyChanged=�6  5�      $ 5�      �� 5�      .R�5�   "   �� $��txtWTAmntFC��6�   
���   ���6?   �� $" WTAmntFC�$& 
{0:#,0.00}��$# PropertyChanged=�6�   5�      5�        5�      $ 	Categoria��6-   $
 auto 6@   -   5        	categoria�� 5�      �� 5�      .R�5�   "   �� $��txtCategory��6�   
���   �% . ���	#FFE5E5E5#��[  6�   ��6f   �� $" Category�$# PropertyChanged=�6�   5�      $ 5�      �� 5�      .R�5�   "   �� $��txtCategory��6�   
���   ����	#FFE5E5E5��6V   �� $" Category�$# PropertyChanged=�6�   5�      5�        5�      $ 	Tipo Base��6-   $
 auto 6@   -   5        tipoBase�� 5�      �� 5�      .R�5�   "   �� $��txtBaseType��6�   
���   �% . ���	#FFE5E5E5#��[  6�   ��6f   �� $" BaseType�$# PropertyChanged=�6�   5�      $ 5�      �� 5�      .R�5�   "   �� $��txtBaseType��6�   
���   ����	#FFE5E5E5��6V   �� $" BaseType�$# PropertyChanged=�6�   5�      5�        5�      $ Cuenta��6-   $
 auto 6=   -   5        
cuenta�� 5�      �� 5�      .R�5�   "   �� $! 
txtAccount��6*   $��12(�6>   $��Stretch=�6L   
���   �#��[  6�   
�������$��0q�6�   $
��auto��6  % . ���	#FFE5E5E5��6}   �� $" Account�$# PropertyChanged=�6G  5�      $ 5�      �� 5�      .R�5�   "   �� $��
txtAccount��6�   
���   ����	#FFE5E5E5��6X   �� $" Account�$# PropertyChanged=�6�   5�      5�      5�      �� 5�      -   5        ( ��Name$( btnCrear��5�      $��OK��6'   $
��Left=�64   $��
31,317,0,0q�6O   $	��Top=�6c   $��95��6{   $��3q�6�   6�   �� 5�      -   5        $( btnCancelar��5�      $��Cancelar��6*   $
��Left=�6W   $��153,317,0,0q�6r   $	��Top=�6�   $��94��6�   $��3q�6�   
�������
�������6�   5�      5�      5�      