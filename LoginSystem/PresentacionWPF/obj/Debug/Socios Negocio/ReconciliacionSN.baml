   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	       Vista.ReconciliacionSN   5   	   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	   -   5          � Title$"  Reconciliacion Socio Negocio��5   	   $��300.341��6.   $��537.363��6?    � WindowStartupLocation$ CenterScreen=�6i   .��5	      �� $
��Auto=�6   $
��Auto=�66   .��5
   
   � $��Center=�6   $	��Top=�6,   $	��270��6D   $	��521��6Q   .+�5      �� -   5         ��Name$ lblReconciliacion��5      $
��Bold"�63   $
��Left=�6E   $��	27,78,0,0q�6`   $
��Wrap=�6s   $��Fecha Reconciliacion��6�   $	��Top=�6�   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ dpReconciliacion��5   x   $
��Left=�6   $��
202,73,0,0q�64   $	��Top=�6H   $	��134��6`   $��25��6l   $��1q�6�    � 	Resources 5       �� 
TargetType �� Property �� Value��%^   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 3��69   5      5      5      �� 5      -   5         ��Name$ btnReconciliar��5      $��Reconciliar��6-   $
��Left=�6C   $��
20,203,0,0q�6^   $	��Top=�6r   $��95��6�   $��3q�6�   6�   �� 5      -   5        $ btnCancelar��5      $��Cancelar��6*   $
��Left=�6=   $��136,203,0,0q�6X   $	��Top=�6m   $��94��6�   $��3q�6�   
�������
�������6�   �� 5      -   5        $ lblSN��5      $
��Bold"�6'   $��12(�69   
���   �$
��Left=�6Z   $��	27,32,0,0q�6u   $
��Wrap=�6�   $��Socio de Negocio��6�   $	��Top=�6�   �� 5      -   5        	 ��Name$
	 bdSN��5   a   $��1q�6   
�������
 �� CornerRadius$
 3��6<   $��
201,28,0,0q�6M   
�������$
��Left=�6�   $	��135��6�   $��25��6�   $	��Top=�6�   ._�5      ]� -   5         ]�Name$
 dpSN��5   Y   $��1��6   $��1��6)   $��4.667,0.667,4.667,0.5q�6:   
�������.+�5      �� -	   5         ��Name$ imgSN��5   �   $��Right=�6Z   $��lupa.png��6q   $��20��6�   $��0,0,0,-0.333q�6�   $y�Hidden=�6�    � Cursor$
 Hand��6�   �� 5      -
   5         ��Name$ txtSN��5      $��12(�6-   $��Normal"�6;   
�������$��0q�6�   $��0,0,0,0.333q�6�   $	��123��6�   
���   �$	��Top=�6�   $��Stretch=�6  $��Stretch=�6  5      5        5      -   5        $ dpDFechaContabilizacion��5   l   $
��Left=�6   $��
80,125,0,0q�64   $	��Top=�6H   $	��138��6`    5      ��%^   '��       �� 5      " ��6   .�5       ��  �@��CornerRadius$ 3��69   5"      5#      5$      �� 5%      -   5        $ lblHFechaContabilizacion��5%      $
��Bold"�6:   $��12(�6L   
���   �$
��Left=�6m   $��257,129,0,0q�6�   $
��Wrap=�6�   $��Hasta��6�   $	��Top=�6�     5&      -   5        $ dpHFechaContabilizacion��5&   m   $
��Left=�6   $��309,125,0,0q�64   $	��Top=�6I   $	��132��6a    5'      ��%^   '��       �� 5(      " ��6   .�5)      ��  �@��CornerRadius$ 3��69   5+      5,      5-      �� 5.      -   5        $ lblDFechaContabilizacion��5.      $
��Bold"�6:   $��12(�6L   
���   �$
��Left=�6m   $��
32,129,0,0q�6�   $
��Wrap=�6�   $��Desde��6�   $	��Top=�6�   5/      50      51      