   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	        Vista.ListaCodigosFiscales   5   	   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	   -   5          � Title$  ListaCodigosFiscales��5   	   $��259.135��6&   $��331.673��67    � WindowStartupLocation$ CenterScreen=�6`   .��5
   
   � .+�5      �� -   5         ��Name$ 	txtFilter��5      $��1q�6)   $��	14,21,0,0q�6=   $��28��6t   $	��Top=�6�   $
��Left=�6�   $	��159��6�   .��6�    � 	Resources 5       �� 
TargetType �� Property �� Value��%^   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 3��69   5      5      .��6%   5      �� 5   
   -   5         ��Name$ ListCodigosFiscales��5      
���   �$��14,63,10,9.667q�6�   
���   �$��1q�6�   ��.  $
��Auto=�6  ��5      �� 5      " ��6   .�5      ��  � ��$ Stretch=�6G   �� 5       � ��$ Stretch=�6E   5       �� View 5      �� 5      !	 �� ColumnHeaderContainerStyle	 5"      �� 5#      " ��6$   .�5%   "   ��  � �� �	#FF2196F36?   �� 5&   "    � ��
 �����6?   �� 5'   "    � ��$
 Bold"�6?   �� 5(   "    � ��$ 30��6;   �� 5)   "    � ��$ Center=�6O   �� 5*   "    � ��$ Center=�6M   �� 5+   "    �@��TextAlignment$ Center=�6L   5,      .P�5.      �� $��Codigo��6*   
 �� Width
 6:   ��  �� ElementName$
 col1�� �� Path$ ActualWidth� �� CellTemplate 5/      �� 50   "   .R�51   &   �� 
�������$��1,1,0,1q�6E   $��-8,-2,-8,-2q�6`   ._�52   *   �� $��-8,-2,-8,-2q�65   .+�53   .   ��  �� TextAlignment$ Center=�68   $��22��6e   ��6O   �� *Code+6s   54   +   55   '   56   #   58      �� 59      $
��Tasa��6)   
 67   �� $
 col2��$ ActualWidth� 5:      �� 5;   "   .R�5<   &   �� 
�������$��1,1,0,1q�6E   $��-8,-2,-8,-2q�6`   ._�5=   *   �� $��-8,-2,-8,-2q�65   .+�5>   .   �� $ Center=�68   $��22��6e   ��6O   �� *Rate+6s   5?   +   5@   '   5A   #   5C      5E      5I      � 5J      $y�Hidden=�6    � ColumnDefinitions 5K      �� 5M      $��* �6'   �� 5O      $��* �6'   .+�5U      � -   5         �Name$
 col1��5U   '   $��0��6   6'   � 5V      -   5        $
 col2��5V   '   $��1��6   6'   5X      5[      5]      