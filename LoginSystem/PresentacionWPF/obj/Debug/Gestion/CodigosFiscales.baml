   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	   i9clr-namespace:Vista.Gestion.ValitadeErrorsCodigosFiscales+Vista.Gestion.ValitadeErrorsCodigosFiscales  6-       Vista.CodigosFiscales   5      n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	   Llocal29clr-namespace:Vista.Gestion.ValitadeErrorsCodigosFiscales     6-   -   5           Vista.Document   Name$  codigosFiscalesWindow��5   _      Vista.Document   Closing$ Window_Closing��6~      Loaded$ Window_Loaded��6�    � Title$ CodigosFiscales��6	   $	��450��6!   $	��800��6.    � WindowStartupLocation$ CenterScreen=�6:    � ContextMenu 5	      �� 5
   
   .@�5      m� -   5        $��Deleted��5      $��Eliminar��6&   5      5       � DataContext 5      O   IVista.Gestion.ValitadeErrorsCodigosFiscales.ValidateErrorsCodigosFiscales  5   
    � 	Resources 5         TextBlockStyleValidationV1 �� 
TargetType	 �� Property
 �� Value �� ElementName �� Path �� Triggers P� Property P� Value �� RelativeSource  TextBlockStyleValidation �� UpdateSourceTrigger �� ValidatesOnDataErrors �� NotifyOnValidationError��%P  &	        &	 L    �� 5   
   " ��63   .�5      �� 	 �@=�ErrorTemplate
 5      �� 5      .R�5      ]� ��. .+�5      �� $��Right=�6(   
��� ���$��5q�5      $
��12pt(�5      ��5      �� $ 	MyAdorner��$8 2AdornedElement.(Validation.Errors)[0].ErrorContent�5       �� 5"      
���  ��$��3q�67   ._�5#   "   �� $��	MyAdorner��6<   5$      5%      5&      5(       5)      P� 5*       �@=�HasError . . �5+      �� 	 �@�ToolTip
 5,      ��  �� *Self+$) #(Validation.Errors)[0].ErrorContent�5.      50      �� 51   
   " ��61    52      P� 53       �@=�HasError . . �54      �� 	 �@�ToolTip
 55      ��  �� *Self+$) #(Validation.Errors)[0].ErrorContent�$ PropertyChanged=� .  . 57      59      5;      .��5<      � .+�5=   
   �� -   5         ��Name$ imgleft��5=       � Cursor$
 Hand��6a   $��003-anterior-2.png��6o   $
��Left=�6�   $��28��6�   $��	377,6,0,0q�6�   $	��Top=�6�   $��31��6�   �� 5>   
   -   5        $ imgRight��5>      $
 Hand��6c   $��004-proximo.png��6q   $
��Left=�6�   $��28��6�   $��	417,6,0,0q�6�   $	��Top=�6�   $��31��6�    J� RenderTransformOrigin$ 1.296,0.488&�6�   �� 5?   
   -   5        $ imgCrear��5?      $
 Hand��6c   $��001-texto.png��6q   $
��Left=�6�   $��28��6�   $��	264,6,0,0q�6�   $	��Top=�6�   $��31��6�   $ 1.296,0.488&�6�   �� 5@   
   -   5        $ 	imgBuscar��5@      $
 Hand��6e   $��002-encontrar.png��6s   $
��Left=�6�   $��28��6�   $��	303,6,0,0q�6�   $	��Top=�6�   $��31��6�   $ 1.296,0.488&�6�   �� 5A   
   -   5        $ 	imgInicio��5A      $
 Hand��6e   $��001-anterior.png��6s   $
��Left=�6�   $��28��6�   $��	341,6,0,0q�6�   $	��Top=�6�   $��31��6�   $ 1.296,0.488&�6�   �� 5B   
   -   5        $ imgFin��5B      $
 Hand��6    $��002-anterior-1.png��6m   $
��Left=�6�   $��28��6�   $��	453,6,0,0q�6�   $	��Top=�6�   $��31��6�   $ 1.296,0.488&�6�   &   System.Windows.Controls.DataGrid  5C   
   -	   5          Name$ dgCodigosFiscales��5C      $��1q�6.   
