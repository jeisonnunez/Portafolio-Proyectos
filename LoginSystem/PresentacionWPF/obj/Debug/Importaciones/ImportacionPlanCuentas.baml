   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Vista.ImportacionesVista.Importaciones  5   	   0    *Vista.Importaciones.ImportacionPlanCuentas   5   	   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Vista.Importaciones     5   	   -   5          � Title$  ImportacionPlanCuentas��5   	   $	��450��6(   $	��895��65    � WindowStartupLocation$ CenterScreen=�6q   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgImportarCuentas��5
   V   
�������$��1q�6&      AutoGenerateColumns .  $
��Left=�6q   $	��257��6�   $��	48,69,0,0q�6�   $	��Top=�6�   $	��798��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ AcctCode��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *
AcctCode+   ElementStyle 5      �� 5       �� 
TargetType" ��6    .�5      �� 	 �� Property	 � ��
 �� Value
 65   �� *
AcctCode+5      5        5      $ AcctName��6%    67   �� *
AcctName+ 5      �� 5      " ��6    .�5      �� 	 � ��
 65   �� *
AcctName+5      5        5      $ Levels��6%    65   �� *Levels+ 5      �� 5      " ��6    .�5      �� 	 � ��
 65   �� *Levels+5!      5#        5$      $ 	FatherNum��6%    68   �� *	FatherNum+ 5%      �� 5&      " ��6    .�5'      �� 	 � ��
 65   �� *	FatherNum+5)      5+        5,      $ Postable��6%    67   �� *
Postable+ 5-      �� 5.      " ��6    .�5/      �� 	 � ��
 65   �� *
Postable+51      53        54      $ ActType��6%    66   �� *	ActType+ 55      �� 56      " ��6    .�57      �� 	 � ��
 65   �� *	ActType+59      5;        5<      $ ActCurr��6%    66   �� *	ActCurr+ 5=      �� 5>      " ��6    .�5?      �� 	 � ��
 65   �� *	ActCurr+5A      5C        5D      $ 
LocManTran��6%    69   �� *
LocManTran+ 5E      �� 5F      " ��6    .�5G      �� 	 � ��
 65   �� *
LocManTran+5I      5K        5L      $ 	GroupMask��6%    68   ��  �� Path$ 	GroupMask� 5M      �� 5N      " ��6$   .�5O   "   �� 	 � ��
 69   �� $ 	GroupMask�5Q      5T      5V      �� 5W   
   -   5         ��Name$ btnImportar��5W      $��Importar��6@   $
��Left=�6S   $��
48,360,0,0q�6n   $	��Top=�6�   $��92��6�   �� 5X   
   -   5        $ 	btnBuscar��5X      $��Seleccionar��6<   $
��Left=�6R   $��739,360,0,0q�6m   $	��Top=�6�   $	��106��6�   �� 5Y   
   -   5        $ btnCancelar��5Y      
�������
�������$��Cancelar��6e   $
��Left=�6x   $��164,360,0,0q�6�   $	��Top=�6�   $��92��6�   5[      5\      