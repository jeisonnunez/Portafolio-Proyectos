   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	       Vista.PeriodosContables   5   	   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	   -   5          � Title$  PeriodosContables��5   	   $��423.333��6#   $��829.333��64    � WindowStartupLocation$ CenterScreen=�6D    � 	Resources 5	       �� 
TargetType   ImageButtonStyle �� Property �� Value �� 
TargetType��%�   &	        �� 5
   
   " ��6   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� 5      5      5      5      .��5      �� $
��Auto=�6   $
��Auto=�66   .��5   
   � $��Center=�6   $	��Top=�6,   $��0,20,0,0q�6D   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dgPeriodosContables��5      ���	#FFE5E5E5$��1q�6L   
�������   CanUserDeleteRows .  	   GridLinesVisibility$		 All=�6�   
   VerticalGridLinesBrush

 �����   HorizontalGridLinesBrush
 �����$��Center=�6�   $	��297��6     CanUserAddRows .     
IsReadOnly . $	��Top=�6�  $	��742��6�  
���   �   AutoGenerateColumns .  $   HorizontalScrollBarVisibility$
 Auto=�6�     SelectionMode$ Extended=�6	     RowStyle 5!      �� 5"      )  #System.Windows.Controls.DataGridRow"  6    �� Triggers 5#      P� 5$       P� Property �@J�IsMouseOver P� Value . . �5&   "   ��  � �� �	#FF2196F35'      �� 5(   "    � ��
 �����5)      5*      .�5,      ��  �@��TextAlignment$ Center=�6D   6U   �� 5-       � ��$ Center=�6H   6Y   5.         Columns 51      4  .System.Windows.Controls.DataGridTemplateColumn  52      ,  &System.Windows.Controls.DataGridColumn   Header$ Codigo Periodo��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6E      CellTemplate 53      �� 54      .R�55   "   ]� $��dp��6j   $��1��6,   $��1��69   $��4.667,3.667,4.667,2.667q�6I   $��Stretch=�6t   $��Stretch=�6�   .+�56   &   �� $	��img��6�   -   5        $
��Left=�56   j   $��004-proximo.png��6�   $��20��6�   $��0,0,0,-0.333q�6�   $y�Visible=�6�    � Cursor$
 Hand��6�   �� 57   &    ��Name$	 txt��60   $��0,0,0,-0.333q�6T   $��95��6j   ��6=   �� *Code+6y   58   #   59         CellEditingTemplate 5;      �� 5<      .R�5=   "   ]� $��dp��6j   $��1��6,   $��1��69   $��4.667,3.667,4.667,2.667q�6I   $��Stretch=�6t   $��Stretch=�6�   .+�5>   &   �� $	��img��6�   -   5        $
��Left=�5>   j   $��004-proximo.png��6�   $��20��6�   $��0,0,0,-0.333q�6�   $y�Visible=�6�   $
 Hand��6�   �� 5?   &   $	 txt��60   $��0,0,0,-0.333q�6S   $��95��6i   ��6=   �� *Code+6x   5@   #   5A      5C      0  *System.Windows.Controls.DataGridTextColumn  5G      $ Nombre Periodo��6B   $
 auto 6Z   -   5        nombrePeriodo��1  +System.Windows.Controls.DataGridBoundColumn   Binding 5G   )   �� *Name+6�     5H      $
 auto 6I   $ Status Periodo��6V   -   5        statusPeriodo�� 5H   )   �� *
PeriodStat+6�     5I      $! Fecha Contabilizacion Desde��6-   -   5        fcDesde��$
 auto 5I   c    5J      �� 5K      .R�5L   "   �� ��6,   �� *	F_RefDate+ �� StringFormat$ {0:dd/MM/yyyy}��5M       5O      �� 5P      .R�5Q   "   (  "System.Windows.Controls.DatePicker     SelectedDate 6-   �� *	F_RefDate+$ {0:dd/MM/yyyy}�� 5R   &   ��%^   '��       �� 5S   *   " ��60   .�5T   .   ��  �@��CornerRadius$ 3��6M   5V   +   5W   '   5X   #   5Y      5[        5\      $! Fecha Contabilizacion Hasta��6-   -   5        fcHasta��$
 auto 5\   c    5]      �� 5^      .R�5_   "   �� ��6,   �� *	T_RefDate+$ {0:dd/MM/yyyy}��5`       5b      �� 5c      .R�5d   "      6-   �� *	T_RefDate+$ {0:dd/MM/yyyy}��5e      5g        5h      $ Fecha Vencimiento Desde��6-   -	   5        fvDesde��$
 auto 5h   _    5i      �� 5j      .R�5k   "   �� ��6,   �� *	F_TaxDate+$ {0:dd/MM/yyyy}��5l       5n      �� 5o      .R�5p   "      6-   �� *	F_TaxDate+$ {0:dd/MM/yyyy}��5q      5s        5t      $ Fecha Vencimiento Hasta��6-   -
   5        fvHasta��$
 auto 5t   _    5u      �� 5v      .R�5w   "   �� ��6,   �� *	T_TaxDate+$ {0:dd/MM/yyyy}��5x       5z      �� 5{      .R�5|   "      6-   �� *	T_TaxDate+$ {0:dd/MM/yyyy}��5}      5        5�         
Visibility$ Hidden=�6F   $
 auto 6Z   -   5        category�� 5�   )   �� *
Category+5�      5�      �� 5�      -   5          ��Name$  btnOk��5�      $��OK��6$   $
��Left=�61   $��3,319,0,-0.333q�6L   $	��Top=�6d   $��84��6|   $��14(�6�   $
��Bold"�6�   $��3q�6�   6�   �� 5�      -   5        $  btnCancelar��5�      $��Cancelar��6*   $
��Left=�6=   $��101,319,0,-0.333q�6X   $	��Top=�6r   $��91��6�   $��14(�6�   $
��Bold"�6�   $��3q�6�   
�������
�������6�   �� 5�      -   5        $  btnPeriodoNuevo��5�      $��Periodo Nuevo��6.   $
��Left=�6F   $��624,319,0,-0.333q�6a   $	��Top=�6{   $	��120��6�   $��14(�6�   $
��Bold"�6�   $��3q�6�   6�   5�      5�      5�      