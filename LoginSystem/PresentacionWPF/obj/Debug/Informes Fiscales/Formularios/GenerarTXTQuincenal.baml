   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	       Vista.GenerarTXTQuincenal   5   	   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	   -   5          � Title$  GenerarTXTQuincenal��5   	    � WindowStartupLocation$ CenterScreen=�6<   $��212.667��6{   $��417.982��6�   .��5	      � .+�5
   
   �� -   5         ��Name$ 
lblPeriodo��5
      $
��Bold"�6(   $
��Left=�6:   $��	20,50,0,0q�6U   $
��Wrap=�6h   $��Introduzca Periodo��6|   $	��Top=�6�   �� 5   
   -   5         ��Name$ 	cbPeriodo��5       �� SelectedValuePath$
 Code��6&    �� DisplayMemberPath$
 Code��6?      ComboBoxStyle#��[  6Y   $��23��6�   
������� �� 
IsReadOnly . 
���   �$
��Left=�6  $��
146,49,0,0q�6  $	��Top=�63  $	��162��6K  �� 5   
   -   5         ��Name$ btnCrear��5      $��OK��6#   $
��Left=�60   $��
21,138,0,0q�6K   $	��Top=�6_   $��95��6w   $��3q�6�   6�   �� 5   
   -   5        $ btnCancelar��5      $��Cancelar��6&   $
��Left=�69   $��130,138,0,0q�6T   $	��Top=�6i   $��94��6�   $��3q�6�   
�������
�������6�   �� 5   
   -   5        $ lblQuincena��5      $
��Bold"�6)   $
��Left=�6;   $��	21,89,0,0q�6V   $
��Wrap=�6i   $��	Quincena:��6}   $	��Top=�6�   �� 5   
   -   5        $ 
cbQuincena��5      $
 Name��6'   $
 Code��6@   #��[  6Y   $��23��6�   
������� . 
���   �$
��Left=�6  $��
146,85,0,0q�6  $	��Top=�63  $	��162��6K  5      5      