   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	   I)clr-namespace:Vista.Gestion.ModelUsuariosVista.Gestion.ModelUsuarios  6+       Vista.Usuarios   5      n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	   <local1)clr-namespace:Vista.Gestion.ModelUsuarios     6+      Vista.Document    Closing$  Window_Closing��5   3      MouseRightButtonDown$ Grid_MouseRightButtonDown��6q    � Title$ Usuarios��6	   $	��417��6   $	��617��6'    � WindowStartupLocation$ CenterScreen=�6L    � DataContext 5	      /   )Vista.Gestion.ModelUsuarios.ModelUsuarios  5
   
   .��5      �� $
��Auto=�6   $
��Auto=�66   .��5   
   � $��Center=�6   $	��Top=�6,   .+�5      �� -   5         ��Name$ imgleft��5       � Cursor$
 Hand��6e   $��003-anterior-2.png��6s   $
��Left=�6�   $��28��6�   $��
279,10,0,0q�6�   $	��Top=�6�   $��31��6�   �� 5      -   5        $ imgRight��5      $
 Hand��6g   $��004-proximo.png��6u   $
��Left=�6�   $��28��6�   $��
319,10,0,0q�6�   $	��Top=�6�   $��31��6�    J� RenderTransformOrigin$ 1.296,0.488&�6�   �� 5      -   5        $ imgCrear��5      $
 Hand��6g   $��001-texto.png��6u   $
��Left=�6�   $��28��6�   $��
166,10,0,0q�6�   $	��Top=�6�   $��31��6�   $ 1.296,0.488&�6�   �� 5      -   5        $ 	imgBuscar��5      $
 Hand��6i   $��002-encontrar.png��6w   $
��Left=�6�   $��28��6�   $��
205,10,0,0q�6�   $	��Top=�6�   $��31��6�   $ 1.296,0.488&�6�   �� 5      -   5        $ 	imgInicio��5      $
 Hand��6i   $��001-anterior.png��6w   $
��Left=�6�   $��28��6�   $��
243,10,0,0q�6�   $	��Top=�6�   $��31��6�   $ 1.296,0.488&�6�   �� 5      -   5        $ imgFin��5      $
 Hand��6$   $��002-anterior-1.png��6q   $
��Left=�6�   $��28��6�   $��
355,10,0,0q�6�   $	��Top=�6�   $��31��6�   $ 1.296,0.488&�6�   �� 5      -   5         ��Name$ lblCodigoUsuario��5      $
��Left=�62   $��	49,62,0,0q�6M   $
��Wrap=�6`   $��Codigo Usuario��6t   $	��Top=�6�   $��14(�6�   $
��Bold"�6�   �� 5      -   5        $ lblNombreUsuario��5      $
��Left=�62   $��	49,98,0,0q�6M   $
��Wrap=�6`   $��Nombre Usuario��6t   $	��Top=�6�   $��14(�6�   $
��Bold"�6�   �� 5      -	   5        	 ��Name$	 txtCodigoUsuario��5      
�������$��1q�6}   $
��Left=�6�   $��23��6�   $��
170,59,0,0q�6�   
 �� TextWrapping$

 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6:  ��  �� Path$ 	User_code� �� Mode$ TwoWay=� �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ PropertyChanged=� �� NotifyOnValidationError .  � ToolTip 5      ��  �� RelativeSource �� *Self+$) #(Validation.Errors)[0].ErrorContent� . $ PropertyChanged=� . .��5   �    � 	Resources 5       �� 
TargetType �� Property �� Value��%^   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 3��69   5      5      .��6%   5       �� 5!      -
   5        $	 txtNombreUsuario��5!      
�������$��1q�6}   $
��Left=�6�   $��23��6�   $��
170,97,0,0q�6�   $

 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6:  �� $ 	User_name�$ TwoWay=� . $ PropertyChanged=� .  5"      ��  �� *Self+$) #(Validation.Errors)[0].ErrorContent� . $ PropertyChanged=� . .��5#   �    5$      ��%^   '��       �� 5%      " ��6   .�5&      ��  �@��CornerRadius$ 3��69   5'      5(      .��6%   5)      �� 5*      -   5         ��Name$ 
tabControl��5*      $
��Left=�6-   $	��165��6H   $��
49,151,0,0q�6U   $	��Top=�6i   $	��495��6�    5+       �� 
TargetType �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  '��       �� 5,      " ��6   .�5-      ��  � �� 5.      �� 5/   "   " ��62   .R�50   &   �� $��Border��6-   $��1,1,1,0q�6;   
�������$ 4,4,0,0��6m   $	��2,0q�6�   ._�51   *   �� $ ContentSite��6;   $��Center=�52   )   $��Center=�53   )   $��Header��54   )   $
��10,2q�55   )   56   '    57   &   P� 58   *    �@��
IsSelected . . �59   .   �� $ Border��65    � �� �	#FF2196F36_   �� 5:   .    � ��
 �����6L   �� 5;   .    � ��$ 14(�6J   5<   +   P� 5=   *    �@��
IsSelected .  . �5>   .   �� $ Border��65    � ��
 �����6_   5?   +   5A   #   5C      5D      5E      .@�5F      �� $��General��6   $
��Bold"�6+   .��5G      � ���	#FFE5E5E5.+�5H      �� -   5        $ lblClaveAcceso��5H   $   
���   �$
��Left=�6O   $��	18,16,0,0q�6j   $
��Wrap=�6}   $��Clave Acceso��6�   $��14(�6�   $
��Bold"�6�   $	��Top=�6�   G� 5I      -   5         G�Name$ txtClaveAcceso��5I   &   
������� G� Password$
 ****��6U   
���   �$��1q�6x   $
��Left=�6�   $��24��6�   $��
117,13,0,0q�6�   $	��Top=�6�   $	��120��6�      Vista.Usuarios    Password  6�   �� $ Password� . $ PropertyChanged=� .  5K      �� *ErrorCollection[Password]+ 5L      ��%^   '��       �� 5M   "   " ��6(   .�5N   &   ��  �@��CornerRadius$ 3��6E   5O   #   5P      5Q      �� 5R      -   5        ! ��Name$! btnClave��5R   !   $	��...��63   $
��Left=�6A   $��250,14,0,95.667q�6\   $��37��6u   $��3q�6�   $��16(�6�   $
��Bold"�6�   $
��Auto��6�   6�   �� 5S      -   5        " ��Name$" chxBloqueado��5S   #   
���   �$��	Bloqueado��6L   $
��Left=�6`   $��	18,62,0,0q�6{   $	��Top=�6�   $��14(�6�   $
��Bold"�6�   6�   5T      5U      5W      �� 5X      -   5        $! btnCrear��5X      $��Crear��6'   $
��Left=�67   $��
49,336,0,0q�6R   $	��Top=�6f   $��75��6~   $��3q�6�   6�   �� 5Y      -   5        $! btnCancelar��5Y      $��Cancelar��6*   $
��Left=�6=   $��153,336,0,0q�6X   $	��Top=�6m   $��77��6�   $��3q�6�   
�������
�������6�   5[      5\      5]      