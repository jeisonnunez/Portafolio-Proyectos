   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	   Y1clr-namespace:Vista.Gestion.ValidateErrorsMonedas#Vista.Gestion.ValidateErrorsMonedas  6+       Vista.Monedas   5      n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	   Dlocal11clr-namespace:Vista.Gestion.ValidateErrorsMonedas     6+      Vista.Document    Closing$  Window_Closing��5   _      Loaded$ Window_Loaded��6x    � Title$ Monedas��6	   $��452.383��6   $��466.202��6*    � WindowStartupLocation$ CenterScreen=�6:    J� CommandBindings 5	      )  #System.Windows.Input.CommandBinding  5
   
   -   5           Command$  local:CustomCommands1.Exit��5
      6b    � DataContext 5      ?   9Vista.Gestion.ValidateErrorsMonedas.ValidateErrorsMonedas  5   
    � 	Resources 5         TextBlockStyleValidation �� 
TargetType	 �� Triggers
 P� Property P� Value �� Property �� Value �� RelativeSource �� Path �� UpdateSourceTrigger �� ValidatesOnDataErrors �� NotifyOnValidationError��%�   &	        �� 5   
   " ��61   	 5      P� 5      
 �@=�HasError . . �5      ��  �@�ToolTip 5      ��  �� *Self+$) #(Validation.Errors)[0].ErrorContent�$ PropertyChanged=� .  . 5      5      5      .��5      �� $
��Auto=�6   $
��Auto=�66   .��5   
   � $��Center=�6   $	��Top=�6,   $��0,10,0,0q�6D   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dgMoneda��5      $��0,20,0,0q�6)   $��1q�6<      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6P   
�������$	��311��6z   $	��374��6�      AutoGenerateColumns .     CanUserDeleteRows .     CanUserSortColumns .    SelectionMode$ Single=�6  $   HorizontalScrollBarVisibility$
 Auto=�6$  "   VerticalScrollBarVisibility$
 Auto=�6I  $	��Top=�6l     GridLinesVisibility$	 All=�6�     VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   SelectionUnit$ FullRow=�6�  ���	#FFE5E5E5   	CellStyle 5      �� 5!      *  $System.Windows.Controls.DataGridCell"  6   	 5"      P� 5#      
 �@J�IsMouseOver . . �5%   "   ��  � �� �	#FF74C1FF5&      �� 5'   "    � ��
 �   �5(      5+      .�5-      ��  � ��$ 25��63   6@   �� 5.       � ��$ Center=�6G   6X   �� 5/       � ��$ Center=�6E   6V   �� 50       �@��TextAlignment$ Center=�6D   6U   �� 51       � ��$ Center=�6H   6Y   �� 52       � ��$ Center��64   6E   56          RowStyle  5:      �� 5;      )  #System.Windows.Controls.DataGridRow"  6   	 5<      P� 5=      
 �@J�IsMouseOver . . �5?   "   ��  � ��
 �����5@      �� 5A   "    � ��
 �   �5B      5D      .�5I      ��  �@�Tag 5J      ��  �� ! �� AncestorType"! �$ DataContext��� 5L       �@�ContextMenu 5M      �� 5N   "    6.   �� *PlacementTarget.Tag+ �� *Self+.@�5Q   &   m� $��Eliminar��6/   " m� Command$ " local:CustomCommands1.Exit��6A   5R   #   5T      5W       5Z        TaxTextBoxStyle# �� Binding$ �� Value  TextBoxStyle��%�  &	       &	 Z    �� 5[      " ��64   	 5]      �� 5^      # 6*   �� $ Locked�$ N6J   .a�5_   "   ��  �@��
IsReadOnly .  6?   �� 5`   "    � �� �	#FF74C1FF6S   5a      �� 5b      # 6*   �� $ Locked�$ Y6J   .a�5c   "   ��  �@��
IsReadOnly . 6?   �� 5d   "    � ��
 � � �6O   5g      5j      �� 5l      " ��61   .�5m      ��  � �� �	#FF74C1FF6K   5n      5o      %   Columns% 5s      4  .System.Windows.Controls.DataGridTemplateColumn  5t      ,	  &System.Windows.Controls.DataGridColumn& 	  Header$& Codigo��6-   -   5        
codigo��'   CellTemplate' 5u      �� 5v      .R�5w   "   �� $��txtCodeCurrency��6�   #��[  6-   
���   �$y�Visible=�6  ��6~   �� $ CurrCode�$ PropertyChanged=� .  . 6)  5x      (   CellEditingTemplate( 5z      �� 5{      .R�5|   "   �� $��txtCodeCurrency��6�   -   5        
���   �#��[ 5|   �   $��0q�6�   
������ ��6=   �� $ CurrCode�$ PropertyChanged=�6  5}      5        5�      $& Moneda��6-   -   5        
moneda��' 5�      �� 5�      .R�5�   "   �� $��txtCodeCurrency��6�   #��[  6,   
���   ���6}   �� $ CurrName�$ PropertyChanged=� .  . 6  5�      ( 5�      �� 5�      .R�5�   "   �� $��txtCodeCurrency��6�   
���   �#��[ 6�   ��6=   �� $ CurrName�$ PropertyChanged=�6�   5�      5�        5�      $& Codigo Internacional��6-   -   5        codigointernacional��' 5�      �� 5�      .R�5�   "   �� $��txtCodeCurrency��6�   #��[  6,   
���   ���6}   �� $ 
DocCurrCod�$ PropertyChanged=� .  . 6  5�      ( 5�      �� 5�      .R�5�   "   �� $��txtCodeCurrency��6�   
���   �#��[ 6�   ��6=   �� $ 
DocCurrCod�$ PropertyChanged=�6�   5�      5�      5�      �� 5�      -   5        ) ��Name$) btnOk��5�      $��OK��6$   $
��Left=�61   $��	0,365,0,0q�6L   $	��Top=�6_   $��85��6w   $��3q�6�   $��16(�6�   6�   �� 5�      -   5        $) btnCancelar��5�      $��Cancelar��6B   $
��Left=�6U   $��103,365,0,0q�6p   $	��Top=�6�   $��89��6�   $��3q�6�   $��16(�6�   
�������
�������6�   5�      5�      5�      