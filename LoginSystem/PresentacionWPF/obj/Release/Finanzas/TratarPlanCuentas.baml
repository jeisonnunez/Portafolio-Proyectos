   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista      Vista.TratarPlanCuentas   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Vista     -     � Title$  TratarPlanCuentas��$��556.22��$	��978�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � ContextMenu �� .@�m� -   $��Deleted��$��Eliminar��.���� $
��Auto=�$
��Auto=�.��� $��Center=�$	��Top=�$��0,10,0,0q�.+�R� -    R�Name$ treeViewCuentas�����	#FFE5E5E5
����  �$��1q�$
��Left=�$	��430��$��
339,10,0,0q�$	��Top=�$	��609��$
��Bold"�
����  � � 	Resources  �� 
TargetType �� Property �� Value	 �� Triggers
 ^� 
Conditions �� Binding �� RelativeSource �� Path �� Value �� AncestorType��%P  'Q�       �� " Q�.���  � �� �� .R��� ._��� ���� ���� " ��.���  � ��$ 1q���  � ��
 ���� 	 ^� 
 ��  ��  �� *Self+$ IsMouseOver� True��  ��  �� $ TreeViewItemL�$ 
IsSelected�	 False.0���  � �� �	#ffe5f3fb��  � �� �	#ffa5d7f0�� -    ��Name$ lblInfoCuenta��$
��Left=�$��	17,17,0,0q�$
��Wrap=�$$��Info Detallada Cuenta de Mayor��$	��Top=�$��14(�$
��Bold"�$��	Underline{�	� -    	�Name$ rbTitulo��$
��Bold"�$��Titulo��$
��Left=�$��	14,45,0,0q�$	��Top=�	� -   $ rbCuentaActiva��$
��Bold"�$��Cuenta Activa��$
��Left=�$��
132,45,0,0q�$	��Top=��� -   $ lblCuentaMayor��$
��Bold"�$
��Left=�$��	17,81,0,0q�$
��Wrap=�$��Cuenta de Mayor��$	��Top=��� -    ��Name$ 	txtCuenta��$��1q�
�������$
��Left=�$��23��$��
132,77,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��162��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -	   $ 	lblNombre��$
��Bold"�$
��Left=�$��
17,119,0,0q�$
��Wrap=�$��Nombre��$	��Top=��� -
   $ 	txtNombre��$��1q�
�������$
��Left=�$��23��$��132,115,0,0q�$
 Wrap=�$	��Top=�$	��162��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -   $ lblUbicacion��$
��Left=�$��
17,311,0,0q�$
��Wrap=�$��Ubicacion Cuenta de Mayor��$	��Top=�$��14(�$
��Bold"�$��	Underline{��� -   $ lblCajon��$
��Bold"�$
��Left=�$��
17,351,0,0q�$
��Wrap=�$��Cajon��$	��Top=��� -   $ lblNivel��$
��Bold"�$
��Left=�$��137,159,0,0q�$
��Wrap=�$��Nivel��$	��Top=��� -   $ txtNivel��
������� �� 
IsReadOnly . $��1q�$
��Left=�$��23��$��205,155,0,0q�$
 Wrap=�$	��Top=�$��87��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -    ��Name$ btnOk��$��OK��$
��Left=�$��
21,462,0,0q�$	��Top=�$��94��$��3q�$��16(��� -   $ btnSalir��$��Cancelar��$
��Left=�$��138,462,0,0q�$	��Top=�$��94��
�������
�������$��3q�$��16(��� -    ��Name$ cbCajon��   ComboBoxStyle#��[  
������� �� 
IsReadOnly . 
���   �$��1q�$
��Left=�$��131,351,0,0q�$	��Top=�$	��161��$��24���� -   $ lblCuentaPadre��$
��Bold"�$
��Left=�$��
17,391,0,0q�$
��Wrap=�$��Articulo Superior��$	��Top=��� -   $ cbCuentaPadre��#��[  
������� . 
���   �$��1q�$
��Left=�$��131,391,0,0q�$	��Top=�$	��161��$��24���� -   $ btnAddCuentaNivel��{�.  $��Añadir Cuenta Nivel��$
��Left=�$��341,462,0,0q�$	��Top=�$	��168��$��3q�$��16(��� -   $ btnAddCuentaSubordinada��{�.  $��Añadir Cuenta Inferior��$
��Left=�$��770,462,0,0q�$	��Top=�$	��177��$��3q�$��16(