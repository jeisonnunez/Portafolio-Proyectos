   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista      Vista.PeriodosContables   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Vista     -     � Title$  PeriodosContables��$��423.333��$��829.333�� � WindowStartupLocation$ CenterScreen=� � 	Resources  �� 
TargetType   ImageButtonStyle �� Property �� Value �� 
TargetType��%:   &	        �� " ��.���  � �� �� " ��.R��� .���� $
��Auto=�$
��Auto=�.��� $��Center=�$	��Top=�$��0,20,0,0q�.+�&   System.Windows.Controls.DataGrid  -     Name$ dgPeriodosContables�����	#FFE5E5E5$��1q�
�������   CanUserDeleteRows .  	   GridLinesVisibility$		 All=�
   VerticalGridLinesBrush

 �����   HorizontalGridLinesBrush
 �����$��Center=�$	��297��   CanUserAddRows .     
IsReadOnly . $	��Top=�$	��742��
���   �   AutoGenerateColumns .  $   HorizontalScrollBarVisibility$
 Auto=�   SelectionMode$ Extended=�   RowStyle �� )  #System.Windows.Controls.DataGridRow"   �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ���  � �� �	#FF2196F3��  � ��
 �����.���  �@��TextAlignment$ Center=���  � ��$ Center=�   Columns 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Codigo Periodo��   Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto    CellTemplate �� .R�]� $��dp��$��1��$��1��$��4.667,3.667,4.667,2.667q�$��Stretch=�$��Stretch=�.+��� $	��img��-   $
��Left=�$��004-proximo.png��$��20��$��0,0,0,-0.333q�$y�Visible=� � Cursor$
 Hand����  ��Name$	 txt��$��0,0,0,-0.333q�$��95������ *Code+   CellEditingTemplate �� .R�]� $��dp��$��1��$��1��$��4.667,3.667,4.667,2.667q�$��Stretch=�$��Stretch=�.+��� $	��img��-   $
��Left=�$��004-proximo.png��$��20��$��0,0,0,-0.333q�$y�Visible=�$
 Hand���� $	 txt��$��0,0,0,-0.333q�$��95������ *Code+0  *System.Windows.Controls.DataGridTextColumn  $ Nombre Periodo��$
 auto -   nombrePeriodo��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Name+  $
 auto $ Status Periodo��-   statusPeriodo�� �� *
PeriodStat+  $! Fecha Contabilizacion Desde��-   fcDesde��$
 auto  �� .R��� ���� *	F_RefDate+ �� StringFormat$ {0:dd/MM/yyyy}�� �� .R�(  "System.Windows.Controls.DatePicker     SelectedDate �� *	F_RefDate+$ {0:dd/MM/yyyy}�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��  $! Fecha Contabilizacion Hasta��-   fcHasta��$
 auto  �� .R��� ���� *	T_RefDate+$ {0:dd/MM/yyyy}�� �� .R�   �� *	T_RefDate+$ {0:dd/MM/yyyy}��  $ Fecha Vencimiento Desde��-	   fvDesde��$
 auto  �� .R��� ���� *	F_TaxDate+$ {0:dd/MM/yyyy}�� �� .R�   �� *	F_TaxDate+$ {0:dd/MM/yyyy}��  $ Fecha Vencimiento Hasta��-
   fvHasta��$
 auto  �� .R��� ���� *	T_TaxDate+$ {0:dd/MM/yyyy}�� �� .R�   �� *	T_TaxDate+$ {0:dd/MM/yyyy}��     
Visibility$ Hidden=�$
 auto -   category�� �� *
Category+�� -     ��Name$  btnOk��$��OK��$
��Left=�$��3,319,0,-0.333q�$	��Top=�$��84��$��14(�$
��Bold"�$��3q��� -   $  btnCancelar��$��Cancelar��$
��Left=�$��101,319,0,-0.333q�$	��Top=�$��91��$��14(�$
��Bold"�$��3q�
�������
��������� -   $  btnPeriodoNuevo��$��Periodo Nuevo��$
��Left=�$��624,319,0,-0.333q�$	��Top=�$	��120��$��14(�$
��Bold"�$��3q