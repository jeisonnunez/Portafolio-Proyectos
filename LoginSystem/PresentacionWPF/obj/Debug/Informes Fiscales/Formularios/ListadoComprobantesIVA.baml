   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:Vista.Informes_Fiscales.Formularios#Vista.Informes_Fiscales.Formularios  5   	   @    :Vista.Informes_Fiscales.Formularios.ListadoComprobantesIVA   5   	   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Clocal1clr-namespace:Vista.Informes_Fiscales.Formularios     5   	   -   5          � Title$  ListadoComprobantesIVA��5   	   $��272.334��6(   $��350.333��69    � WindowStartupLocation$ CenterScreen=�6I   .��5	      � .+�5
   
   �� -   5         ��Name$ lblDesde��5
      $
��Bold"�6&   $
��Left=�68   $��	21,26,0,0q�6S   $
��Wrap=�6f   $��Fecha Desde��6z   $	��Top=�6�   �� 5   
   -   5         ��Name$ btnCrear��5      $��OK��6:   $
��Left=�6G   $��
21,194,0,0q�6b   $	��Top=�6v   $��95��6�   $��3q�6�   �� 5   
   -   5        $ btnCancelar��5      $��Cancelar��6&   $
��Left=�69   $��131,192,0,0q�6T   $	��Top=�6i   $��94��6�   $��3q�6�   
�������
�������6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dpDesde��5   h   $
��Left=�6   $��
105,21,0,0q�60   $	��Top=�6D   $	��143��6\    � 	Resources 5       �� 
TargetType �� Property �� Value��%^   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 3��65   5      5      5      �� 5   
   -   5        $ lblHasta��5      $
��Bold"�6&   $
��Left=�68   $��	21,64,0,0q�6S   $
��Wrap=�6f   $��Fecha Hasta��6z   $	��Top=�6�     5   
   -   5        $ dpHasta��5   h   $
��Left=�6   $��
105,60,0,0q�60   $	��Top=�6D   $	��143��6\    5      ��%^   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 3��65   5      5      5      �� 5   
   -   5        $ lblProveedor��5      $
��Bold"�6*   $
��Left=�6<   $��
21,101,0,0q�6W   $
��Wrap=�6k   $��
Proveedor:��6   $	��Top=�6�   �� 5   
   -	   5        	 ��Name$	 bdProveedor��5   ]   $��1q�6   
�������
 �� CornerRadius$
 3��68   $��
107,96,0,0q�6I   
�������$
��Left=�6�   $	��141��6�   $��25��6�   $	��Top=�6�   ._�5       ]� -
   5         ]�Name$ dpProveedor��5    U   $��1��6   $��1��6%   $��4.667,0.667,4.667,0.5q�66   
�������.+�5!      �� -   5         ��Name$ imgProveedor��5!   �   $��Right=�6]   $��lupa.png��6t   $��20��6�   $��0,0,0,-0.333q�6�   $y�Hidden=�6�    � Cursor$
 Hand��6�   �� 5"      -   5         ��Name$ txtProveedor��5"      $��12(�60   $��Normal"�6>   
�������$��0q�6�   $��0,0,0,0.333q�6�   $	��114��6�   
���   �$	��Top=�6�   $��Stretch=�6  $��Stretch=�60  5#      5$      �� 5%   
   -   5        $ lblProveedorH��5%      $
��Bold"�6+   $
��Left=�6=   $��
21,135,0,0q�6X   $
��Wrap=�6l   $��
Proveedor:��6�   $	��Top=�6�   �� 5&   
   -   5        $	 bdProveedorH��5&   ^   $��1q�6   
�������$
 3��68   $��107,130,0,0q�6I   
�������$
��Left=�6�   $	��141��6�   $��25��6�   $	��Top=�6�   ._�5'      ]� -   5        $ dpProveedorH��5'   U   $��1��6   $��1��6%   $��4.667,0.667,4.667,0.5q�66   
�������.+�5(      �� -   5        $ imgProveedorH��5(   �   $��Right=�6^   $��lupa.png��6u   $��20��6�   $��0,0,0,-0.333q�6�   $y�Hidden=�6�   $
 Hand��6�   �� 5)      -   5        $ txtProveedor1��5)      $��12(�61   $��Normal"�6?   
�������$��0q�6�   $��0,0,0,0.333q�6�   $	��114��6�   
���   �$	��Top=�6�   $��Stretch=�6  $��Stretch=�61  5*      5+      5-      5.      