   M S B A M L   `   `   `  ����  MVVMDIWpfApp    MVVMDIWpfApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   0localusing:SampleMVVMWpfApplication     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � DataContext 5   	   �� *MainViewModel+   	vmLocator �� Source# [  .��5      � .+�5   
   �� .+�5	      �� $��
20,20,20,0q�69   ��6   �� *Text+ �� Mode$ TwoWay=�.��6M   5
      �� 5      $��
20,20,20,0q�6.   ��6   �� *Text+5      5      �� 5   
   $
��Left=�6   $	��151��60   $��
62,119,0,0q�6=   $	��Top=�6Q   $	��390��6i   .+�5      �� -   5        $
��Left=�5   9   $��21��6T   $��	108,0,0,0q�6`    �� TextWrapping$
 Wrap=�6s   $	��177��6�   ��6   �� *Text+$ TwoWay=�6�   �� 5      $��
Say hello!��6[   $
��Left=�6p   $��52��6�   $��	108,0,0,0q�6�   $	��177��6�   ��6   �� *SayHelloCommand+��69   �� *Text+6�   �� 5      $
��Left=�6   $��19��61   $��	109,0,0,0q�6=   $
 Wrap=�6P   $�� ��6d   $	��176��6l   5      5      5      