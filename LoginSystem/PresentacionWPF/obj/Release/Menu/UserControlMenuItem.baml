   M S B A M L   `   `   `  ���� @  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista      Vista.UserControlMenuItem   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     %localclr-namespace:Vista     U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  $��271.765��.���   � ColumnDefinitions  �� $��5* ��� $��1* �.+�'  !MaterialDesignThemes.Wpf.PackIcon  $��20��$��20��$��	10,16,0,0q�
�������   Kind ��  �� Path$
 Icon��� -    ��Name$ ListViewItemMenu��$��	0,20,20,0q�$��0,0,0,0q�$��14(�$��16(�$��2��$	��230������ $ Header�9� -    9�Name$ ExpanderMenu��$	��230��$��Right=�
�������$��2������ $ Header� 9� 
IsExpanded ��  �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType$ ListBoxItemL�$ 
IsSelected���Z� .���� -   	 ��Name$	 ListViewMenu��
�������$��Disabled=�
 � Cursor$

 Hand������ $ SubItems����� .R���  �� Padding$ 	20,5,20,0q�
������ ���� $
 Name�
 � Tag �� $ IsValid�����  �� 
TargetType" ��.�-    �� Triggers P�  P� Property �@��
IsSelected P� Value . . ���  �� Property � �� �� Value
 ���� P�  �@��
IsSelected .  . ���  � ��
 ���� P�  �@J�IsMouseOver . . ���  � ��
 � �����  � ��$ 14(���  �@�Cursor$
 Hand��