   M S B A M L   `   `   `  ����D  @ClietTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ClietTest	ClietTest  5   	       ClietTest.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ClietTest     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5
      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   <    �� 
TargetType   
NoNeBorder �� 	Resources  Key j� 
AlignmentX j� 
AlignmentY j� Stretch !� Visual �� Triggers	 P� Property
 �� Empty P� Value �� Property  CueBannerBrush �� Value1&clr-namespace:System;assembly=mscorlibSystem 5)   C     NoNeBorderAddress1&clr-namespace:System;assembly=mscorlibSystem 5F   @     NoNeBorderPort�� 5   
   %�  &	        7  7  &	 ,    7  7  &	 M    7  7  �� 5      6sys&clr-namespace:System;assembly=mscorlib     6<   " ��6    5      ��!� 5      CueBannerBrush $ Center=�69   $ Center=�6M   $
 None=�6a    5      �� 5      $��
INPUT TEXT��6$   
�������69   5      5       5      P� 5      	 � ��# Z
 6.   . �5      ��  � ��8   67   5      P� 5      	 � �� 6.   Z� . �5      ��  � ��8  67   5      P� 5      	 �@J�IsKeyboardFocused$
 True��6;   . �5      ��  � ��
 �����67   5      5(      �� 5)      .sys&clr-namespace:System;assembly=mscorlib  6C   " ��6    5*      ��!� 5+      CueBannerBrush $ Center=�69   $ Center=�6M   $
 None=�6a    5,      �� 5-      $��ADDRESS��6$   
�������66   5/      50       51      P� 52      	 � ��# Z
 6.   . �53      ��  � ��8   67   54      P� 55      	 � �� 6.   Z� . �56      ��  � ��8  67   57      P� 58      	 �@J�IsKeyboardFocused$
 True��6;   . �59      ��  � ��
 �����67   5:      5E      �� 5F      .sys&clr-namespace:System;assembly=mscorlib  6@   " ��6    5G      ��!� 5H      CueBannerBrush $ Center=�69   $ Center=�6M   $
 None=�6a    5I      �� 5J      $
��7771��6$   
�������63   5L      5M       5N      P� 5O      	 � ��# Z
 6.   . �5P      ��  � ��8   67   5Q      P� 5R      	 � �� 6.   Z� . �5S      ��  � ��8  67   5T      P� 5U      	 �@J�IsKeyboardFocused$
 True��6;   . �5V      ��  � ��
 �����67   5W      5b      5c      .��5f      �  � RowDefinitions 5g   
   �� 5h      $
��auto �6   �� 5i      $
��auto �6   �� 5j      $��* �6   �� 5k      $
��auto �6   �� 5l      $
��auto �6   .+�5n   
   � $��0��6    � ColumnDefinitions 5o      �� 5p      $
��auto �6#   �� 5q      $��* �6#   �� 5r      $
��auto �6#   �� 5s      $
��auto �6#   �� 5t      $
��auto �6#   .+�5v      �� -   5        $
��SEND��5v      $��3q�69   $��76��6D   �� 5w      -   5         ��Name$ TbInput��5w   '   $��1��6   #��[  68   $	��5 0q�6�   $��Center=�6�   $��Center=�6�   ��6\   �� *Msg+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5x      $��2��6   #��[ 6(   $	��5 0q�6�   $��Center=�6�   $��Center=�6�   $	��150��6�   ��6S   �� *	Address+$ TwoWay=�$ PropertyChanged=�6�   �� 5y      $��3��6   #��[ 6(   $	��5 0q�6�   $��Center=�6�   $��Center=�6�   $��80��6�   ��6P   �� *Port+$ TwoWay=�$ PropertyChanged=�6�   5z      � 5{   
   $��2��6   .+�5|      �� .��5}      �� -   5         ��Name$
 data��5}      $
��Wrap=�6@    �� Padding$ 5q�6T   ���#fffde7��6*   �� *Data+6`   5~      5      5�      5�      