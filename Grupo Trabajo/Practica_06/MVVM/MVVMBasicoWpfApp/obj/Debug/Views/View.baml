   M S B A M L   `   `   `  ����K  GMVVMBasicoWpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:MVVMBasicoWpfApp.ViewModelsMVVMBasicoWpfApp.ViewModels  5   	   G(clr-namespace:MVVMBasicoWpfApp.BehaviorsMVVMBasicoWpfApp.Behaviors  5   	   !    MVVMBasicoWpfApp.Views.View   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   8vm)clr-namespace:MVVMBasicoWpfApp.ViewModels     5   	   6b(clr-namespace:MVVMBasicoWpfApp.Behaviors     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   $��333.403��5   !   $��477.612��62     � Title  6	   �� *Title+ � DataContext 5	      +   %MVVMBasicoWpfApp.ViewModels.ViewModel  5
   
   .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *ShowWelcomeMsgCommand+5       � 	Resources 5       �� 
TargetType �� Property	 �� Value��%>  '��       '�� �     �� 5   
   " ��6   .�5      ��  � ��
	 ��ح�6+   �� 5       � ��$	 Italic$�6*   �� 5       � ��$	 4q�6'   5      �� 5   
   " ��6   .�5      ��  � ��
	 ��ح�6+   �� 5       � ��$	 Italic$�6*   �� 5       � ��$	 4q�6'   5      5      .��5       � $	��294��6   $	��Top=�6   
 � RowDefinitions
 5!   
   �� 5"      �� 5#      �� 5$      $��30 �6   �� 5%      �� 5&       � ColumnDefinitions 5(   
   �� 5)      �� 5*      �� 5+      .+�5-   
   �� -   5        $��cmdSetTitle��5-   L   $��Change Title��65   $��0,0,0,0q�6_   ��6   �� *SetTitleCommand+6_   �� 5.   
   -   5        $��cmbItems��5.       �� SelectedValuePath$ Value��6#    �� DisplayMemberPath$
 Name��6=   $��1��6�   $��2��6�   $��0q�6�   ��6V   �� *Items+ �� SelectedItem 6t   �� *SelectedItem+ �� Mode$ TwoWay=�6�   �� 5/   
   -   5        $��cmdResetTitle��5/   M   $��Reset Title��67   $��-1,0,0,0q�6b   $��1��6t   ��6   �� *ResetTitleCommand+6t   �� 50   
   -   5        $��
cmdAddItem��50   G   $��Add Item��64   $��1��6Y   $��1��6i   $��0q�6v   ��6   �� *AddItemCommand+6v   �� 51   
   -   5        $��cmdDeleteItem��51   M   $��Remove Item��67   $��2��6b   $��1��6r   $��0q�6   ��6   �� *RemoveItemCommand+6   �� 52   
   -   5        $��
textBlock1��52      $��2��6V   $��3��6c   $��Center=�6w   ��6&   ��  �� Path$ SelectedItem�$ OneWay=�6w   �� 53   
   $��Show Question��6>   $��3��6V   $��0q�6c   ��6   �� *ShowYesNoQuestionCommand+6c   �� 54   
   $��3��6,   $��1��69   $��2��6I   $��Center=�6]   $��Center=�6z   ��6   �� *Answer+6z   �� 55   
   $"��System.Windows.Interactivity��6   $��4��68   $��0q�6E    56        57      $ 
MouseEnter��6!   . 58         6,   �� *ChangeColorCommand+59      5;      �� 5<   
   $��4��6   $��1��6!    �� TextAlignment$ Center=�6Q   $��Center=�6h   $��14(�6�   $��Italic$�6�   ��61   �� *MouseEnterText+��6�   �� *	ColorText+6�   �� 5=   
   $��Attached behavior��6   $��4��6-   $��2��6:   $��0q�6�   .   (MVVMBasicoWpfApp.Behaviors.MouseBehavior   
MouseEnter 6J   �� *ChangeColorCommand+6�   5>      5@      