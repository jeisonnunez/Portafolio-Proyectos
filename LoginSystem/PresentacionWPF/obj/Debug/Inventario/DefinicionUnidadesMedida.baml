   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	   $    Vista.DefinicionUnidadesMedida   5      n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	      Vista.Document    Closing$  Window_Closing��5   l      Loaded$ Window_Loaded��6�    � Title$ DefinicionUnidadesMedida��6	   $	��450��6*   $��821.077��67    � WindowStartupLocation$ CenterScreen=�6G    � 	Resources 5	         TextBlockStyleValidation �� 
TargetType �� Triggers P� Property P� Value	 �� Property
 �� Value �� NotifyOnValidationError �� RelativeSource �� UpdateSourceTrigger �� ValidatesOnDataErrors �� Binding �� Path �� Value��%_  &	        �� 5
   
   " ��61    5      P� 5       �@=�HasError . . �5      �� 	 �@�ToolTip
 5      �� *%#(Validation.Errors)[0].ErrorContent+ .  �� *Self+$ PropertyChanged=� . 5      �� 5       6   �� $ LineNum� 16?   .a�5      �� 	 � ��

 �����6G   5      5      5      .��5      �  %� VirtualizationMode$ Standard=�6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$! dgDefinicionUnidadesMedidas��5         CanUserAddRows . $��51,55,48.667,0q�6N   $��1q�6g      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6{   
�������$	��277��6�      AutoGenerateColumns .     CanUserDeleteRows .     CanUserSortColumns .    SelectionMode$ Single=�6=  $   HorizontalScrollBarVisibility$
 Auto=�6U  "   VerticalScrollBarVisibility$
 Auto=�6z  $	��Top=�6�     GridLinesVisibility$	 All=�6�     VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   SelectionUnit$ FullRow=�6  ���	#FFE5E5E5 5        TextBoxStyleReadOnly  TextBoxStyle��%U  &	       &	 �     �� 5      " ��65   .�5      �� 	 � ��
 �	#FF74C1FF6G    5      �� 5        6&   �� $ LineNum� 16G   .a�5!      �� 	 �@��
IsReadOnly
 . 6;   �� 5"      	 � ��

 �����6O   5#      5'      �� 5)      " ��6-   .�5*      �� 	 � ��
 �	#FF74C1FF63   5+      5,          	CellStyle  50      �� 52      *  $System.Windows.Controls.DataGridCell"  6   .�53      �� 	 � ��$
 25��6/   �� 54      	 � ��$
 Center=�6C   �� 55      	 � ��$
 Center=�6A   �� 56      	 �@��TextAlignment$
 Center=�6@   �� 57      	 � ��$
 Center=�6:   �� 58      	 � ��$
 Center��60    5<      P� 5=       �@J�IsMouseOver . . �5?      �� 	 � ��
 �	#FF74C1FF5@   !   �� 5A      	 � ��

 �   �5B   !   5E      5J      !   RowStyle! 5N      �� 5O      )  #System.Windows.Controls.DataGridRow"  6   .�5Q      �� 	 �@�Tag
 5R      �� *DataContext+ �� " �� AncestorType"" ��� 5S      	 �@�ContextMenu
 5T      �� 5U      # � DataContext# 6*   �� *PlacementTarget.Tag+ �� *Self+.@�5W   "   m� $��Eliminar��6+   $ m� Command$ $ local:CustomCommands1.Exit��6=   5X      5Z       5]      P� 5^       �@J�IsMouseOver . . �5`      �� 	 � ��

 �����5a   !   �� 5b      	 � ��

 �   �5c   !   5e      % �� 	Resources% 5j      & �� Color��%�   (��       5k   *   * SystemColors.HighlightBrushKey+)(�� %     5l   *   *$"SystemColors.HighlightTextBrushKey+)�� 5k      $& Transparent��6\   �� 5l      $& Black��6`   5m      5p      '   Columns' 5v      4  .System.Windows.Controls.DataGridTemplateColumn  5w      ,  &System.Windows.Controls.DataGridColumn(   Header$( Cantidad Alt��6)   -   5        	grupo��)   Width$) * 5w   O   *   CellTemplate* 5x      �� 5y      .R�5z      �� + ��Name$+ 	txtAltQty��6�   #��[  6(   
���   �$y�Visible=�6  ��6y   �� $ AltQty� . $ PropertyChanged=� . 6  5{      ,   CellEditingTemplate, 5}      �� 5~      .R�5      �� - ��Name$- 	txtAltQty��6�   -   5        
���   �#��[ 5   {   $��0q�6�   ��69   �� $ AltQty�$ PropertyChanged=�6�   5�      5�        5�      $( Unidad Medida Alt��6)   -   5        unidadMedidaAlt��$) * 5�   ^   * 5�      �� 5�      .R�5�      �� $+ 
txtUomCode��6�   #��[  6(   
���   ���6z   �� $ UomCode� . $ PropertyChanged=� . 6�   5�      , 5�      �� 5�      .R�5�      �� $��bd��6]   $��1q�6%   
�������. �� CornerRadius$. 3��6L   ._�5�   "   ]� $��dp��6I   $��1��6,   $��1��69   $��Stretch=�6S   $��Stretch=�6q   .+�5�   &   �� $��
imgUomCode��6�   -   5        $��Right=�5�   o   $��lupa.png��6�   $��20��6�   $y�Visible=�6�   / � Cursor$
/ Hand��6�   �� 5�   &   $- 
txtUomCode��6.   -   5        $��12(�5�   _   $��Stretch=�6m   
���   �#��[ 6�   
�������$��0q�6#  $
��auto��68  ��6�   �� $ UomCode�$ PropertyChanged=�6H  5�   #   5�      5�      5�      0  *System.Windows.Controls.DataGridTextColumn  5�      $) * 6%   $( =��6/   -   5        
nombre��0   
IsReadOnly0 . 1 �� TextAlignment$
1 Left=�5�   ^   1	  +System.Windows.Controls.DataGridBoundColumn2 	  ElementStyle2 5�      �� 5�      " ��6    .�5�      �� 	 � ��$
 =��65   5�      5�        5�      $( Cantidad Base��6)   -   5        cantidadBase��$) * 5�   W   * 5�      �� 5�      .R�5�      �� $+ 
txtBaseQty��6�   #��[  6(   
���   ���6z   �� $ BaseQty� . $ PropertyChanged=� . 6�   5�      , 5�      �� 5�      .R�5�      �� $- 
txtBaseQty��6�   
���   �#��[ 6|   ��69   �� $ BaseQty�$ PropertyChanged=�6�   5�      5�        5�      $
) auto 6%   $( Unidad Medida Base��62   -	   5        
unidadBase��0 . $
1 Left=�5�   v   5�        5�      $
) auto 6)   3   
Visibility$3 Hidden=�67   * 5�      �� 5�      .R�5�      �� $��txtUomEntry��6   
���   ���6<   �� $ UomEntry�$ PropertyChanged=�6�   5�      5�      5�      �� 5�   
   -
   5        4 ��Name$4 btnOk��5�      $��OK��6    $
��Left=�6-   $��
55,365,0,0q�6H   $	��Top=�6\   $	��101��6t   $��3q�6�   $��16(�6�   6�   �� 5�   
   -   5        $4 btnCancelar��5�      $��Cancelar��6@   $
��Left=�6S   $��177,365,0,0q�6n   $	��Top=�6�   $	��107��6�   $��3q�6�   $��16(�6�   
�������
�������6�   5�      5�      