   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	       Vista.ComprobanteARCV   5   	   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	   -   5          � Title$  ComprobanteARCV��5   	   $��206.11��68   $	��450��6H    � WindowStartupLocation$ CenterScreen=�6T   .��5	      � .+�5
   
   �� -   5         ��Name$ lblYear��5
      $
��Bold"�6%   $
��Left=�67   $��	21,42,0,0q�6R   $
��Wrap=�6e   $��Año:��6y   $	��Top=�6�   �� 5   
   -   5         ��Name$ cbYear��5       �� DisplayMemberPath$ Category��6$    �� SelectedValuePath$ Category��6A      ComboBoxStyle#��[  6^   $��25��6�   
������� �� 
IsReadOnly . 
���   �$
��Left=�6  $��
230,37,0,0q�6   $	��Top=�64  $	��162��6L  5      �� 5   
   -   5        $ lblProveedor��5      $
��Bold"�6*   $
��Left=�6<   $��	21,73,0,0q�6W   $
��Wrap=�6j   $��
Proveedor:��6~   $	��Top=�6�   �� 5   
   -   5        $��bdProveedor��5   ]   $��1q�6   
������� �� CornerRadius$ 3��68   $��
231,68,0,0q�6I   
�������$
��Left=�6�   $	��162��6�   $��25��6�   $	��Top=�6�   ._�5      ]� -   5        $��dpProveedor��5   U   $��1��6   $��1��6%   $��4.667,0.667,4.667,0.5q�66   
�������.+�5      �� -   5        $��imgProveedor��5   �   $��Right=�6]   $��lupa.png��6t   $��20��6�   $��0,0,0,-0.333q�6�   $y�Hidden=�6�    � Cursor$
 Hand��6�   �� 5      -   5        	 ��Name$	 txtProveedor��5      $��12(�60   $��Normal"�6>   
�������$��0q�6�   $��0,0,0,0.333q�6�   $	��130��6�   
���   �$	��Top=�6�   $��Stretch=�6  $��Stretch=�60  6R  5      5      �� 5   
   -	   5        
 ��Name$
 btnCrear��5      $��OK��6:   $
��Left=�6G   $��
21,117,0,0q�6b   $	��Top=�6v   $��95��6�   $��3q�6�   �� 5   
   -
   5        $
 btnCancelar��5      $��Cancelar��6&   $
��Left=�69   $��130,117,0,0q�6T   $	��Top=�6i   $��94��6�   $��3q�6�   
�������
�������6�   5      5      