   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	   c6clr-namespace:Vista.Inicio.ValidationErrorUsuarioSitio(Vista.Inicio.ValidationErrorUsuarioSitio  6+       Vista.UsuarioSitio   5   	   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	   Ilocal16clr-namespace:Vista.Inicio.ValidationErrorUsuarioSitio     6+   -   5          � Title$  UsuarioSitio��5   	   $��255.424��6   $��476.405��6/    � WindowStartupLocation$ CenterScreen=�6X    � DataContext 5	      J   DVista.Inicio.ValidationErrorUsuarioSitio.ValidationErrorUsuarioSitio  5
   
    � 	Resources 5         TextBlockStyleValidation �� 
TargetType �� Triggers P� Property P� Value �� Property	 �� Value
 �� RelativeSource �� Path �� UpdateSourceTrigger �� ValidatesOnDataErrors �� NotifyOnValidationError��%�   &	        �� 5   
   " ��61    5      P� 5       �@=�HasError . . �5      ��  �@�ToolTip	 5      �� 
 �� *Self+$) #(Validation.Errors)[0].ErrorContent�$ PropertyChanged=� .  . 5      5      5      .��5      � .+�5   
   �� -   5         ��Name$ btnLogin��5      $��3q�6#   $��Ok��6/   $
��Left=�6<   $��
67,159,0,0q�6W   $	��Top=�6k   $��83��6�   $
��Bold"�6�   $��14(�6�   6�   �� 5   
   -   5        $ btnExit��5      $��3q�6"   $��Cancelar��6.   $
��Left=�6A   $��165,159,0,0q�6\   $	��Top=�6q   $��87��6�   $
��Bold"�6�   $��14(�6�   
�������
�������6�   �� 5   
   -   5         ��Name$ lblPasswordSQL��5      $
��Left=�6,   $��
65,113,0,0q�6G   $��Contraseña��6[   $
��Wrap=�6m   $	��Top=�6�   $
��Bold"�6�   $��14(�6�   $	��127��6�   �� 5   
   -   5         ��Name$ txtUsuarioSitio��5   '   $��1q�6   $
��Left=�6A   $��
247,62,0,0q�6]    �� TextWrapping$
 Wrap=�6q   $	��Top=�6�   $	��172��6�   $��0q�6�   $��26��6�   ��6�   �� $ Username� . $ PropertyChanged=� � ToolTip 5      �� 
 �� *Self+$&  (Validation.Errors)/ErrorContent� . $ PropertyChanged=� . .��5    �    5!      ��%^   '��       �� 5"      " ��6   .�5#      ��  �@��CornerRadius$	 3��65   5%      5&      .��6!   5'      �� 5)   
   -   5        $ lblUsuarioSQL��5)      $
��Left=�6+   $��	65,64,0,0q�6F   $
��Wrap=�6Y   $��ID Usuario Administrador��6m   $	��Top=�6�   $	��187��6�   $
��Bold"�6�   $��14(�6�   G� 5*   
   -   5         G�Name$ txtPasswordSQL��5*   =   $��1q�6   
�������$
��Left=�6�   $��247,110,0,0q�6�   $	��Top=�6�   $	��170��6�    G� PasswordChar$ *��6�   $��25��6�      Vista.Login   Password 6  �� $ Password� �� Mode$ TwoWay=� .  . $ PropertyChanged=� 5,      �� *ErrorCollection[Password]+$ TwoWay=�$ PropertyChanged=� .  .  5-      ��%^   '��       �� 5.      " ��6   .�5/      ��  �@��CornerRadius$	 3��65   51      52      53      54      55      