�������   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6Z      CanUserResizeRows .    CanUserSortColumns .    CanUserReorderColumns .    AutoGenerateColumns .     CanUserAddRows .  $
��Left=�6�   $	��196��6  $��
32,150,0,0q�6  $	��Top=�6)  $	��730��6A     VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����    SelectionMode$  Single=�6�  !   SelectionUnit$! FullRow=�6�  "   CanUserDeleteRows" .  
���   �$��Center=�6&  $��Center=�6J  #   GridLinesVisibility$	# All=�6l  $   	CellStyle$ 5D      �� 5F      *  $System.Windows.Controls.DataGridCell"  6    5G      P� 5H       �@J�IsMouseOver . . �5J      �� 	 � ��
 �	#FF74C1FF5K      5P      .�5R      �� 	 � ��$
 30��6/   6<   �� 5S      	 � ��$
 Center=�6C   6T   �� 5T      	 � ��$
 Center=�6A   6R   �� 5U      	 �@��TextAlignment$
 Center=�6@   6Q   �� 5V      	 � ��$
 Center=�6D   6U   5W      %   RowStyle% 5[      �� 5\      )  #System.Windows.Controls.DataGridRow"  6    5]      P� 5^       �@J�IsMouseOver . . �5`      �� 	 � ��

 �����5a      5d      & �� 	Resources& 5f      ' �� Color��%�   (��       5g   *   * SystemColors.HighlightBrushKey+)(�� %     5h   *   *$"SystemColors.HighlightTextBrushKey+)�� 5g      $' Transparent��6\   �� 5h      $' Black��6`   5i      5k       5n        TextBoxStyle  TextBoxStyleNotReadOnly  TextBlockStyle( �� Binding) �� Value��%V  &	       &	 P     &	 �     �� 5o      " ��6-   .�5p      �� 	 � ��
 �	#FF74C1FF6G   5r      �� 5s      " ��68   .�5t      �� 	 � ��
 �	#FF74C1FF6G   5v      �� 5x      " ��6/    5z      �� 5{      ( 6&   �� $ 
DataSource�) N6J   .a�5|      �� 	 � ��

 �����6K   5}      5�      5�      *   Columns* 5�      4  .System.Windows.Controls.DataGridTemplateColumn  5�      ,	  &System.Windows.Controls.DataGridColumn+ 	  Header$+ Codigo��6)   -
   5        code��, 	  Width$, * 5�   G   -   CellTemplate- 5�      �� 5�      .R�5�      �� . ��Name$	. txt��6f   -   5        #��[ 5�   (   $��12(�6s   $��Stretch=�6�   
