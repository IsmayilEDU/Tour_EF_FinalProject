   M S B A M L   `   `   `  ����F  BTourProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:TourProject.Views.StartViewsTourProject.Views.StartViews  5   	   /    )TourProject.Views.StartViews.RegisterView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:TourProject.Views.StartViews     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � WindowStyle$
 None=�6.    � AllowsTransparency$
 True��6A    � 
ResizeMode$ NoResize=�6[   $	��800��6q   $	��800��6}   
������ .��5
      ��  �� CornerRadius$ 30��6      cBackground#��[  6   ._�5   
   �  � RowDefinitions 5      �� 5      $	��150 �6    �� 5      �� 5      $	��100 �6    .+�5      �� $��0��6   .+�5      �� $��Right=�5      $��	0 20 20 0q�5      $��Back to Login��5         MaterialDesignFlatDarkButton#��[ 5       � ToolTip$ MaterialDesignFlatButton��5       ��5      �� *BackToLogin_Command+{�5      �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType
 Window5       �� 5#      $��Registration��6    ! MaterialDesignLightForeground#��[ 6/   $��Center=�6k   $��40(�6�   $
��Bold"�6�   5$      � 5(      $��1��6   	 � ColumnDefinitions	 5+      �� 5,      �� 5-      .+�52      � .+�55      �� $��1��6!   $
��20 0q�6.   .+�5:      �� $
��Name��6      cMenuBackground#��[ 6/   $��20(�6]   $
��Bold"�6k   �� 5=      -   5        
 ��Name$
 textbox_Name��5>   !   $��20(�67   $��0 0 0 40q�6E   #��[ 5?   !   )  #MaterialDesignThemes.Wpf.HintAssist   
HelperText$ Example : Ismayil��5@   !      Hint$ Please enter your name��5A   !   .��6Y   5B      �� 5I      $��Surname��6    #��[ 62   $��20(�6`   $
��Bold"�6n   �� 5L      -   5        $
 textbox_Surname��5M   !   $��20(�6:   $��0 0 0 40q�6H   #��[ 5N   !   $ Example : Kerimzade��5O   !   $ Please enter your surname��5P   !   .��6\   5Q      �� 5X      $��Phone��6    #��[ 60   $��20(�6^   $
��Bold"�6l   �� 5[      -   5        $
 textbox_Phone��5\   !   $��20(�68   $��0 0 0 40q�6F   #��[ 5]   !   $ Example : 050-665-06-55��5^   !   $ Please enter your phone��5_   !   .��6Z   5`      �� 5g      $��Username��6    #��[ 63   $��20(�6a   $
��Bold"�6o   �� 5j      -   5        $
 textbox_Username��5k   !   $��20(�6;   $��0 0 0 40q�6I   #��[ 5l   !   $ Example : ismayil123 ��5m   !   $  Please enter your username��5n   !   .��6]   5o      �� 5u      $��Password��6    #��[ 63   $��20(�6a   $
��Bold"�6o   G� 5v      -   5         G�Name$ passwordBox_Password��5w      #��[ 5x      $	��Top=�5y      $ Example : ismayil123��5z       % !MaterialDesignOutlinedPasswordBox#��[ 5|      {�5{      ��  �� Path$ 	IsChecked� �� ElementName$6 0MaterialDesignOutlinedPasswordBoxEnabledComboBox��5|      5�      5�      �� 5�      $��1��6   $
��20 0q�6-   .+�5�      �� $��Name of bank��6    $��Center=�64   $
��0 20q�6O   $
��Left=�5�      $��20(�67   $
��Bold"�6E   #��[ 5�      �� 5�      -   5        $
 textbox_BankName��5�      $��15(�63   #��[ 5�      $ Example : Leobank��5�      $ Please enter Bank name��5�      .��6Q   5�      �� 5�      $��Card number��6    $��Center=�63   $��	0 40 0 10q�6N   $
��Left=�5�      $��20(�67   $
��Bold"�6E   #��[ 5�      �� 5�      -   5        $
 textbox_CardNumber��5�      $��15(�65   #��[ 5�      $  Example : 1234567891234567��5�      $* $Please enter card number (16 digits)��5�      .��6_   5�      �� 5�      $��ExpirationDate of card��6    $��Center=�6>   $��	0 40 0 10q�6Y   $
��Left=�5�      $��20(�67   $
��Bold"�6E   #��[ 5�      (  "System.Windows.Controls.DatePicker  5�      -   5        $��datePicker_ExpirationDate��5�      $ Expiration date��5�      $) #Please enter ExpirationDate of card��5�       $  MaterialDesignOutlinedDatePicker#��[ 5�      �� 5�      $	��CVC��6    $��Center=�6+   $��	0 40 0 10q�6F   $
��Left=�5�      $��20(�67   $
��Bold"�6E   #��[ 5�      �� 5�      -	   5        $
 textbox_CVC��5�      $��15(�6.   #��[ 5�      $ Example : 984��5�      $ Please enter CVC��5�      .��6K   5�      �� 5�      $��Balance��6    $��Center=�6/   $��	0 30 0 10q�6J   $
��Left=�5�      $��20(�67   $
��Bold"�6E   #��[ 5�      �� 5�      -
   5        $
 textbox_Balance��5�      $��15(�62   #��[ 5�      $ Example : 5000��5�      $ Please enter balance��5�      .��6O   5�      5�      5�      � 5�      $��2��6   $	��200��6    $��0q�6,   .+�5�      �� $��70��5�      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5�        MaterialDesignRaisedButton#��[ 5�      $3 -MaterialDesignRaisedButton with Round Corners��5�      ��5�      �� *Register_Command+{�5�      �� *DataContext.ControlsEnabled+ �� *FindAncestor+
 Window.��5�      �� $��Register��6    $��23(�60   5�      5�      5�      5�      5�      