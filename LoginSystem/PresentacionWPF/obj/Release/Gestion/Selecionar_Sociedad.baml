   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  q=clr-namespace:Vista.Gestion.ValidateErrorsSeleccionarSociedad/Vista.Gestion.ValidateErrorsSeleccionarSociedad      Vista.Selecionar_Sociedad   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Vista     Plocal1=clr-namespace:Vista.Gestion.ValidateErrorsSeleccionarSociedad     -     � Title$  Selecionar_Sociedad��$	��446��$	��800�� � WindowStartupLocation$ Manual=� � DataContext W   QVista.Gestion.ValidateErrorsSeleccionarSociedad.ValidateErrorsSeleccionarSociedad  .���� $
��Auto=�$
��Auto=�.��� $��Center=�$	��Top=�$��0,20,0,0q�.+��� -    ��Name$ 
lblUsuario��$
��Left=�$��	87,34,0,0q�$
��Wrap=�$��ID de Usuario��$	��Top=�$
��Bold"�$��14(��� -   $ lblClave��$
��Left=�$��
326,34,0,0q�$
��Wrap=�$��Clave de Acceso��$	��Top=�$��17��$
��Bold"�$��14(��� -    ��Name$ 
txtUsuario��
�������$��1q�$
��Left=�$��23��$��
186,31,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��120������ *
Username+ �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ PropertyChanged=� � ToolTip �� *ErrorCollection[Username]+$ PropertyChanged=�.��	 � 	Resources	 
 �� 
TargetType �� Property �� Value��%9   '��       �� "
 ��.���  �@��CornerRadius$ 3��.��G� -    G�Name$ txtClave��
�������$��1q�$
��Left=�$��23��$��
442,30,0,0q�$	��Top=�$	��120�� G� PasswordChar$ *��   Vista.Login   Password �� *
Password+ . $ PropertyChanged=� �� *ErrorCollection[Password]+	 ��%9   '��       �� "
 ��.���  �@��CornerRadius$ 3���� -   $ lblBBDD��$
��Left=�$��	87,86,0,0q�$
��Wrap=�$��Base de Datos��$	��Top=�$
��Bold"�$��14(��� -   $ txtBBDD��
�������$��1q�$
��Left=�$��23��$��
186,83,0,0q�$
 Wrap=�$	��Top=�$	��120������ *
Sociedad+ . $ PropertyChanged=� �� *ErrorCollection[Sociedad]+.��	 ��%9   '��       �� "
 ��.���  �@��CornerRadius$ 3��.���� -    ��Name$ btnNuevo��$��Nuevo��$
��Left=�$��603,137,0,0q�$	��Top=�$	��121��$
��Bold"�$��14(�&   System.Windows.Controls.DataGrid  -	     Name$ 	dgCompany��$   HorizontalScrollBarVisibility$ Visible=�   AutoGenerateColumns .  "   VerticalScrollBarVisibility$ Visible=�$
��Left=�$	��189��$��
87,138,0,0q�$	��Top=�$	��475��   SelectionMode$ Extended=�   GridLinesVisibility$	 All=�   VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����   CanUserReorderColumns .    CanUserSortColumns . $��0q�   CanUserResizeColumns . $��1q�
�������   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ *    RowStyle �� )  #System.Windows.Controls.DataGridRow"
  .���  � ��
 �������  �@ ValidationErrorTemplate Z�  �� Triggers P�  P� Property �@J�IsMouseOver  P� Value  . . ���  � �� �	#FF2196F3��  � ��
 �������  �@�Cursor$
 Hand��! �� 	Resources! " �� Color��%�   (��       * SystemColors.HighlightBrushKey+)(��      *$"SystemColors.HighlightTextBrushKey+)�� $" Transparent���� $" Black��	    
errorStyle# �� RelativeSource$ �� Path��%�   &	        �� "
 ��.���  � ��$ -2q� P�  �@=�HasError  . . ���  �@�ToolTip �� # �� *Self+$)$ #(Validation.Errors)[0].ErrorContent���  � ��
 �   �%   Columns% 0  *System.Windows.Controls.DataGridTextColumn  1  +System.Windows.Controls.DataGridBoundColumn&   EditingElementStyle#& [  ,  &System.Windows.Controls.DataGridColumn'   Header$' Nombre Sociedad��(   Width$( * -
   ID��)   Binding) �� *NombreSociedad+$ PropertyChanged=� . * �� NotifyOnValidationError* .   $( * $' Base de Datos��) �� *name+  $( * $' Fecha de Creacion��) �� *create_date+�� -   $ btnOk��$��OK��$
��Left=�$��
87,344,0,0q�$	��Top=�$��92��$
��Bold"�$��16(��� -   $ btnCancelar��$��Cancelar��$
��Left=�$��203,344,0,0q�$	��Top=�$	��103��$
��Bold"�$��16(�
�������
��������� -   $ btnChangeUser��$��Cambiar Usuario��$
��Left=�$��
603,22,0,0q�$	��Top=�$	��121��$��2q�$
��Bold"�$��14(