   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  3    -Vista.TablaReconciliacionesInternasAnteriores   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Vista        Vista.Converter    Loaded$  Window_Loaded��   Closing$ Window_Closing�� � Title$- 'TablaReconciliacionesInternasAnteriores��$��662.777��$��1156.288�� � WindowStartupLocation$ CenterScreen=� � 	Resources     Vista.ConverterClosePeriod   ConverterClosePeriod��%   &	          .��� .+�&   System.Windows.Controls.DataGrid  -     Name$ dgHistorialReconciliacion��$��Normal"�$��1q�   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 
�������$
��Left=�$	��212��$��	77,64,0,0q�$	��Top=�$
��1012��   AutoGenerateColumns .     CanUserDeleteRows .  	   CanUserSortColumns	 .  
   SelectionMode$
 Single=�$   HorizontalScrollBarVisibility$
 Auto=�"   VerticalScrollBarVisibility$
 Auto=�$��Center=�$��Center=�   GridLinesVisibility$	 All=�   VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   SelectionUnit$ FullRow=����	#FFE5E5E5   	CellStyle ��  �� 
TargetType*  $System.Windows.Controls.DataGridCell"  .���  �� Property � �� �� Value$ 30����  � ��$ Center=���  � ��$ Center=���  �@��TextAlignment$ Center=���  � ��$ Center=���  � �� �	#FFE5E5E5   RowStyle �� )  #System.Windows.Controls.DataGridRow"   �� 	Resources  �� Color��%�   (��       * SystemColors.HighlightBrushKey+)(��      *$"SystemColors.HighlightTextBrushKey+)�� $ 	#FFE5E5E5���� $ Black��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width$	 110    Header$ Nro Reconciliacion��-   nroReconciliacion��  HeaderStyle   HeaderStyle# [    
IsReadOnly . 1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding �� *
ReconNum+ �� UpdateSourceTrigger$ PropertyChanged=� 	  ElementStyle �� " ��.���  �@��TextAlignment$ Center=�  $	 180 $ Importe Reconciliacion��-   importeReconciliacion��# [  .  �� *Total+$ PropertyChanged=� �� " ��.���  �@��TextAlignment$ Center=�  $	 140 $ Tipo Reconciliacion��# [ -   tipoReconciliacion�� .  �� *	ReconType+$ PropertyChanged=� �� " ��.���  �@��TextAlignment$ Center=�  $	 140 $ Fecha Reconciliacion��-   fechaReconciliacion��# [  .  �� *	ReconDate+$ PropertyChanged=� �� " ��.���  �@��TextAlignment$ Center=�  $	 130 $ Fecha Creacion��# [ -   fechaCreacion�� .  �� *
CreateDate+$ PropertyChanged=� �� " ��.���  �@��TextAlignment$ Center=�  $	 130 $  Nro Reconciliacion Anulado��# [ -   nroReconciliacionAnulado�� .  �� *	CancelAbs+$ PropertyChanged=� �� " ��.���  �@��TextAlignment$ Center=�  $	 130 $ Asiento Creado��# [ -   asientoCreado�� .  �� *	ReconJEId+$ PropertyChanged=� �� " ��.���  �@��TextAlignment$ Center=��� -	     ��Name$   lblHistorialReconciliacion��$��	Underline{�$��14(�$
��Left=�$��	77,17,0,0q�$
��Wrap=�$!��Historial de Reconciliacion��$
��Bold"�$	��Top=�  -
   $ dgDetallesReconciliacion��$��Normal"�$��1q�$ * 
�������$
��Left=�$	��212��$��
77,358,0,0q�$	��Top=�$
��1012�� .   .  	 .  $
 Single=�$
 Auto=�$
 Auto=�$��Center=�$��Center=�$	 All=�
 �����
 �����$ FullRow=����	#FFE5E5E5 �� "  .���  � ��$ 30����  � ��$ Center=���  � ��$ Center=���  �@��TextAlignment$ Center=���  � ��$ Center=���  � �� �	#FFE5E5E5 �� "   ��%�   (��       * SystemColors.HighlightBrushKey+)(��      *$"SystemColors.HighlightTextBrushKey+)�� $ 	#FFE5E5E5���� $ Black�� 4
  .System.Windows.Controls.DataGridTemplateColumn
  $ * $ Origen��-   
origen�� . # [ ! 
  CellTemplate! �� .R�]� $��dp��$��1��$��1��$��4.667,3.667,4.667,2.667q�$��Stretch=�$��Stretch=�.+��� $��imgSrcObjTyp��-   $
��Left=�$��004-proximo.png��$��20��$��15��$��0,0,0,-0.333q�" � Cursor$
" Hand���� $  txtSrcObjTyp��$��0,0,0,-0.333q�$��95��# �� TextAlignment$# Center=����� $ �� Path$$ 	SrcObjTyp�$ PropertyChanged=�  $ * $ 
Nro Origen��-   	nroOrigen��# [  .  �� *	SrcObjAbs+$ PropertyChanged=� �� " ��.���  �@��TextAlignment$ Center=�  $ * $ Cuenta /Codigo SN��# [ -   	shortName�� .  �� *	ShortName+$ PropertyChanged=� �� " ��.���  �@��TextAlignment$ Center=�  $ * $ Cuenta/Nombre SN��-   account��# [  .  �� *	Account+$ PropertyChanged=� �� " ��.���  �@��TextAlignment$ Center=�  $ * $ Importe Aplicado��# [ -   reconSum�� .  �� *
ReconSum+$ PropertyChanged=� �� " ��.���  �@��TextAlignment$ Center=��� -   $  lblDetallesReconciliacion��$��	Underline{�$��14(�$
��Left=�$��
77,311,0,0q�$
��Wrap=�$ ��Detalles de Reconciliacion��$
��Bold"�$	��Top=��� $��19��$��0,293,0.333,0q�$	��Top=�$��Stretch=�$��Stretch=��� -   % ��Name$% btnOk��$��OK��$
��Left=�$��136,584,0,0q�$	��Top=�$��94��$��3q��� -   $% btnCancelar��$��Cancelar��$
��Left=�$��253,584,0,0q�$	��Top=�$��94��$��3q�
�������
��������� -   & ��Name$& 	imgReturn��$2��,/Vista;component/Finanzas/003-anterior-2.png��$
" Hand��$y�Visible=�' J� RenderTransformOrigin$' 1.591,0.437&�$��40��$��75,584,0,16.333q�$
��Left=��� -   $% btnCancelarReconciliacion��$��Cancelar Reconciliacion��$
��Left=�$��935,584,0,0q�$	��Top=�$	��152��$��3q�{�.  