   M S B A M L   `   `   `  ����T  PLearningClassLibrary.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullzSclr-namespace:LearningClassLibrary.Data.Entities;assembly=LearningClassLibrary.Data"LearningClassLibrary.Data.Entities  5   �    UsingDBLearningWpfApp(   "UsingDBLearningWpfApp.Views.Tutors   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6F   hEntitiesSclr-namespace:LearningClassLibrary.Data.Entities;assembly=LearningClassLibrary.Data     6�   -   5          � Title$  Tutors��5   	   $	��300��6   $��447.761��6%    � 	Resources 5         tutorViewSource��%   &	        �� 5   
   6   5      .��5	      �  � DataContext# [  6   $��0,0,2,0q�6:   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ tutorDataGrid��5         RowDetailsVisibilityMode$ VisibleWhenSelected=�6*   $��30,33,10,36q�6Y      EnableRowVirtualization .    AutoGenerateColumns .  ��6n   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        emailColumn��,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 5   :   	   Header$	 Email��6O   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6^   �� *Email+  5      -   5        firstNameColumn��$ SizeToHeader 5   >   $	 
First Name��6S   
 6g   �� *	FirstName+  5      -   5        genderColumn��$ SizeToHeader 5   ;   $	 Gender��6P   
 6`   �� *Gender+  5      -   5        idColumn��$ SizeToHeader 5   7   $	 Id��6L   
 6X   �� *Id+  5      -   5        lastNameColumn��$ SizeToHeader 5   =   $	 	Last Name��6R   
 6e   �� *
LastName+  5      -   5        passwordColumn��$ SizeToHeader 5   =   $	 Password��6R   
 6d   �� *
Password+  5      -	   5        userNameColumn��$ SizeToHeader 5   =   $	 	User Name��6R   
 6e   �� *
UserName+5      5      5      