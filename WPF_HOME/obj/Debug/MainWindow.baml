   M S B A M L   `   `   `  ����C  ?WPF_HOME, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WPF_HOMEWPF_HOME  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089I2clr-namespace:System.Collections;assembly=mscorlibSystem.Collections 5   	   1&clr-namespace:System;assembly=mscorlibSystem 5   	       WPF_HOME.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   (otherclr-namespace:WPF_HOME     5   	   Jcollections2clr-namespace:System.Collections;assembly=mscorlib     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   X TXceed.Wpf.Toolkit, Version=3.1.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  Home expenses��5	   	   $	��500��6   $��831.746��6,    � WindowStartupLocation$ CenterScreen=�6<   .��5
      � $��0,0,2,0q�6   .+�5   
   o� $
��Left=�6   $��23��6*   $	��Top=�66   $	��826��6N   .@�5      m� -   5        $
��File��5      .@�5      m� $
��Save��6   $
��Left=�6)   $	��145��6D   m� 5      $
��Exit��6   $
��Left=�6)   $	��145��6D   5      m� 5      -   5        $
��Help��5      .@�5      m� $��About��6   $
��Left=�6*   $	��145��6E   5      5      �� 5   
   $
��Left=�6   $	��447��60   $��0,23,0,0q�6=   $	��Top=�6O   $	��826��6g   .@�5      �� $��Add product��6   $
��Left=�6+   $��85��6F   .��5      � ���	#FFE5E5E5$��-17,-5,-3,-8q�6.    � RowDefinitions 5      �� 5      $	��61* �6(    � ColumnDefinitions 5      �� 5      $��126.667 �6+   �� 5      $��710.333 �6+   .+�5      �� -   5         ��Name$ textBox_Name_product��5      $
��Left=�6=   $��23��6X   $��	17,48,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��128��6�    J� RenderTransformOrigin$ 0.708,1.162&�6�   $��2��6  ��6d   ��  �� ElementName$ comboBox_type_things�� �� Path$
 Text�6  �� 5       -   5        $ textBox_Price_product��5       $
��Left=�6=   $��23��6X   $��	48,48,0,0q�6d   $
 Wrap=�6w   $��7��6�   $	��Top=�6�   $��78��6�   $ 0.708,1.162&�6�   $��1��6�   (  "System.Windows.Controls.DatePicker  5!      -   5        	  Name$	 dateTime_of_order��5!   !   $
��Left=�6<   $��	48,96,0,0q�6W   $	��Top=�6j   $��22��6�   $	��123��6�   $ 0.162,0.477&�6�   
   SelectedDateFormat$
 Short=�6�      FirstDayOfWeek$ Monday=�6�    � Cursor$ SizeAll��6�      IsTodayHighlighted .  
 �� Now   SelectedDate# Z 6  $��1��6H  �� 5"      -   5         ��Name$ comboBox_type_things��5"      $
��Left=�6=   $��	17,96,0,0q�6X   $	��Top=�6k   $	��128��6�    � ToolTip$  ��6�    �� IsDropDownOpen .  $��22��6�    �� SelectedValue$ Продукти��6�   $��2��6�   .@�5#      �� $��Продукти��6'   $
��Left=�6:   $	��118��6U   �� 5$      $��Авто��6'   $
��Left=�66   $	��118��6Q   �� 5%      $��Дитина��6'   $
��Left=�68   $	��118��6S   �� 5&      $��Одяг/Речі��6'   $
��Left=�6;   $	��118��6V   �� 5'      $��Дорога��6'   $
��Left=�68   $	��118��6S   �� 5(      $��Donation��6'   $
��Left=�6:   $	��118��6U   �� 5)      $��Заощадження��6'   $
��Left=�6=   $	��118��6X   �� 5*      $��Медицина��6'   $
��Left=�6:   $	��118��6U   �� 5+      $��Дозвілля��6'   $
��Left=�6:   $	��118��6U   �� 5,      $)��#Комунальні платежі��6'   $
��Left=�6D   $	��118��6_   �� 5-      $��Гігієна��6'   $
��Left=�69   $	��118��6T   �� 5.      $��
Побут��6'   $
��Left=�67   $	��118��6R   5/      �� 50      -   5        $ textBox_TotalPrice��50      $
��Left=�6:   $��23��6U   $��312.333,94,0,0q�6a   $
 Wrap=�6y   $��0��6�   $	��Top=�6�   $��77��6�   $��1��6�   �� 52      -   5         ��Name$ listView_Item��52      $��Center=�68   $	��273��6U   $��16,145,11,0q�6b   $	��Top=�6w   $	��810��6�    J� IsHitTestVisible . $��2��6�   ��6�   �� *
MainWindow+ �� View 53      �� 54      P�55   "   �� 56   &   $��Id��65    �� Width$ 0��6A    �� DisplayMemberBinding 6K   �� $ Id�6v   �� 57   &   $
��Name��65   $	 180��6C    6P   �� $
 Name�6}   �� 58   &   $��	Price UAH��65   $ 85��6H    6S   �� $ Price�6�   �� 59   &   $��Count��65   $ 85��6D    6O   �� $ Count�6}   �� 5:   &   $��Total Price��65   $ 85��6J    6U   �� $ 
TotalPrice�6�   �� 5;   &   $
��Type��65   $	 180��6C    6O   �� $
 Type�6|   �� 5<   &   $
��Date��65   $	 190��6C    6O   �� $
 Date� �� StringFormat$ 
dd/MM/yyyy��6�   5>      5@      �� 5A      $
��Name��6   $
��Left=�6+   $��	16,17,0,0q�6F   $	��Top=�6Y   $ 0.447,-0.731&�6q   $��26��6�   $��42��6�   �� 5B      $��Price��6   $
��Left=�6,   $��	90,22,0,0q�6G   $	��Top=�6Z   $ 0.447,-0.731&�6r   $��26��6�   $��36��6�   $��1��6�   �� 5C      $��Total Price��6   $
��Left=�62   $��312.333,68,0,0q�6M   $	��Top=�6e   $ 0.447,-0.731&�6}   $��26��6�   $��65��6�   $��1��6�   �� 5D      -	   5         ��Name$ button_add_product��5D      $	��Add��69   $
��Left=�6G   $��508.333,56,0,0q�6b   $	��Top=�6z   $��88��6�   $��38��6�   $��1��6�   �� 5E      -
   5        $ button_Remove��5E      $��Remove��64   $
��Left=�6E   $��508.333,0,0,295q�6`   $��Bottom=�6y   $��88��6�   $��38��6�   $��1��6�   �� 5F      -   5        $ button_Save��5F      $
��Save��62   $
��Left=�6A   $��611.333,99,0,0q�6\   $	��Top=�6t   $��88��6�   $��38��6�   $��1��6�   �� 5G      -   5        $ button_Reset��5G      $��Reset��63   $
��Left=�6C   $��611.333,56,0,0q�6^   $	��Top=�6v   $��88��6�   $��38��6�   $ 1.523,1.132&�6�   $��1��6�   �� 5H      $	��UAH��6   $
��Left=�6*   $��394.333,92,0,0q�6E   $	��Top=�6]   $ 0.447,-0.731&�6u   $��26��6�   $��35��6�   $��1��6�   �� 5I      $��Count��6   $
��Left=�6,   $��204.333,68,0,0q�6G   $	��Top=�6_   $ 0.447,-0.731&�6w   $��26��6�   $��65��6�   $��1��6�   �� 5J      -   5        $ textBox_Count��5J      $
��Left=�65   $��23��6P   $��210.333,95,0,0q�6\   $
 Wrap=�6t   $��1��6�   $	��Top=�6�   $��33��6�   $ 0.708,1.162&�6�   $��1��6�   �� 5K      -   5        $ button_Exit��5K      $
