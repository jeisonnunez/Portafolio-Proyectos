   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  7    1Vista.GestionarReconciliacionesInternasAnteriores   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Vista     -     � Title$1  +GestionarReconciliacionesInternasAnteriores��$��321.292��$��597.619�� � WindowStartupLocation$ CenterScreen=�.��� .+��� -    ��Name$ 
lblSNDesde��$
��Bold"�$��12(�
���   �$
��Left=�$��	23,32,0,0q�$
��Wrap=�$��Desde��$	��Top=��� -   $ 
lblSNHasta��$
��Bold"�$��12(�
���   �$
��Left=�$��
310,32,0,0q�$
��Wrap=�$��Hasta��$	��Top=��� -    ��Name$ 	bdDesdeSN��$��1q�
������� �� CornerRadius$ 3��$��
155,28,0,0q�
�������$
��Left=�$	��135��$��25��$	��Top=�._�]� -    ]�Name$ 	dpDesdeSN��$��1��$��1��$��4.667,0.667,4.667,0.5q�
�������.+��� -    ��Name$ 
imgDesdeSN��$��Right=�$5��//Vista;component/Utilidades/Formulario/lupa.png��$��20��$��0,0,0,-0.333q�$y�Hidden=� � Cursor$
 Hand���� -    ��Name$ 
txtDesdeSN��$��12(�$��Normal"�
�������$��0q�$��0,0,0,0.333q�$	��123��
���   �$	��Top=�$��Stretch=�$��Stretch=��� -   $ 	bdHastaSN��$��1q�
�������$ 3��$��
357,28,0,0q�
�������$
��Left=�$	��139��$��25��$	��Top=�._�]� -	   $ 	dpHastaSN��$��1��$��1��$��4.667,0.667,4.667,0.5q�
�������.+��� -
   $ 
imgHastaSN��$��Right=�$5��//Vista;component/Utilidades/Formulario/lupa.png��$��20��$��0,0,0,-0.333q�$y�Hidden=�$
 Hand���� -   $ 
txtHastaSN��$��12(�$��Normal"�
�������$��0q�$��0,0,0,0.333q�$	��119��
���   �$	��Top=�$��Stretch=�$��Stretch=��� -   $ lblDFechaVencimiento��$
��Bold"�$��12(�
���   �$
��Left=�$��	23,91,0,0q�$
��Wrap=�$��Desde��$	��Top=�(  "System.Windows.Controls.DatePicker  -   	  Name$	 dpDFechaReconciliacion��$
��Left=�$��
154,85,0,0q�$	��Top=�$	��138��
 � 	Resources
  �� 
TargetType �� Property �� Value��%9   '��       �� " ��.���  �@��CornerRadius$ 3���� -   $ lblHFechaVencimiento��$
��Bold"�$��12(�
���   �$
��Left=�$��
313,89,0,0q�$
��Wrap=�$��Hasta��$	��Top=�  -   $	 dpHFechaReconciliacion��$
��Left=�$��
357,85,0,0q�$	��Top=�$	��139��
 ��%9   '��       �� " ��.���  �@��CornerRadius$ 3���� -   $ lblDNroReconciliacion��$
��Bold"�$
��Left=�$��
21,141,0,0q�$
��Wrap=�$��Nro Reconciliacion de��$	��Top=��� -   $ txtDNroReconciliacion��$��1q�
�������$
��Left=�$��25��$��154,137,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��138��.��
 ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -   $ txtHNroReconciliacion��$��1q�
�������$
��Left=�$��25��$��358,137,0,0q�$
 Wrap=�$	��Top=�$	��138��.��
 ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -   $ lblHFechaVencimiento_Copy��$
��Bold"�$��12(�
���   �$
��Left=�$��313,139,0,0q�$
��Wrap=�$��Hasta��$	��Top=��� -    ��Name$ btnOK��$��OK��$
��Left=�$��
26,233,0,0q�$	��Top=�$��95��$��3q��� -   $ btnCancelar��$��Cancelar��$
��Left=�$��148,233,0,0q�$	��Top=�$��94��$��3q�
�������
�������