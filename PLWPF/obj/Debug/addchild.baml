   M S B A M L   `   `   `  ����@  <PLWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLWPFPLWPF  5   	       PLWPF.addchild   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:PLWPF     5   	     � Title$  addchild��5   	   $��312.667��6   $��399.333��6+   .��5	      �  � RowDefinitions 5
   
   �� 5      $��3.333 �6   �� 5      $��29.333 �6   �� 5      $
��Auto �6   $��26��6*   �� 5      $
��Auto �6   $��26��6*   �� 5      $
��Auto �6   $��26��6*   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5       � ColumnDefinitions 5   
   �� 5      $
��145* �6   �� 5      $
��148* �6   .+�5   
   �� -   5         ��Name$ child_combo��5      $��1��6(   $��Stretch=�68   $��Stretch=�6V   $
��Bold"�6�   $��0,5.667,0.667,4.667q�6�   $��1��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 20Q�6#      Opacity$	 0.3Q�63   5      �� 5   
   $��Choose Mother��6   $��1��6(   $
��Left=�65   $��Center=�6Q   $
��Bold"�6l   $��26��6~   $��0,0.667,0,2.667q�6�   $��97��6�    5        5       $ 20Q�6#   5"      �� 5#   
   $��Id Child��6   $��1��6#   $��Center=�60   $��Stretch=�6K   $
��Bold"�6i   $��2��6{   $��0,21.667,180.667,7.667q�6�   $��26��6�   $��2��6�    5$        5%      $ 20Q�6#   5'      �� 5(   
   -   5         ��Name$ id��5(      $��2��6   $��Stretch=�6+    �� TextWrapping$
 Wrap=�6I   $��Center=�6|   $��1��6�   $
��Bold"�6�   $��0,3.333,-0.333,4.667q�6�   $��18��6�   ��6]   �� 	 �� Path$	 ID_child�.��6�    5)        5*      $ 20Q�6#   $	 0.3Q�63   .��5+      5,      �� 5-   
   $��
First name��6   $��2��6%   $
��Left=�62   $��Center=�6N   $	��108��6i   $��26��6u   $
��Bold"�6�   $��0,25.333,0,0.667q�6�   $��2��6�    5.        5/      $ 20Q�6#   51      �� 52   
   -   5        $
 name��52      $��3��6    $��Stretch=�6-   $
 Wrap=�6K   $��Center=�6   $��1��6�   $
��Bold"�6�   $��0,3.333,-0.333,4.667q�6�   $��18��6�   ��6_   �� $	 	FirstName�.��6�    53        54      $ 20Q�6#   $	 0.3Q�63   .��55      56      �� 57   
   $��
Birth date��6   $��3��6%   $
��Left=�62   $��Center=�6M   $
��Bold"�6h   $��26��6z   $��0,25.333,0,0.667q�6�   $��2��6�   $��67��6�    58        59      $ 20Q�6#   5;      (  "System.Windows.Controls.DatePicker  5<   
   -   5        
  Name$
 started_DateDatePicker��5<      $��4��65   $��Stretch=�6�   $��Center=�6�   $��1��6�   $
��Bold"�6�   $��0,0.333,0.667,1.667q�6�   $��24��6�    5=        5>      $ 20Q�6#   $	 0.3Q�63   5@      �� 5A   
   $��Any special needs?��6   $��4��6-   $
��Left=�6:   $��Center=�6U   $
��Bold"�6p   $��26��6�   $��0,25.333,0,0.667q�6�   $��2��6�   $	��115��6�    5B        5C      $ 20Q�6#   5E      �� 5F   
   $��Any allergies?��6   $��5��6)   $
��Left=�66   $��Center=�6R   $
��Bold"�6m   $��26��6   $��0,25.333,0,0.667q�6�   $��2��6�   $��88��6�    5G        5H      $ 20Q�6#   5J      �� 5K   
   $��5��6   $
��Left=�6    $��Center=�6;   $��1��6V   $
��Bold"�6f   $��0,4.333,0,5.667q�6x   $��16��6�   $��16��6�    5L        5M      $ 20Q�6#   $	 0.3Q�63   5O      �� 5P   
   $��6��6   $
��Left=�6!   $��Center=�6<   $��1��6X   $
��Bold"�6h   $��0,4.333,0,5.667q�6z   $��16��6�   $��16��6�    5Q        5R      $ 20Q�6#   $	 0.3Q�63   5T      �� 5U   
   -   5        $��	Add Child��5U      $��7��6%   $��center=�62   $��Center=�6P   $��2��6�   $
��Bold"�6�   $��167,50.333,160.667,50.333q�6�   $��20��6�   $��65��6�    5V        5W      $ 20Q�6#   5Y      ��5Z   
   �� 5[       �� ImageSource$T NC:\Users\Chany\Desktop\school\Nanny\SuperManaging\PLWPF\Resources\90168532.jpg��6    j� Stretch$ UniformToFill=�6v    �� Opacity$	 0.2Q�6�   5]      5^      