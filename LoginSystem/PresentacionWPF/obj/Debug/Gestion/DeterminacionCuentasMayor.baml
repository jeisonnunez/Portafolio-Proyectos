   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	   o<clr-namespace:Vista.Gestion.ValidateErrorsDeterminacionMayor.Vista.Gestion.ValidateErrorsDeterminacionMayor  6+   %    Vista.DeterminacionCuentasMayor   5      n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	   Olocal1<clr-namespace:Vista.Gestion.ValidateErrorsDeterminacionMayor     6+      Vista.Document    Loaded$  Window_Loaded��5   N      Closing$ Window_Closing��6e    � Title$! Determinacion Cuentas Mayor��6	   $��421.829��6-   $��615.453��6>    � WindowStartupLocation$ CenterScreen=�6~    � 	Resources 5	         TextBlockStyleValidation �� 
TargetType �� Triggers P� Property P� Value	 �� Property
 �� Value �� RelativeSource �� Path �� UpdateSourceTrigger �� ValidatesOnDataErrors �� NotifyOnValidationError��%�   &	        �� 5
   
   " ��61    5      P� 5       �@=�HasError . . �5      �� 	 �@�ToolTip
 5      ��  �� *Self+$) #(Validation.Errors)[0].ErrorContent�$ PropertyChanged=� .  . 5      5      5       � DataContext 5      L   FVista.Gestion.ValidateErrorsDeterminacionMayor.ModelDeterminacionMayor  5   
   .��5      � $��Stretch=�6   $��Stretch=�6)    � ColumnDefinitions 5   
   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $��* �6   6)   .+�5"   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	dgCuentas��5"      $��Stretch=�6&   $��0��6K   $��0��6X   
�������$��1q�6{   
�������   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�   $	��258��6�   $��36,46,31.667,0q�6�   $	��Top=�6�      CanUserResizeRows .    CanUserSortColumns .    CanUserReorderColumns .    AutoGenerateColumns .     CanUserDeleteRows .  
���   �   GridLinesVisibility$	 All=�6�     VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   SelectionMode$ Extended=�6�     SelectionUnit$ FullRow=�6     CanUserAddRows .  $��10(�61  $��Normal"�6?   5#        TextBoxStyle  �� Binding! �� Value  TextBoxStyleNotReadOnly  TextBlockStyle��%�  &	       &	 �     &	 B    �� 5$      " ��6-   .�5%      �� 	 � ��
 �	#FF74C1FF63    5&      �� 5'        6&   �� *
DataSource+! N6E   .a�5(      �� 	 �@��
IsReadOnly
 . 6;   �� 5)      	 � ��

 �����6;   5*      5-      �� 5.      " ��68   .�5/      �� 	 � ��
 �	#FF74C1FF63   51      �� 53      " ��6/    55      �� 56        6&   �� *
DataSource+! N6E   .a�57      �� 	 � ��

 �����6;   58      5;      5>      "   	CellStyle" 5?      �� 5A      *  $System.Windows.Controls.DataGridCell"  6   .�5B      �� 	 � ��$
 30��6/   �� 5C      	 � ��$
 Center=�6C   �� 5D      	 � ��$
 Center=�6A   �� 5E      	 �@��TextAlignment$
 Center=�6@   �� 5F      	 � ��$
 Center=�6:    5G      P� 5H       �@J�IsMouseOver . . �5J      �� 	 � ��
 �	#FF74C1FF5K   !   5P      5R      #   RowStyle# 5V      �� 5W      )  #System.Windows.Controls.DataGridRow"  6   $ �� 	Resources$ 5X      % �� Color��%�   (��       5Y   *   * SystemColors.HighlightBrushKey+)(�� %     5Z   *   *$"SystemColors.HighlightTextBrushKey+)�� 5Y      $% Transparent��6\   �� 5Z      $% Black��6`   5[       5]      P� 5^       �@J�IsMouseOver . . �5`      �� 	 � ��

 �����5a   !   5d      5g      &   Columns& 5j      4  .System.Windows.Controls.DataGridTemplateColumn  5k      ,  &System.Windows.Controls.DataGridColumn'   Header$' #��6)   (   Width$( * 64   )   
IsReadOnly) . -   5        ID��*   CellEditingTemplate* 5l      �� 5m      .R�5n      �� + ��Name$+ txtAcctName��6�   
���   �#��[ 6�   ���	#FFE5E5E5, �� 
IsReadOnly, . ��69   �� $ ID�$ PropertyChanged=� .  . 6  5o      -   CellTemplate- 5q      �� 5r      .R�5s      �� 
���   ����	#FFE5E5E5#��[ 5t      $
��Bold"�6(  . � ToolTip. 5s   (   ��  �� *Self+$) #(Validation.Errors)[0].ErrorContent� . $ PropertyChanged=� . ��5t   �   �� $ ID�$ PropertyChanged=�6(  5u      5x        5y      $' Clase Cuenta��6)   $( * 6?   ) . -   5        clasecuenta��* 5z      �� 5{      .R�5|      �� $+ txtType��6�   
���   �#��[ 6y   ���	#FFE5E5E5, . ��69   �� $
 Type�$ PropertyChanged=�6�   5}      - 5      �� 5�      .R�5�      �� $
