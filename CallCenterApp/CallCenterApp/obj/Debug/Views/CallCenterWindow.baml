   M S B A M L   `   `   `  ����H  DCallCenterApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CallCenterApp.ViewsCallCenterApp.Views  5   	   *    $CallCenterApp.Views.CallCenterWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:CallCenterApp.Views     5   	   -   5          � Title$  CallCenterWindow��5   	   $	��325��6"   $	��900��6/   $	��325��6;   $	��900��6K    � WindowState$ 	Maximized=�6Z   .��5	      �  � ColumnDefinitions 5
   
   �� 5      .+�5   
   �� -   5         ��Name$ buttonCreate��5      $��Dodaj��6'   $
��Left=�67   $��	10,10,0,0q�6R   $	��Top=�6e   $��75��6}   6�   �� 5   
   -   5        $ 
buttonEdit��5      $��Edytuj��6%   $
��Left=�66   $��	90,10,0,0q�6Q   $	��Top=�6d   $��75��6|   6�   �� 5   
   -   5        $ 
buttonShow��5      $��Pokaż��6%   $
��Left=�65   $��
170,10,0,0q�6P   $	��Top=�6d   $��75��6|   6�   �� 5   
   -   5        $ buttonDelete��5      $��Usuń��6'   $
��Left=�66   $��
250,10,0,0q�6Q   $	��Top=�6e   $��75��6}   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGridContractors��5         AutoGenerateColumns .     
IsReadOnly . $��10,35,10,10q�6^      CanUserAddRows .     SelectionMode$ Single=�6�   	 �� SelectedItem	 6�   �� *SelectedContractor+
 �� Mode$
 TwoWay=���6�   �� *Contractors+$
 OneWay=� �� NotifyOnSourceUpdated .  �� UpdateSourceTrigger$ PropertyChanged=� � 	Resources 5      )  #System.Windows.Controls.DataGridRow �� 
TargetType��%E   '        �� 5      "  6   .�5      -   5        5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Data Wprowadzenia��6%      MinWidth$	 120Q�6@      Width5  /System.Windows.Controls.DataGridLengthConverter$
 120* 6O   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6\   ��  �� Path$ 
LaunchDate� �� StringFormat$ {0:dd.MM.yyyy}��  5      $ Nazwa Firmy��6%   $	 120Q�6:    6I   �� $ CompanyName�  5      $	 NIP��6%   $	 120Q�62   $
 120* 6A    6N   �� $	 NIP�  5      $ Województwo��6%   $	 120Q�6:    6I   �� $ Voivodeship�  5      $ Umowa Do��6%   $	 120Q�67   $
 120* 6F    6S   �� $ DateOfContract�$ {0:dd.MM.yyyy}��  5      $ Data Spotkania��6%   $	 120Q�6=   $
 120* 6L    6Y   �� $ DateOfAppointment�$ {0:dd.MM.yyyy}��  5      $ Nr telefonu��6%   $	 120Q�6:   $
 120* 6I    6V   �� $ 	TelNumber�  5      $ Taryfa��6%   $	 120Q�65   $
 120* 6D    6Q   �� $ Tariff�  5       $ Adres��6%   $	 120Q�64   $
 120* 6C    6P   �� $ Adress�  5!      $ Kontakt��6%   $	 120Q�66   $
 120* 6E    6R   �� $ Contact�$ {0:dd.MM.yyyy}��  5"      $ Uwagi��6%   $	 120Q�64   $
 120* 6C    6P   �� $ 
OthersInfo�  5#      -   5        GridColumnWhoCreated��$ 
Kto dodał��5#   C   $	 120Q�6V   $
 120* 6e    6r   �� $ WhoCreatedName�5%      �� 5&   
   -	   5         ��Name$ comboBoxCriterias��5&      $��0,8,90,0q�6�   $��Right=�6�   $	��120��6�   $��22��6�   $	��Top=�6�   	 6.   �� *SelectedSearchCriteria+$
 TwoWay=���6l   �� *SearchCriterias+$
 OneWay=�6�   �� 5'   
   -
   5         ��Name$ textBoxSearch��5'      $��	0,8,215,0q�6)    �� TextWrapping$
 Wrap=�6<   $��Right=�6�   $	��120��6�   $��23��6�   $	��Top=�6�   ��6P   �� $
 TwoWay=�$ SearchCriteria�6�   �� 5(   
   -   5        $ buttonSearch��5(      $��Szukaj��6'   $��	0,10,10,0q�68   $��Right=�6f   $��75��6�   $��20��6�   $	��Top=�6�   �� 5)   
   -   5        $ buttonUsers��5)      $��Użytkownicy��6&   $
��Left=�6<   $��
372,10,0,0q�6W   $	��Top=�6k   $��75��6�   6�   5,      5-      