��Exit��62   $
��Left=�6A   $��648.333,10,0,0q�6\   $	��Top=�6t   $��51��6�   $��1��6�   5L      5M      �� 5N      $��Select��6   .��5O      � -   5         �Name$3 -button_clear_tablebutton_clear_table_No_Name_��5O      ���	#FFE5E5E5$��
-3,-4,3,-4q�6e    5P      �� 5Q      $
��109* �6+   �� 5R      $
��711* �6+   .+�5T      �� -   5        $ listView_select��5T      $��Center=�68   $	��285��6U   $��
12,100,7,0q�6b   $	��Top=�6v   $	��801��6�    . $��2��6�    5U      �� 5V      .P�5W   "   �� $��Id��61   $ 45��6=    6H   �� $ Id�6s   �� 5X   "   $
��Name��61   $	 140��6?    6L   �� $
 Name�6y   �� 5Y   "   $��	Price UAH��61   $ 85��6D    6O   �� $ Price�6}   �� 5Z   "   $��Count��61   $ 85��6@    6K   �� $ Count�6y   �� 5[   "   $��Total Price��61   $ 85��6F    6Q   �� $ 
TotalPrice�6�   �� 5\   "   $
��Type��61   $	 175��6?    6K   �� $
 Type�6x   �� 5]   "   $
��Date��61   $	 165��6?    6K   �� $
 Date�$ 
