   M S B A M L   `   `   `  ����R  NHolaMundoWpfApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK/clr-namespace:HolaMundoWpfApplication;assembly=HolaMundoWpfApplication  5   	   #    HolaMundoWpfApplication.Login   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Alocal/clr-namespace:HolaMundoWpfApplication;assembly=     5   	     � Title$  Hola Mundo - Login��5   	   $	��175��6$   $	��450��61    � 	Resources 5      +   %HolaMundoWpfApplication.UsuariosModel   ListaUsuarios*   $HolaMundoWpfApplication.UsuarioModel   Nombre   PalabraDePaso��%S   &	          5   
     5	      $
 Iker��6!   $ Casillas��6/   5
      5      .��5      � $��Stretch=�6    � ColumnDefinitions 5   
   �� 5      $
��235* �6   �� 5      $
��235* �6    � RowDefinitions 5   
   �� 5      $	��35* �6   �� 5      $	��35* �6   �� 5      $	��35* �6   �� 5      $	��35* �6   .+�5   
   �� $��Login��6   $��Stretch=�6    $��0q�6>   $	��Top=�6I   $��2��6a     headerTextStyle#��[ 6u   �� 5   
   $��Usuario��6   $��Center=�6"   $��0q�6?   $��1��6J   $	��Top=�6W   $��26��6o   $��70��6{     
labelStyle#��[ 6�   �� 5   
   $��Palabra de paso��6   $��Center=�6*   $��0q�6G   $��2��6R   $	��Top=�6_   $��26��6w   $	��130��6�   #��[ 6�   �� 5   
   -   5        $��usuarioTextBox��5      $��1��6(   $��Stretch=�68   $��23��6V   $��0,0,30,0q�6b   $��1��6t    �� TextWrapping$
 Wrap=�6�   $�� ��6�   $	��Top=�6�   �� 5    
   -   5        $��palabraDePasoTextBox��5       $��1��6.   $��Stretch=�6>   $��23��6\   $��0,0,30,0q�6h   $��2��6z   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   �� 5!   
   -   5        $��OK��5!   (   $��Center=�65   $��0q�6R   $��3��6]   $��Center=�6j   $��74��6�   $��22��6�     okButtonStyle#��[ 6�   �� 5"   
   -   5        $��Cancel��5"   ,   $��1��6=   $��Center=�6M   $��0q�6j   $��3��6u   $��Center=�6�   $��74��6�   $��22��6�     cancelButtonStyle#��[ 6�   �� 5#   
   -   5         ��Name$ usuariosComboBox��5#      #��[  6b    �� DisplayMemberPath$ Nombre��6�   	 �� SelectedValuePath$	 Nombre��6�   $��1��6�   $
��Left=�6�   $��0,5,30,0q�6�   $	��Top=�6  $	��190��6&  5&      5'      