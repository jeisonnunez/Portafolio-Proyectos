   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	       Vista.ClasesImpuestos   5      n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	      Vista.Document    Closing$  Window_Closing��5   _      Loaded$ Window_Loaded��6x    � Title$ ClasesImpuestos��6	   $	��450��6!   $	��664��6.    � WindowStartupLocation$ CenterScreen=�6:    J� CommandBindings 5	      )  #System.Windows.Input.CommandBinding  5
   
   -   5           Command$ local:CustomCommands.Exit��5
      6a    � 	Resources 5         TextBlockStyleValidation �� 
TargetType �� Triggers	 P� Property
 P� Value �� Property �� Value �� RelativeSource �� Path �� UpdateSourceTrigger �� ValidatesOnDataErrors �� NotifyOnValidationError��%�   &	        �� 5   
   " ��61    5      P� 5      	 �@=�HasError
 . . �5      ��  �@�ToolTip 5      ��  �� *Self+$) #(Validation.Errors)[0].ErrorContent�$ PropertyChanged=� .  . 5      5      5      .��5      �� $
��Auto=�6   $
��Auto=�66   .��5   
   � $��Center=�6   $	��Top=�6,   $��0,10,0,0q�6D   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dgClasesImpuestos��5      ���	#FFE5E5E5$��1q�6I   
�������   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6u   $��Center=�6�   $	��311��6�   $��0,30,0,0q�6�   $	��Top=�6�   $	��575��6�      CanUserResizeRows .    CanUserSortColumns .    CanUserReorderColumns .    AutoGenerateColumns .     CanUserDeleteRows .  
���   �$��Center=�6�  $��Center=�6�     GridLinesVisibility$	 All=�6�     VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   SelectionMode$ Extended=�6O     SelectionUnit$ FullRow=�6h  ��6�  �� *ValidateErrorsClasesImpuestos+   	CellStyle 5      �� 5      *  $System.Windows.Controls.DataGridCell"  6    5      P� 5      	 �@J�IsMouseOver
 . . �5!   "   ��  � �� �	#FF74C1FF5"      �� 5#   "    � ��
 �   �5$      5'      .�5)      ��  � ��$ 30��63   6@   �� 5*       � ��$ Center=�6G   6X   �� 5+       � ��$ Center=�6E   6V   �� 5,       �@��TextAlignment$ Center=�6D   6U   �� 5-       � ��$ Center=�6H   6Y   5.         RowStyle 52      �� 53      )  #System.Windows.Controls.DataGridRow"  6    57      P� 58      	 �@J�IsMouseOver
 . . �5:   "   ��  � ��
 �����5;      5>        �� 	Resources  5@      ! �� Color��%�   (��       5A   .   * SystemColors.HighlightBrushKey+)(�� %     5B   .   *$"SystemColors.HighlightTextBrushKey+)�� 5A      $! Transparent��6`   �� 5B      $! Black��6d   5C      .�5E      ��  �@�Tag 5F      ��  �� " �� AncestorType"" �$ DataContext��� 5H       �@�ContextMenu 5I      �� 5J   "   # � DataContext# 6.   �� *PlacementTarget.Tag+ �� *Self+.@�5M   &   m� $��Eliminar��6/   $ m� Command$$ local:CustomCommands.Exit��6A   5N   #   5P      �� 5R       �@ ValidationErrorTemplate 6D   Z� 5T       5W        TextBoxStyle��%Z   &	       �� 5X      " ��61   .�5Y      ��  � �� �	#FF74C1FF6K   5Z      5[      %   Columns% 5\      4  .System.Windows.Controls.DataGridTemplateColumn  5]      ,  &System.Windows.Controls.DataGridColumn&   Header$& Codigo��6-   '   Width$
' auto 6=   -   5        
codigo��(   CellEditingTemplate( 5^      �� 5_      .R�5`   "   �� $��txtCodeCurrency��6�   
���   �#��[ 6}   ��6=   �� $
 Code�$ PropertyChanged=�6�   5a      )   CellTemplate) 5c      �� 5d      .R�5e   "   �� $��txtCodeCurrency��6�   #��[  6,   
���   ���6}   �� $
 Code�$ PropertyChanged=� .  . 6  5f      5i        5k      $& Nombre��6-   $
' auto 6=   -   5        name��( 5l      �� 5m      .R�5n   "   �� $��txtName��6�   
���   �#��[ 6|   ��6=   �� $
 Name�$ PropertyChanged=�6�   5o      ) 5q      �� 5r      .R�5s   "   �� $��txtName��6�   #��[  6,   
���   ���6}   �� $
 Name�$ PropertyChanged=� .  . 6  5t      5w        5y      $
& Tasa��6-   $
' auto 6;   -   5        tasa��( 5z      �� 5{      .R�5|   "   �� 
���   �#��[ 6|   ��6=   �� $
 Rate�$ PropertyChanged=�6�   5}      ) 5      �� 5�      .R�5�   "   �� #��[  6,   
���   ���6}   �� $
 Rate�$ PropertyChanged=� .  . 6�   5�      5�        5�      $& Cuenta Impuesto de Venta��6-   $
' auto 6O   -   5        salestax��( 5�      �� 5�      .R�5�   "   �� $��bd��6a   $��1q�6)   
�������* �� CornerRadius$* 3��6P   ._�5�   &   ]� $��dp��6M   $��1��60   $��1��6=   $��Stretch=�6W   $��Stretch=�6u   .+�5�   *   �� $	��img��6�   -   5        $��Right=�5�   l   $��lupa.png��6�   $��20��6�   $y�Visible=�6�   + � Cursor$
+ Hand��6�   �� 5�   *   , ��Name$, txtSalesTax��62   $��12(�6G   $��Stretch=�6U   
���   �#��[ 6�   
�������$��0q�6  $
��auto��6  ��6�   �� $ SalesTax�$ PropertyChanged=�6)  5�   '   5�   #   5�      ) 5�      �� 5�      .R�5�   "   �� $��txtSalesTax��6�   
���   �#��[  6?   ��6}   �� $ SalesTax�$ PropertyChanged=� .  . 6  5�      5�        5�      $& Cuenta Impuesto de Compra��6-   $
' auto 6P   -   5        purchtax��( 5�      �� 5�      .R�5�   "   �� $��bd��6a   $��1q�6)   
�������$* 3��6P   ._�5�   &   ]� $��dp��6M   $��1��60   $��1��6=   $��Stretch=�6W   $��Stretch=�6u   .+�5�   *   �� $��
imgPuchTax��6�   -	   5        $��Right=�5�   s   $��lupa.png��6�   $��20��6�   $y�Visible=�6�   $
+ Hand��6�   �� 5�   *   $, txtPurchTax��62   $��12(�6G   $��Stretch=�6U   
���   �
�������$��0q�6�   $
��auto��6�   ��6�   �� $ PurchTax�$ PropertyChanged=�6  5�   '   5�   #   5�      ) 5�      �� 5�      .R�5�   "   �� 
���   �#��[  6�   ��6?   �� $ PurchTax�$ PropertyChanged=� .  . 6�   5�      5�      5�      �� 5�      -
   5        - ��Name$- btnOk��5�      $��OK��6$   $
��Left=�61   $��	0,365,0,0q�6L   $	��Top=�6_   $��85��6w   $��3q�6�   $��16(�6�   6�   �� 5�      -   5        $- btnCancelar��5�      $��Cancelar��6*   $
��Left=�6=   $��104,365,0,0q�6X   $	��Top=�6m   $��89��6�   $��3q�6�   $��16(�6�   
�������
�������6�   5�      5�      5�      