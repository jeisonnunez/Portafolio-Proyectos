   M S B A M L   `   `   `  ����@  <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista  5   	   W0clr-namespace:Vista.Gestion.ModelPeriodoContable"Vista.Gestion.ModelPeriodoContable  6+       Vista.Periodo_Contable   5   	   n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Vista     5   	   Clocal10clr-namespace:Vista.Gestion.ModelPeriodoContable     6+   -   5          � Title$  Periodo Contable��5   	   $	��551��6"   $	��559��6/    � WindowStartupLocation$ CenterScreen=�6;    � DataContext 5	      =   7Vista.Gestion.ModelPeriodoContable.ModelPeriodoContable  5
   
    � 	Resources 5         DatePicketStyle �� 
TargetType(  "System.Windows.Controls.DatePicker �� Triggers P� Property P� Value �� Property	 �� Value
 �� RelativeSource �� Path��%�   &	        �� 5   
   "  6(    5      P� 5       �@=�HasError . . �5      ��  �@�ToolTip	 5      �� 
 �� *Self+$) #(Validation.Errors)[0].ErrorContent�5      5      5      .��5      �� $
��Auto=�6   $
��Auto=�66   .��5   
   � $��Center=�6   $	��Top=�6,   $��0,10,0,0q�6D    � ColumnDefinitions 5       �� 5!      $
��200* �6#   �� 5"      .+�5$      �� -   5         ��Name$ lblCodigoPeriodo��5$      $
��Left=�62   $��	45,30,0,0q�6M   $
��Wrap=�6`   $��Codigo de Periodo��6t   $	��Top=�6�   $��14(�6�   $
��Bold"�6�   �� 5%      -   5         ��Name$ txtCodigoPeriodo��5%      
������� �� TextAlignment$ Center=�6�   $
��Left=�6�   $��26��6�   $��
221,26,0,0q�6�    �� TextWrapping$
 Wrap=�6  $	��Top=�6  $	��156��60  $��1q�6<  ��6P  �� $ 	PeriodCat� �� Mode$ TwoWay=� �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ PropertyChanged=� �� NotifyOnValidationError .  � ToolTip 6�  �� 
 �� *Self+$) #(Validation.Errors)[0].ErrorContent� . $ PropertyChanged=� . .��5&   �    5'      ��%^   '��       �� 5(      " ��6   .�5)      ��  �@��CornerRadius$	 3��69   5*      5+      .��6%   5,      �� 5-      -   5        $ lblNombrePeriodo��5-      $��14(�62   $
