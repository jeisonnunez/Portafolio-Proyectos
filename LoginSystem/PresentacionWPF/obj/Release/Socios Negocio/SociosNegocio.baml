   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista      Vista.SociosNegocio   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Vista     -     � Title$  Socios Negocio��$	��713��$��853.5�� � WindowStartupLocation$ CenterScreen=� � ContextMenu �� .@�m� -   $��Deleted��$��Eliminar��.���� $
��Auto=�$
��Auto=�.��� $��Center=�$	��Top=�.+��� -    ��Name$ imgleft�� � Cursor$
 Hand��$��003-anterior-2.png��$
��Left=�$��28��$��
439,10,0,0q�$	��Top=�$��31���� -   $ imgRight��$
 Hand��$��004-proximo.png��$
��Left=�$��28��$��
479,10,0,0q�$	��Top=�$��31�� J� RenderTransformOrigin$ 1.296,0.488&��� -   $ imgCrear��$
 Hand��$��001-texto.png��$
��Left=�$��28��$��
326,10,0,0q�$	��Top=�$��31��$ 1.296,0.488&��� -   $ 	imgBuscar��$
 Hand��$��002-encontrar.png��$
��Left=�$��28��$��
365,10,0,0q�$	��Top=�$��31��$ 1.296,0.488&��� -   $ 	imgInicio��$
 Hand��$��001-anterior.png��$
��Left=�$��28��$��
403,10,0,0q�$	��Top=�$��31��$ 1.296,0.488&��� -   $ imgFin��$
 Hand��$��002-anterior-1.png��$
��Left=�$��28��$��
515,10,0,0q�$	��Top=�$��31��$ 1.296,0.488&��� -	    ��Name$ tcNotaDebitoProveedores��$
��Left=�$	��371��$��
36,238,0,0q�$	��Top=�$	��772�� � 	Resources  �� 
TargetType	 �� Property
 �� Value �� 
TargetType �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  '��       �� " ��.��� 	 � ��
 �� " ��.R��� $��Border��$��1,1,1,0q�
