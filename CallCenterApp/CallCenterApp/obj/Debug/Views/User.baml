   M S B A M L   `   `   `  ����H  DCallCenterApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CallCenterApp.ViewsCallCenterApp.Views  5   	       CallCenterApp.Views.User   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:CallCenterApp.Views     5   	     � Title$
  User��5   	   $	��160��6   $	��200��6#   $	��160��6/   $	��200��6?    � 
ResizeMode$ CanMinimize=�6N   .��5	      � .+�5
   
   �� -   5         ��Name$ 	labelName��5
      $��Nazwa��6#   $
��Left=�63   $��	10,10,0,0q�6N   $	��Top=�6a   �� 5   
   -   5         ��Name$ textBoxName��5      $
��Left=�6'   $��23��6B   $��	60,13,0,0q�6N    �� TextWrapping$
 Wrap=�6a   $	��Top=�6�   $	��120��6�   ��6u   ��  �� Mode$ TwoWay=� �� Path$ 	User.Name�6�   �� 5   
   -   5        $ labelPassword��5      $��Hasło��6'   $
��Left=�67   $��	10,36,0,0q�6R   $	��Top=�6e   G� 5   
   -   5         G�Name$ passwordBoxPassword��5      $
��Left=�63   $��	60,41,0,0q�6N   $	��Top=�6a   $	��120��6y   $��23��6�   �� 5   
   -   5         ��Name$ checkBoxIsAdmin��5      $�� ��6,   $
��Left=�67   $��	60,69,0,0q�6R   $	��Top=�6e   	 d� 	IsChecked	 6}   �� $ User.IsAdmin��� 5   
   -   5        $ labelIsAdmin��5      $��Admin��6&   $
��Left=�66   $��	10,61,0,0q�6Q   $	��Top=�6d   �� 5   
   -   5        
 ��Name$
 
buttonSave��5      $��Zapisz��6%   $
��Left=�66   $��	10,0,0,10q�6Q   $��75��6d   $��20��6o   $��Bottom=�6{   6�   �� 5   
   -   5        $
 buttonCancel��5      $��Anuluj��6'   $��	0,0,10,10q�68   $��Bottom=�6K   $��Right=�6f   $��75��6�   6�   5      5      