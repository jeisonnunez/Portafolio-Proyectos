   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	   K*clr-namespace:Vista.Gestion.ModelRegistrosVista.Gestion.ModelRegistros  6+       Vista.Registro   5      n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	   =local1*clr-namespace:Vista.Gestion.ModelRegistros     6+      Vista.Document    Closing$  Window_Closing��5   _    � Title$ Clave de Acceso��6	   $	��372��6!   $	��562��6.    � WindowStartupLocation$ CenterScreen=�6:    � DataContext 5	      1   +Vista.Gestion.ModelRegistros.ModelRegistros  5
   
   .��5      �� $
��Auto=�6   $
��Auto=�66   .��5   
   � $��Center=�6   $	��Top=�6,   $��0,10,0,0q�6D   .+�5      �� -   5         ��Name$ lblUsername��5      $
��Left=�6-   $��
35,179,0,0q�6H   $��Usuario��6\   $
��Wrap=�6k   $	��Top=�6   $
��Bold"�6�   $��14(�6�    J� RenderTransformOrigin$ 0.588,-0.456&�6�   �� 5      -   5        $ lblPassword��5      $
��Left=�6-   $��
35,211,0,0q�6H   $��Clave de Acceso��6\   $
��Wrap=�6s   $	��Top=�6�   $
��Bold"�6�   $��14(�6�   �� 5      -   5        $ lblPasswordConfirm��5      $
��Left=�64   $��
35,243,0,0q�6O   $��	Confirmar��6c   $
��Wrap=�6t   $	��Top=�6�   $
��Bold"�6�   $��14(�6�   G� 5      -   5         G�Name$ txtPassword��5      
�������$��1q�6�   $
��Left=�6�   $��249,211,0,0q�6�   $	��Top=�6�   $	��120��6   G� PasswordChar$ *��6     Vista.Registro   Password 60  �� 	 �� Path$	 Password�
 �� ValidatesOnDataErrors
 .  �� UpdateSourceTrigger$ PropertyChanged=� �� NotifyOnValidationError .  � ToolTip 5      �� *ErrorCollection[Password]+ � 	Resources 5       �� 
TargetType �� Property �� Value��%^   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 3��69   5      5      5      G� 5      -   5        $ txtPasswordConfirm��5      
�������$��1q�5   �   $
��Left=�6�   $��249,243,0,0q�6�   $	��Top=�6�   $	��120��6�   $ *��6   5   6   �� $	 PasswordConfirm�
 . $ PropertyChanged=� .  5      �� *" ErrorCollection[PasswordConfirm]+ 5      ��%^   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 3��69   5       5!      5"      �� 5#      -   5         ��Name$ txtUser��5#      
�������$��1q�5%   �   $
��Left=�6�   $��249,179,0,0q�6   �� TextWrapping$
 Wrap=�6)  $	��Top=�6=  $	��120��6U  ��5#   '   �� $	 	User_code� �� Mode$ TwoWay=�
 . $ PropertyChanged=� .  5$      ��  �� RelativeSource �� *Self+$)	 #(Validation.Errors)[0].ErrorContent�
 . $ PropertyChanged=� . .��5%   a   5&      ��%^   '��       �� 5'      " ��6   .�5(      ��  �@��CornerRadius$ 3��69   5)      5*      .��6%   5+      �� 5,      -   5         ��Name$ btnRegistro��5,      $��OK��6*   $
��Left=�67   $��
35,289,0,0q�6R   $	��Top=�6f   $��30��6~   $��96��6�   $��16(�6�   $
��Bold"�6�   �� 5-      -   5        $ btnCancelar��5-      $��Cancelar��6*   $
��Left=�6=   $��152,289,0,0q�6X   $	��Top=�6m   $��30��6�   $��96��6�   $��16(�6�   $
��Bold"�6�   
�������
�������6�   �� 5.      -	   5        $ lblDescripcion��5.      $
��Left=�60   $��	34,33,0,0q�6K   $j��dSeleccione una clave de acceso nueva que se ajuste a las politicas de clave de acceso de su empresa.��6^   $
��Wrap=�6�   $	��Top=�6�   $
��Bold"�6�   $��14(�6  $ 0.588,-0.456&�6  $��41��6;  $	��514��6G  �� 5/      -
   5        $ lblDescripcion1��5/      $
��Left=�61   $��	35,74,0,0q�6L   $&�� La clave de acceso debe contener��6_   $
��Wrap=�6�   $	��Top=�6�   $
��Bold"�6�   $��14(�6�   $ 0.588,-0.456&�6�   $��23��6�   $	��514��6  �� 50      -   5        $ lblDescripcion2��50      $
��Left=�61   $��	35,97,0,0q�6L   $B��<Minimo de 6 caracteres de longitud, 1 carta(s) en mayúscula��6_   $
��Wrap=�6�   $	��Top=�6�   $
��Bold"�6�   $��14(�6�   $ 0.588,-0.456&�6�   $��23��6  $	��514��6  �� 51      -   5        $ lblDescripcion3��51      $
��Left=�61   $��
35,120,0,0q�6L   $D��>1 carta(s) en minúscula 1 digito(s) 1 carácter alfanumérico��6`   $
��Wrap=�6�   $	��Top=�6�   $
��Bold"�6�   $��14(�6�   $ 0.588,-0.456&�6�   $��23��6  $	��514��6   52      53      54      