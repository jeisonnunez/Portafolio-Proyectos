   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5      _4clr-namespace:Vista.Informes_Financieros.Formularios&Vista.Informes_Financieros.Formularios  5   	   B    <Vista.Informes_Financieros.Formularios.TipoCambioAlternativo   5      local1clr-namespace:Vista  n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Flocal4clr-namespace:Vista.Informes_Financieros.Formularios     5   	      Vista.Converter    Loaded$  Window_Loaded��5   i      Closing$ Window_Closing��6�    � Title$ TipoCambioAlternativo��6	   $��274.586��6'   $	��717��68    � WindowStartupLocation$ CenterScreen=�6D   .��5	      � .+�5
   
   �� -   5         ��Name$ lblDFechaVencimiento��5
      $
��Bold"�62   $��14(�6D   
���   �$
��Left=�6e   $��	31,93,0,0q�6�   $
��Wrap=�6�   $��Fecha Vencimiento Desde��6�   $	��Top=�6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dpDFechaVencimiento��5   h   $
��Left=�6   $��
210,89,0,0q�60   $	��Top=�6D   $	��138��6\    � 	Resources 5       �� 
TargetType �� Property	 �� Value��%^   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$	 3��65   5      5      5      �� 5   
   -   5        $ lblHFechaVencimiento��5      $
��Bold"�62   $��14(�6D   
���   �$
��Left=�6e   $��
371,91,0,0q�6�   $
��Wrap=�6�   $��Fecha Vencimiento Hasta��6�   $	��Top=�6�     5   
   -   5        $ dpHFechaVencimiento��5   h   $
��Left=�6   $��
551,87,0,0q�60   $	��Top=�6D   $	��132��6\    5      ��%^   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$	 3��65   5      5      5      �� 5   
   -   5        $ lblTipoCambio��5      $
��Left=�6+   $��
33,142,0,0q�6F   $��Tipo de Cambio��6Z   $
��Wrap=�6p   $	��Top=�6�   $
��Bold"�6�   $��14(�6�   $	��146��6�   �� 5   
   -   5        
 ��Name$
 txtTipoCambio��5   9   $��1q�6   
�������$
��Left=�6�   $��210,138,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��138��6�   $��25��6�   .��6�    5      ��%^   '��       �� 5      " ��6   .�5       ��  �@��CornerRadius$	 3��65   5"      5#      .��6!   5%      �� 5&   
   -   5         ��Name$ btnEjecutar��5&      $��Ejecutar��6&   $
��Left=�69   $��
34,191,0,0q�6T   $	��Top=�6h   $��94��6�   $��3q�6�   6�   �� 5'   
   -   5        $ btnCancelar��5'      $��Cancelar��6&   $
��Left=�69   $��151,191,0,0q�6T   $	��Top=�6i   $��94��6�   $��3q�6�   
�������
�������6�   �� 5(   
   -	   5        $ lblCuentaBeneficio��5(      $
��Bold"�60   $
��Left=�6B   $��	31,41,0,0q�6]   $
��Wrap=�6p   $��Cuenta Beneficio��6�   $��14(�6�   $	��Top=�6�   �� 5)   
   -
   5         ��Name$ bdCuentaBeneficioCliente��5)   ]   $��1q�6   
������� �� CornerRadius$ 3��68   $��
210,36,0,0q�6I   
�������$
��Left=�6�   $	��138��6�   $��25��6�   $	��Top=�6�   ._�5*      ]� -   5         ]�Name$ dpCuentaBeneficioCliente��5*   U   $��1��6   $��1��6%   $��4.667,0.667,4.667,0.5q�66   
�������.+�5+      �� -   5         ��Name$ imgCuentaBeneficioCliente��5+   �   $��Right=�6j   $(��"/Vista;component/Finanzas/lupa.png��6�   $��20��6�   $��0,0,0,-0.333q�6�   $y�Hidden=�6�    � Cursor$
 Hand��6  �� 5,      -   5        $
 txtCuentaBeneficio��5,      $��12(�66   $��Normal"�6D   
�������$��0q�6�   $��0,0,0,0.333q�6�   $	��130��6�   
���   �$	��Top=�6�   $��Stretch=�6  $��Stretch=�60  5-      5.      �� 5/   
   -   5        $ lblCuentaPerdida��5/      $
��Bold"�6.   $
��Left=�6@   $��
369,41,0,0q�6[   $��14(�6o   $
��Wrap=�6}   $��Cuenta Perdida��6�   $	��Top=�6�   �� 50   
   -   5        $ bdCuentaPerdidaCliente��50   ]   $��1q�6   
�������$ 3��68   $��
549,36,0,0q�6I   
�������$
��Left=�6�   $	��135��6�   $��25��6�   $	��Top=�6�   ._�51      ]� -   5        $ dpCuentaPerdidaCliente��51   U   $��1��6   $��1��6%   $��4.667,0.667,4.667,0.5q�66   
�������.+�52      �� -   5        $ imgCuentaPerdidaCliente��52   �   $��Right=�6h   $(��"/Vista;component/Finanzas/lupa.png��6   $��20��6�   $��0,0,0,-0.333q�6�   $y�Hidden=�6�   $
 Hand��6  �� 53      -   5        $
 txtCuentaPerdida��53      $��12(�64   $��Normal"�6B   
�������$��0q�6�   $��0,0,0,0.333q�6�   $	��130��6�   
���   �$	��Top=�6�   $��Stretch=�6  $��Stretch=�6.  54      55      57      58      