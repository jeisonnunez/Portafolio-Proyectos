   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  %    Vista.DeterminacionCuentasMayor   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Vista        Vista.Document    Loaded$  Window_Loaded��   Closing$ Window_Closing�� � Title$! Determinacion Cuentas Mayor��$��421.829��$��629.453�� � WindowStartupLocation$ CenterScreen=�.��� $��Stretch=�$��Stretch=� � ColumnDefinitions �� $��* � � RowDefinitions �� $��* �.+�&   System.Windows.Controls.DataGrid  -     Name$ 	dgCuentas��$��Stretch=�$��0��$��0��
�������$��1q�
�������   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * $	��258��$��36,46,31.667,0q�$	��Top=�   CanUserResizeRows . 	   CanUserSortColumns	 . 
   CanUserReorderColumns
 .    AutoGenerateColumns .     CanUserDeleteRows .  
���   �   GridLinesVisibility$	 All=�   VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   SelectionMode$ Extended=�   SelectionUnit$ FullRow=�   CanUserAddRows .  $��10(�$��Normal"� � 	Resources    TextBoxStyle �� 
TargetType �� Property �� Value �� Triggers �� Binding �� Value  TextBoxStyleNotReadOnly  TextBlockStyle��%!  &	        &	 �     &	 �     �� " ��.���  � �� �	#FF74C1FF ��  �� *
DataSource+ N.a���  �@��
IsReadOnly . ��  � ��
 ������� " ��.���  � �� �	#FF74C1FF�� " �� ��  �� *
DataSource+ N.a���  � ��
 �����   	CellStyle �� *  $System.Windows.Controls.DataGridCell"  .���  � ��$ 30����  � ��$ Center=���  � ��$ Center=���  �@��TextAlignment$ Center=���  � ��$ Center=� P�  P� Property �@J�IsMouseOver P� Value . . ���  � �� �	#FF74C1FF   RowStyle �� )  #System.Windows.Controls.DataGridRow"   �� 	Resources  �� Color��%�   (��       * SystemColors.HighlightBrushKey+)(��      *$"SystemColors.HighlightTextBrushKey+)�� $ Transparent���� $ Black�� P�  �@J�IsMouseOver . . ���  � ��
 �����    Columns  4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn!   Header$! #��"   Width$" * #   
IsReadOnly# . -   ID��$   CellEditingTemplate$ �� .R��� % ��Name$% txtAcctName��
���   �#��[  ���	#FFE5E5E5& �� 
IsReadOnly& . ���� ' �� Path$' ID�( �� UpdateSourceTrigger$( PropertyChanged=�)   CellTemplate) �� .R��� 
���   ����	#FFE5E5E5#��[ ���� $' ID�$( PropertyChanged=�  $! Clase Cuenta��$" * # . -   clasecuenta��$ �� .R��� $% txtType��
���   �#��[  ���	#FFE5E5E5& . ���� $
' Type�$( PropertyChanged=�) �� .R��� 
���   ����	#FFE5E5E5#��[ ���� $
' Type�$( PropertyChanged=�  $! Cuenta��$" * -   acctCode��$ �� .R��� * ��Name$* bd��$��1q�
�������+ �� CornerRadius$+ 3��._�]� , ]�Name$, dp��$��1��$��1��$��Stretch=�$��Stretch=�.+��� - ��Name$- 
imgAccount��-   $��Right=�$��lupa.png��$��20��$y�Visible=�. � Cursor$
. Hand���� $% 
txtAccount��-   $��10(�$��Stretch=�
���   �#��[  
�������$��0q�$
��auto������ $' AcctCode�$( PropertyChanged=�) �� .R��� / ��Name$/ 
txtAccount��
���   �#��[ ���� $' AcctCode�  $! Nombre de Cuenta��$" * # . -   
nameCuenta��$ �� .R��� $% txtAcctName��
���   �#��[  ���	#FFE5E5E5& . ���� $' AcctName�$( PropertyChanged=�) �� .R��� $/ txtAcctName��
���   ����	#FFE5E5E5#��[ ���� $' AcctName�$( PropertyChanged=��� -   0 ��Name$0 btnOK��$��OK��$
��Left=�$��
35,343,0,0q�$	��Top=�$��95��$��3q��� -	   $0 btnCancelar��$��Cancelar��$
��Left=�$��157,343,0,0q�$	��Top=�$��94��$��3q�
�������
�������