���   �$
��auto��6G  ��6�   �� $ 	Code_OSTA�$ PropertyChanged=� .  . 6W  5�      /   CellEditingTemplate/ 5�      �� 5�      .R�5�   "   �� $��bd��6a   $��1q�6)   
�������0 �� CornerRadius$0 3��6P   ._�5�   &   ]� $��dp��6M   $��1��60   $��1��6=   $��Stretch=�6W   $��Stretch=�6u   .+�5�   *   �� $	��img��6�   -   5        $��Right=�5�   l   $��lupa.png��6�   $��20��6�   $y�Visible=�6�   $
 Hand��6�   �� 5�   &   1 ��Name$	1 txt��6D   -   5        $��12(�5�   Q   $��Stretch=�6_   
���   �#��[ 6�   
�������$��0q�6  $
��auto��6$  ��6�   �� $ 	Code_OSTA�$ PropertyChanged=�64  5�   '   5�   #   5�      5�        5�      $, * 6)   $+ Nombre��63   -   5        name��2 	  
IsReadOnly2 . - 5�      �� 5�      .R�5�      ]� $��dp��6E   $��1��6(   $��1��65   ���	#FFE5E5E5$��Stretch=�6f   $��Stretch=�6�   .+�5�   "   �� $. txtName��6j   #��[ 6,   ���	#FFE5E5E5$��12(�6�   $��Stretch=�6�   $��0,0,0,-0.333q�6�   $��95��6�   ��6�   �� $ 	Name_OSTA�$ PropertyChanged=� .  . 6c  5�      5�      / 5�      �� 5�      .R�5�      �� $��txtName��6�   -   5        
���   �3 �� 
IsReadOnly3 . ���	#FFE5E5E5#��[ 5�   �   $��Stretch=�6�   $��Stretch=�6  $��Stretch=�6,  $��Stretch=�6Q  ��6x   �� $ 	Name_OSTA�$ PropertyChanged=�6w  5�      5�        5�      $, * 6)   $	+ T/C��63   -   5        TC��2 . - 5�      �� 5�      .R�5�      ]� $��dp��6Z   ��. $��1��6=   $��1��6J   ���	#FFE5E5E5$��Stretch=�6{   $��Stretch=�6�   .+�5�   &   �� $. txtRate��6o   #��[ 60   ���	#FFE5E5E5$��12(�6�   $��Stretch=�6�   $��Stretch=�6�   $��0,0,0,-0.333q�6�   $��95��6�   ��6  �� $ 	Rate_OSTA�$ PropertyChanged=� .  . 6�  5�      5�      5�        5�      $, * 6)   $+ Cuenta Impuesto Ventas��63   -   5        	ImpVentas��2 . - 5�      �� 5�      .R�5�      ]� $��dp��6E   $��1��6(   $��1��65   ���	#FFE5E5E5$��Stretch=�6f   $��Stretch=�6�   .+�5�   "   �� $. txtSalesTax��6k   #��[ 6,   ���	#FFE5E5E5$��12(�6�   $��Stretch=�6�   $��0,0,0,-0.333q�6�   $��95��6�   ��6�   �� $ SalesTax�$ PropertyChanged=� .  . 6g  5�      5�      5�        5�      $, * 6)   $+ Cuenta Impuesto Compras��63   -   5        
ImpCompras��2 . - 5�      �� 5�      .R�5�      ]� $��dp��6E   $��1��6(   $��1��65   ���	#FFE5E5E5$��Stretch=�6f   $��Stretch=�6�   .+�5�   "   �� $. txtPurchTax��6k   #��[ 6,   ���	#FFE5E5E5$��12(�6�   $��Stretch=�6�   $��0,0,0,-0.333q�6�   $��95��6�   ��6�   �� $ PurchTax�$ PropertyChanged=� .  . 6g  5�      5�      5�      5�      �� 5�   
   -   5        4 ��Name$4 btnOk��5�      $��Crear��6    $
��Left=�60   $��
32,365,0,0q�6K   $	��Top=�6_   $��85��6w   $��3q�6�   $��16(�6�   6�   �� 5�   
   -   5        $4 btnCancelar��5�      $��Cancelar��6>   $
��Left=�6Q   $��144,365,0,0q�6l   $	��Top=�6�   $��89��6�   $��3q�6�   $��16(�6�   
�������
�������6�   �� 5�   
   -   5        $. 	lblCodigo��5�      $
��Bold"�6'   $
��Left=�69   $��	34,35,0,0q�6T   $
��Wrap=�6g   $��Codigo��6{   $	��Top=�6�   �� 5�   
   -   5        $1 	txtCodigo��5�      $��1q�6%   
�������$
��Left=�6�   $��23��6�   $��	35,56,0,0q�6�   5 �� TextWrapping$
5 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6)  �� $
 Code�6 �� Mode$6 TwoWay=� . $ PropertyChanged=� . 7 � ToolTip7 5�      ��  �� *Self+$) #(Validation.Errors)[0].ErrorContent� . $ PropertyChanged=� . .��5�   �    5�      ��%^   '��       �� 5�      " ��6   .�5�      �� 	 �@��CornerRadius$
 3��65   5�      5�      .��6!   5�      �� 5�   
   -   5        $. 	lblNombre��5�      $
��Bold"�6'   $
��Left=�69   $��
176,35,0,0q�6T   $
��Wrap=�6h   $��Nombre��6|   $	��Top=�6�   �� 5�   
   -   5        $1 	txtNombre��5�      $��1q�6%   
�������$
��Left=�6�   $��23��6�   $��
177,56,0,0q�6�   $
5 Wrap=�6�   $	��Top=�6�   $	��286��6�   ��6'  �� $
 Name�$6 TwoWay=� . $ PropertyChanged=� . 7 5�      ��  �� *Self+$) #(Validation.Errors)[0].ErrorContent� . $ PropertyChanged=� . .��5�   �    5�      ��%^   '��       �� 5�      " ��6   .�5�      �� 	 �@��CornerRadius$
 3��65   5�      5�      .��6!   5�      �� 5�   
   -   5        $. lblTipoImpositivo��5�      $
��Bold"�6/   $
��Left=�6A   $��
486,35,0,0q�6\   $
��Wrap=�6p   $��Tipo Impositivo��6�   $	��Top=�6�   �� 5�   
   -   5        $1 txtTipoImpositivo��5�      $��1q�6-   
�������3 . $
��Left=�6k   $��23��6�   $��
487,56,0,0q�6�   $
5 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6�   �� $
 Rate�$6 TwoWay=� . $ PropertyChanged=� . 7 5�      ��  �� *Self+$) #(Validation.Errors)[0].ErrorContent� . $ PropertyChanged=� . .��5�   �    5�      ��%^   '��       �� 5�      " ��6   .�5�      �� 	 �@��CornerRadius$
 3��65   5�      5�      .��6!   5�      �� 5�   
   -   5        8 ��Name$8 	cbxVentas��5�      $��Ventas��5�   �   $