��Bold"�6(   
���   ����	#FFE5E5E5#��[ 5�   <  . 5�   :   ��  �� *Self+$) #(Validation.Errors)[0].ErrorContent� . $ PropertyChanged=� . ��5�   �   �� $
 Type�$ PropertyChanged=� .  . 6<  5�      5�        5�      $' Cuenta��6)   $( * 69   -   5        acctCode��* 5�      �� 5�      .R�5�      �� / ��Name$/ bd��6]   $��1q�6%   
�������0 �� CornerRadius$0 3��6L   ._�5�   "   ]� 1 ]�Name$1 dp��6I   $��1��6,   $��1��69   $��Stretch=�6U   $��Stretch=�6s   .+�5�   &   �� 2 ��Name$2 
imgAccount��6�   -   5        $��Right=�5�   o   $��lupa.png��6�   $��20��6�   $y�Visible=�6�   3 � Cursor$
3 Hand��6�   �� 5�   &   $+ 
txtAccount��6.   -   5        $��10(�5�   B   $��Stretch=�6P   
���   �#��[ 6�   
�������$��0q�6   $
��auto��6  ��6�   �� $ AcctCode�$ PropertyChanged=�6"  5�   #   5�      5�      - 5�      �� 5�      .R�5�      �� 4 ��Name$4 
txtAccount��5�   '  $
��Bold"�5�   (   
���   �#��[ 5�   ;  . 5�   :   ��  �� *Self+$) #(Validation.Errors)[0].ErrorContent� . $ PropertyChanged=� . ��5�   �   �� $ AcctCode�$ PropertyChanged=� .  . 6;  5�      5�        5�      $' Nombre de Cuenta��6)   $( * 6C   ) . -   5        
nameCuenta��* 5�      �� 5�      .R�5�      �� $+ txtAcctName��6�   
���   �#��[ 6~   ���	#FFE5E5E5, . ��6:   �� $ AcctName�$ PropertyChanged=�6�   5�      - 5�      �� 5�      .R�5�      �� $4 txtAcctName��5�   g  $
��Bold"�5�   (   
���   ����	#FFE5E5E5#��[ 5�   ?  . 5�   :   ��  �� *Self+$) #(Validation.Errors)[0].ErrorContent� . $ PropertyChanged=� . ��5�   �   �� $ AcctName�$ PropertyChanged=� .  . 6g  5�      5�      5�      �� 5�   
   -   5        5 ��Name$5 btnOK��5�      $��OK��6    $
��Left=�6-   $��
35,343,0,0q�6H   $	��Top=�6\   $��95��6t   $��3q�6   6�   �� 5�   
   -	   5        $5 btnCancelar��5�      $��Cancelar��6&   $
��Left=�69   $��157,343,0,0q�6T   $	��Top=�6i   $��94��6�   $��3q�6�   
�������
�������6�   5�      5�      