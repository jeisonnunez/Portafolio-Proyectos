   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  !    Vista.GenerarRetencionesIVA   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Vista     -     � Title$  GenerarRetencionesIVA��$	��403��$	��392�� � WindowStartupLocation$ CenterScreen=�.��� .+��� -    ��Name$ lblProveedor��$
��Bold"�$
��Left=�$��	21,37,0,0q�$
��Wrap=�$��
Proveedor:��$	��Top=��� -    ��Name$ bdProveedor��$��1q�
������� �� CornerRadius$ 3��$��
147,32,0,0q�
�������$
��Left=�$	��161��$��25��$	��Top=�._�]� -    ]�Name$ dpProveedor��$��1��$��1��$��4.667,0.667,4.667,0.5q�
�������.+��� -    ��Name$ imgProveedor��$��Right=�$��lupa.png��$��20��$��0,0,0,-0.333q�$y�Hidden=� � Cursor$
 Hand���� -    ��Name$ txtProveedor��$��12(�$��Normal"�
�������$��0q�$��0,0,0,0.333q�$	��114��
���   �$	��Top=�$��Stretch=�$��Stretch=��� -   $ lblProveedorH��$
��Bold"�$
��Left=�$��	21,79,0,0q�$
��Wrap=�$��
Proveedor:��$	��Top=��� -   $ bdProveedorH��$��1q�
�������$ 3��$��
145,74,0,0q�
�������$
��Left=�$	��163��$��25��$	��Top=�._�]� -	   $ dpProveedorH��$��1��$��1��$��4.667,0.667,4.667,0.5q�
�������.+��� -
   $ imgProveedorH��$��Right=�$��lupa.png��$��20��$��0,0,0,-0.333q�$y�Hidden=�$
 Hand���� -   $ txtProveedor1��$��12(�$��Normal"�
�������$��0q�$��0,0,0,0.333q�$	��114��
���   �$	��Top=�$��Stretch=�$��Stretch=��� -   	 ��Name$	 btnCrear��$��OK��$
��Left=�$��
26,320,0,0q�$	��Top=�$��95��$��3q��� -   $	 btnCancelar��$��Cancelar��$
��Left=�$��136,318,0,0q�$	��Top=�$��94��$��3q�
�������
��������� -   $ lblQuincena��$
��Bold"�$
��Left=�$��
21,122,0,0q�$
��Wrap=�$��	Quincena:��$	��Top=��� -   
 ��Name$
 
cbQuincena�� �� DisplayMemberPath$
 Name�� �� SelectedValuePath$
 Code��   ComboBoxStyle#��[  $��25��
������� �� 
IsReadOnly . 
���   �$
��Left=�$��146,118,0,0q�$	��Top=�$	��162���� -   $ lblTipo��$
��Bold"�$
��Left=�$��
21,162,0,0q�$
��Wrap=�$��Tipo:��$	��Top=��� -   $
 cbTipo��$
 Name��$
 Code��#��[  $��25��
������� . 
���   �$
��Left=�$��146,158,0,0q�$	��Top=�$	��162���� -   $ lblMes��$
��Bold"�$
��Left=�$��
21,202,0,0q�$
��Wrap=�$
��Mes:��$	��Top=��� -   $
 cbMes��$ Month��$
 Code��#��[  $��25��
������� . 
���   �$
��Left=�$��146,198,0,0q�$	��Top=�$	��162���� -   $ lblAnno��$
��Bold"�$
��Left=�$��
21,238,0,0q�$
��Wrap=�$��Año:��$	��Top=��� -   $
 cbAnno��$ Category��$ Category��#��[  $��25��
������� . 
���   �$
��Left=�$��146,234,0,0q�$	��Top=�$	��162��