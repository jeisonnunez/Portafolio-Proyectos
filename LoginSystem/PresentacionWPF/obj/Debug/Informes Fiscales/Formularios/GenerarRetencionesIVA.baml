   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	   !    Vista.GenerarRetencionesIVA   5   	   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	   -   5          � Title$  GenerarRetencionesIVA��5   	   $	��403��6'   $	��392��64    � WindowStartupLocation$ CenterScreen=�6@   .��5	      � .+�5
   
   �� -   5         ��Name$ lblProveedor��5
      $
��Bold"�6*   $
��Left=�6<   $��	21,37,0,0q�6W   $
��Wrap=�6j   $��
Proveedor:��6~   $	��Top=�6�   �� 5   
   -   5         ��Name$ bdProveedor��5   ]   $��1q�6   
������� �� CornerRadius$ 3��68   $��
147,32,0,0q�6I   
�������$
��Left=�6�   $	��161��6�   $��25��6�   $	��Top=�6�   ._�5      ]� -   5         ]�Name$ dpProveedor��5   U   $��1��6   $��1��6%   $��4.667,0.667,4.667,0.5q�66   
�������.+�5      �� -   5         ��Name$ imgProveedor��5   �   $��Right=�6]   $��lupa.png��6t   $��20��6�   $��0,0,0,-0.333q�6�   $y�Hidden=�6�    � Cursor$
 Hand��6�   �� 5      -   5         ��Name$ txtProveedor��5      $��12(�60   $��Normal"�6>   
�������$��0q�6�   $��0,0,0,0.333q�6�   $	��114��6�   
���   �$	��Top=�6�   $��Stretch=�6  $��Stretch=�60  5      5      �� 5   
   -   5        $ lblProveedorH��5      $
��Bold"�6+   $
��Left=�6=   $��	21,79,0,0q�6X   $
��Wrap=�6k   $��
Proveedor:��6   $	��Top=�6�   �� 5   
   -   5        $ bdProveedorH��5   ]   $��1q�6   
�������$ 3��68   $��
145,74,0,0q�6I   
�������$
��Left=�6�   $	��163��6�   $��25��6�   $	��Top=�6�   ._�5      ]� -	   5        $ dpProveedorH��5   U   $��1��6   $��1��6%   $��4.667,0.667,4.667,0.5q�66   
�������.+�5      �� -
   5        $ imgProveedorH��5   �   $��Right=�6^   $��lupa.png��6u   $��20��6�   $��0,0,0,-0.333q�6�   $y�Hidden=�6�   $
 Hand��6�   �� 5      -   5        $ txtProveedor1��5      $��12(�61   $��Normal"�6?   
�������$��0q�6�   $��0,0,0,0.333q�6�   $	��114��6�   
���   �$	��Top=�6�   $��Stretch=�6  $��Stretch=�61  5      5      �� 5   
   -   5        	 ��Name$	 btnCrear��5      $��OK��6:   $
��Left=�6G   $��
26,320,0,0q�6b   $	��Top=�6v   $��95��6�   $��3q�6�   �� 5   
   -   5        $	 btnCancelar��5      $��Cancelar��6&   $
��Left=�69   $��136,318,0,0q�6T   $	��Top=�6i   $��94��6�   $��3q�6�   
�������
�������6�   �� 5   
   -   5        $ lblQuincena��5      $
��Bold"�6)   $
��Left=�6;   $��
21,122,0,0q�6V   $
��Wrap=�6j   $��	Quincena:��6~   $	��Top=�6�   �� 5   
   -   5        
 ��Name$
 
cbQuincena��5       �� DisplayMemberPath$
 Name��6'    �� SelectedValuePath$
 Code��6@      ComboBoxStyle#��[  6Y   $��25��6�   
������� �� 
IsReadOnly . 
���   �$
��Left=�6   $��146,118,0,0q�6  $	��Top=�60  $	��162��6H  �� 5   
   -   5        $ lblTipo��5      $
��Bold"�6%   $
��Left=�67   $��
21,162,0,0q�6R   $
��Wrap=�6f   $��Tipo:��6z   $	��Top=�6�   �� 5   
   -   5        $
 cbTipo��5      $
 Name��6#   $
 Code��6<   #��[  6U   $��25��6|   
������� . 
���   �$
��Left=�6�   $��146,158,0,0q�6  $	��Top=�6,  $	��162��6D  �� 5   
   -   5        $ lblMes��5      $
��Bold"�6$   $
��Left=�66   $��
21,202,0,0q�6Q   $
��Wrap=�6e   $
��Mes:��6y   $	��Top=�6�   �� 5   
   -   5        $
 cbMes��5      $ Month��6"   $
 Code��6<   #��[  6U   $��25��6|   
������� . 
���   �$
��Left=�6�   $��146,198,0,0q�6  $	��Top=�6,  $	��162��6D  �� 5    
   -   5        $ lblAnno��5       $
��Bold"�6%   $
��Left=�67   $��
21,238,0,0q�6R   $
��Wrap=�6f   $��Año:��6z   $	��Top=�6�   �� 5!   
   -   5        $
 cbAnno��5!      $ Category��6#   $ Category��6@   #��[  6]   $��25��6�   
������� . 
���   �$
��Left=�6  $��146,234,0,0q�6  $	��Top=�64  $	��162��6L  5#      5$      