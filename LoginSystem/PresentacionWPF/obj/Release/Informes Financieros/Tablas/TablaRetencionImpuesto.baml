   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  "    Vista.TablaRetencionImpuesto   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Vista        Vista.Document    Loaded$  Document_Loaded��   Closing$ Document_Closing�� � Title$ TablaRetencionImpuesto��$��403.14��$	��895��.���� $
��Auto=�$
��Auto=�.��� $��Center=�$	��Top=�.+�&   System.Windows.Controls.DataGrid  -     Name$ dgRetenciones��$��1q�   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 
�������$
��Left=�$	��236��$��	25,54,0,0q�$	��Top=�$	��839��   AutoGenerateColumns .     CanUserDeleteRows .     CanUserSortColumns .    SelectionMode$ Single=�$	   HorizontalScrollBarVisibility$
	 Auto=�"
   VerticalScrollBarVisibility$

 Auto=�$��Center=�$��Center=�   GridLinesVisibility$	 All=�   VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   SelectionUnit$ FullRow=�   CanUserAddRows .    	CellStyle ��  �� 
TargetType*  $System.Windows.Controls.DataGridCell"   �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ���  �� Property � �� �� Value �	#FF74C1FF��  � ��
 �   �.���  � ��$ 30����  � ��$ Center=���  � ��$ Center=���  �@��TextAlignment$ Center=���  � ��$ Center=�   RowStyle �� )  #System.Windows.Controls.DataGridRow"   P�  �@J�IsMouseOver . . ���  � ��
 ����� �� 	Resources  �� Color��%�   (��       * SystemColors.HighlightBrushKey+)(��      *$"SystemColors.HighlightTextBrushKey+)�� $ Transparent���� $ Black�� � 	Resources    TextBoxStyle��%5   &	        �� " ��.���  � �� �	#FF74C1FF   Columns 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Codigo��   Width$
 auto -   
codigo��   CellEditingTemplate �� .R��� $��bd��$��1q�
������� �� CornerRadius$ 3��._�]� $��dp��$��1��$��1��$��Stretch=�$��Stretch=�.+��� $��	imgWTCode��-   $��Right=�$��lupa.png��$��20��$y�Visible=�  � Cursor$
  Hand���� ! ��Name$! 	txtWTCode��-   $��12(�$��Stretch=�
���   �#��[  
�������$��0q�$
��auto������ " �� Path$" WTCode�# �� UpdateSourceTrigger$# PropertyChanged=�$   CellTemplate$ �� .R��� $��	txtWTCode��
���   ����� $" WTCode�$# PropertyChanged=�  $ Nombre��$
 auto -   
nombre�� �� .R��� $! 	txtWTName��% �� 
IsReadOnly% . ���	#FFE5E5E5$��12(�$��Stretch=�
���   �#��[  
�������$��0q�$
��auto������ $" WTName�$# PropertyChanged=�$ �� .R��� $��	txtWTName��
���   ����	#FFE5E5E5���� $" WTName�$# PropertyChanged=�  $
 Tasa��$
 auto -   tasa�� �� .R��� $��txtRate��
���   �% . ���	#FFE5E5E5#��[  ���� $
" Rate�& �� StringFormat$& 
{0:#,0.00}��$# PropertyChanged=�$ �� .R��� $��txtRate��
���   ����	#FFE5E5E5���� $
" Rate�$& 
{0:#,0.00}��$# PropertyChanged=�  $ Importe Base��$
 auto -   importebase�� �� .R��� $��txtBaseAmnt��
���   �% . ���	#FFE5E5E5#��[  ���� $" BaseAmnt�$& 
{0:#,0.00}��$# PropertyChanged=�$ �� .R��� $��txtBaseAmnt��
���   ����	#FFE5E5E5���� $" BaseAmnt�$& 
{0:#,0.00}��$# PropertyChanged=�  $ Importe Base FC��$
 auto -   importebaseFC��'   
Visibility$' Hidden=� �� .R��� $��txtBaseAmntFC��
���   �% . ���	#FFE5E5E5#��[  ���� $" 
BaseAmntFC�$& 
{0:#,0.00}��$# PropertyChanged=�$ �� .R��� $��txtBaseAmntFC��
���   ����	#FFE5E5E5���� $" 
BaseAmntFC�$& 
{0:#,0.00}��$# PropertyChanged=�  $ 
PrctBsAmnt��$
 auto -	   
PrctBsAmnt��$' Hidden=� �� .R��� $! txtPrctBsAmnt��% . ���	#FFE5E5E5$��12(�$��Stretch=�
���   �#��[  
�������$��0q�$
��auto������ $" 
PrctBsAmnt�$# PropertyChanged=�$ �� .R��� $��txtPrctBsAmnt��
���   ����	#FFE5E5E5���� $" 
PrctBsAmnt�$& 
{0:#,0.00}��$# PropertyChanged=�  $ Imp. Sujeto a Retencion��$
 auto -
   importeSujeto��$' Visible=� �� .R��� $��txtTaxbleAmnt��-   
���   �#��[  ���� $" 
TaxbleAmnt�$& 
{0:#,0.00}��$# PropertyChanged=�$ �� .R��� $��txtTaxbleAmnt��
���   ����� $" 
TaxbleAmnt�$& 
{0:#,0.00}��$# PropertyChanged=�  $ Imp. Sujeto a RetencionFC��$
 auto -   importeSujetoFC��$' Hidden=� �� .R��� $��txtTaxbleAmntFC��-   
���   �#��[  ���� $" TaxbleAmntFC�$& 
{0:#,0.00}��$# PropertyChanged=�$ �� .R��� $��txtTaxbleAmntFC��
���   ����� $" TaxbleAmntFC�$& 
{0:#,0.00}��$# PropertyChanged=�  $ WImpte. Retencion��$
 auto -   wimporte�� �� .R��� $��	txtWTAmnt��-   
���   �#��[  ���� $" WTAmnt�$& 
{0:#,0.00}��$# PropertyChanged=�$ �� .R��� $��	txtWTAmnt��
���   ����� $" WTAmnt�$& 
{0:#,0.00}��$# PropertyChanged=�  $ WImpte. RetencionFC��$
 auto -   
wimporteFC��$' Hidden=� �� .R��� $��txtWTAmntFC��-   
���   �#��[  ���� $" WTAmntFC�$& 
{0:#,0.00}��$# PropertyChanged=�$ �� .R��� $��txtWTAmntFC��
���   ����� $" WTAmntFC�$& 
{0:#,0.00}��$# PropertyChanged=�  $ 	Categoria��$
 auto -   	categoria�� �� .R��� $��txtCategory��
���   �% . ���	#FFE5E5E5#��[  ���� $" Category�$# PropertyChanged=�$ �� .R��� $��txtCategory��
���   ����	#FFE5E5E5���� $" Category�$# PropertyChanged=�  $ 	Tipo Base��$
 auto -   tipoBase�� �� .R��� $��txtBaseType��
���   �% . ���	#FFE5E5E5#��[  ���� $" BaseType�$# PropertyChanged=�$ �� .R��� $��txtBaseType��
���   ����	#FFE5E5E5���� $" BaseType�$# PropertyChanged=�  $ Cuenta��$
 auto -   
cuenta�� �� .R��� $! 
txtAccount��$��12(�$��Stretch=�
���   �#��[  
�������$��0q�$
��auto��% . ���	#FFE5E5E5���� $" Account�$# PropertyChanged=�$ �� .R��� $��
txtAccount��
���   ����	#FFE5E5E5���� $" Account�$# PropertyChanged=��� -   ( ��Name$( btnCrear��$��OK��$
��Left=�$��
31,317,0,0q�$	��Top=�$��95��$��3q��� -   $( btnCancelar��$��Cancelar��$
��Left=�$��153,317,0,0q�$	��Top=�$��94��$��3q�
�������
�������