   M S B A M L   `   `   `  ����G  CHealthCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:HealthCenterHealthCenter  5          HealthCenter.EventsView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:HealthCenter     5      .��5	      � 
�������  � RowDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� 
���iii� �� Orientation$ 
Horizontal=�6*   .+�5      �� -   5        $��AddBtn��5      $��3q�68   $��8q�6C   $��0��6O   $��Create New Event��6\   �� 5      -   5        $��ExportReportBtn��5      $��3q�6,   $��8q�67   $��0��6a   $��Download Report��6n   �� 5      -   5        $��3q�5      $��8q�6    $��0��6A   $��Reload��6N   5      �� 5   
   $��1��6   $
��Auto=�6$   .��5      �� -   5        $��EventItemsGrid��5      ��61   �� *Events+��5      �� 5      .R�5      � 5      ��5      �� 5      .R�5      �� $��
itemBorder��6O   -   5        $	��300��5   !   $	��300��60   ���#fafafa$��5q�5   P    �� Padding$ 3q�6[   
 � Tag 5   ?   ��  J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5   "      RenderingBias$ Performance=�63      Color$ 	Gainsboro��6O      ShadowDepth$ 1Q�5    3   ._�5"      �  � ColumnDefinitions 5#   "   �� 5$   &   $
��Auto �67   �� 5%   &   $��* �67   .+�5'   "   �� $��0��6)   $ 5q�69   	 �� CornerRadius$	 2��6E   $��10q�6V   ���#66BB6A._�5)   &   �� .+�5*   *   �� $��Center=�64   $��DemiBold"�6O   $��Center=�5+   0   
���iii�$��30(�5,   0   ��6>   �� *PersonCount+
 �� Mode$
 OneWay=��� 5-   *   $��10(�64   
�������$��	Record(s)��6Z   5.   '   5/   #   � 50   "   $��10q�6'   $��1��63     51   &   �� 52   *   $
��Auto �68   �� 53   *   $��* �68   .+�55   &   �� $��0��61   .+�56   *   (� $
��Left=�62   $��30��6M   .��57   .   �� $
��Wrap=�68   
���iii�$��20(�58   8   ��6F   �� *Title+59   +   �� 5:   *   $��12(�64   $��Italic$�6B   
���iii���5<   0   �� *Description+5=   '   �� 5>   &   $��1��61   $��Right=�6>   $ 
Horizontal=�6Z   .+�5?   *   �� $��	ExportBtn��6>   -   5        $��30��5?   1   $��1q�6�   $ 10q�6�    6}   �� ._�5@   .   �� 
����  �Download Records6\   5A   +   �� 5B   *   $��EditBtn��6=   -   5        $��30��5B   1   $��1q�6�   $ 10q�6�    6x   �� ._�5C   .   �� 
����  �Edit6P   5D   +   5E   '   5G   #   5H      5I      5J      5L      5M      5N      5O      