   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5          Vista.UserControlMenuItem   5      n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      %localclr-namespace:Vista     5      U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $��271.765��5      .��5
      �   � ColumnDefinitions  5   
   �� 5      $��5* �6   �� 5      $��1* �6   .+�5   
   '  !MaterialDesignThemes.Wpf.PackIcon  $��20��6=   $��20��6H   $��	10,16,0,0q�6T   
�������   Kind 6"   ��  �� Path$
 Icon�6g   �� 5   
   -   5         ��Name$ ListViewItemMenu��5      $��	0,20,20,0q�6P   $��0,0,0,0q�6d   $��14(�6u   $��16(�6�   $��2��6�   $	��230��6�   ��60   �� $ Header�6�   9� 5   
   -   5         9�Name$ ExpanderMenu��5      $	��230��6�   $��Right=�6�   
�������$��2��6  ��6)   �� $ Header� 9� 
IsExpanded 6H   ��  �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType$ ListBoxItemL�$ 
IsSelected���6�   Z� .��5      �� -   5        	 ��Name$	 ListViewMenu��5      
�������$��Disabled=�6f   
 � Cursor$

 Hand��6�   ��6-   �� $ SubItems���5      �� 5      .R�5      ��  �� Padding$ 	20,5,20,0q�6?   ��6$   �� $
 Name�
 � Tag 6S   �� $ IsValid�5      ��5      �� 5       �� 
TargetType" ��6   .�5      -   5         �� Triggers 5       P� 5!       P� Property �@��
IsSelected P� Value . . �5"   "   ��  �� Property � �� �� Value
 ���� 6?   5#      P� 5$       �@��
IsSelected .  . �5%   "   ��  � ��
 ���� 6?   5&      P� 5'       �@J�IsMouseOver . . �5(   "   ��  � ��
 � ���6?   �� 5)   "    � ��$ 14(�6=   �� 5*   "    �@�Cursor$
 Hand��6;   5+      5-      50      51      54      55      