dd/MM/yyyy��6�   5^      5`        5a      -   5        $	 dateTimePicker_Select��5a   !   $
��Left=�6@   $��	15,22,0,0q�6[   $	��Top=�6n   $��22��6�   $	��117��6�   $��2��6�   �� 5b      -   5        $ comboBox_Select_Type��5b      $ Усі витрати��6=   $
��Left=�6Y   $��	63,22,0,0q�6t   $	��Top=�6�   $	��120��6�   $  ��6�    .  $��22��6�   $��1��6�   .@�5d      �� $��Усі витрати��6'   $
��Left=�6=   $	��118��6X   �� 5e      $��Продукти��6'   $
��Left=�6:   $	��118��6U   �� 5f      $��Авто��6'   $
��Left=�66   $	��118��6Q   �� 5g      $��Дитина��6'   $
��Left=�68   $	��118��6S   �� 5h      $��Одяг/Речі��6'   $
��Left=�6;   $	��118��6V   �� 5i      $��Дорога��6'   $
��Left=�68   $	��118��6S   �� 5j      $��Donation��6'   $
��Left=�6:   $	��118��6U   �� 5k      $��Заощадження��6'   $
��Left=�6=   $	��118��6X   �� 5l      $��Медицина��6'   $
��Left=�6:   $	��118��6U   �� 5m      $��Дозвілля��6'   $
��Left=�6:   $	��118��6U   �� 5n      $)��#Комунальні платежі��6'   $
��Left=�6D   $	��118��6_   �� 5o      $��Гігієна��6'   $
��Left=�69   $	��118��6T   �� 5p      $��
Побут��6'   $
��Left=�67   $	��118��6R   5q      �� 5r      -   5        $ Total_Price_Select��5r      $��Center=�6:   $��Center=�6W   $��569,390,53,13q�6y   $
 Wrap=�6�   $��0��6�   $��89��6�   $��16(�6�   $
��Bold"�6�    �� TextAlignment$ Center=�6�   $��1��6�   
������� �� 
IsReadOnly .  �� MaxLines$ 1��6$  &   System.Windows.Media.TextOptions   TextHintingMode$ Fixed=�61  $��
Sitka Text)�6U  �� 5s      $��Total Price��6   $
��Left=�62   $��484,390,0,0q�6M   $	��Top=�6b   $ 0.447,-0.731&�6z   $��24��6�   $��75��6�   $��1��6�   $
��Bold"�6�   $��11(�6�   $��
Sitka Text)�6�   �� 5t      $	��UAH��6   $
��Left=�6*   $��669,390,0,0q�6E   $	��Top=�6Z   $ 0.447,-0.731&�6r   $��24��6�   $��35��6�   $��1��6�   $��
Sitka Text)�6�   �� 5u      -   5          ��Name$  checkBox_day��5u      $	��Day��65   $
��Left=�6C   $��	15,69,0,0q�6^   $	��Top=�6q   ! d� 	IsChecked$
! TrueY�6�   $��16��6�   $��46��6�   $Y SSet this checkbox, if you wish to select items specific date that you specify above��5v      �� 5w      -   5        $  checkBox_Mounth��5w      $��Mounth��68   $
��Left=�6I   $��	85,69,0,0q�6d   $	��Top=�6w   $ -1.279,0.375&�6�   $
! TrueY�6�   $��16��6�   $��71��6�   $B <Set this checkbox, if you wish to select items for the month��5x      $��2��6f   �� 5y      -   5        $ button_Select��5y      $��Select��64   $
��Left=�6E   $��
413,17,0,0q�6`   $	��Top=�6t   $��84��6�   $��24��6�   $��1��6�   �� 5z      -   5        $ button_Reset_Select��5z      $��Reset��6:   $
��Left=�6J   $��
413,51,0,0q�6e   $	��Top=�6y   $��84��6�   $��24��6�   $��1��6�   �� 5{      -   5        $ button_clear_table��5{      $��Clear table��69   $
��Left=�6O   $��
515,17,0,0q�6j   $	��Top=�6~   $��84��6�   $��24��6�   ���	#FFF09A9A$��1��6�   �� 5|      -   5        $ button_Select_Exit��5|      $
��Exit��69   $
��Left=�6H   $��
618,17,0,0q�6c   $	��Top=�6w   $��83��6�   $��24��6�   $��1��6�   �� 5}      -   5        $ button_remove_from_db��5}      $��Remove��6<   $
��Left=�6M   $��
515,51,0,0q�6h   $	��Top=�6|   $��83��6�   $��24��6�   $��1��6�   5~      5      5�      5�      5�      