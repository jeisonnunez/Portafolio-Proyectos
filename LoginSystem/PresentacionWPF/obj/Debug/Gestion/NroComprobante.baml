   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	   g8clr-namespace:Vista.Gestion.ValidateErrorsNroComprobante*Vista.Gestion.ValidateErrorsNroComprobante  6+       Vista.NroComprobante   5      n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	   Klocal18clr-namespace:Vista.Gestion.ValidateErrorsNroComprobante     6+      Vista.Document    Loaded$  Window_Loaded��5   b      Closing$ Window_Closing��6y    � Title$ NroComprobante��6	   $��447.333��6    $	��680��61    � WindowStartupLocation$ CenterScreen=�6=    J� CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ local:CustomCommands.Exit��5      6a    � DataContext 5      M   GVista.Gestion.ValidateErrorsNroComprobante.ValidateErrorsNroComprobante  5   
    � 	Resources 5         TextBlockStyleValidation �� 
TargetType	 �� Triggers
 P� Property P� Value �� Property �� Value �� RelativeSource �� Path �� UpdateSourceTrigger �� ValidatesOnDataErrors �� NotifyOnValidationError  CheckBoxStyle  ComboBoxStyles��%�  &	        &	 �     &	 �    �� 5   
   " ��61   	 5      P� 5      
 �@=�HasError . . �5      ��  �@�ToolTip 5      ��  �� *Self+$) #(Validation.Errors)[0].ErrorContent�$ PropertyChanged=� .  . 5      5      �� 5#   
   " ��6&   	 5%      P� 5'      
 �@=�HasError . . �5)      ��  �@�ToolTip 5*      ��  �� *Self+$) #(Validation.Errors)[0].ErrorContent�5-      51      �� 52   
   " ��6'   	 54      P� 56      
 �@=�HasError . . �58      ��  �@�ToolTip 59      ��  �� *Self+$) #(Validation.Errors)[0].ErrorContent�5<      5@      5B      .��5C      �� $
��Auto=�6   $
��Auto=�66   .��5D   
   � $��Center=�6   $	��Top=�6,   $��0,20,0,0q�6D   .+�5F      &   System.Windows.Controls.DataGrid  -   5          Name$ dgComprobante��5F      $��1q�6h   
�������   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�      SelectionMode$ Single=�6�      SelectionUnit$ FullRow=�6�      GridLinesVisibility$	 All=�6�      VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   AutoGenerateColumns .  $
��Left=�6G  $	��311��6b  $	��Top=�6p  $	��566��6�     CanUserResizeRows .    CanUserSortColumns .    CanUserDeleteRows .  
���   �$��Right=�6   $��Center=�6C  ���	#FFE5E5E5��6.   �� $" ValidateErrorsNroComprobante�   	CellStyle 5G      �� 5I      *  $System.Windows.Controls.DataGridCell"  6   	 5J      P� 5K      
 �@J�IsMouseOver . . �5M   "   ��  � �� �	#FF74C1FF5N      �� 5O   "    � ��
 �   �5P      5S      .�5U      ��  � ��$ 25��63   6@   �� 5V       � ��$ Center=�6G   6X   �� 5W       � ��$ Center=�6E   6V   �� 5X       �@��TextAlignment$ Center=�6D   6U   �� 5Y       � ��$ Center=�6H   6Y   �� 5Z       � ��$ Center��64   6E   5^         RowStyle 5b      �� 5c      )  #System.Windows.Controls.DataGridRow"  6   	 5d      P� 5e      
 �@J�IsMouseOver . . �5g   "   ��  � ��
 �����5h      �� 5i   "    � ��
 �   �5j      5l      .�5q      ��  �@�Tag 5r      ��  ��   �� AncestorType"  �$ DataContext��� 5t       �@�ContextMenu 5u      �� 5v   "    6.   �� *PlacementTarget.Tag+ �� *Self+.@�5y   &   m� $��Eliminar��6/   ! m� Command$! local:CustomCommands.Exit��6A   5z   #   5|      5~       5�        TaxTextBoxStyle" �� Binding# �� Value  TextBoxStyle  CenterCellStyle$ �� 
TargetType��%~  &	       &	 �    &	 �    �� 5�      " ��64   .�5�      ��  � �� �	#FF74C1FF6K   	 5�      �� 5�      " 6*   �� $ Canceled�# N6L   .a�5�   "   ��  �@��
IsReadOnly .  6?   �� 5�   "    � �� �	#FF74C1FF6S   5�      �� 5�      " 6*   �� $ Canceled�# Y6L   .a�5�   "   ��  �@��
IsReadOnly . 6?   �� 5�   "    � �� �	#FF74C1FF6S   5�      5�      �� 5�      " ��61   .�5�      ��  � �� �	#FF74C1FF6K   5�      �� 5�      "  64   .�5�      ��  � �� 5�      �� 5�   "   "$  62   .R�5�   &   � #��z��6+   .+�5�   *   �� $��Center=�6;   $��Center=�6X   $
��auto��6s   6�   5�   '   5�   #   5�      	 5�      P� 5�      
 �@J�IsMouseOver . . �5�   "   ��  � �� �	#FF74C1FF5�      �� 5�   "    � ��
 �   �5�      5�      5�      5�      %   Columns% 5�      4  .System.Windows.Controls.DataGridTemplateColumn  5�      ,	  &System.Windows.Controls.DataGridColumn& 	  Header$& Codigo��6-   ' 	  Width$
