   M S B A M L   `   `   `  ����K  GLicenceSCVSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:LicenceSCVSystemLicenceSCVSystem  5   	   !    LicenceSCVSystem.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:LicenceSCVSystem     5   	   -   5          � Title$  
MainWindow��5   	   $	��334��6   $��481.33��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ 
btnGenerar��5
      $��3q�6&   $��Generar��62   $
��Left=�6D   $��
44,243,0,0q�6_   $	��Top=�6s   $��88��6�   $
��Bold"�6�   $��14(�6�   $��32��6�   �� 5   
   -   5        $ btnExit��5      $��3q�6"   $��	Finalizar��6.   $
��Left=�6B   $��162,243,0,0q�6]   $	��Top=�6r   $��87��6�   $
��Bold"�6�   $��14(�6�   $��32��6�   �� 5   
   -   5         ��Name$ lblServidor��5      $
��Left=�6)   $��	49,37,0,0q�6D   $��Servidor��6W   $
��Wrap=�6g   $	��Top=�6{   $
��Bold"�6�   $��14(�6�   $��56��6�   �� 5   
   -   5        $ lblHardWareKey��5      $
��Left=�6,   $��	49,73,0,0q�6G   $��Hardware Key��6Z   $
��Wrap=�6n   $	��Top=�6�   $
��Bold"�6�   $��14(�6�   $	��120��6�   �� 5   
   -   5        $ lblFechaInicio��5      $
��Left=�6,   $��
49,117,0,0q�6G   $��Fecha Inicio��6[   $
��Wrap=�6o   $	��Top=�6�   $
��Bold"�6�   $��14(�6�   $	��120��6�   �� 5   
   -   5        $ lblFechaVencimiento��5      $
��Left=�61   $��
49,153,0,0q�6L   $��Fecha Vencimiento��6`   $
��Wrap=�6y   $	��Top=�6�   $
��Bold"�6�   $��14(�6�   $	��144��6�   �� 5   
   -   5         ��Name$ txtServidor��5   '   $��1q�6   $
��Left=�6<   $��
216,33,0,0q�6W    �� TextWrapping$
 Wrap=�6k   $	��Top=�6   $	��150��6�   $��25��6�   .��6�    � 	Resources 5       �� 
TargetType �� Property �� Value��%^   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 3��65   5      5      .��6!   5      �� 5   
   -	   5        $ txtHardWareKey��5   (   $��1q�6   $
��Left=�6@   $��
216,71,0,0q�6[   $
 Wrap=�6o   $	��Top=�6�   $	��150��6�   $��25��6�   .��6�    5      ��%^   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 3��65   5      5      .��6!   5!      (  "System.Windows.Controls.DatePicker  5"   
   -
   5        	  Name$	 dpFechaInicio��5"      $
��Left=�6,   $��217,110,0,0q�6G   $	��Top=�6\   $	��149��6t   $��26��6�    5#      ��%^   '��       �� 5$      " ��6   .�5%      ��  �@��CornerRadius$ 3��65   5'      5(      5)        5*   
   -   5        $	 dpFechaVencimiento��5*      $
��Left=�61   $��217,150,0,0q�6L   $	��Top=�6a   $	��149��6y   $��26��6�    5+      ��%^   '��       �� 5,      " ��6   .�5-      ��  �@��CornerRadius$ 3��65   5/      50      51      �� 52   
   -   5        $ 
btnValidar��52      $��3q�6%   $��Validar��61   $
��Left=�6C   $��280,243,0,0q�6^   $	��Top=�6s   $��87��6�   $
��Bold"�6�   $��14(�6�   $��32��6�   54      55      