��Bold"�6@   $
��Left=�6R   $��	45,72,0,0q�6m   $
��Wrap=�6�   $��Nombre Periodo��6�   $	��Top=�6�   �� 5.      -   5        $ lblSubPeriodos��5.      $��14(�60   $
��Bold"�6>   $
��Left=�6Q   $��
45,109,0,0q�6l   $
��Wrap=�6�   $��SubPeriodos��6�   $	��Top=�6�   �� 5/      -   5        $ lblCantidadPeriodos��5/      $��14(�65   $
��Bold"�6C   $
��Left=�6U   $��
45,146,0,0q�6p   $
��Wrap=�6�   $��Cantidad Periodos��6�   $	��Top=�6�   �� 50      -   5        $ 	lblFechas��50      $
��Left=�6+   $��
57,237,0,0q�6F   $
��Wrap=�6Z   $��Fechas:��6n   $��16(�6}   $	��Top=�6�   $��	Underline{�6�   $
��Bold"�6�   �� 51      -   5        $ lblDContabilizacion��51      $��14(�65   $
��Bold"�6C   $
��Left=�6U   $��
45,270,0,0q�6p   $
��Wrap=�6�   $��De Fecha Contabilizacion��6�   $	��Top=�6�   �� 52      -	   5        $ lblDVencimiento��52      $��14(�61   $
��Bold"�6?   $
��Left=�6Q   $��
45,306,0,0q�6l   $
��Wrap=�6�   $��De Fecha Vencimiento��6�   $	��Top=�6�   �� 53      -
   5        $ lblDDocumento��53      $��14(�6/   $
��Bold"�6=   $
��Left=�6O   $��
45,339,0,0q�6j   $
��Wrap=�6~   $��De Fecha Documento��6�   $	��Top=�6�   �� 54      -   5        $ lblIEjercicio��54      $��14(�6/   $
��Bold"�6=   $
��Left=�6O   $��
45,383,0,0q�6j   $
��Wrap=�6~   $��Inicio del Ejercicio��6�   $	��Top=�6�   �� 55      -   5        $ lblEjercicio��55      $��14(�6.   $
��Bold"�6<   $
��Left=�6N   $��
45,419,0,0q�6i   $
��Wrap=�6}   $��	Ejercicio��6�   $	��Top=�6�   �� 56      -   5         ��Name$ btnCrear��56      $��Crear��6'   $
��Left=�67   $��
39,471,0,0q�6R   $	��Top=�6f   $��88��6~   $��24��6�   $��3q�6�   �� 57      -   5        $ btnCancelar��57      $��Cancelar��6*   $
��Left=�6=   $��159,471,0,0q�6X   $	��Top=�6m   $��92��6�   $��24��6�   
�������
�������$��3q�6�   �� 58      -   5        $ txtNombrePeriodo��58      $��1q�59   �   $ Center=�6  $
��Left=�62  $��26��6M  $��
221,66,0,0q�6Y  $
 Wrap=�6m  $	��Top=�6�  $	��156��6�  
���������58   0   �� $ 
PeriodName�$ TwoWay=� . $ PropertyChanged=� .  6�   �� 
 �� *Self+$) #(Validation.Errors)[0].ErrorContent� . $ PropertyChanged=� . .��59   �   5:      ��%^   '��       �� 5;      " ��6   .�5<      ��  �@��CornerRadius$	 3��69   5=      5>      .��6%   5?      �� 5@      -   5        $ txtSubPeriodos��5@      $��1q�6.   $
��Left=�6B   $ Center=�6]   $��26��6t   $��221,104,0,0q�6�   $��Meses��6�   $
 Wrap=�6�   $	��Top=�6�   $	��156��6�    �� 
IsReadOnly . 
�������.��69   5A      ��%^   '��       �� 5B      " ��6   .�5C      ��  �@��CornerRadius$	 3��69   5D      5E      .��6%   5F      �� 5G      -   5        $ txtCantidadPeriodos��5G      $��1q�63   $ Center=�6G   $
��Left=�6^   $��26��6y   $��221,142,0,0q�6�   $
 Wrap=�6�   $��12��6�   $	��Top=�6�   $	��156��6�    . 
�������.��6;   5H      ��%^   '��       �� 5I      " ��6   .�5J      ��  �@��CornerRadius$	 3��69   5K      5L      .��6%   5M        5N      -   5          Name$ dpDContabilizacion��5N     #��[  6   $
��Left=�6  $��221,266,0,0q�6:  $	��Top=�6O  $	��120��6g  $��27��6s     SelectedDate 6O   �� $ 	F_RefDate�$ TwoWay=� . $ PropertyChanged=� .  5O      ��%^   '��       �� 5P      " ��6   .�5Q      ��  �@��CornerRadius$	 3��69   5S      5T      5U        5W      -   5        $ dpDDocumento��5X   �   $
��Left=�6k   $��221,336,0,0q�6�   $	��Top=�6�   $	��120��6�   $��27��6�    5W      �� $ 	F_TaxDate�$ TwoWay=� . $ PropertyChanged=� .  6�   �� 
 �� *Self+$) #(Validation.Errors)[0].ErrorContent� 5Y      ��%^   '��       �� 5Z      " ��6   .�5[      ��  �@��CornerRadius$	 3��69   5]      5^      5_      �� 5`      -   5        $ lblHContabilizacion��5`      $��14(�65   $
��Bold"�6C   $
��Left=�6U   $��357,270,0,0q�6p   $
��Wrap=�6�   $��Hasta��6�   $	��Top=�6�   �� 5a      -   5        $ lblHVencimiento��5a      $��14(�61   $
��Bold"�6?   $
��Left=�6Q   $��357,306,0,0q�6l   $
��Wrap=�6�   $��Hasta��6�   $	��Top=�6�   �� 5b      -   5        $ lblHDocumento��5b      $��14(�6/   $
��Bold"�6=   $
��Left=�6O   $��357,339,0,0q�6j   $
��Wrap=�6   $��Hasta��6�   $	��Top=�6�     5c      -   5        $ dpHContabilizacion��5d   
  |�.  {�.  $
��Left=�6�   $��405,266,0,0q�6�   $	��Top=�6�   $	��120��6�   $��27��6�    5c   +   �� $ 	T_RefDate�$ TwoWay=� . $ PropertyChanged=� .  6�   �� 
 �� *Self+$) #(Validation.Errors)[0].ErrorContent� . $ PropertyChanged=� .  5e      ��%^   '��       �� 5f      " ��6   .�5g      ��  �@��CornerRadius$	 3��69   5i      5j      5k        5l      -   5        $ dpHVencimiento��5m   %  $
��Left=�6�   $��405,302,0,0q�6�   $	��Top=�6�   $	��120��6  $��27��6   5l      �� $ 	T_DueDate�$ TwoWay=� . $ PropertyChanged=� .  6�   �� 
 �� *Self+$) #(Validation.Errors)[0].ErrorContent� . $ PropertyChanged=� .  5n      ��%^   '��       �� 5o      " ��6   .�5p      ��  �@��CornerRadius$	 3��69   5r      5s      5t        5u      -   5        $ dpHDocumento��5v   %  $
��Left=�6�   $��405,336,0,0q�6�   $	��Top=�6�   $	��120��6  $��27��6   5u      �� $ 	T_TaxDate�$ TwoWay=� . $ PropertyChanged=� .  6�   �� 
 �� *Self+$) #(Validation.Errors)[0].ErrorContent� . $ PropertyChanged=� .  5w      ��%^   '��       �� 5x      " ��6   .�5y      ��  �@��CornerRadius$	 3��69   5{      5|      5}      �� 5~      -   5        $ txtEjercicio��5~      
�������$��1q�5   �   $ Center=�6�   $
��Left=�6  $��23��6+  $��221,419,0,0q�67  $
 Wrap=�6L  $	��Top=�6`  $	��120��6x  ��5~   ,   �� $
 Year�$ TwoWay=� . $ PropertyChanged=� .  6�   �� 
 �� *Self+$) #(Validation.Errors)[0].ErrorContent� . $ PropertyChanged=� . .��5   �   5�      ��%^   '��       �� 5�      " ��6   .�5�      ��  �@��CornerRadius$	 3��69   5�      5�      .��6%   5�        5�      -   5        $ dpEjercicio��5�     $
��Left=�6�   
�������$��221,383,0,0q�6�   $	��Top=�6�   $	��120��6�   $��24��6�    5�      �� $ 
FinancYear�$ TwoWay=� . $ PropertyChanged=� .  6�   �� 
 �� *Self+$) #(Validation.Errors)[0].ErrorContent� . $ PropertyChanged=� .  5�      ��%^   '��       �� 5�      " ��6   .�5�      ��  �@��CornerRadius$	 3��69   5�      5�      5�      �� 5�      -   5        $ 
lblEstatus��5�      $��14(�6,   $
��Bold"�6:   $
��Left=�6L   $��
45,194,0,0q�6g   $
��Wrap=�6{   $��Estatus del Periodo��6�   $	��Top=�6�   �� 5�      -   5         ��Name$ cbEstatusPeriodo��5�   �    �� DisplayMemberPath$ PeriodStatName��5�   M    �� SelectedValuePath$ PeriodStatCode��6p     ComboBoxStyle#��[ 6�   $��Center=�5�   �   $
��Left=�6  $��26��6)  {�.  $��221,190,0,0q�6G  $	��Top=�6]  $	��156��6u   �� 
IsEditable .  
�������$��Center=�6�  ��5�      �� *EstadosPeriodos+$ OneWay=� �� SelectedValue 6�   �� $ 
PeriodStat�$ PropertyChanged=� .  .  5�   p   �� 
 �� *Self+$) #(Validation.Errors)[0].ErrorContent�$ PropertyChanged=� .  . 5�        5�      -   5        $ dpDVencimiento��5�   U  $
��Left=�6�   $��221,302,0,0q�6  $	��Top=�6%  $	��120��6=  $��27��6I   5�      �� $ 	F_DueDate�$ TwoWay=� . $ PropertyChanged=� .  6�   �� 
 �� *Self+$) #(Validation.Errors)[0].ErrorContent�$ TwoWay=� . $ PropertyChanged=� . " �� ValidatesOnNotifyDataErrors .  5�      ��%^   '��       �� 5�      " ��6   .�5�      ��  �@��CornerRadius$	 3��69   5�      5�      5�      5�      5�      5�      