   M S B A M L   `   `   `  ����>  :Lee, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Lee.ControlsLee.Controls  5   	   clr-namespace:LeeLee  5   	       Lee.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +cmsgclr-namespace:Lee.Controls     5   	   #localclr-namespace:Lee     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � 	Resources 5
      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   <    �� 
TargetType   
NoNeBorder �� 	Resources  Key j� 
AlignmentX j� 
AlignmentY j� Stretch !� Visual �� Triggers	 P� Property
 �� Empty P� Value �� Property  CueBannerBrush �� Value1&clr-namespace:System;assembly=mscorlibSystem 5)   @     NoNeBorderPort�� 5   
   %o  &	        7  7  &	 -    7  7  �� 5      6sys&clr-namespace:System;assembly=mscorlib     6<   " ��6    5      ��!� 5      CueBannerBrush $ Center=�69   $ Center=�6M   $
 None=�6a    5      �� 5      $��192.168.0.1��6$   
�������6:   5      5       5      P� 5      	 � ��# Z
 6.   . �5      ��  � ��8   67   5      P� 5      	 � �� 6.   Z� . �5      ��  � ��8  67   5      P� 5      	 �@J�IsKeyboardFocused$
 True��6;   . �5      ��  � ��
 �����67   5      5(      �� 5)      .sys&clr-namespace:System;assembly=mscorlib  6@   " ��6    5*      ��!� 5+      CueBannerBrush $ Center=�69   $ Center=�6M   $
 None=�6a    5,      �� 5-      $
��7771��6$   
�������63   5/      50       51      P� 52      	 � ��# Z
 6.   . �53      ��  � ��8   67   54      P� 55      	 � �� 6.   Z� . �56      ��  � ��8  67   57      P� 58      	 �@J�IsKeyboardFocused$
 True��6;   . �59      ��  � ��
 �����67   5:      5E      5F      .��5H      � .+�5I      �  � RowDefinitions 5J   
   �� 5K      $
��auto �6   �� 5L      $��* �6   �� 5M      $
��auto �6    �� 5N      $
��auto �6    .+�5P   
   � $��0��6    � ColumnDefinitions 5Q      �� 5R      $
��auto �6#   �� 5S      $
��auto �6#   �� 5T      $
��auto �6#   �� 5U      $
��auto �6#   �� 5V      $
��auto �6#   �� 5W      $��* �6#   �� 5X      $
��auto �6#   .+�5Z      �� -   5        $��0��5Z      $
��SEND��6%   $��76��6J   $	��5 0q�6X   �� 5[      -   5         ��Name$ TbInput��5[   '   $��1��6   #��[  68   $�� ��6\   $	��5 0q�6e   $	��120��6r   $��Center=�6~   �� 5\      -   5        $ TbInputPort��5\   '   $��2��6   #��[ 6<   $�� ��6d   $	��5 0q�6m   $��75��6z   $��Center=�6�   �� 5]      $��3��6   $	��250��6'    �� DisplayMemberPath$ Client��5^       �� SelectedValuePath$ Client��62    �� SelectedItem 5]   3   �� *Client+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=���6�   �� *ListClients+5^   2   5_      � 5`   
   $��1��6   .+�5a      �� .��5b      �� -   5         ��Name$
 data��5b       $
��Wrap=�6D    �� Padding$ 5q�6X   ���#fffde7��6.   �� *Data+6d   5c      5d      � 5e   
   $��3��6    5f      �� 5g      $
��Auto �6#   �� 5h      $
��Auto �6#   �� 5i      $��* �6#   �� 5j      $
��Auto �6#   .+�5m      �� -   5        $ msgText��5m   ,   $��3��6   ��6=   �� *Msg+5o      5p         Lee.Controls.MsgClient  5q   
   -   5          Name$
 CMsg��5q      $	��250��6'   $	��400��64   $y�	Collapsed=�6@   5r      5s      