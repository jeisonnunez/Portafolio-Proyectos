   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista      Vista.Usuarios   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Vista     -     � Title$  Usuarios��$	��417��$	��617�� � WindowStartupLocation$ CenterScreen=�.���� $
��Auto=�$
��Auto=�.��� $��Center=�$	��Top=�.+��� -    ��Name$ imgleft�� � Cursor$
 Hand��$��003-anterior-2.png��$
��Left=�$��28��$��
279,10,0,0q�$	��Top=�$��31���� -   $ imgRight��$
 Hand��$��004-proximo.png��$
��Left=�$��28��$��
319,10,0,0q�$	��Top=�$��31�� J� RenderTransformOrigin$ 1.296,0.488&��� -   $ imgCrear��$
 Hand��$��001-texto.png��$
��Left=�$��28��$��
166,10,0,0q�$	��Top=�$��31��$ 1.296,0.488&��� -   $ 	imgBuscar��$
 Hand��$��002-encontrar.png��$
��Left=�$��28��$��
205,10,0,0q�$	��Top=�$��31��$ 1.296,0.488&��� -   $ 	imgInicio��$
 Hand��$��001-anterior.png��$
��Left=�$��28��$��
243,10,0,0q�$	��Top=�$��31��$ 1.296,0.488&��� -   $ imgFin��$
 Hand��$��002-anterior-1.png��$
��Left=�$��28��$��
355,10,0,0q�$	��Top=�$��31��$ 1.296,0.488&��� -    ��Name$ lblCodigoUsuario��$
��Left=�$��	49,62,0,0q�$
��Wrap=�$��Codigo Usuario��$	��Top=�$��14(�$
��Bold"��� -	   $ lblNombreUsuario��$
��Left=�$��	49,98,0,0q�$
��Wrap=�$��Nombre Usuario��$	��Top=�$��14(�$
��Bold"��� -
    ��Name$ txtCodigoUsuario��
�������$��1q�$
��Left=�$��23��$��
170,59,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��120��.�� � 	Resources 	 �� 
TargetType
 �� Property �� Value��%9   '��       �� "	 ��.��� 
 �@��CornerRadius$ 3��.���� -   $ txtNombreUsuario��
�������$��1q�$
��Left=�$��23��$��
170,97,0,0q�$
 Wrap=�$	��Top=�$	��120��.�� ��%9   '��       �� "	 ��.��� 
 �@��CornerRadius$ 3��.���� -    ��Name$ 
tabControl��$
��Left=�$	��165��$��
49,151,0,0q�$	��Top=�$	��495��  �� 
TargetType �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  '��       �� "	 ��.��� 
 � �� �� " ��.R��� $��Border��$��1,1,1,0q�
�������$ 4,4,0,0��$	��2,0q�._��� $ ContentSite��$��Center=�$��Center=�$��Header��$
��10,2q� P�  �@��
IsSelected . . ��� $ Border��
 � �� �	#FF2196F3�� 
 � ��
 ������� 
 � ��$ 14(�P�  �@��
IsSelected .  . ��� $ Border��
 � ��
 �����.@��� $��General��$
��Bold"�.��� ���	#FFE5E5E5.+��� -   $ lblClaveAcceso��
���   �$
��Left=�$��	18,16,0,0q�$
��Wrap=�$��Clave Acceso��$��14(�$
��Bold"�$	��Top=�G� -    G�Name$ txtClaveAcceso��
������� G� Password$
 ****��
���   �$��1q�$
��Left=�$��24��$��
117,13,0,0q�$	��Top=�$	��120�� ��%9   '��       �� "	 ��.��� 
 �@��CornerRadius$ 3���� -    ��Name$ btnClave��$	��...��$
��Left=�$��250,14,0,95.667q�$��37��$��3q�$��16(�$
��Bold"�$
��Auto���� -    ��Name$ chxBloqueado��
���   �$��	Bloqueado��$
��Left=�$��	18,62,0,0q�$	��Top=�$��14(�$
��Bold"��� -   $ btnCrear��$��Crear��$
��Left=�$��
49,336,0,0q�$	��Top=�$��75��$��3q��� -   $ btnCancelar��$��Cancelar��$
��Left=�$��153,336,0,0q�$	��Top=�$��77��$��3q�
�������
�������