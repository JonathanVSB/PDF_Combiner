   M S B A M L   `   `   `  ����G  CPDF_Combiner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PDF_CombinerPDF_Combiner  5   	       PDF_Combiner.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:PDF_Combiner     5   	   -   5          � Title$  
MainWindow��5   	    � SizeToContent$ WidthAndHeight=�5	   	   $	��270��5
   	   $	��410��6   $	��255��5   	   $	��800��6    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency$
 True��5   	    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ /Styles.xaml?�6%   %    5      .��5      �� $��1q�5   	   
�������	 �� CornerRadius$	 20��5   	   
 �� Padding$
 0q�5   	   ���#FCFCFC._�5!   
   � 
������  � RowDefinitions 5"      �� 5#      $��* �6    �� 5$      $��* �6    �� 5%      $��* �6    .+�5'      �� $��0q�5(      ���#e5e5e5$	 	20,20,0,0��5*      ���#e5e5e5._�5,      � $��0��6   
������ .+�5-      �� $��PDF COMBINER��5.      
���   �$��Center=�50      $��Center=�51      $��10q�52      $��30(�53      $��Arial)�54      $
��Bold"�55      56      57      � 58      $��1��6   $��
20,20,20,0q�6     � ColumnDefinitions 59      �� 5:      $
��auto �6'   �� 5;      $��* �6'   �� 5<      $
��auto �6'   .+�5>      �� $��0��5?      $��	PFF files��5@      
���   �$��20(�5B      $��Center=�5C      $
��Left=�5D      � 5F      $��1��6   $��2��6'   .+�5G      �� -   5         ��Name$ 	TextField��5H      $��16(�5I      ���#45BED3$��5q�5K      
���   �$��Center=�5M      ���#FCFCFC �� TextWrapping$
 Wrap=�5O      �� 5P      ���#45BED3$��0q�63   �� 5Q      -   5         ��Name$ ButtonDirectorie��5R      $��Right=�5S      
������ 
������ $��0q�5V      $��30��6%    � Cursor$
 Hand��5W      .��5Z      �� $��/carpetaIcon.png��6    $��50��6:   $��25��6E    J� RenderTransformOrigin$ 0.75,0.5&�6Q   5\      5]      5_      � 5`      $��2��6    5a      �� 5b      $��* �6'   �� 5c      $��* �6'   .+�5f      �� -   5        $ 	btnCancel��5h         ActionFillButton#��[  5g      $��Cancel��5i      $��0��5j      $��40��5k      $��80��5l      $��	0,10,0,20q�5m      $��Center=�5n      
����������#538BEC$
��Bold"�5q      6'   �� 5t      -   5        $ 	btnFusion��5v      #��[  5u      $��Fusionar��5w      $��1��5x      $��Arial)�5y      $
��Bold"�5z      $��15(�5{      
�������$��40��5}      $��80��5~      $��	0,10,0,20q�5      $��Center=�5�      ���#538BEC5�   *   5�      5�      5�      5�      