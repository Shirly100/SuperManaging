   M S B A M L   `   `   `  ����@  <PLWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLWPFPLWPF  5   	       PLWPF.addChildMother   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:PLWPF     5   	     � Title$  addChildMother��5   	   $��257.566��6    $	��300��61   .��5	      �  � RowDefinitions 5
   
   �� 5      $��10 �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��145* �6   �� 5      $
��148* �6   .+�5   
   �� $��Id Child��6   $��1��6#   $��Center=�60   $��Stretch=�6K   $
��Bold"�6i    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 20Q�6#   5      �� 5   
   -   5         ��Name$ id��5      $��1��6   $��Stretch=�6+    �� TextWrapping$
 Wrap=�6I   $��Center=�6|   $��1��6�   $
��Bold"�6�   ��6]   ��  �� Path$ ID_child�.��6�    5        5      $ 20Q�6#      Opacity$	 0.3Q�63   .��5      5       �� 5!   
   $��
First name��6   $��2��6%   $
��Left=�62   $��Center=�6N   $	��108��6i   $��26��6u   $
��Bold"�6�    5"        5#      $ 20Q�6#   5%      �� 5&   
   -   5        $
 name��5&      $��2��6    $��Stretch=�6-   $
 Wrap=�6K   $��Center=�6   $��1��6�   $
��Bold"�6�   ��6_   �� $ 	FirstName�.��6�    5'        5(      $ 20Q�6#   $	 0.3Q�63   .��5)      5*      �� 5+   
   $��
Birth date��6   $��3��6%   $
��Left=�62   $��Center=�6M   $
��Bold"�6h    5,        5-      $ 20Q�6#   5/      (  "System.Windows.Controls.DatePicker  50   
   -   5        	  Name$	 started_DateDatePicker��50      $��3��65   $��Stretch=�6�   $��Center=�6�   $��1��6�   $
��Bold"�6�    51        52      $ 20Q�6#   $	 0.3Q�63   54      �� 55   
   $��Any special needs?��6   $��4��6-   $
��Left=�6:   $��Center=�6U   $
��Bold"�6p    56        57      $ 20Q�6#   59      �� 5:   
   $��Any allergies?��6   $��5��6)   $
��Left=�66   $��Center=�6R   $
��Bold"�6m    5;        5<      $ 20Q�6#   5>      �� 5?   
   $��4��6   $
��Left=�6    $��Center=�6;   $��1��6V   $
��Bold"�6f    5@        5A      $ 20Q�6#   $	 0.3Q�63   5C      �� 5D   
   $��5��6   $
��Left=�6!   $��Center=�6<   $��1��6X   $
��Bold"�6h    5E        5F      $ 20Q�6#   $	 0.3Q�63   5H      �� 5I   
   -   5        $��	Add Child��5I      $��6��6%   $��center=�62   $��Center=�6P   $��2��6�   $
��Bold"�6�    5J        5K      $ 20Q�6#   5M      ��5N   
   �� 5O      
 �� ImageSource$1
 +C:\Users\Shirly\background_material_red.jpg��6    j� Stretch$ UniformToFill=�6S    �� Opacity$	 0.2Q�6k   5Q      5R      