   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:Vista.Informes_Fiscales.Formularios#Vista.Informes_Fiscales.Formularios  @    :Vista.Informes_Fiscales.Formularios.ListadoComprobantesIVA   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Clocal1clr-namespace:Vista.Informes_Fiscales.Formularios     -     � Title$  ListadoComprobantesIVA��$��272.334��$��350.333�� � WindowStartupLocation$ CenterScreen=�.��� .+��� -    ��Name$ lblDesde��$
��Bold"�$
��Left=�$��	21,26,0,0q�$
��Wrap=�$��Fecha Desde��$	��Top=��� -    ��Name$ btnCrear��$��OK��$
��Left=�$��
21,194,0,0q�$	��Top=�$��95��$��3q��� -   $ btnCancelar��$��Cancelar��$
��Left=�$��131,192,0,0q�$	��Top=�$��94��$��3q�
�������
�������(  "System.Windows.Controls.DatePicker  -     Name$ dpDesde��$
��Left=�$��
105,21,0,0q�$	��Top=�$	��143�� � 	Resources  �� 
TargetType �� Property �� Value��%9   '��       �� " ��.���  �@��CornerRadius$ 3���� -   $ lblHasta��$
��Bold"�$
��Left=�$��	21,64,0,0q�$
��Wrap=�$��Fecha Hasta��$	��Top=�  -   $ dpHasta��$
��Left=�$��
105,60,0,0q�$	��Top=�$	��143�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3���� -   $ lblProveedor��$
��Bold"�$
��Left=�$��
21,101,0,0q�$
��Wrap=�$��
Proveedor:��$	��Top=��� -	   	 ��Name$	 bdProveedor��$��1q�
�������
 �� CornerRadius$
 3��$��
107,96,0,0q�
�������$
��Left=�$	��141��$��25��$	��Top=�._�]� -
    ]�Name$ dpProveedor��$��1��$��1��$��4.667,0.667,4.667,0.5q�
�������.+��� -    ��Name$ imgProveedor��$��Right=�$��lupa.png��$��20��$��0,0,0,-0.333q�$y�Hidden=� � Cursor$
 Hand���� -    ��Name$ txtProveedor��$��12(�$��Normal"�
�������$��0q�$��0,0,0,0.333q�$	��114��
���   �$	��Top=�$��Stretch=�$��Stretch=��� -   $ lblProveedorH��$
��Bold"�$
��Left=�$��
21,135,0,0q�$
��Wrap=�$��
Proveedor:��$	��Top=��� -   $	 bdProveedorH��$��1q�
�������$
 3��$��107,130,0,0q�
�������$
��Left=�$	��141��$��25��$	��Top=�._�]� -   $ dpProveedorH��$��1��$��1��$��4.667,0.667,4.667,0.5q�
�������.+��� -   $ imgProveedorH��$��Right=�$��lupa.png��$��20��$��0,0,0,-0.333q�$y�Hidden=�$
 Hand���� -   $ txtProveedor1��$��12(�$��Normal"�
�������$��0q�$��0,0,0,0.333q�$	��114��
���   �$	��Top=�$��Stretch=�$��Stretch=