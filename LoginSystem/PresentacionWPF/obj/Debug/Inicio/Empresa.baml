   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	   Y1clr-namespace:Vista.Inicio.ValidationErrorEmpresa#Vista.Inicio.ValidationErrorEmpresa  6+       Vista.Empresa   5   	   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	   Dlocal11clr-namespace:Vista.Inicio.ValidationErrorEmpresa     6+   -   5          � Title$  Crear Nueva Empresa��5   	   $	��286��6%   $��396.459��62    � WindowStartupLocation$ CenterScreen=�6B    � DataContext 5	      @   :Vista.Inicio.ValidationErrorEmpresa.ValidationErrorEmpresa  5
   
   .��5      �� $
��Auto=�6   $
��Auto=�66   .��5   
   � $��Center=�6   $	��Top=�6,   .+�5      �� -   5         ��Name$ 
txtEmpresa��5      
�������$��1q�6w   $
��Left=�6�   $��
202,44,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��151��6�   $��1��6�   $��25��6  ��6  �� *
Sociedad+ �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ PropertyChanged=� � ToolTip 5      �� *ErrorCollection[Sociedad]+$ PropertyChanged=�.��6i    � 	Resources 5      	 �� 
TargetType
 �� Property �� Value��%^   '��       �� 5      "	 ��6   .�5      �� 
 �@��CornerRadius$ 3��69   5      5      .��6%   5      �� 5      -   5         ��Name$ 
lblEmpresa��5      $��14(�6,   $
��Bold"�6:   $
��Left=�6L   $��	14,48,0,0q�6g   $��Nombre de Sociedad��6z   $
��Wrap=�6�   $	��Top=�6�   $��21��6�   $	��147��6�   $��2��6�   �� 5      -   5         ��Name$ btnCrearEmpresa��5      $��3q�6.   $
��Bold"�6:   $��OK��6L   $��Center=�6Y   $��14,200,280,0q�6v   $	��Top=�6�   $��82��6�   $��1��6�   �� 5      -   5        $ lblDatabase��5      $��14(�6-   $
��Bold"�6;   $
��Left=�6N   $��	14,90,0,0q�6i   $
��Wrap=�6|   $��Nombre Base de Datos��6�   $	��Top=�6�   $��25��6�   $	��161��6�   $��2��6�   �� 5      -   5        $ txtDatabase��5      
�������$��1q�6x   $
��Left=�6�   $��
202,90,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��151��6�   $��25��6�   $��2��6   ��6  �� *
Database+ . $ PropertyChanged=� 5      �� *ErrorCollection[Database]+.��6E    5      ��%^   '��       �� 5       "	 ��6   .�5"      �� 
 �@��CornerRadius$ 3��69   5$      5%      .��6%   5'      �� 5(      -   5        $ btnCancelar��5(      $��Cancelar��6*   $
��Bold"�6U   $��Center=�6g   $��121,200,157,0q�6�   $	��Top=�6�   $��98��6�   $��1��6�   
�������
�������$��3q�6�   �� 5)      -   5        $ 
lblPeriodo��5)      $��14(�6,   $
��Bold"�6:   $
��Left=�6L   $��
14,142,0,0q�6g   $
��Wrap=�6{   $ ��Definir Periodos Contables��6�   $	��Top=�6�   $��20��6�   $	��183��6�   $��2��6�   �� 5*      -	   5        $ btnPeriodos��5*      $	��...��6*   $��Center=�68   $��203,135,131.333,0q�6U   $	��Top=�6p   $��43��6�   $��1��6�   
�������
�������$��18(�6�   $��30��6�   $
��Bold"�6�   $��3q�6  5+      5,      5-      