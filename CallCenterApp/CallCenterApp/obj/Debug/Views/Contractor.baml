   M S B A M L   `   `   `  ����H  DCallCenterApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CallCenterApp.ViewsCallCenterApp.Views  5   	   $    CallCenterApp.Views.Contractor   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:CallCenterApp.Views     5   	     � Title$  
Contractor��5   	   $��276.573��6   $	��608��6-   .��5	      � .+�5
   
   �� -   5         ��Name$ textBoxCompanyName��5
      $
��Left=�6.   $��23��6I   $��
107,10,0,0q�6U    �� TextWrapping$
 Wrap=�6i   $	��Top=�6�   $	��175��6�   ��6}   ��  �� Mode$ TwoWay=� �� Path$ Contractor.CompanyName�6�   �� 5   
   -   5         ��Name$ labelCompanyName��5      $��Nazwa Firmy��6*   $
��Left=�6@   $��10,6,0,0q�6[   $	��Top=�6m   �� 5   
   -   5        $ 
textBoxNip��5      $
��Left=�6&   $��23��6A   $��
107,38,0,0q�6M   $
 Wrap=�6a   $	��Top=�6�   $	��175��6�   ��6u   �� $ TwoWay=�$ Contractor.NIP�6�   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��DatePickerDateOfContract��5   h   $
��Left=�6   $��
159,64,0,0q�60   $	��Top=�6D   $	��123��6\      SelectedDate 6�   �� $ TwoWay=�$ Contractor.DateOfContract�   DisplayDate 6�   �� $ TwoWay=�$ Contractor.DateOfContract�  5   
   -   5        $!��DatePickerDateOfAppointment��5   h   $
��Left=�6   $��
159,90,0,0q�60   $	��Top=�6D   $	��123��6\    6�   �� $ TwoWay=�$" Contractor.DateOfAppointment� 6�   �� $ TwoWay=�$" Contractor.DateOfAppointment��� 5   
   -   5        $ textBoxOthersInfo��5      $
��Left=�6-   $��69��6H   $��416,124,0,0q�6T   $
 Wrap=�6i   $	��Top=�6�   $	��175��6�   ��6}   �� $ TwoWay=�$ Contractor.OthersInfo�6�   �� 5   
   -   5        $ labelNip��5      $	��NIP��6"   $
��Left=�60   $��	10,34,0,0q�6K   $	��Top=�6^   �� 5   
   -   5        $ labelDateOfContract��5      $��Umowa Do��6-   $
��Left=�6@   $��	10,63,0,0q�6[   $	��Top=�6n   �� 5   
   -	   5        $ labelDateOfAppointment��5      $��Data Spotkania��60   $
��Left=�6I   $��	10,90,0,0q�6d   $	��Top=�6w   �� 5   
   -
   5        $ labelOthersInfo��5      $��Uwagi��6)   $
��Left=�69   $��319,124,0,0q�6T   $	��Top=�6i   �� 5   
   -   5         ��Name$ 
buttonSave��5      $��Zapisz��6%   $
��Left=�66   $��
13,215,0,0q�6Q   $	��Top=�6e   $��75��6}   6�   �� 5   
   -   5        $ buttonCancel��5      $��Anuluj��6'   $
��Left=�68   $��207,215,0,0q�6S   $	��Top=�6h   $��75��6�   6�   �� 5   
   -   5        $ textBoxTelNumber��5      $
��Left=�6,   $��23��6G   $��
416,96,0,0q�6S   $
 Wrap=�6g   $	��Top=�6�   $	��175��6�   ��6{   �� *Contractor.TelNumber+$ TwoWay=�6�   �� 5   
   -   5        $ labelTelNumber��5      $��Nr telefonu��6(   $
��Left=�6>   $��
319,93,0,0q�6Y   $	��Top=�6m   �� 5   
   -   5        $ textBoxVoivodeship��5      $
��Left=�6.   $��23��6I   $��
416,10,0,0q�6U   $
 Wrap=�6i   $	��Top=�6�   $	��175��6�   ��6}   �� *Contractor.Voivodeship+$ TwoWay=�6�   �� 5   
   -   5        $ labelVoivodeship��5      $��Województwo��6*   $
��Left=�6@   $��	319,6,0,0q�6[   $	��Top=�6n   �� 5   
   -   5        $ textBoxTariff��5      $
��Left=�6)   $��23��6D   $��
416,38,0,0q�6P   $
 Wrap=�6d   $	��Top=�6�   $	��175��6�   ��6x   �� *Contractor.Tariff+$ TwoWay=�6�   �� 5   
   -   5        $ labelTariff��5      $��Taryfa��6%   $
��Left=�66   $��
319,34,0,0q�6Q   $	��Top=�6e   �� 5   
   -   5        $ textBoxAdress��5      $
��Left=�6)   $��23��6D   $��
416,67,0,0q�6P   $
 Wrap=�6d   $	��Top=�6�   $	��175��6�   ��6x   �� *Contractor.Adress+$ TwoWay=�6�   �� 5   
   -   5        $ labelAdress��5      $��Adres��6%   $
��Left=�65   $��
319,63,0,0q�6P   $	��Top=�6d     5   
   -   5        	  Name$	 DatePickerContact��5   i   $
��Left=�6   $��159,119,0,0q�60   $	��Top=�6E   $	��123��6]    6�   �� *Contractor.Contact+$ TwoWay=� 6�   �� *Contractor.Contact+$ TwoWay=��� 5   
   -   5        $ labelContact��5      $��Kontakt��6&   $
��Left=�68   $��
10,119,0,0q�6S   $	��Top=�6g     5    
   -   5        $	 DatePickerLaunchDate��5    i   $
��Left=�6   $��159,150,0,0q�60   $	��Top=�6E   $	��123��6]   {�.   6�   �� *Contractor.LaunchDate+$ TwoWay=� 6�   �� *Contractor.LaunchDate+$ TwoWay=�6�   �� 5!   
   -   5        $ labelLaunchDate��5!      $��Data wprowadzenia��6)   $
��Left=�6E   $��
10,149,0,0q�6`   $	��Top=�6t   5#      5$      