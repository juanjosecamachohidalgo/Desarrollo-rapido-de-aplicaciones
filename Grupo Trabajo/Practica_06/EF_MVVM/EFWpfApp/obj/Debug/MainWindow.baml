   M S B A M L   `   `   `  ����M  IEFMVVMClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS<clr-namespace:EFMVVMClassLibrary;assembly=EFMVVMClassLibraryEFMVVMClassLibrary  5   �    EFWpfApp   EFWpfApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6F   [EFMVVMClassLibrary<clr-namespace:EFMVVMClassLibrary;assembly=EFMVVMClassLibrary     6�   -   5          � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � 	Resources 5         customerViewSource % !customerCustomerAddressViewSource �� Source �� Source��%`   &	        &	      7   �� 5   
   6   �� 5   
    6I   �� *CustomerAddress+8   5	      .��5
      �  � DataContext# [  6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ customerDataGrid��5         RowDetailsVisibilityMode$ VisibleWhenSelected=�6-   $��55,26,62,141q�6\      EnableRowVirtualization .    AutoGenerateColumns .  ��6r   �� 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        companyNameColumn��,  &System.Windows.Controls.DataGridColumn
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 SizeToHeader 5   @      Header$ Company Name��6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6k   �� *CompanyName+  5      -   5        customerIDColumn��$
 SizeToHeader 5   ?   $ Customer ID��6T    6i   �� *
CustomerID+  5      -   5        emailAddressColumn��$
 SizeToHeader 5   A   $ Email Address��6V    6m   �� *EmailAddress+  5      -   5        firstNameColumn��$
 SizeToHeader 5   >   $ 
First Name��6S    6g   �� *	FirstName+  5      -   5        lastNameColumn��$
 SizeToHeader 5   =   $ 	Last Name��6R    6e   �� *
LastName+  5      -   5        middleNameColumn��$
 SizeToHeader 5   ?   $ Middle Name��6T    6i   �� *
MiddleName+4  .System.Windows.Controls.DataGridTemplateColumn  5      -	   5        modifiedDateColumn��$
 SizeToHeader 5   E   $ Modified Date��6Z      CellTemplate 5      �� 5      .R�5      (  "System.Windows.Controls.DatePicker     SelectedDate 6)   �� *ModifiedDate+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 5      5      4  .System.Windows.Controls.DataGridCheckBoxColumn  5      -
   5        nameStyleColumn��$
 SizeToHeader 5   B   $ 
Name Style��6W    6k   �� *	NameStyle+  5      -   5        passwordHashColumn��$
 SizeToHeader 5   A   $ Password Hash��6V    6m   �� *PasswordHash+  5      -   5        passwordSaltColumn��$
 SizeToHeader 5   A   $ Password Salt��6V    6m   �� *PasswordSalt+  5      -   5        phoneColumn��$
 SizeToHeader 5   :   $ Phone��6O    6^   �� *Phone+  5      -   5        rowguidColumn��$
 SizeToHeader 5   <   $ rowguid��6Q    6b   �� *	rowguid+  5       -   5        salesPersonColumn��$
 SizeToHeader 5    @   $ Sales Person��6U    6k   �� *SalesPerson+  5!      -   5        suffixColumn��$
 SizeToHeader 5!   ;   $ Suffix��6P    6`   �� *Suffix+  5"      -   5        titleColumn��$
 SizeToHeader 5"   :   $ Title��6O    6^   �� *Title+5$        5%   
   -   5        $ customerAddressDataGrid��5%       .   . $��55,192,62,30q�6�   $ VisibleWhenSelected=�6�   ��6o   �� # [ 	 5&        5'      -   5        addressIDColumn��$ 
Address ID��5'   \   $
 SizeToHeader 6p    6>   �� *	AddressID+6p     5(      -   5        addressTypeColumn��$ Address Type��5(   `   $
 SizeToHeader 6v    6@   �� *AddressType+6v     5)      -   5        customerIDColumn1��$ Customer ID��5)   _   $
 SizeToHeader 6t    6@   �� *
CustomerID+6t     5*      -   5        modifiedDateColumn1��$ Modified Date��5*   F   $
 SizeToHeader 6]    5+      �� 5,      .R�5-         6)   �� *ModifiedDate+$ TwoWay=� .  . 5.      50        51      -   5        rowguidColumn1��$ rowguid��51   Y   $
 SizeToHeader 6j    6=   �� *	rowguid+6j   53      55      56      