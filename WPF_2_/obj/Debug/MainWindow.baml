   M S B A M L   `   `   `  ����A  =WPF_2_, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPF_2_WPF_2_  5   	       WPF_2_.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WPF_2_     5   	   -   5          �Name$  _Window��5   	    � Icon$ Image\ROZA_1.png��6    � Title$ 
MainWindow��5   	   $	��550��5	   	   $	��900��5
   	   $	��900��5   	   $	��550��5   	    � WindowState$ 	Maximized=�5   	      VS2012WindowStyle#��[  5   	   .��5      � -   5         � ShowGridLines .  ��5   
   �� 5       �� ImageSource$ Image\SJ.jpg��6    � ColumnDefinitions 5   
   �� 5      $	��12* �6   6-   �� 5      $	��77* �6   �� 5      $
��279* �6   6.   �� 5      $	��78* �6   �� 5      $
��446* �6   6.   .+�5   
   � $��0��6    . $��2��64    � RowDefinitions 5      �� 5       6"   �� 5!      6"   �� 5"      6"   .+�5$      �� $��0��6     GlassLabelStyle#���  6!   �� 5%      $��1��6   #���  6!   �� 5&      $��2��6   #���  6!   5'      � 5(   
   $��4��6    .   5)      �� 5*      $��0.08* �6    62   �� 5+      $
��0.2* �6    60   �� 5,      6"   �� 5-      $
��0.1* �6    60   .+�5/      � $��0��6    .   50      �� 51      6)   �� 52      6)   �� 53      6)   �� 54      6)   .+�56      �� -   5         ��Name$ L_Save��56      $��0��6(   .��57      �� $��Image\Save.png��6   	 J� Opacity$	 5Q�64   $
��Fill=�6@   6Q   58      �� 59      -   5        $ L_Color��59      $��1��6)   $��Center=�69   $��Center=�6T   .��5:      �� $��Image\Color.png��6   $	 5Q�65   $
��Fill=�6A   6R   5;      �� 5<      -   5        $ L_Bold��5<      $��2��6(   $��Center=�68   $��Center=�6S   .��5=      �� $��Image\Bold.png��6   $	 5Q�64   $
��Fill=�6@   6Q   5>      �� 5?      -   5        $ 
L_TextSize��5?      $��3��6,   $��Center=�6<   $��Center=�6W   .��5@      �� $��Image\Text Size.png��6   $	 5Q�69   $
��Fill=�6E   6V   5A      5B      � 5C      -   5        
 �Name$
 _RGrid��5C      $��1��6#    .   � 	Resources 5D        
IMG_CIRCLE �� 
TargetType �� Property �� Value��%�   &	       '�� /     �� 5E      $ Image\mrPcoZytokQ.jpg��64   �� 5F      " ��6   .�5G      ��  � ��$ Comic Sans MS)�67   6O   �� 5H       � ��$ Center=�6@   6Q   �� 5I       � ��$ Center=�6>   6O   5J      5K       5L      �� 5M      $	��34* �6$   �� 5N      $	��27* �6$    5P      �� 5Q      $	��33* �6'   65   �� 5R      $
��135* �6'   66   �� 5S      $	��30* �6'   .+�5U      A� -   5         A�Name$ E_CircleFrame��5U      #���  61   $��0��6U   $��2��6b    J� RenderTransformOrigin$ 0.5,0.5&�6�   ��5V      �� 5W      -	   5        StrokeColor�� �� Color$ Black��5W   ?    � Triggers 5Y      :� 5Z       :� RoutedEvent$ 
MouseEnter��6'   .[�5[      �� -
   5         ��Name$ 	EllipseSB��5[   /   .��5\   "   �� .��5]   &   W�  �� TargetProperty$ StrokeThickness�66   	 W� To$ 70X�6b   �� 5^   &    �� 
TargetName$ StrokeColor��65   $ Color�6Y   	 �� To$ 
WhiteSmokeX�6{   W� 5_   &   $ Opacity�66   $ 0X�6Z   5`   #   5a      5b      :� 5c      $ 
MouseLeave��6'   .[�5d      ��  �� BeginStoryboardName$ 	EllipseSB��6-   5e      5g      �� 5h      -   5        $ L_TimeTitle��5h      $��2��6-   $��0��6=   $��23:23��6J   $��18(�6Z   $��0,4,3,4q�6h   $��Right=�6y   $��59��6�   �� 5i      -   5        $ L_DateTitle��5i      $��2��6-   $��1��6=   $��
12.12.2018��6J   $��12(�6_   $��Impact)�6m   $��6,4,2,4q�6�   $��Right=�6�   �� 5j      -   5         ��Name$ T_Title��5j      $��1��6+   $��2��6;   $	��123��6L   $��65(�6W   $��Comic Sans MS)�6e   $��2��6�   $��0,0,66,0q�6�   6�   5k      � 5l      $��2��6   .+�5m      �� -   5        $ TextBoxBigTEXT_BLOB��5m      $��Comic Sans MS)�67   $��15(�6R    �� TextWrapping$
 Wrap=�6`   $
��Auto=�6t   6�   5n      � 5o      $��3��6    .   5p      �� 5q      $
��0.2* �6'   66   �� 5r      $
��0.1* �6'   66   �� 5s      $
��0.3* �6'   66   .+�5u      � $��0��6   .+�5v      (� $	��127��6   $��24��6+   .��5w      �� -   5        $ L_TimeFuture��5w       $��23:59 Monday��66   $��40(�6M   $��Yu Gothic UI Semibold)�6[   
�������$
��Bold"�6�   6�   5x      5y      � 5z      $��1��6    5{      ��%�   '��       �� 5|      " ��6    .�5}      ��  � ��$ Comic Sans MS)�6;   �� 5~       � ��$ 11(�69   �� 5       � ��$ Black"�6;   5�      5�       5�      �� 5�      6*   �� 5�      6*   .+�5�      �� -   5         ��Name$ B_Plus��5�      $��0��6-   $��+��6:     GlassButton#��[ 6F   6�   �� 5�      -   5        $ B_Minus��5�      $��1��6.   $��-��6;   #��[ 6G   6n   5�      � 5�      $��2��6    5�      �� 5�      $
��0.7* �6+   6:   �� 5�      6-   .+�5�      �� -   5        $ L_MonthFuture��5�      $��0��63   $	��May��6C   $��20(�6Q   
�������$��Comisc Sans MS)�6r   $��Center=�6�   $��Center=�6�   6�   (  "System.Windows.Controls.DatePicker  5�      -   5          Name$ DP_DateFuture��5�   !   $��7,3,0,3q�68   $��1��6I   $��Comic Sans MS)�6Y   $
��Bold"�6t   $��13(�6�   5�      5�      5�      �� 5�   
   -   5         ��Name$ 	ListBoxC1��5�      $��2��6%   $
��Auto=�6Y   $��Disabled=�6�    � Cursor$ Arrow��6�   $��2��6�   5�      5�      