   M S B A M L   `   `   `  ����S  OValidacionWpfApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:ValidacionWpfApplicationValidacionWpfApplication  5   	   )    #ValidacionWpfApplication.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   8local&clr-namespace:ValidacionWpfApplication     5   	     � Title$  
MainWindow��5   	   $	��250��6   $	��460��6)    � 	Resources 5       �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value �� RelativeSource	 �� Path��%  '��       �� 5   
   " ��6   .�5	      ��  � ��$ 8q�6'   �� 5       �@=�ErrorTemplate 5      �� 5      .R�5      ]� ��. .+�5      �� $��Right=�6(   
���  ��$��14(�5   %   $
��Bold"�63   !6H   �� 5      
���  ��$��1q�67   ._�5   "   �� 6>   5      5      5      5       5      P� 5       �@=�HasError . . �5      ��  �@�ToolTip 60   ��  �� *Self+$)	 #(Validation.Errors)[0].ErrorContent�5      5      5      .��5!      � 
 J� RenderTransformOrigin$
 0.524,0.582&�6   .+�5"   
   �� $��
4,4,51,113q�6   .+�5$      �� $
��Left=�6   $��20��63   $��10,0,0,0q�6?   $
��Wrap=�6Q   $��Username��6e   $��67��6u   �� 5&      ��6   �� *Nombre+ �� ValidatesOnDataErrors . �� 5'      $
��Left=�6   $��15��63   $��10,0,0,0q�6?   $
��Wrap=�6Q   $��Password��6e   $��53��6u   �� 5(      ��6   �� *PalabraDePaso+ �� UpdateSourceTrigger$ PropertyChanged=� . 5*      �� 5+   
   -   5         ��Name$ messageButtom��5+      $��OK��6G   $
��Left=�6T   $��23��6o   $��
99,126,0,0q�6{   $	��Top=�6�   $��70��6�   ��6(   �� *	OkCommand+6�   5,      5.      