' auto 6=   -   5        
codigo��(   CellEditingTemplate( 5�      �� 5�      .R�5�   "   �� $��txtCodeCurrency��6�   -   5        
���   �#��[ 5�   }   ��6=   �� $
 Code�$ PropertyChanged=�6�   5�      )   CellTemplate) 5�      �� 5�      .R�5�   "   �� $��txtCodeCurrency��6�   #��[  6,   
���   ���6}   �� $
 Code�$ PropertyChanged=� .  . 6  5�      5�        5�      $& Nombre de Serie��6-   $
' Auto 6F   -   5        name��( 5�      �� 5�      .R�5�   "   �� 
���   �#��[ 6�   ��6*   �� $ NombreSerie�$ PropertyChanged=�6�   5�      ) 5�      �� 5�      .R�5�   "   �� #��[  6,   
���   ���6j   �� $ NombreSerie�$ PropertyChanged=� .  . 6�   5�      5�        5�      $& 
Tipo Serie��6-   $
' Auto 6A   -   5        	tipoSerie��( 5�      �� 5�      .R�5�   "   �� * �� 
IsEditable* .  + �� 
IsReadOnly+ . 
���   �  ComboBoxStyle#��[ 64  ��6+   �� $ TipoSerieList�, �� Mode$, TwoWay=�- �� SelectedValue- 6b   �� $ 	TipoSerie�$ PropertyChanged=�. �� SelectedItem. 6�   �� $ 	TipoSerie�$ PropertyChanged=�6]  5�      ) 5�      �� 5�      .R�5�   "   �� #��[  6,   
���   ���6j   �� $ 	TipoSerie�$ PropertyChanged=� .  . 6�   5�      5�      0
  *System.Windows.Controls.DataGridTextColumn
  5�      $& Nombre de Serie��6I   $
' Auto 6b   1  +System.Windows.Controls.DataGridBoundColumn/   Binding/ 6)   �� *NombreSerie+6r   
  5�      $
' Auto 6J   $& Descripcion��6W   -   5        descripcion��/ 5�   )   �� *Descripcion+6�     5�      $& Inicio��6-   $
' Auto 6=   -   5        
inicio��( 5�      �� 5�      .R�5�   "   �� 
���   �#��[ 6�   ��6+   �� $ Inicio�$ PropertyChanged=�6�   5�      ) 5     �� 5     .R�5  "   �� #��[  6,   
���   ���6l   �� $ Inicio�$ PropertyChanged=� .  . 6�   5     5       5
     $& 	Siguiente��6-   $
' Auto 6@   -	   5        	siguiente��( 5     �� 5     .R�5  "   �� 
���   �#��[ 6�   ��6*   �� $ 	Siguiente�$ PropertyChanged=�6�   5     ) 5     �� 5     .R�5  "   �� #��[  6,   
���   ���6j   �� $ 	Siguiente�$ PropertyChanged=� .  . 6�   5     5       5     $	& Fin��6-   $
' Auto 6:   -
   5        fin��( 5     �� 5     .R�5  "   �� 
���   �#��[ 6}   ��6*   �� $	 Fin�$ PropertyChanged=�6�   5     ) 5     �� 5      .R�5!  "   �� #��[  6,   
���   ���6k   �� $	 Fin�$ PropertyChanged=� .  . 6�   5"     5$       5&     $& Activo��6-   $
' auto 6=   -   5        activos��) 5'     �� 5(     .R�5)  "   �� $��activo��6+   -   5        #��[ 5)  9   $��Center=�6c  $��Center=�6~  $��Center=�6�  $��Center=�6�  0 d� IsThreeState0 .  1 d� 	IsChecked1 6l   �� $ Activo�$ PropertyChanged=� .  . 5*  #   5+     ( 5-     �� 5.     .R�5/  "   �� $��activo��6+   -   5        $��Center=�5/  0  $��Center=�6K  $��Center=�6m  $��Center=�6�  0 .  1 69   �� $ Activo�$ PropertyChanged=� .  . 50  #   51     53     56     �� 57     -   5        2 ��Name$2 btnOk��57     $��OK��6$   $
��Left=�61   $��	0,342,0,0q�6L   $	��Top=�6_   $��85��6w   $��3q�6�   $��16(�6�   6�   �� 58     -   5        $2 btnCancelar��58     $��Cancelar��6*   $
��Left=�6=   $��110,342,0,0q�6X   $	��Top=�6m   $��89��6�   $��3q�6�   $��16(�6�   
�������
�������6�   5:     5;     5<     