   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista      Vista.Periodo_Contable   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Vista     -     � Title$  Periodo Contable��$	��551��$	��559�� � WindowStartupLocation$ CenterScreen=�.���� $
��Auto=�$
��Auto=�.��� $��Center=�$	��Top=�$��0,10,0,0q� � ColumnDefinitions �� $
��200* ��� .+��� -    ��Name$ lblCodigoPeriodo��$
��Left=�$��	45,30,0,0q�$
��Wrap=�$��Codigo de Periodo��$	��Top=�$��14(�$
��Bold"��� -    ��Name$ txtCodigoPeriodo��
������� �� TextAlignment$ Center=�$
��Left=�$��26��$��
221,26,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��156��$��1q�.�� � 	Resources  �� 
TargetType	 �� Property
 �� Value��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��.���� -   $ lblNombrePeriodo��$��14(�$
��Bold"�$
��Left=�$��	45,72,0,0q�$
��Wrap=�$��Nombre Periodo��$	��Top=��� -   $ lblSubPeriodos��$��14(�$
��Bold"�$
��Left=�$��
45,109,0,0q�$
��Wrap=�$��SubPeriodos��$	��Top=��� -   $ lblCantidadPeriodos��$��14(�$
��Bold"�$
��Left=�$��
45,146,0,0q�$
��Wrap=�$��Cantidad Periodos��$	��Top=��� -   $ 	lblFechas��$
��Left=�$��
57,237,0,0q�$
��Wrap=�$��Fechas:��$��16(�$	��Top=�$��	Underline{�$
��Bold"��� -   $ lblDContabilizacion��$��14(�$
��Bold"�$
��Left=�$��
45,270,0,0q�$
��Wrap=�$��De Fecha Contabilizacion��$	��Top=��� -	   $ lblDVencimiento��$��14(�$
��Bold"�$
��Left=�$��
45,306,0,0q�$
��Wrap=�$��De Fecha Vencimiento��$	��Top=��� -
   $ lblDDocumento��$��14(�$
��Bold"�$
��Left=�$��
45,339,0,0q�$
��Wrap=�$��De Fecha Documento��$	��Top=��� -   $ lblIEjercicio��$��14(�$
��Bold"�$
��Left=�$��
45,383,0,0q�$
��Wrap=�$��Inicio del Ejercicio��$	��Top=��� -   $ lblEjercicio��$��14(�$
��Bold"�$
��Left=�$��
45,419,0,0q�$
��Wrap=�$��	Ejercicio��$	��Top=��� -    ��Name$ btnCrear��$��Crear��$
��Left=�$��
39,471,0,0q�$	��Top=�$��88��$��24��$��3q��� -   $ btnCancelar��$��Cancelar��$
��Left=�$��159,471,0,0q�$	��Top=�$��92��$��24��
�������
�������$��3q��� -   $ txtNombrePeriodo��$��1q�$ Center=�$
��Left=�$��26��$��
221,66,0,0q�$
 Wrap=�$	��Top=�$	��156��
�������.�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��.���� -   $ txtSubPeriodos��$��1q�$
��Left=�$ Center=�$��26��$��221,104,0,0q�$��Meses��$
 Wrap=�$	��Top=�$	��156�� �� 
IsReadOnly . 
�������.�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��.���� -   $ txtCantidadPeriodos��$��1q�$ Center=�$
��Left=�$��26��$��221,142,0,0q�$
 Wrap=�$��12��$	��Top=�$	��156�� . 
�������.�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��.��(  "System.Windows.Controls.DatePicker  -     Name$ dpDContabilizacion��$
��Left=�$��221,266,0,0q�$	��Top=�$	��120��$��27�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��  -   $ dpDDocumento��$
��Left=�$��221,336,0,0q�$	��Top=�$	��120��$��27�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3���� -   $ lblHContabilizacion��$��14(�$
��Bold"�$
��Left=�$��357,270,0,0q�$
��Wrap=�$��Hasta��$	��Top=��� -   $ lblHVencimiento��$��14(�$
��Bold"�$
��Left=�$��357,306,0,0q�$
��Wrap=�$��Hasta��$	��Top=��� -   $ lblHDocumento��$��14(�$
��Bold"�$
��Left=�$��357,339,0,0q�$
��Wrap=�$��Hasta��$	��Top=�  -   $ dpHContabilizacion��|�.  {�.  $
��Left=�$��405,266,0,0q�$	��Top=�$	��120��$��27�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��  -   $ dpHVencimiento��$
��Left=�$��405,302,0,0q�$	��Top=�$	��120��$��27�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��  -   $ dpHDocumento��$
��Left=�$��405,336,0,0q�$	��Top=�$	��120��$��27�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3���� -   $ txtEjercicio��
�������$��1q�$ Center=�$
��Left=�$��23��$��221,419,0,0q�$
 Wrap=�$	��Top=�$	��120��.�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��.��  -   $ dpEjercicio��$
��Left=�
�������$��221,383,0,0q�$	��Top=�$	��120��$��24�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3���� -   $ 
lblEstatus��$��14(�$
��Bold"�$
��Left=�$��
45,194,0,0q�$
��Wrap=�$��Estatus del Periodo��$	��Top=��� -    ��Name$ cbEstatusPeriodo��$��Center=�$
��Left=�$��26��{�.  $��221,190,0,0q�$	��Top=�$	��156�� �� 
IsEditable .  
�������$��Center=�.@���  �� 
IsSelected . $��Center=�$��Desbloqueado���� $��	Bloqueado��$��Center=��� $��Cierre Periodo��$��Center=��� $��Desbloqueado Excp Ventas��$��Center=�  -   $ dpDVencimiento��$
��Left=�$��221,302,0,0q�$	��Top=�$	��120��$��27�� ��%9   '��       �� " ��.��� 	 �@��CornerRadius$
 3��