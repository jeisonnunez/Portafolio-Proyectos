   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:Vista.Informes_Fiscales.Formularios#Vista.Informes_Fiscales.Formularios  5   	   B    <Vista.Informes_Fiscales.Formularios.ComprobanteISLROperacion   5   	   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Clocal1clr-namespace:Vista.Informes_Fiscales.Formularios     5   	   -   5          � Title$  ComprobanteISLROperacion��5   	    � WindowStartupLocation$ CenterScreen=�6*   $��212.667��6h   $	��450��6y   .��5	      � .+�5
   
   �� -   5         ��Name$ lblTipoTransaccion��5
      $
��Bold"�60   $
��Left=�6B   $��	21,68,0,0q�6]   $
��Wrap=�6p   $��Tipo Transaccion:��6�   $	��Top=�6�   �� 5   
   -   5         ��Name$ cbTipoTransaccion��5       �� DisplayMemberPath$
 Name��6.    �� SelectedValuePath$
 Code��6G      ComboBoxStyle#��[  6`   $��23��6�   
������� �� 
IsReadOnly . 
���   �$
��Left=�6  $��
230,64,0,0q�6"  $	��Top=�66  $	��162��6N  �� 5   
   -   5        $ lblProveedor��5      $
��Bold"�6*   $
��Left=�6<   $��
21,102,0,0q�6W   $
��Wrap=�6k   $��
Proveedor:��6   $	��Top=�6�   �� 5   
   -   5        $��bdProveedor��5   ^   $��1q�6   
������� �� CornerRadius$ 3��68   $��231,100,0,0q�6I   
�������$
��Left=�6�   $	��162��6�   $��25��6�   $	��Top=�6�   ._�5      ]� -   5        $��dpProveedor��5   U   $��1��6   $��1��6%   $��4.667,0.667,4.667,0.5q�66   
�������.+�5      �� -   5        $��imgProveedor��5   �   $��Right=�6]   $��lupa.png��6t   $��20��6�   $��0,0,0,-0.333q�6�   $y�Hidden=�6�    � Cursor$
 Hand��6�   �� 5      -   5        	 ��Name$	 txtProveedor��5      $��12(�60   $��Normal"�6>   
�������$��0q�6�   $��0,0,0,0.333q�6�   $	��130��6�   
���   �$	��Top=�6�   $��Stretch=�6  $��Stretch=�60  6R  5      5      �� 5   
   -	   5        
 ��Name$
 btnCrear��5      $��OK��6#   $
��Left=�60   $��
21,137,0,0q�6K   $	��Top=�6_   $��95��6w   $��3q�6�   6�   �� 5   
   -
   5        $
 btnCancelar��5      $��Cancelar��6&   $
��Left=�69   $��130,137,0,0q�6T   $	��Top=�6i   $��94��6�   $��3q�6�   
�������
�������6�   �� 5   
   -   5        $ lblNroDocumento��5      $
��Bold"�6-   $
��Left=�6?   $��	21,27,0,0q�6Z   $
��Wrap=�6m   $��NroDocumento:��6�   $	��Top=�6�   �� 5   
   -   5        $	 txtNoDocumento��5      $��1q�6*   
�������$
��Left=�6�   $��23��6�   $��
230,27,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��162��6�   .��6�    � 	Resources 5       �� 
TargetType �� Property �� Value��%^   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 3��65   5      5      .��6!   5      5      5       