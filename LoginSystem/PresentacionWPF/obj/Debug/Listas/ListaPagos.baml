   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	       Vista.ListaPagos   5   	   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	   -   5          � Title$  Lista Pagos��5   	   $��325.708��6   $��655.953��6.    � WindowStartupLocation$ CenterScreen=�6>   .��5
      � .+�5   
   �� -   5         ��Name$ 	txtFilter��5      $��1q�6%   $��	14,21,0,0q�69   $��28��6p   $	��Top=�6|   $
��Left=�6�   $	��170��6�   ��.  $
��Auto=�6  .��6K   � 	Resources 5       �� 
TargetType �� Property �� Value��%^   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 3��65   5      5      .��6!   5      �� 5   
   -   5         ��Name$ ListPayment��5      
���   �$��14,63,10,9.667q�6�   
���   �$��1q�6�   ��.  $
��Auto=�6  ��5      �� 5      " ��6   .�5      ��  � ��$ Stretch=�6C   �� 5       � ��$ Stretch=�6A   5       �� View 5      �� 5      !	 �� ColumnHeaderContainerStyle	 5#      �� 5$      " ��6    .�5&      ��  � �� �	#FF2196F36;   �� 5'       � ��
 �����6;   �� 5(       � ��$
 Bold"�6;   �� 5)       � ��$ 30��67   �� 5*       � ��$ Center=�6K   �� 5+       � ��$ Center=�6I   �� 5,       �@��TextAlignment$ Center=�6H   5-      .P�5/      �� $��Numero��6&   
 �� Width
 66   ��  �� ElementName$
 col1�� �� Path$ ActualWidth� �� CellTemplate 50      �� 51      .R�52   "   �� 
�������$��1,1,0,1q�6A   $��-8,-2,-8,-2q�6\   ._�53   &   �� $��-8,-2,-8,-2q�61   .+�54   *   ��  �� TextAlignment$ Center=�64   $��22��6c   ��6K   �� *DocNum+6q   55   '   56   #   57      59      �� 5:      $��Fecha��6%   
 64   �� $
 col2��$ ActualWidth� 5;      �� 5<      .R�5=   "   �� 
�������$��1,1,0,1q�6A   $��-8,-2,-8,-2q�6\   ._�5>   &   �� $��-8,-2,-8,-2q�61   .+�5?   *   �� $ Center=�64   $��22��6�   ��6K   �� *	DocDate+ �� StringFormat$ {0:dd/MM/yyyy}��6�   5@   '   5A   #   5B      5D      �� 5E      $��	Proveedor��6%   
 68   �� $
 col3��$ ActualWidth� 5F      �� 5G      .R�5H   "   �� 
�������$��1,1,0,1q�6A   $��-8,-2,-8,-2q�6\   ._�5I   &   �� $��-8,-2,-8,-2q�61   .+�5J   *   �� $ Center=�64   $��22��6e   ��6K   �� *
CardCode+6s   5K   '   5L   #   5M      5O      �� 5P      $��
Comentario��6%   
 69   �� $
 col4��$ ActualWidth� 5Q      �� 5R      .R�5S   "   �� 
�������$��1,1,0,1q�6A   $��-8,-2,-8,-2q�6\   ._�5T   &   �� $��-8,-2,-8,-2q�61   .+�5U   *   �� $ Center=�64   $��22��6e   ��6K   �� *
JrnlMemo+6s   5V   '   5W   #   5X      5Z      5\      5`      � 5a   
   $y�Hidden=�6    � ColumnDefinitions 5b      �� 5d      $��* �6#   �� 5f      $��* �6#   �� 5g      $��* �6#   �� 5i      $��* �6#   .+�5o      � -   5         �Name$
 col1��5o   #   $��0��6   6#   � 5p      -   5        $
 col2��5p   #   $��1��6   6#   � 5q      -   5        $
 col3��5q   #   $��2��6   6#   � 5r      -   5        $
 col4��5r   #   $��3��6   6#   5t      5w      5y      