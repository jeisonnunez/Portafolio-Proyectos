   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista      Vista.MediosPago   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Vista        Vista.Document    Closing$  Window_Closing�� � Title$ 
MediosPago��$��638.769��$��653.624�� � WindowStartupLocation$ CenterScreen=�.���� $
��Auto=�$
��Auto=�.��� $��Center=�$	��Top=�.+��� -    ��Name$ 	lblMoneda��$
��Bold"�$
��Left=�$��	67,20,0,0q�$
��Wrap=�$��Moneda��$	��Top=��� -    ��Name$ cbMoneda�� �� DisplayMemberPath$ CurrName�� �� SelectedValuePath$ CurrCode��   ComboBoxStyle#��[  $��23��
������� �� 
IsReadOnly . 
���   �$
��Left=�$��
147,17,0,0q�$	��Top=�$	��200���� -    ��Name$ tcMediosPago��$
��Left=�$	��338��$��	67,74,0,0q�$	��Top=�$	��543��	 � 	Resources	 
 �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  '��       �� "
 ��.���  � �� �� " ��.R��� $��Border��$��1,1,1,0q�
�������$ 4,4,0,0��$	��2,0q�._��� $ ContentSite��$��Center=�$��Center=�$��Header��$
��10,2q� P�  �@��
IsSelected . . ��� $ Border�� � �� �	#FF2196F3��  � ��
 �������  � ��$ 14(�P�  �@��
IsSelected .  . ��� $ Border�� � ��
 �����.@��� -   $��tabTransferencia��$��Transferencia Bancaria��$
��Bold"�.��� ���	#FFE5E5E5$��Stretch=�$��Stretch=�.+��� -   $ 
lblCuentaT��$��12(�$
��Bold"�
���   �$
��Left=�$��	14,30,0,0q�$
��Wrap=�$��Cuenta de Mayor��$	��Top=��� -   $ lblReferencia��$��12(�$
��Bold"�
���   �$
��Left=�$��
14,112,0,0q�$
��Wrap=�$��
Referencia��$	��Top=��� -    ��Name$ txtReferencia��
���   �$��1q�$
��Left=�$��23��$��148,110,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��164��
�������.��	 ��%9   '��       �� "
 ��.���  �@��CornerRadius$ 3��.���� -   $ lblFechaTransferencia��$
��Bold"�$��12(�
���   �$
��Left=�$��	12,72,0,0q�$
��Wrap=�$��Fecha de Transferencia��$	��Top=�(  "System.Windows.Controls.DatePicker  -	   $��dpFechaTransferencia��$
��Left=�$��
148,64,0,0q�$	��Top=�$	��164��	 ��%9   '��       �� "
 ��.���  �@��CornerRadius$ 3���� -
   $ lblTotal��$��14(�$
��Bold"�
���   �$
��Left=�$��266,278,0,0q�$
��Wrap=�$��Total��$	��Top=��� -   $ txtTotal��
���   �$��1q�$
��Left=�$��23��$��360,244,0,0q�$
 Wrap=�$	��Top=�$	��164��
�������.��	 ��%9   '��       �� "
 ��.���  �@��CornerRadius$ 3��.���� -    ��Name$ 	bdCuentaT��$��1q�
�������$ 3��$��149,24,223,256.333q�
�������._�]� -    ]�Name$ 	dpCuentaT��$��1��$��1��$��4.667,1.5,4.667,1q�$��Stretch=�$��Stretch=�
�������.+��� -    ��Name$ 
imgCuentaT��$��Right=�$.��(/Vista;component/Socios Negocio/lupa.png��$��20��$��0,0,0,-0.333q�$y�Hidden=� � Cursor$
 Hand���� -   $ 
txtCuentaT��$��12(�$��Normal"�$��Stretch=�
�������$��0q�$��0,0,0,-0.333q�$	��130��
���   �$	��Top=��� -   $��tabEfectivo��$��Fondos en Efectivo��$
��Bold"�.��� ���	#FFE5E5E5 � ColumnDefinitions �� $	��12* ��� $	��55* �.+��� -   $ bdCuentaT_Copy��$��1q�
�������$ 3��$��48,25,228,254.333q�
�������$��1�� J� RenderTransformOrigin$ 0.5,0.5&�._�]� -   $ 	dpCuentaE��$��1��$��1��$��4.667,1.5,4.667,1q�$��Stretch=�$��Stretch=�
�������.+��� -   $ 
imgCuentaE��$��Right=�$.��(/Vista;component/Socios Negocio/lupa.png��$��20��$��0,0,0,-0.333q�$y�Hidden=�$
 Hand���� -   $ 
txtCuentaE��$��12(�$��Normal"�$��Stretch=�
�������$��0q�$��0,0,0,-0.333q�$	��130��
���   �$	��Top=��� -   $ 
lblCuentaE��$��12(�$
��Bold"�
���   �$
��Left=�$��	14,30,0,0q�$
��Wrap=�$��Cuenta de Mayor��$	��Top=�$��2���� -   $ 	lblTotal1��$��14(�$
��Bold"�
���   �$
��Left=�$��169.667,278,0,0q�$
��Wrap=�$��Total��$	��Top=�$��1���� -   $ 	txtTotal1��
���   �$��1q�$
��Left=�$��23��$��263.667,244,0,0q�$
 Wrap=�$	��Top=�$	��164��
�������$��1��.��	 ��%9   '��       �� "
 ��.���  �@��CornerRadius$ 3��.���� -    ��Name$ btnOK��$��OK��$
��Left=�$��
67,561,0,0q�$	��Top=�$��94��$��3q��� -   $ btnCancelar��$��Cancelar��$
��Left=�$��186,561,0,0q�$	��Top=�$��94��$��3q�
�������
��������� -   $ lblImporteTotal��$��12(�$
��Bold"�
���   �$
��Left=�$��
67,433,0,0q�$
��Wrap=�$��Importe total��$	��Top=��� -   $ txtImporteTotal��
���   �$��1q�$
��Left=�$��23��$��172,430,0,0q�$
 Wrap=�$	��Top=�$	��164��
�������.��	 ��%9   '��       �� "
 ��.���  �@��CornerRadius$ 3��.���� -   $ lblSaldoVencido��$��12(�$
��Bold"�
���   �$
��Left=�$��
67,465,0,0q�$
��Wrap=�$��Saldo vencido��$	��Top=��� -   $ txtSaldoVencido�� �� 
IsReadOnly . ���	#FFE5E5E5
���   �$��1q�$
��Left=�$��23��$��172,462,0,0q�$
 Wrap=�$	��Top=�$	��164��.��	 ��%9   '��       �� "
 ��.���  �@��CornerRadius$ 3��.���� -   $ lblGastosBancarios��$��12(�$
��Bold"�
���   �$
��Left=�$��
67,499,0,0q�$
��Wrap=�$��Gastos Bancarios��$	��Top=��� -   $ txtGastosBancarios��
���   �$��1q�$
��Left=�$��23��$��171,498,0,0q�$
 Wrap=�$	��Top=�$	��164��
�������.��	 ��%9   '��       �� "
 ��.���  �@��CornerRadius$ 3��.���� -    $ 	lblPagado��$��12(�$
��Bold"�
���   �$
��Left=�$��385,548,0,0q�$
��Wrap=�$��Pagado��$	��Top=��� -!   $ 	txtPagado�� . ���	#FFE5E5E5
���   �$��1q�$
��Left=�$��23��$��446,545,0,0q�$
 Wrap=�$	��Top=�$	��164��.��	 ��%9   '��       �� "
 ��.���  �@��CornerRadius$ 3��.���� -"   $ txtImporteTotal_ME�� . $y�Hidden=����	#FFE5E5E5
���   �$��1q�$
��Left=�$��23��$��358,430,0,0q�$
 Wrap=�$	��Top=�$	��164��.��	 ��%9   '��       �� "
 ��.���  �@��CornerRadius$ 3��.���� -#   $ txtSaldoVencido_ME�� . $y�Hidden=����	#FFE5E5E5
���   �$��1q�$
��Left=�$��23��$��358,462,0,0q�$
 Wrap=�$	��Top=�$	��164��.��	 ��%9   '��       �� "
 ��.���  �@��CornerRadius$ 3��.��