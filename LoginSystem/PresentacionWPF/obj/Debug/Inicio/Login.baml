   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	   U/clr-namespace:Vista.Inicio.ValidationErrorLogin!Vista.Inicio.ValidationErrorLogin  6+       Vista.Login   5      n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	   Blocal1/clr-namespace:Vista.Inicio.ValidationErrorLogin     6+   -   5           Vista.Document   Name$  login��5   �      Vista.Document   Loaded$ Window_Loaded��64      KeyDown$ login_KeyDown��6K      Closing$ login_Closing��6�    � Title$ Login��6	   $	��450��6   $��741.333��6$    � WindowStartupLocation$ CenterScreen=�6d    � DataContext 5	      =   7Vista.Inicio.ValidationErrorLogin.ValidationErrorsLogin  5
   
    � Triggers 5      :� 5   
    :� RoutedEvent$ Loaded��6   .[�5      �� .��5      �� 	 g� Duration$	 00:00:6D�6   
 �� TargetProperty$
 Opacity�60   .��5      W�  W� From$ 0X�6&   	 W� To$ 1X�6/   5      5      5      .��5      �� $
��Auto=�6   $
��Auto=�66   .��5   
   � -   5         �Name$ gLogin��5      $��0,80,0,0q�66   $	��270��6H   $��Center=�6U   $	��Top=�6r   .+�5      �� -   5         ��Name$ btnLogin��5      $��3q�6(   $��Ok��64   $
��Left=�6A   $��158,222,0,0q�6\   $	��Top=�6q   $��64��6�   $
��Bold"�6�   $��14(�6�   �� 5      -   5        $ btnExit��5      $��3q�6&   $��	Finalizar��62   $
��Left=�6F   $��240,222,0,0q�6a   $	��Top=�6v   $��87��6�   $
��Bold"�6�   $��14(�6�   �� 5      -   5         ��Name$ 
lblUsuario��5      $
��Left=�6,   $��149,117,0,0q�6G   $��Usuario��6\   $
��Wrap=�6k   $	��Top=�6   $
��Bold"�6�   $��14(�6�   $��56��6�   �� 5      -   5        $ lblPassword��5      $
��Left=�6-   $��149,168,0,0q�6H   $��Clave��6]   $
��Wrap=�6j   $	��Top=�6~   $
��Bold"�6�   $��14(�6�   $��39��6�   �� 5      -   5         ��Name$ 
txtUsuario��5   Z   $��1q�6   
�������$
��Left=�6�   $��316,115,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��150��6  $��25��6  ��6  �� *
Username+ �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ PropertyChanged=� � ToolTip 5      �� *ErrorCollection[Username]+$ PropertyChanged=�.��6i    � 	Resources 5       �� 
TargetType �� Property �� Value��%^   '��       �� 5      " ��6   .�5       ��  �@��CornerRadius$ 3��69   5"      5#      .��6%   5%      G� 5&      -   5         G�Name$ txtClave��5(   r   $��1q�5&      
�������$
��Left=�5(   �   $��316,164,0,0q�6�   $	��Top=�6�   $	��150��6   G� PasswordChar$ *��6  $��25��6%     Vista.Login   Password 5&   .   �� *
Password+ . $ PropertyChanged=� �� NotifyOnValidationError .  5(      �� *ErrorCollection[Password]+ 5)      ��%^   '��       �� 5*      " ��6   .�5+      ��  �@��CornerRadius$ 3��69   5-      5.      5/      �� 51      -	   5        $ txtSociedad��51   �   $��1q�6   
�������$
��Left=�6�   $��
316,68,0,0q�6�   $
 Wrap=�6  $	��Top=�6  $	��150��6/  $��0q�6;  $��26��6G  ��6S  �� *
Sociedad+ . $ PropertyChanged=� 53      �� *ErrorCollection[Sociedad]+.��6E    54      ��%^   '��       �� 55      " ��6   .�56      ��  �@��CornerRadius$ 3��69   58      59      .��6%   5:      �� 5<      -
   5        $ lblSociedad��5<      $
��Left=�6-   $��
149,75,0,0q�6H   $
��Wrap=�6\   $��Nombre Sociedad��6p   $	��Top=�6�   $	��144��6�   $
��Bold"�6�   $��14(�6�   �� 5=      -   5        $ btnSociedad��5=      $��Modificar Sociedad��6*   $
��Left=�6G   $��343,222,-1.333,0q�6b   $	��Top=�6|   $	��139��6�   $
��Bold"�6�   $��14(�6�   $��3q�6�   �� 5>      -   5         ��Name$ image��5>      $
��Fill=�6#   $
��Left=�62   $	��232��6M   $��0,22,0,0q�6Z   $	��Top=�6l   $	��131��6�   $��fondoPantalla.jpeg��6�   �� 5?      -   5        $ 	lbltitulo��5?      $
��Left=�6+   $��
151,11,0,0q�6F   $
��Wrap=�6Z   $	��SCV��6n   $	��Top=�6y   $��38(�6�   $
��Bold"�6�   
�������6�   5I      5J      5K      