   M S B A M L   `   `   `  ����@  <PLWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLWPFPLWPF  5   	       PLWPF.addcontract   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:PLWPF     5   	     � Title$  addcontract��5   	   $��250.332��6   $	��279��6.   .��5
      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ End_Working��5      $��Center=�6%   $��3��6@   $
��Left=�6N   $��0��6i   $��End Working:��6y   $
��Bold"�6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 20Q�6#   5      (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ end_WorkingDatePicker��5      $��Center=�6t   $��3��6�   $��Stretch=�6�   $��1��6�   $
��Bold"�6�    5        5         Opacity$	 0.3Q�6#   5!      �� 5"   
   $��Center=�6   $��1��6,   $
��Left=�6:   $��0��6U   $��Nanny:��6e   $
��Bold"�6v    5#        5$      $ 20Q�6#   5&      �� 5'   
   $��Center=�6   $��0��6,   $
��Left=�69   $��0��6T   $��Child name:��6d   $
��Bold"�6z    5(        5)      $ 20Q�6#   5+      �� 5,   
   -   5         ��Name$ id_ChidComboBox��5,      $��center=�6-   $��Stretch=�6~   $��0��6�   $��1��6�   $
��Bold"�6�    5-        5.      $	 0.3Q�6#   50      �� 52   
   $��Center=�6   $��4��6+   $
��Left=�68   $��0��6S   $��Num Of Hours:��6c   $
��Bold"�6{    53        54      $ 20Q�6#   56      �� 57   
   -   5        	 ��Name$	 num_Of_HoursTextBox��57      $��Center=�6/   $��4��6J   $��Stretch=�6�   $��1��6�   $
��Bold"�6�   ��6X   �� 
 �� Path$
 hours_Of_Employment�.��6�    58        59      $	 0.3Q�6#   .��5:      5;      �� 5<   
   $��Center=�6   $��2��6+   $
��Left=�69   $��0��6T   $��Started Working:��6d   $
��Bold"�6�    5=        5>      $ 20Q�6#   5@        5A   
   -   5        $ started_WorkingDatePicker��5A      $��Center=�6|   $��2��6�   $��Stretch=�6�   $��1��6�   $
��Bold"�6�    5B        5C      $	 0.3Q�6#   5E      �� 5F   
   -   5         ��Name$ choosenanny��5F      $��Choose Nanny��6'   $��Center=�6>   $��1��6Y   $��1��6f   $��Stretch=�6v   $
��Bold"�6�    5G        5H      $	 0.3Q�6#   5J      �� 5K   
   -   5        $ 
add_button��5K      $��5��6%   $��2��62   $��Add Contract��6C   $��center=�6Z   $��center=�6w   $��0��6�   $��2��6�   $
��Bold"�6�    5L        5M      $ 20Q�6#   5O      ��5Q   
   �� 5R       �� ImageSource$1 +C:\Users\Shirly\background_material_red.jpg��6    j� Stretch$ UniformToFill=�6S    �� Opacity$	 0.2Q�6k   5T      5V      