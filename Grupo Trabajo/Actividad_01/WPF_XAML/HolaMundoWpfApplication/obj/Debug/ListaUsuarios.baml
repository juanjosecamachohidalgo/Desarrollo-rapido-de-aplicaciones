   M S B A M L   `   `   `  ����R  NHolaMundoWpfApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK/clr-namespace:HolaMundoWpfApplication;assembly=HolaMundoWpfApplication  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R8clr-namespace:System.ComponentModel;assembly=WindowsBaseSystem.ComponentModel 5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35X@clr-namespace:System.Windows.Data;assembly=PresentationFrameworkSystem.Windows.Data 5   	   +    %HolaMundoWpfApplication.ListaUsuarios   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Alocal/clr-namespace:HolaMundoWpfApplication;assembly=     5   	   Hscm8clr-namespace:System.ComponentModel;assembly=WindowsBase     5   	   Pdat@clr-namespace:System.Windows.Data;assembly=PresentationFramework     5   	     � Title$  ListaUsuarios��5   	   $	��402��6   $	��311��6,    � 	Resources 5         xmlListaUsuarios � XPath � Source.   (HolaMundoWpfApplication.UsuarioConverter  usuarioConverter  UsuarioViewSource �� Source �� Source �� XPath �� GroupDescriptions2  ,System.Windows.Data.PropertyGroupDescription   PropertyName	 �� SortDescriptions+  %System.ComponentModel.SortDescription
   PropertyName��%  &	        &	 H     &	 [     7   � 5
   
   $ Usuarios��63   $ ListaUsuarios.xml?�6D   5        5   
   6!   �� 5   
   -   5         5   9   �� 8   $ 	//Usuario�� 5        5      $
 Edad��6/   	 5        5      $

 Edad��6&   5      5      .��5      �� .��5   
   ��  �� Orientation$ Vertical=�6   .+�5      �� $��Todos los usuarios��6   $��5,0,0,0q�5      $��14(�6"   $
��Bold"�60   �� 5      $ 
Horizontal=�6   $��10,10,10,10q�62   
�������.+�5      �� ��6   �� # [  $ Usuario/Nombre��5      �� 5       $ ��Usuario de profesion Actor��6   $��5,0,0,0q�5!      $��14(�6&   $
��Bold"�64   �� 5"      $ 
Horizontal=�6   $��10,10,10,10q�62   
�������.+�5$      �� $	��178��5%   8   ��5$      �� # [  $ *[@Profesion='Actor']�� �� SelectedItem 5%      �� *Path+��5&      �� 5'      .R�5(      �� ��6$   ��  �� 	Converter# [ 5)      5+      5,      �� 5-      -   5        $��
Collection��5-       �� DisplayMemberPath$ Nombre��6(   ��6C   �� # [  �� 
GroupStyle 5.      �� 5/       �� Member$ GroupStyle.Default��6   51      52      53      54      