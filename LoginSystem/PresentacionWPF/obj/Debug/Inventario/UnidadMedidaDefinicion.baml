   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	   k:clr-namespace:Vista.Inventario.ModelUnidadMedidaDefinicion,Vista.Inventario.ModelUnidadMedidaDefinicion  6+   "    Vista.UnidadMedidaDefinicion   5      n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	   Mlocal1:clr-namespace:Vista.Inventario.ModelUnidadMedidaDefinicion     6+      Vista.Document    Closing$  Window_Closing��5   A      Loaded$ Window_Loaded��6Z    � Title$ UnidadMedidaDefinicion��6	   $	��450��6(   $	��800��65    � WindowStartupLocation$ CenterScreen=�6q    � DataContext 5	      N   HVista.Inventario.ModelUnidadMedidaDefinicion.ModelUnidadMedidaDefinicion  5
   
    � 	Resources 5         TextBlockStyleValidation �� 
TargetType �� Triggers P� Property	 P� Value
 �� Property �� Value �� NotifyOnValidationError �� RelativeSource �� UpdateSourceTrigger �� ValidatesOnDataErrors��%�   &	        �� 5   
   " ��61    5      P� 5       �@=�HasError	 . . �5      �� 
 �@�ToolTip 5      �� *%#(Validation.Errors)[0].ErrorContent+ .  �� *Self+$ PropertyChanged=� . 5      5      5      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgUnidadesMedidas��5         CanUserAddRows . $��36,45,42.333,0q�6E   $��1q�6^      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6r   
�������$	��277��6�      AutoGenerateColumns .     CanUserDeleteRows .     CanUserSortColumns .    SelectionMode$ Single=�6*  $   HorizontalScrollBarVisibility$
 Auto=�6B  "   VerticalScrollBarVisibility$
 Auto=�6g  $	��Top=�6�     GridLinesVisibility$	 All=�6�     VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   SelectionUnit$ FullRow=�6�  ���	#FFE5E5E5 5        TaxTextBoxStyle �� Binding �� Mode �� Value  TaxTextBlockBoxStyle  TextBoxStyle��%�  &	       &	 �     &	 [    �� 5      " ��60    5      �� 5       6&   ��  �� $ PreviousData=� 5      Z� .a�5       �� 
 �@��
