   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  c6clr-namespace:Vista.Inicio.ValidationErrorUsuarioSitio(Vista.Inicio.ValidationErrorUsuarioSitio      Vista.UsuarioSitio   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Vista     Ilocal16clr-namespace:Vista.Inicio.ValidationErrorUsuarioSitio     -     � Title$  UsuarioSitio��$��255.424��$��476.405�� � WindowStartupLocation$ CenterScreen=� � DataContext J   DVista.Inicio.ValidationErrorUsuarioSitio.ValidationErrorUsuarioSitio  .��� .+��� -    ��Name$ btnLogin��$��3q�$��Ok��$
��Left=�$��
67,159,0,0q�$	��Top=�$��83��$
��Bold"�$��14(��� -   $ btnExit��$��3q�$��Cancelar��$
��Left=�$��165,159,0,0q�$	��Top=�$��87��$
��Bold"�$��14(�
�������
��������� -    ��Name$ lblPasswordSQL��$
��Left=�$��
65,113,0,0q�$��Contraseña��$
��Wrap=�$	��Top=�$
��Bold"�$��14(�$	��127���� -    ��Name$ txtUsuarioSitio��$��1q�$
��Left=�$��
247,62,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��172��$��0q�$��26������ *
Username+ �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ PropertyChanged=�	 � ToolTip	 �� *ErrorCollection[Username]+$ PropertyChanged=�.��
 � 	Resources
  �� 
TargetType �� Property �� Value��%9   '��       �� " ��.���  �@��CornerRadius$ 3��.���� -   $ lblUsuarioSQL��$
��Left=�$��	65,64,0,0q�$
��Wrap=�$��ID Usuario Administrador��$	��Top=�$	��187��$
��Bold"�$��14(�G� -    G�Name$ txtPasswordSQL��$��1q�
�������$
��Left=�$��247,110,0,0q�$	��Top=�$	��170�� G� PasswordChar$ *��$��25��   Vista.Login   Password �� *
Password+ . $ PropertyChanged=�	 �� *ErrorCollection[Password]+
 ��%9   '��       �� " ��.���  �@��CornerRadius$ 3��