�������$ 4,4,0,0��$	��2,0q�._��� $ ContentSite��$��Center=�$��Center=�$��Header��$
��10,2q� P�  �@��
IsSelected . . ��� $ Border��	 � ��
 �	#FF2196F3�� 	 � ��

 ������� 	 � ��$
 14(�P�  �@��
IsSelected .  . ��� $ Border��	 � ��

 �����.@��� -
   $��
tabGeneral��$��General��$
��Bold"�.��� ���	#FFE5E5E5$��Stretch=�$��Stretch=� � ColumnDefinitions �� $	��66* ��� $
��317* �.+��� -    ��Name$ 	lblPhone1��$��12(�$
��Bold"�$
��Left=�$��	13,25,0,0q�$
��Wrap=�$��	Telefono1��
���   �$	��Top=��� -    ��Name$ 	txtPhone1��$��12(�
���   �$	��Top=�$��1q�
�������$
��Left=�$��23��$��
117,23,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��186��$��2��$��Normal"�.�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��.���� -   $ 	lblPhone2��$��12(�$
��Bold"�$
��Left=�$��	13,59,0,0q�$
��Wrap=�$��	Telefono2��
���   �$	��Top=��� -   $ 	txtPhone2��$��12(�$��Normal"�
���   �$	��Top=�$��1q�
�������$
��Left=�$��23��$��
117,57,0,0q�$
 Wrap=�$	��Top=�$	��186��$��2��.�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��.���� -   $ lblFax��$��12(�$
��Bold"�$
��Left=�$��	13,93,0,0q�$
��Wrap=�$	��FAX��
���   �$	��Top=��� -   $ txtFax��$��12(�$��Normal"�
���   �$	��Top=�$��1q�
�������$
��Left=�$��23��$��
117,91,0,0q�$
 Wrap=�$	��Top=�$	��186��$��2��.�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��.���� -   $ 	lblCorreo��$��12(�$
��Bold"�$
��Left=�$��253.333,25,0,0q�$
��Wrap=�$��Correo��
���   �$	��Top=�$��1���� -   $ 	txtCorreo��$��12(�$��Normal"�
���   �$	��Top=�$��1q�
�������$
��Left=�$��23��$��379.333,23,0,0q�$
 Wrap=�$	��Top=�$	��186��$��1��.�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��.���� -   $ lblSitioWeb��$��12(�$
��Bold"�$
��Left=�$��253.333,59,0,0q�$
��Wrap=�$��	Sitio Web��
���   �$	��Top=�$��1���� -   $ txtSitioWeb��$��12(�$��Normal"�
���   �$	��Top=�$��1q�
�������$
��Left=�$��23��$��379.333,57,0,0q�$
 Wrap=�$	��Top=�$	��186��$��1��.�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��.���� -   $ lblPersonaContacto��$��12(�$
��Bold"�$
��Left=�$��253.333,93,0,0q�$
��Wrap=�$��Persona Contacto��
���   �$	��Top=�$��1���� -   $ txtPersonaContacto��$��12(�$��Normal"�
���   �$	��Top=�$��1q�
�������$
��Left=�$��23��$��379.333,91,0,0q�$
 Wrap=�$	��Top=�$	��186��$��1��.�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��.���� -   $��tabDirecciones��$��Direcciones��$
��Bold"�.��� ���	#FFE5E5E5.+�&   System.Windows.Controls.DataGrid  -   $��dgDirecciones��$��553,42,26.333,67q�$y�Hidden=�   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * $��Center=�$��Center=�   GridLinesVisibility$	 All=�   VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����$��1q�
�������   AutoGenerateColumns .     	CellStyle �� *  $System.Windows.Controls.DataGridCell"   �� Triggers P�  �@J�IsMouseOver . . ��� 	 � ��

 ��ح��� 	 � ��

 �   �.��� 	 � ��$
 30��   RowStyle �� )  #System.Windows.Controls.DataGridRow"   P�  �@J�IsMouseOver . . ��� 	 � ��

 �����   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ 	Direccion��    Width$  * ! �� TextAlignment$! Center=�1  +System.Windows.Controls.DataGridBoundColumn"   Binding" �� *Datos+#   ElementStyle# �� " ��.��� 	 � ��$
 Center=�$   HeaderStyle$ �� =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  .��� 	 � ��$
 Center=��� -   $ lblDireccion��$��12(�$
��Bold"�$
��Left=�$��	13,25,0,0q�$
��Wrap=�$��	Direccion��
���   �$	��Top=��� -   $ txtDireccion��$��12(�$��Normal"�
���   �$	��Top=�$��1q�
�������$
��Left=�$	��137��$��
117,23,0,0q�$
 Wrap=�$	��Top=�$	��232��.�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��.���� -   $��tabFinanzas��$��Finanzas��$
��Bold"�.��� ���	#FFE5E5E5.+��� -   $ lblCuentaAsociada��$��12(�
���   �$
��Bold"�$
��Left=�$��	24,24,0,0q�$
��Wrap=�$��Cuenta Asociada��$	��Top=�$��95���� -   $ lblImpuesto��$��12(�
���   �$
��Bold"�$
��Left=�$��	24,54,0,0q�$
��Wrap=�$��Impuesto��$	��Top=�$��95���� -   $��
bdImpuesto��$��1q�
�������$ 3��$��140,50,461.333,263q�
�������._�]� -   $��
dpImpuesto��$��1��$��1��$��4.667,1.5,4.667,1q�$��Stretch=�$��Stretch=�
�������.+��� -    $��imgImpuesto��$��Right=�$��lupa.png��$��20��$��0,0,0,-0.333q�$y�Hidden=�$
 Hand���� -!   $ txtImpuesto��$��12(�$��Normal"�$��Stretch=�
�������$��0q�$��0,0,0,-0.333q�$	��130��
���   �$	��Top=��� -"   $��bdCuentaAsociada��$��1q�
�������$ 3��$��141,20,460.333,293q�
�������._�]� -#   $��dpCuentaAsociada��$��1��$��1��$��4.667,1.5,4.667,1q�$��Stretch=�$��Stretch=�
�������.+��� -$   $��imgCuentaAsociada��$��Right=�$��lupa.png��$��20��$��0,0,0,-0.333q�$y�Hidden=�$
 Hand���� -%   $ txtCuentaAsociada��$��12(�$��Normal"�$��Stretch=�
�������$��0q�$��0,0,0,-0.333q�$	��130��
���   �$	��Top=��� -&   $ 	lblCodigo��$
��Bold"�$
��Left=�$��	41,49,0,0q�$
��Wrap=�$��Codigo��$	��Top=��� -'   $ 	txtCodigo��$��1q�
�������$
��Left=�$��23��$��
156,45,0,0q�$
 Wrap=�$	��Top=�$��80��.�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��.���� -(   $ 	lblNombre��$
��Bold"�$
��Left=�$��	41,79,0,0q�$
��Wrap=�$��Nombre��$	��Top=��� -)   $ 	txtNombre��$��1q�
�������$
��Left=�$��23��$��
156,75,0,0q�$
 Wrap=�$	��Top=�$	��157��.�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��.���� -*   $ lblRIF��$
��Bold"�$
��Left=�$��
41,109,0,0q�$
��Wrap=�$	��RIF��$	��Top=��� -+   $ txtRIF��$��1q�
�������$
��Left=�$��23��$��156,105,0,0q�$
 Wrap=�$	��Top=�$	��157��.�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��.���� -,   % ��Name$
% cbSN��   ComboBoxStyle#��[  $��23��
�������& �� 
IsReadOnly& . 
���   �$��1q�$
��Left=�$��
241,45,0,0q�$	��Top=�$��72���� --   $ 	lblMoneda��$
��Bold"�$
��Left=�$��
41,139,0,0q�$
��Wrap=�$��Moneda��$	��Top=��� -.   $% cbMoneda��' �� DisplayMemberPath$' CurrName��( �� SelectedValuePath$( CurrCode��#��[  $��23��) �� 
IsEditable) . & . 
���   �$
��Left=�$��156,135,0,0q�$	��Top=�$	��157��
����ح��� -/   $ lblSaldoCuenta��$
��Bold"�$
��Left=�$��
535,77,0,0q�$
��Wrap=�$��Saldo de Cuenta��$	��Top=��� -0   $ txtSaldoCuenta��* �� 
IsReadOnly* . ���	#FFE5E5E5$��1q�$
��Left=�$��23��$��
652,73,0,0q�$
 Wrap=�$	��Top=�$	��156��.�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��.���� -1   $ lblPedidosEntrada��$
��Bold"�$
��Left=�$��535,107,0,0q�$
��Wrap=�$��Entrada Mercancia��$	��Top=��� -2   $ txtPedidosEntrada��$��1q�* . ���	#FFE5E5E5$
��Left=�$��23��$��652,103,0,0q�$
 Wrap=�$	��Top=�$	��156��.�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��.���� -3   + ��Name$+ btnCrear��$��Crear��$
��Left=�$��
36,635,0,0q�$	��Top=�$��95��$��3q��� -4   $+ btnCancelar��$��Cancelar��$
��Left=�$��158,635,0,0q�$	��Top=�$��94��$��3q�
�������
��������� -5   $ lblTipoPersona��$
��Bold"�$
��Left=�$��
41,169,0,0q�$
��Wrap=�$��Tipo Persona��$	��Top=��� -6   $% cbTipoPersona��#��[  $��23��
�������& . $
��Left=�$��156,165,0,0q�$	��Top=�$	��157������ , �� Path$, ListTipoCuenta�- �� UpdateSourceTrigger$- PropertyChanged=�' �� $, 
TipoCuenta�$- PropertyChanged=�( �� $, 
TipoCuenta�$- PropertyChanged=��� -7   $ lblContribuyente��$
��Bold"�$
��Left=�$��
41,199,0,0q�$
��Wrap=�$��Contribuyente��$	��Top=��� -8   $% cbContribuyente��. K� ZIndex$. 1��#��[  $��23��
�������& . 
���   �$
��Left=�$��156,195,0,0q�$	��Top=�$	��157������ *	ListYesNo+' �� *YesNo+( �� *YesNo+�� -9   $ lblSucursal��$
��Bold"�$
��Left=�$��537,137,0,0q�$
��Wrap=�$��Sucursal��$	��Top=��� -:   $% 
cbSucursal��#��[  $��23��
�������& . 
���   �$
��Left=�$��652,133,0,0q�$	��Top=�$	��156������ *	ListYesNo+' �� *YesNo+( �� *YesNo+�� -;   $ lblITF��$
��Bold"�$
��Left=�$��537,169,0,0q�$
��Wrap=�$��
Aplica ITF��$	��Top=��� -<   $% cbITF��#��[  $��23��
�������& . 
���   �$
��Left=�$��652,165,0,0q�$	��Top=�$	��156������ *	ListYesNo+' �� *YesNo+( �� *YesNo+�� -=   $% cbSaldoMoneda��#��[  $��23��
�������& . 
���   �$
��Left=�$��
652,41,0,0q�$	��Top=�$	��156��