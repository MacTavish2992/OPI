   M S B A M L   `   `   `  ����B  >Sportik, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:SportikSportik  5   	       Sportik.AddClient   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Sportik     5   	     � Title$  	AddClient��5   	   $��319.2��6   $	��800��6*    � WindowStartupLocation$ CenterScreen=�66   .��5	      � .+�5
   
   �� -   5         ��Name$ PatronumicTextBox��5
      $
��Left=�6-   $��23��6H   $��	10,31,0,0q�6T    �� TextWrapping$
 Wrap=�6g   $	��Top=�6{   $	��120��6�   �� 5   
   -   5        $ NameTextBox��5      $
��Left=�6'   $��23��6B   $��	10,80,0,0q�6N   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5   
   -   5        $ SurnameTextBox��5      $
��Left=�6*   $��23��6E   $��
10,129,0,0q�6Q   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�   �� 5   
   -   5        $ 
AgeTextBox��5      $
��Left=�6&   $��23��6A   $��
10,178,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5   
   -   5         ��Name$ 
BackButton��5      $��
Назад��6%   $
��Left=�65   $��
11,255,0,0q�6P   $	��Top=�6d   $��53��6|   6�   �� 5   
   $
��Left=�6   $��	10,10,0,0q�6/   $
��Wrap=�6B   $��Фамилия:��6V   $	��Top=�6f   �� 5   
   $
��Left=�6   $��	10,59,0,0q�6/   $
��Wrap=�6B   $��Имя:��6V   $	��Top=�6b   �� 5   
   $
��Left=�6   $��
10,108,0,0q�6/   $
��Wrap=�6C   $��Отчество:��6W   $	��Top=�6h   �� 5   
   $
��Left=�6   $��
10,157,0,0q�6/   $
��Wrap=�6C   $��Возраст:��6W   $	��Top=�6g   �� 5   
   -   5        $ 	AddButton��5      $��Добавить��6$   $
��Left=�67   $��
69,255,0,0q�6R   $	��Top=�6f   $��63��6~   6�   �� 5   
   $
��Left=�6   $��
10,206,0,0q�6/   $
��Wrap=�6C   $"��Номер телефона:��6W   $	��Top=�6n   �� 5   
   -   5        $ PhoneNumberTextBox��5      $
��Left=�6.   $��23��6I   $��
10,227,0,0q�6U   $
 Wrap=�6i   $�� ��6}   $	��Top=�6�   $	��120��6�   �� 5   
   -   5         ��Name$ InstructorsList��5      $
��Left=�6,   $	��270��6G   $��
135,10,0,0q�6T   $	��Top=�6h   $	��649��6�    �� View 5      �� 5      .P�5      �� $��Фамилия��6%    �� DisplayMemberBinding 66   �� *	Surname+�� 5      $��Имя��6%    62   �� *Name+�� 5      $��Отчество��6%    67   �� *
Patronymic+�� 5      $��Возраст��6%    66   �� *Age+5      5       5"      5#      