��Left=�6�   $��
486,97,0,0q�6�   $	��Top=�6�   $
��Bold"�6	  9 d� 	IsChecked9 5�   &   �� $ 
ValidForAR�$6 TwoWay=� . $ PropertyChanged=� . 7 5�      ��  �� *Self+$) #(Validation.Errors)[0].ErrorContent� . $ PropertyChanged=� . 5�   	  �� 5�   
   -   5        $8 
cbxCompras��5�      $��Compras��6@   $
��Left=�6R   $��
594,97,0,0q�6m   $	��Top=�6�   $
��Bold"�6�   9 6�   �� $ 
ValidForAP�$6 TwoWay=� . $ PropertyChanged=� . 7 5�      ��  �� *Self+$) #(Validation.Errors)[0].ErrorContent� . $ PropertyChanged=� . �� 5�   
   -   5        $8 cbxInactivo��5�      $��Inactivo��6A   $
��Left=�6T   $��
622,17,0,0q�6o   $	��Top=�6�   $
��Bold"�6�   9 6�   �� $ Lock1�$6 TwoWay=� . $ PropertyChanged=� . 7 5�      ��  �� *Self+$) #(Validation.Errors)[0].ErrorContent� . $ PropertyChanged=� . �� 5�   
   -   5        $. lblAlicuota��5�      $
��Bold"�6)   $
��Left=�6;   $��
34,119,0,0q�6V   $
��Wrap=�6j   $��Alicuota��6~   $	��Top=�6�   �� 5�   
   -   5        : ��Name$: 
cbAlicuota��5�   �     ComboBoxStyle#��[ 6�   $
��Left=�6�   $��100,113,0,0q�6�   $	��Top=�6  $	��133��6  $��26��6*  ; �� DisplayMemberPath$
; Code��66  < �� SelectedValuePath$
< Name��6O  = �� SelectedValue= 5�      �� $ Selected_U_IDA_Alicuota�$6 TwoWay=�$ PropertyChanged=� .  . 7 5�   p   ��  �� *Self+$) #(Validation.Errors)[0].ErrorContent�$ PropertyChanged=� .  . 5�   h  �� 5�   
   -    5        $. 	lblValido��5�      $
��Left=�6'   $��
376,97,0,0q�6B   $
��Wrap=�6V   $��Valido para��6j   $
��Bold"�6}   $	��Top=�6�   5�      5�      