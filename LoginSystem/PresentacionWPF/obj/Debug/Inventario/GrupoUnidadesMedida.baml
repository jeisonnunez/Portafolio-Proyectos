   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	       Vista.GrupoUnidadesMedida   5      n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	      Vista.Document    Closing$  Window_Closing��5   g      Loaded$ Window_Loaded��6�    � Title$ GrupoUnidadesMedida��6	   $	��450��6%   $��703.044��62    � WindowStartupLocation$ CenterScreen=�6B    � 	Resources 5	         TextBlockStyleValidation �� 
TargetType �� Triggers P� Property P� Value	 �� Property
 �� Value �� NotifyOnValidationError �� RelativeSource �� UpdateSourceTrigger �� ValidatesOnDataErrors��%�   &	        �� 5
   
   " ��61    5      P� 5       �@=�HasError . . �5      �� 	 �@�ToolTip
 5      �� *%#(Validation.Errors)[0].ErrorContent+ .  �� *Self+$ PropertyChanged=� . 5      5      5      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgGrupoUnidadesMedidas��5      $��51,54,63.667,0q�63   $��1q�6L      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6`   
�������$	��277��6�      AutoGenerateColumns .     CanUserDeleteRows .     CanUserSortColumns .    SelectionMode$ Single=�6  $   HorizontalScrollBarVisibility$
 Auto=�65  "   VerticalScrollBarVisibility$
 Auto=�6Z  $	��Top=�6}     GridLinesVisibility$	 All=�6�     VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   SelectionUnit$ FullRow=�6�  ���	#FFE5E5E5 5        TaxTextBoxStyle �� Binding �� Value  TextBoxStyle��%�  &	       &	 \    �� 5      " ��60    5      �� 5       6&   �� *Locked+ N6A   .a�5      �� 	 �@��
IsReadOnly
 .  6;   �� 5      	 � ��
 �	#FF74C1FF6;   5      �� 5       6&   �� *Locked+ Y6A   .a�5      �� 	 �@��
IsReadOnly
 . 6;   �� 5       	 � ��
 �	#FF74C1FF6;   5#      5&      �� 5(      " ��6-   .�5)      �� 	 � ��
 �	#FF74C1FF63   5*      5+         	CellStyle 5/      �� 51      *  $System.Windows.Controls.DataGridCell"  6   .�52      �� 	 � ��$
 25��6/   �� 53      	 � ��$
 Center=�6C   �� 54      	 � ��$
 Center=�6A   �� 55      	 �@��TextAlignment$
 Center=�6@   �� 56      	 � ��$
 Center=�6:   �� 57      	 � ��$
 Center��60    5;      P� 5<       �@J�IsMouseOver . . �5>      �� 	 � ��
 �	#FF74C1FF5?   !   �� 5@      	 � ��

 �   �5A   !   5D      5I         RowStyle 5M      �� 5N      )  #System.Windows.Controls.DataGridRow"  6   .�5P      �� 	 �@�Tag
 5Q      �� *DataContext+ ��  �� AncestorType" ��� 5R      	 �@�ContextMenu
 5S      �� 5T        � DataContext  6*   �� *PlacementTarget.Tag+ �� *Self+.@�5V   "   m� $��Eliminar��6+   ! m� Command$ ! local:CustomCommands1.Exit��6=   5W      5Y       5\      P� 5]       �@J�IsMouseOver . . �5_      �� 	 � ��

 �����5`   !   �� 5a      	 � ��

 �   �5b   !   5d      " �� 	Resources" 5h      # �� Color��%�   (��       5i   *   * SystemColors.HighlightBrushKey+)(�� %     5j   *   *$"SystemColors.HighlightTextBrushKey+)�� 5i      $# Transparent��6\   �� 5j      $# Black��6`   5k      5n      $   Columns$ 5t      4  .System.Windows.Controls.DataGridTemplateColumn  5u      ,  &System.Windows.Controls.DataGridColumn%   Header$% Grupo��6)   -   5        	grupo��&   Width$& * 5u   I   '   CellTemplate' 5v      �� 5w      .R�5x      �� ( ��Name$( 
txtUgpCode��6�   #��[  6)   
���   �$y�Visible=�6  ��6z   �� ) �� Path$) UgpCode� . $ PropertyChanged=� . 6  5y      *   CellEditingTemplate* 5{      �� 5|      .R�5}      �� + ��Name$+ 
txtUgpCode��6�   -   5        
���   �#��[ 5}   |   $��0q�6�   
������ ��69   �� $) UgpCode�$ PropertyChanged=�6�   5~      5�        5�      $% Descripcion Grupo��6)   $& * 6D   -   5        descripcion��' 5�      �� 5�      .R�5�      �� $( 
txtUgpName��6�   #��[  6(   
���   ���6y   �� $) UgpName� . $ PropertyChanged=� . 6�   5�      * 5�      �� 5�      .R�5�      �� $+ 
txtUgpName��6�   
���   �#��[ 6|   ��69   �� $) UgpName�$ PropertyChanged=�6�   5�      5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,   
Visibility$, Hidden=�6k   1	  +System.Windows.Controls.DataGridBoundColumn- 	  Binding- 6%   �� $) UgpEntry�$ PropertyChanged=�6�     5�      $% Unidad Medida Base��6)   $& * 6F   -   5        
unidadBase��' 5�      �� 5�      .R�5�      �� $( 
txtBaseUom��6�   #��[  6)   
���   �$y�Visible=�6  ��6z   �� $) UomCode� . $ PropertyChanged=� . 6  5�      * 5�      �� 5�      .R�5�      �� $��bd��6]   $��1q�6%   
�������. �� CornerRadius$. 3��6L   ._�5�   "   ]� $��dp��6I   $��1��6,   $��1��69   $��Stretch=�6S   $��Stretch=�6q   .+�5�   &   �� $��
imgUomCode��6�   -   5        $��Right=�5�   o   $��lupa.png��6�   $��20��6�   $y�Visible=�6�   / � Cursor$
/ Hand��6�   �� 5�   &   $+ 
txtUomCode��6.   -   5        $��12(�5�   _   $��Stretch=�6m   
���   �#��[ 6�   
�������$��0q�6  $
��auto��60  ��6�   �� $) UomCode�$ PropertyChanged=�6@  5�   #   5�      5�      5�        5�      $, Hidden=�6j   - 6%   �� $) BaseUom�$ PropertyChanged=�6�   5�      �� 5�   
   -   5        0 ��Name$0 btnOk��5�      $��OK��6    $
��Left=�6-   $��
54,365,0,0q�6H   $	��Top=�6\   $��85��6t   $��3q�6   $��16(�6�   6�   �� 5�   
   -	   5        $0 btnCancelar��5�      $��Cancelar��6@   $
��Left=�6S   $��157,365,0,0q�6n   $	��Top=�6�   $��89��6�   $��3q�6�   $��16(�6�   
�������
�������6�   �� 5�   
   -
   5        $0 btnDefinicion��5�      $��
Definicion��6(   $
��Left=�6=   $��513,365,0,0q�6X   $	��Top=�6m   $	��118��6�   $��3q�6�   $��16(�6�   6�   5�      5�      