IsReadOnly . 6;   5"      5$      �� 5&      " ��65    5(      �� 5)       6&   ��  �� $ PreviousData=� 5*      Z� .a�5+      �� 
 � ��
 �����6;   5-      5/      �� 51      " ��6-   .�52      �� 
 � �� �	#FF74C1FF63   53      54          	CellStyle  58      �� 5:      *  $System.Windows.Controls.DataGridCell"  6   .�5;      �� 
 � ��$ 25��6/   �� 5<      
 � ��$ Center=�6C   �� 5=      
 � ��$ Center=�6A   �� 5>      
 �@��TextAlignment$ Center=�6@   �� 5?      
 � ��$ Center=�6:   �� 5@      
 � ��$ Center��60    5D      P� 5E       �@J�IsMouseOver	 . . �5G      �� 
 � �� �	#FF74C1FF5H   !   �� 5I      
 � ��
 �   �5J   !   5M      5R      !   RowStyle! 5V      �� 5W      )  #System.Windows.Controls.DataGridRow"  6   .�5Y      �� 
 �@�Tag 5Z      �� *DataContext+ �� " �� AncestorType"" ��� 5[      
 �@�ContextMenu 5\      �� 5]       6*   �� *PlacementTarget.Tag+ �� *Self+.@�5_   "   m� $��Eliminar��6+   # m� Command$ # local:CustomCommands1.Exit��6=   5`      5b       5e      P� 5f       �@J�IsMouseOver	 . . �5h      �� 
 � ��
 �����5i   !   �� 5j      
 � ��
 �   �5k   !   5m      $ �� 	Resources$ 5q      % �� Color��%�   (��       5r   *   * SystemColors.HighlightBrushKey+)(�� %     5s   *   *$"SystemColors.HighlightTextBrushKey+)�� 5r      $% Transparent��6\   �� 5s      $% Black��6`   5t      5v      &   Columns& 5}      4  .System.Windows.Controls.DataGridTemplateColumn  5~      ,  &System.Windows.Controls.DataGridColumn'   Header$' Codigo Unidad��6)   -   5        
codigo��(   Width$( * 5~   Q   )   CellTemplate) 5      �� 5�      .R�5�      �� * ��Name$* 
txtUomCode��6�   #��[  6)   
���   �$y�Visible=�6  ��6z   �� + �� Path$+ UomCode� . $ PropertyChanged=� . 6  5�      ,   CellEditingTemplate, 5�      �� 5�      .R�5�      �� - ��Name$- 
txtUomCode��6�   -   5        
���   �#��[ 5�   |   $��0q�6�   
������ ��69   �� $+ UomCode�$ PropertyChanged=�6�   5�      5�        5�      $' Nombre Unidad��6)   -   5        nombreUnidad��$( * 5�   W   ) 5�      �� 5�      .R�5�      �� $* 
txtUomName��6�   #��[  6(   
���   ���6y   �� $+ UomName� . $ PropertyChanged=� . 6�   5�      , 5�      �� 5�      .R�5�      �� $- 
txtUomName��6�   -   5        
���   �#��[ 5�   |   $��0q�6�   
������ ��69   �� $+ UomName�$ PropertyChanged=�6�   5�      5�        5�      $' Longitud��6)   -   5        longitud��$( * 5�   N   ) 5�      �� 5�      .R�5�      �� $* 
txtLength1��6�   #��[  6(   
���   ���6y   �� $+ Length� . $ PropertyChanged=� . 6�   5�      , 5�      �� 5�      .R�5�      �� $- 
txtLength1��6�   
���   �#��[ 6{   ��69   �� $+ Length�$ PropertyChanged=�6�   5�      5�        5�      $' Ancho��6)   -   5        	ancho��$( * 5�   H   ) 5�      �� 5�      .R�5�      �� $* 	txtWidth1��6�   
���   �#��[  6�   ��6;   �� $+ Width� . $ PropertyChanged=� . 6�   5�      , 5�      �� 5�      .R�5�      �� $- 	txtWidth1��6�   
���   �#��[ 6z   ��69   �� $+ Width�$ PropertyChanged=�6�   5�      5�        5�      $' Altura��6)   -   5        
altura��$( * 5�   J   ) 5�      �� 5�      .R�5�      �� $* 
txtHeight1��6�   
���   �#��[  6;   ��6y   �� $+ Height� . $ PropertyChanged=� . 6�   5�      , 5�      �� 5�      .R�5�      �� $- 
txtHeight1��6�   
���   �#��[ 6{   ��69   �� $+ Height�$ PropertyChanged=�6�   5�      5�        5�      $' Volumen��6)   -	   5        volumen��$( * 5�   L   ) 5�      �� 5�      .R�5�      �� $* 	txtVolume��6�   
���   �#��[  6;   ��6y   �� $+ Volume� . $ PropertyChanged=� . 6�   5�      , 5�      �� 5�      .R�5�      �� $- 	txtVolume��6�   
���   �#��[ 6{   ��69   �� $+ Volume�$ PropertyChanged=�6�   5�      5�        5�      $' Unidad Medida��6)   -
   5        unidadVolumen��$( * 5�   X   ) 5�      �� 5�      .R�5�      �� $* 
txtVolUnit��6�   
���   �#��[  6�   ��6<   �� $+ VolUnit� . $ PropertyChanged=� . 6�   5�      , 5�      �� 5�      .R�5�      �� . �� 
IsEditable. .  / �� 
IsReadOnly/ . 
���   �  ComboBoxStyle#��[ 6*  ��6'   �� $+ VolUnitList�0 �� Mode$0 TwoWay=�1 �� SelectedValue1 6\   �� $+ VolUnit�$ PropertyChanged=�2 �� SelectedItem2 6�   �� $+ VolUnit�$ PropertyChanged=�6S  5�      5�        5�      $
' Peso��6)   -   5        peso��$( * 5�   F   ) 5�      �� 5�      .R�5�      �� $* 
txtWeight1��6�   
���   �#��[  6;   ��6y   �� $+ Weight� . $ PropertyChanged=� . 6�   5�      , 5�      �� 5�      .R�5�      �� $- 
txtWeight1��6�   
���   �#��[ 6{   ��69   �� $+ Weight�$ PropertyChanged=�6�   5�      5�      5�      �� 5�   
   -   5        3 ��Name$3 btnOk��5�      $��OK��6    $
��Left=�6-   $��
40,356,0,0q�6H   $	��Top=�6\   $	��101��6t   $��3q�6�   $��16(�6�   6�   �� 5�   
   -   5        $3 btnCancelar��5�      $��Cancelar��6@   $
��Left=�6S   $��162,356,0,0q�6n   $	��Top=�6�   $	��107��6�   $��3q�6�   $��16(�6�   
�������
�������6�   5�      5�      