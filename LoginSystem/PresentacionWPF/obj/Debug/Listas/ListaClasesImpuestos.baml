   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	        Vista.ListaClasesImpuestos   5   	   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	   -   5          � Title$  ListaClasesImpuestos��5   	   $��259.135��6&   $��331.673��67    � WindowStartupLocation$ CenterScreen=�6`   .��5	      � .+�5   
   �� -   5         ��Name$ 	txtFilter��5      $��1q�6%   $��	14,21,0,0q�69   $��28��6p   $	��Top=�6|   $
��Left=�6�   $	��159��6�   .��6�    � 	Resources 5       �� 
TargetType �� Property �� Value��%^   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 3��65   5      5      .��6!   5      �� 5   
   -   5         ��Name$ ListClasesImpuesto��5      
���   �$��14,63,10,9.667q�6�   
���   �$��1q�6�   ��.  $
��Auto=�6  ��5      �� 5      " ��6   .�5      ��  � ��$ Stretch=�6C   �� 5       � ��$ Stretch=�6A   5       �� View 5      �� 5      !	 �� ColumnHeaderContainerStyle	 5!      �� 5"      " ��6    .�5$      ��  � �� �	#FF2196F36;   �� 5%       � ��
 �����6;   �� 5&       � ��$
 Bold"�6;   �� 5'       � ��$ 30��67   �� 5(       � ��$ Center=�6K   �� 5)       � ��$ Center=�6I   �� 5*       �@��TextAlignment$ Center=�6H   5+      .P�5-      �� $��Codigo��6&   
 �� Width
 66   ��  �� ElementName$
 col1�� �� Path$ ActualWidth� �� CellTemplate 5.      �� 5/      .R�50   "   �� 
�������$��1,1,0,1q�6A   $��-8,-2,-8,-2q�6\   ._�51   &   �� $��-8,-2,-8,-2q�61   .+�52   *   ��  �� TextAlignment$ Center=�64   $��22��6a   ��6K   �� *Code+6o   53   '   54   #   55      57      �� 58      $
��Tasa��6%   
 63   �� $
 col2��$ ActualWidth� 59      �� 5:      .R�5;   "   �� 
�������$��1,1,0,1q�6A   $��-8,-2,-8,-2q�6\   ._�5<   &   �� $��-8,-2,-8,-2q�61   .+�5=   *   �� $ Center=�64   $��22��6a   ��6K   �� *Rate+6o   5>   '   5?   #   5@      5B      5D      5H      � 5I   
   $y�Hidden=�6    � ColumnDefinitions 5J      �� 5L      $��* �6#   �� 5N      $��* �6#   .+�5T      � -   5         �Name$
 col1��5T   #   $��0��6   6#   � 5U      -   5        $
 col2��5U   #   $��1��6   6#   5W      5Z      5[      