   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  U/clr-namespace:Vista.Inicio.ValidationErrorLogin!Vista.Inicio.ValidationErrorLogin      Vista.Login   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Vista     Blocal1/clr-namespace:Vista.Inicio.ValidationErrorLogin     -   $��login��  � Title$  Login��$	��450��$��741.333�� � WindowStartupLocation$ CenterScreen=� � DataContext =   7Vista.Inicio.ValidationErrorLogin.ValidationErrorsLogin   � Triggers :�  :� RoutedEvent$ Loaded��.[��� .����  g� Duration$ 00:00:6D� �� TargetProperty$ Opacity�.��W�  W� From$ 0X�	 W� To$ 1X�.���� $
��Auto=�$
��Auto=�.��� -   	 �Name$	 gLogin��$��0,80,0,0q�$	��270��$��Center=�$	��Top=�.+��� -   
 ��Name$
 btnLogin��$��3q�$��Ok��$
��Left=�$��158,222,0,0q�$	��Top=�$��64��$
��Bold"�$��14(��� -   $
 btnExit��$��3q�$��	Finalizar��$
��Left=�$��240,222,0,0q�$	��Top=�$��87��$
��Bold"�$��14(��� -    ��Name$ 
lblUsuario��$
��Left=�$��149,117,0,0q�$��Usuario��$
��Wrap=�$	��Top=�$
��Bold"�$��14(�$��56���� -   $ lblPassword��$
��Left=�$��149,168,0,0q�$��Clave��$
��Wrap=�$	��Top=�$
��Bold"�$��14(�$��39���� -    ��Name$ 
txtUsuario��$��1q�
�������$
��Left=�$��316,115,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��150��$��25������ *
Username+ �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ PropertyChanged=� � ToolTip �� *ErrorCollection[Username]+$ PropertyChanged=�.�� � 	Resources  �� 
TargetType �� Property �� Value��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.��G� -    G�Name$ txtClave��$��1q�
�������$
��Left=�$��316,164,0,0q�$	��Top=�$	��150�� G� PasswordChar$ *��$��25��   Vista.Login   Password �� *
Password+ . $ PropertyChanged=� �� *ErrorCollection[Password]+ ��%9   '��       �� " ��.���  �@��CornerRadius$ 3���� -	   $ txtSociedad��$��1q�
�������$
��Left=�$��
316,68,0,0q�$
 Wrap=�$	��Top=�$	��150��$��0q�$��26������ *
Sociedad+ . $ PropertyChanged=� �� *ErrorCollection[Sociedad]+.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -
   $ lblSociedad��$
��Left=�$��
149,75,0,0q�$
��Wrap=�$��Nombre Sociedad��$	��Top=�$	��144��$
��Bold"�$��14(��� -   $
 btnSociedad��$��Modificar Sociedad��$
��Left=�$��343,222,-1.333,0q�$	��Top=�$	��139��$
��Bold"�$��14(�$��3q��� -    ��Name$ image��$
��Fill=�$
��Left=�$	��232��$��0,22,0,0q�$	��Top=�$	��131��$��fondoPantalla.jpeg���� -   $ 	lbltitulo��$
��Left=�$��
151,11,0,0q�$
��Wrap=�$	��SCV��$	��Top=�$��38(�$
��Bold"�
�������