   M S B A M L   `   `   `  ����F  BTourProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:TourProject.Views.TouristViewsTourProject.Views.TouristViews  5   	   d `Microsoft.Maps.MapControl.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35tRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPFMicrosoft.Maps.MapControl.WPF 5   	   0    *TourProject.Views.TouristViews.TouristView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:TourProject.Views.TouristViews     5   	   bmapRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPF     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     � WindowStartupLocation$  CenterScreen=�5
   	    � WindowStyle$
 None=�6.    � AllowsTransparency$
 True��6A    � 
ResizeMode$ NoResize=�6[   $
��1080��5   	   $	��720��6   
������ .��5      �    cSelectedMenuItem#��[  6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      .+�5   
   ]� .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Account=�5      $��50��5      $��50��5       $
��20 0q�5!      �� 5$      $��Ismayil Kerimzade��5%      $��Center=�5&      $��20(�5'      �� 5+      $��Right=�6    & "MaterialDesignIconForegroundButton#��[ 5.       � ToolTip$( "MaterialDesignIconForegroundButton��5/      ��5,      �� *BackToLogin_Command+{�5-      �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType
 Window.��50        $ 	ExitToApp=�51      $��40��52      $��40��53      54      56      #  MaterialDesignThemes.Wpf.Card  5:   
   $��1��6     cBackground#��[ 5;   	   .��5<      �� #��[ 6    " MaterialDesignFilledTabControl#��[ 5>      	 �� TabStripPlacement$		 Top=�5?      .@�5B      �� $
��Home��5C      .��5E      � 
 � ColumnDefinitions
 5H      �� 5I      �� 5J      $��2* �6/   .+�5O      �� -   5         ��Name$ 
ListOTours��5O   #   $
��Auto=�6[   ��67   �� *ActiveTours+��5P      �� 5Q   "    �� 
TargetType" ��6(   .�5R   &   ��  �� Property � �� �� Value 5S   *   �� 5T   .    �� 
TargetType" ��6>   .R�5U   2   �� $��border��69   $��50��6G    �� CornerRadius$ 	20 0 0 20��6S   $��	10 10 0 0q�6l   
������ #��[ 5V   S   ._�5W   6   ��  �� Orientation$ 
Horizontal=�6A   $��Center=�6Z   .+�5X   :     $ Highway=�6R   $��30��6a   $��30��6l   $
��10 0q�6x   �� 5Y   :   $��20(�6b   ��6@   �� *StartLocation+6b   �� 5Z   :   $	�� - ��6@   $��20(�6N   �� 5[   :   $��20(�6c   ��6@   �� *FinishLocation+6c   5\   7   5]   3    �� Triggers 5^   2   P� 5_   6    P� Property �@��
IsSelected P� Value$
 True��6T   . �5`   :   ��  �� 
TargetName$ border��6A    � ��
 �����6k   5a   7   P� 5b   6    �@J�IsMouseOver$
 True��6U   . �5c   :   �� $ border��6A    � ��
 �����6k   5d   7   5f   /   5h   '   5i   #   5k      �� 5o      $��1��6!   $ 10��61    
 cWhite#��[ 6C   ._�5p      �  5s   "   �� 5t   &   �� 5u   &   $��3* �64   .+�5z   "   � $��0��6'   
 5}   &   �� 5~   *   �� 5   *   �� 5�   *   $
��0.5* �6;   .+�5�   &   �  5�   *   �� 5�   .   �� 5�   .   .+�5�   *   �� $��Start date of tour��64   $��20(�6N   $��Italic$�6\   $��Center=�6o   $��Center=�5�   8   �� 5�   *   $��1��64   $��15(�6i   $��Center=�6x   $��Center=�5�   8   ��5�   A   �� *SelectedTour.StartTime+5�   8   5�   '   � 5�   &   $��1��6+    5�   *   �� 5�   .   �� 5�   .   .+�5�   *   �� $��Finish date of tour��64   $��20(�6O   $��Italic$�6]   $��Center=�6p   $��Center=�5�   8   �� 5�   *   $��1��64   $��15(�6j   $��Center=�6y   $��Center=�5�   8   ��5�   A   �� *SelectedTour.FinishTime+5�   8   5�   '   � 5�   &   $��3��6+   $	��100��6;   .+�5�   *   �� $��50��5�   1   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5�   1     MaterialDesignRaisedButton#��[ 5�   1   $3 -MaterialDesignRaisedButton with Round Corners��5�   1   ��5�   -   �� *BuyTicket_Command+{�5�   1   �� *DataContext.ControlsEnabled+ �� *FindAncestor+
 Window.��5�   .   �� $��
Buy ticket��68   5�   +   5�   '   5�   #   � 5�   "   $��1��6'   
 5�   &   �� 5�   *   �� 5�   *   $��2* �6;   .+�5�   &   �� -   5        $ listView_LocationsName��5�   /   ��6O   �� *NamesOfLocations+��5�   *   �� 5�   .   " ��64   .�5�   2   ��  � �� 5�   6   �� 5�   :   " ��6J   .R�5�   >   �� $��border��6E   $��30��6S   $ 	20 0 0 20��6_   $��5 5 0 0q�6x   
������ #��[ 5�   S   ._�5�   B   �� $ 
Horizontal=�6M   $��Center=�6f   .+�5�   F     $ 	MapMarker=�6^   $��20��6o   $��20��6z   $
��10 0q�6�   �� 5�   F   $��15(�6m   ��6L   �� *LocationName+6m   5�   C   5�   ?    5�   >   P� 5�   B    �@��
IsSelected$
 True��6`   . �5�   F   �� $ border��6M   # [ 6w    � ��5�   C   P� 5�   B    �@J�IsMouseOver$
 True��6a   . �5�   F   �� $ border��6M   # [ 6w    � ��5�   C   5�   ;   5�   3   5�   /   5�   '   '  !Microsoft.Maps.MapControl.WPF.Map  5�   &   $��1��6.   +  %Microsoft.Maps.MapControl.WPF.MapCore   Center<  6Microsoft.Maps.MapControl.WPF.Design.LocationConverter$ 40.1431, 47.5769 6>      	ZoomLevel$ 7Q�6X      CredentialsProviderT  NMicrosoft.Maps.MapControl.WPF.Design.ApplicationIdCredentialsProviderConverter$F @Ak0hEyNDOAMO_Mxk1gTFJfkX2a4HQIriuWfPdpTDtTWFWsZoHhHRRUcGT9G2uPkL 6f      Children. 5�   *   +  %Microsoft.Maps.MapControl.WPF.Pushpin  ,	  &Microsoft.Maps.MapControl.WPF.MapLayer 	  Position 66   �� *SelectedLocation_ForMap+5�   '   5�   #   5�      5�      5�      5�      �� 5�      $��My tours��5�      5�      5�      5�      5�      5      