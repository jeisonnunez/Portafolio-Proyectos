   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista      Vista.TipoCambio   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Vista        Vista.Document    Loaded$  Window_Loaded��   Closing$ Window_Closing�� � Title$ 
TipoCambio��$��600.333��$	��800�� � WindowStartupLocation$ CenterScreen=�.���� $
��Auto=�$
��Auto=�.��� $��Center=�$	��Top=�$��0,20,0,0q�.+��� -    ��Name$ tabControlTipoCambio��$
��Left=�$	��469��$	��Top=�$	��729�� � 	Resources  �� 
TargetType �� Property �� Value	 �� 
TargetType
 �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  '��       �� " ��.���  � �� �� "	 ��.R��� $��Border��$��1,1,1,0q�
�������$
 4,4,0,0��$	��2,0q�._��� $ ContentSite��$��Center=�$��Center=�$��Header��$
��10,2q� P�  �@��
IsSelected . . ��� $ Border�� � �� �	#FF2196F3��  � ��
 �������  � ��$ 14(�P�  �@��
IsSelected .  . ��� $ Border�� � ��
 �����.@��� $��Tipos de Cambio��$
��Bold"�.��� ���	#FFE5E5E5.+��� -    ��Name$ cbMes��   ComboBoxStyle#��[   �� DisplayMemberPath$ Month�� �� SelectedValuePath$
 Code��$
��Left=�$��
397,26,0,0q�$	��Top=�$	��132��
�������$��0q�$��31��
���   ��� -   $ cbAno��#��[  $
��Left=�$��
553,26,0,0q�$	��Top=�$	��132��
�������$��0q�$��31��$ Category��$ Category��&   System.Windows.Controls.DataGrid  -     Name$ dgTipoCambio��   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * $��1q�
�������   CanUserDeleteRows .     CanUserAddRows .  $
��Left=�$	��338��$��	31,82,0,0q�$	��Top=�$	��654��$   HorizontalScrollBarVisibility$ Visible=�"   VerticalScrollBarVisibility$ Visible=�   SelectionMode$ Single=�   SelectionUnit$
 Cell=�   GridLinesVisibility$	 All=�   VerticalGridLinesBrush
 �����   HorizontalGridLinesBrush
 �����
���   �$��Right=�$��Center=�   	CellStyle �� *  $System.Windows.Controls.DataGridCell"   �� Triggers P�  �@J�IsMouseOver . . ���  � �� �	#FF74C1FF��  � ��
 �   �P�  �@ 	IsEditing . . ���  � �� �	#FF74C1FF��  � ��
 �   �.���  � ��$ 25����  � ��$ Right=���  �@��TextAlignment$ Right=���  � ��$ Center=�  �� 	Resources  ! �� Color��%�   (��       * SystemColors.HighlightBrushKey+)(��      *$"SystemColors.HighlightTextBrushKey+)�� $! 	LightBlue���� $! Black��"   RowStyle" �� )  #System.Windows.Controls.DataGridRow"   P�  �@J�IsMouseOver . . ���  � ��
 ����� ��%=   (��       * SystemColors.HighlightBrushKey+)�� $	! Red���� -   # ��Name$# btnOK��$��OK��$
��Left=�$��	0,495,0,0q�$	��Top=�$��99��$��3q�$��16(��� -   $# btnCancelar��$��Cancelar��$
��Left=�$��126,495,0,0q�$	��Top=�$��99��$��3q�
�������
�������$��16(