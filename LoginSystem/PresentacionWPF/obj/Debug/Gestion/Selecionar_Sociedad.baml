   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	   q=clr-namespace:Vista.Gestion.ValidateErrorsSeleccionarSociedad/Vista.Gestion.ValidateErrorsSeleccionarSociedad  6+       Vista.Selecionar_Sociedad   5   	   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	   Plocal1=clr-namespace:Vista.Gestion.ValidateErrorsSeleccionarSociedad     6+   -   5          � Title$  Selecionar_Sociedad��5   	   $	��446��6%   $	��800��62    � WindowStartupLocation$ Manual=�6W    � DataContext 5	      W   QVista.Gestion.ValidateErrorsSeleccionarSociedad.ValidateErrorsSeleccionarSociedad  5
   
   .��5      �� $
��Auto=�6   $
��Auto=�66   .��5   
   � $��Center=�6   $	��Top=�6,   $��0,20,0,0q�6D    %� VirtualizationMode$ Standard=�6V   .+�5      �� -   5         ��Name$ 
lblUsuario��5      $
��Left=�6,   $��	87,34,0,0q�6G   $
��Wrap=�6Z   $��ID de Usuario��6n   $	��Top=�6�   $
��Bold"�6�   $��14(�6�   �� 5      -   5        $ lblClave��5      $
��Left=�6*   $��
326,34,0,0q�6E   $
��Wrap=�6Y   $��Clave de Acceso��6m   $	��Top=�6�   $��17��6�   $
��Bold"�6�   $��14(�6�   �� 5      -   5         ��Name$ 
txtUsuario��5      $ Standard=�6*   
�������$��1q�6s   $
��Left=�6�   $��23��6�   $��
186,31,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��64  �� *
Username+ �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ PropertyChanged=�	 � ToolTip	 5      �� *ErrorCollection[Username]+$ PropertyChanged=�.��6i   
 � 	Resources
 5       �� 
TargetType �� Property �� Value��%^   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 3��69   5      5      .��6%   5      G� 5      -   5         G�Name$ txtClave��5      
�������$��1q�5   W   $
��Left=�6k   $��23��6�   $��
442,30,0,0q�6�   $	��Top=�6�   $	��120��6�    G� PasswordChar$ *��6�      Vista.Login   Password 5   ,   �� *
Password+ . $ PropertyChanged=�	 5      �� *ErrorCollection[Password]+
 5      ��%^   '��       �� 5      " ��6   .�5       ��  �@��CornerRadius$ 3��69   5"      5#      5$      �� 5%      -   5        $ lblBBDD��5%      $
��Left=�6)   $��	87,86,0,0q�6D   $
��Wrap=�6W   $��Base de Datos��6k   $	��Top=�6�   $
��Bold"�6�   $��14(�6�   �� 5&      -   5        $ txtBBDD��5&      
�������$��1q�5(   W   $
��Left=�6k   $��23��6�   $��
186,83,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��5&   '   �� *
Sociedad+ . $ PropertyChanged=�	 5(      �� *ErrorCollection[Sociedad]+.��6  
 5)      ��%^   '��       �� 5*      " ��6   .�5+      ��  �@��CornerRadius$ 3��69   5-      5.      .��6%   5/      �� 50      -   5         ��Name$ btnNuevo��50      $��Nuevo��6'   $
��Left=�67   $��603,137,0,0q�6R   $	��Top=�6g   $	��121��6   $
��Bold"�6�   $��14(�6�   &   System.Windows.Controls.DataGrid  51      -	   5          Name$ 	dgCompany��51      $   HorizontalScrollBarVisibility$ Visible=�6+      AutoGenerateColumns .  "   VerticalScrollBarVisibility$ Visible=�6p   $
��Left=�6�   $	��189��6�   $��
87,138,0,0q�6�   $	��Top=�6�      
IsReadOnly . $	��475��6�      SelectionMode$ Extended=�6,     GridLinesVisibility$	 All=�6E     VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   CanUserReorderColumns .    CanUserSortColumns . $��0q�6�     CanUserResizeColumns . $��1q�6  
�������   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6F     RowStyle 52      �� 53      )  #System.Windows.Controls.DataGridRow"  6   .�54      ��  � ��
 �����55      �� 56       �@ ValidationErrorTemplate 6D   Z�   �� Triggers  57      P� 58      ! P� Property! �@J�IsMouseOver" P� Value" . . �5:   "   ��  � �� �	#FF2196F35;      �� 5<   "    � ��
 �����5=      �� 5>   "    �@�Cursor$
 Hand��6;   6J   5?      # �� 	Resources# 5A      $ �� Color��%�   (��       5B   .   * SystemColors.HighlightBrushKey+)(�� %     5C   .   *$"SystemColors.HighlightTextBrushKey+)�� 5B      $$ Transparent��6`   �� 5C      $$ Black��6d   5D      5F      
 5I         
errorStyle% �� RelativeSource& �� Path��%#  &	        �� 5J      " ��6/   .�5K      ��  � ��$ -2q�64     5L      P� 5M      ! �@=�HasError" . . �5N   "   ��  �@�ToolTip 5O   !   �� % �� *Self+$)& #(Validation.Errors)[0].ErrorContent��� 5Q   "    � ��
 �   �6O   5R      5T      5U      '   Columns' 5W      0  *System.Windows.Controls.DataGridTextColumn  5X      1  +System.Windows.Controls.DataGridBoundColumn(   EditingElementStyle#( [  6)   ,  &System.Windows.Controls.DataGridColumn)   Header$) Nombre Sociedad��5Y      *   Width$* * 6/   -
   5        ID��+   Binding+ 5Z   #   �� *NombreSociedad+$ PropertyChanged=� . , �� NotifyOnValidationError, . 5]        5^      $* * 6C   $) Base de Datos��6M   + 6)   �� *name+6f     5_      $* * 6I   $) Fecha de Creacion��6S   + 6)   �� *create_date+6q   5c      �� 5d      -   5        $ btnOk��5d      $��OK��6$   $
��Left=�61   $��
87,344,0,0q�6L   $	��Top=�6`   $��92��6x   $
��Bold"�6�   $��16(�6�   6�   �� 5e      -   5        $ btnCancelar��5e      $��Cancelar��6*   $
��Left=�6=   $��203,344,0,0q�6X   $	��Top=�6m   $	��103��6�   $
��Bold"�6�   $��16(�6�   
�������
�������6�   �� 5f      -   5        $ btnChangeUser��5f      $��Cambiar Usuario��6,   $
��Left=�6F   $��
603,22,0,0q�6a   $	��Top=�6u   $	��121��6�   $��2q�6�   $
��Bold"�6�   $��14(�6�   6�   5h      5i      5j      