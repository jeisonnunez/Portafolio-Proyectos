   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista      Vista.PlanCuentas   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Vista     -     � Title$  PlanCuentas��$	��577��$��929.562�� � WindowStartupLocation$ CenterScreen=�.���� $
��Auto=�$
��Auto=�.��� $��Center=�$	��Top=�$��0,10,0,0q�.+��� -    ��Name$ 
tabControl��$
��Left=�$	��466��$��	33,44,0,0q�$	��Top=�$	��879�� �� TabStripPlacement$ Right=� � 	Resources  �� 
TargetType �� Property �� Value �� 
TargetType	 �� CornerRadius
 ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  '��       �� " ��.���  � �� �� " ��.R��� $��Border��$��1,1,1,0q�
�������$	 4,4,0,0��$	��2,0q�._��� $
 ContentSite��$��Center=�$��Center=�$��Header��$
��10,2q� P�  �@��
IsSelected . . ��� $ Border�� � �� �	#FF2196F3��  � ��
 �������  � ��$ 14(�P�  �@��
IsSelected .  . ��� $ Border�� � ��
 �����.@��� -   $��tabItemActivos��$��Activos��$��0,-2,-2,-24.667q�$��12(�$
��Bold"�.��� .+�R� -    R�Name$ treeViewActivos��
����  �$��1q����	#FFE5E5E5$
��Left=�$	��459��$��300,0,-0.333,0q�$	��Top=�$	��423��  �� Triggers ^� 
Conditions �� Binding �� RelativeSource �� Path �� Value �� AncestorType��%P  'Q�       �� " Q�.���  � �� �� .R��� ._��� ���� ���� " ��.���  � ��$ 1q���  � ��
 ����  ^�  ��  ��  �� *Self+$ IsMouseOver� True��  ��  �� $ TreeViewItemL�$ 
IsSelected�	 False.0���  � �� �	#ffe5f3fb��  � �� �	#ffa5d7f0�� -   $��tabItemPasivos��$��Pasivos��$��0,28.333,-2,-54q�$��12(�$
��Bold"�.��� .+�R� -   $ treeViewPasivos��
����  �$��1q�$
��Left=�$	��459��$��300,0,-0.333,0q�$	��Top=�$	��423�����	#FFE5E5E5 ��%P  'Q�       �� " Q�.���  � �� �� .R��� ._��� ���� ���� " ��.���  � ��$ 1q���  � ��
 ����  ^�  ��  ��  �� *Self+$ IsMouseOver� True��  ��  �� $ TreeViewItemL�$ 
IsSelected�	 False.0���  � �� �	#ffe5f3fb��  � �� �	#ffa5d7f0�� -   $��tabItemPatrimonio��$��
Patrimonio��$��0,58,-2,-84.333q�$��12(�$
��Bold"�.��� .+�R� -   $ treeViewPatrimonio��
����  �$��1q�$
��Left=�$	��459��$��300,0,-0.333,0q�$	��Top=�$	��423�����	#FFE5E5E5 ��%P  'Q�       �� " Q�.���  � �� �� .R��� ._��� ���� ���� " ��.���  � ��$ 1q���  � ��
 ����  ^�  ��  ��  �� *Self+$ IsMouseOver� True��  ��  �� $ TreeViewItemL�$ 
IsSelected�	 False.0���  � �� �	#ffe5f3fb��  � �� �	#ffa5d7f0�� -	   $��tabItemIngresos��$��Ingresos��$��0,89,-2,-115q�$��12(�$
��Bold"�.��� .+�R� -
   $ treeViewIngresos��
����  �$��1q�$
��Left=�$	��459��$��300,0,-0.333,0q�$	��Top=�$	��423�����	#FFE5E5E5 ��%P  'Q�       �� " Q�.���  � �� �� .R��� ._��� ���� ���� " ��.���  � ��$ 1q���  � ��
 ����  ^�  ��  ��  �� *Self+$ IsMouseOver� True��  ��  �� $ TreeViewItemL�$ 
IsSelected�	 False.0���  � �� �	#ffe5f3fb��  � �� �	#ffa5d7f0�� -   $��tabItemCostos��$��Gastos��$��0,119.333,-2,-145.333q�$��12(�$
��Bold"�.��� .+�R� -   $ treeViewGastos��
����  �$��1q�$
��Left=�$	��459��$��300,0,-0.333,0q�$	��Top=�$	��423�����	#FFE5E5E5 ��%P  'Q�       �� " Q�.���  � �� �� .R��� ._��� ���� ���� " ��.���  � ��$ 1q���  � ��
 ����  ^�  ��  ��  �� *Self+$ IsMouseOver� True��  ��  �� $ TreeViewItemL�$ 
IsSelected�	 False.0���  � �� �	#ffe5f3fb��  � �� �	#ffa5d7f0�� -   $��tabItemGastos��$��Gastos Operacionales��$��0,148.333,-2,-174.333q�$��12(�$
��Bold"�.��� .+�R� -   $! treeViewGastosOperacionales��
����  �$��1q�$
��Left=�$	��459��$��300,0,-0.333,0q�$	��Top=�$	��423�����	#FFE5E5E5 ��%P  'Q�       �� " Q�.���  � �� �� .R��� ._��� ���� ���� " ��.���  � ��$ 1q���  � ��
 ����  ^�  ��  ��  �� *Self+$ IsMouseOver� True��  ��  �� $ TreeViewItemL�$ 
IsSelected�	 False.0���  � �� �	#ffe5f3fb��  � �� �	#ffa5d7f0�� -   $��tabItemOtrosIngresos��$��Otros Ingresos��$��0,178.333,-2,-204.333q�$��12(�$
��Bold"�.��� .+�R� -   $ treeViewOtrosIngresos��
����  �$��1q�$
��Left=�$	��459��$��300,0,-0.333,0q�$	��Top=�$	��423�����	#FFE5E5E5 ��%P  'Q�       �� " Q�.���  � �� �� .R��� ._��� ���� ���� " ��.���  � ��$ 1q���  � ��
 ����  ^�  ��  ��  �� *Self+$ IsMouseOver� True��  ��  �� $ TreeViewItemL�$ 
IsSelected�	 False.0���  � �� �	#ffe5f3fb��  � �� �	#ffa5d7f0�� -   $��tabItemOtrosGastos��$��Otros Gastos��$��0,208.333,-2,-234.333q�$��12(�$
��Bold"�.��� .+�R� -   $ treeViewOtrosGastos��
����  �$��1q�$
��Left=�$	��459��$��300,0,-0.333,0q�$	��Top=�$	��423�����	#FFE5E5E5 ��%P  'Q�       �� " Q�.���  � �� �� .R��� ._��� ���� ���� " ��.���  � ��$ 1q���  � ��
 ����  ^�  ��  ��  �� *Self+$ IsMouseOver� True��  ��  �� $ TreeViewItemL�$ 
IsSelected�	 False.0���  � �� �	#ffe5f3fb��  � �� �	#ffa5d7f0�� -    ��Name$ lblInfoCuenta��$
��Left=�$��	49,55,0,0q�$
��Wrap=�$$��Info Detallada Cuenta de Mayor��$	��Top=�$��14(�$
��Bold"�$��	Underline{�	� -    	�Name$ rbTitulo�� 	� 	GroupName$ cuenta��$
��Bold"�$��Titulo��$
��Left=�$��	46,83,0,0q�$	��Top=�	� -   $ rbCuentaActiva��$ cuenta��$
��Bold"�$��Cuenta Activa��$
��Left=�$��
164,83,0,0q�$	��Top=��� -   $ lblCuentaMayor��$
��Bold"�$
��Left=�$��
49,119,0,0q�$
��Wrap=�$��Cuenta de Mayor��$	��Top=��� -    ��Name$ 	txtCuenta��$��1q�
�������$
��Left=�$��23��$��164,115,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��162��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -   $ 	lblNombre��$
��Bold"�$
��Left=�$��
49,157,0,0q�$
��Wrap=�$��Nombre��$	��Top=��� -   $ 	txtNombre��$��1q�
�������$
��Left=�$��23��$��164,153,0,0q�$
 Wrap=�$	��Top=�$	��162��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -   $ 	lblMoneda��$
��Bold"�$
��Left=�$��
49,195,0,0q�$
��Wrap=�$��Moneda��$	��Top=��� -    ��Name$ cbMoneda�� �� DisplayMemberPath$ CurrName�� �� SelectedValuePath$ CurrCode��
�������   ComboBoxStyle#��[   �� 
IsReadOnly . 
���   �$��1q�$
��Left=�$��164,187,0,0q�$	��Top=�$	��161��$��24���� -   $ lblSaldo��$
��Bold"�$
��Left=�$��
49,297,0,0q�$
��Wrap=�$��Saldo��$	��Top=��� -   $ txtSaldo��
�������  �� 
IsReadOnly  . $��1q�$
��Left=�$��23��$��138,293,0,0q�$
 Wrap=�$	��Top=�$��90��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -   $ cbCodeMoneda��#��[  
������� . 
���   �$��1q�$
��Left=�$��237,293,0,0q�$	��Top=�$��88��$��22���� -   $ lblPropiedad��$
��Left=�$��
49,349,0,0q�$
��Wrap=�$!��Propiedades Cuenta de Mayor��$	��Top=�$��14(�$
��Bold"�$��	Underline{��� -    $ lblClaseCuenta��$
��Bold"�$
��Left=�$��
49,387,0,0q�$
��Wrap=�$��Clase de Cuenta��$	��Top=��� -!   ! ��Name$! cbxCuentaAsociada��$
��Bold"�$��Cuenta Asociada��$
��Left=�$��
51,422,0,0q�$	��Top=��� -"   $ lblNivel��$
��Bold"�$
��Left=�$��169,265,0,0q�$
��Wrap=�$��Nivel��$	��Top=��� -#   $ txtNivel��$��1q�
�������  . $
��Left=�$��23��$��237,261,0,0q�$
 Wrap=�$	��Top=�$��87��.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -$   " ��Name$" btnOk��$��OK��$
��Left=�$��
53,470,0,0q�$	��Top=�$��94��$��3q�$��16(��� -%   $" btnSalir��$��Cancelar��$
��Left=�$��175,470,0,0q�$	��Top=�$��94��
�������
�������$��3q�$��16(��� -&   $ cbClaseCuenta��#��[  $��25��
������� . 
���   �$��1q�$
��Left=�$��164,381,0,0q�$	��Top=�$	��161������ *ListTipoCuenta+ �� *
TipoCuenta+ �� *
TipoCuenta+