   M S B A M L   `   `   `  ����K  GTeil2_Schwimmbad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Teil2_SchwimmbadTeil2_Schwimmbad  5   	   !    Teil2_Schwimmbad.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Teil2_Schwimmbad     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   .+�5   
   �� -   5        $��Menü��5      6<   �� 5   
   -   5        $��Becken-Verwaltung��5      $��1��6I   6[   �� 5   
   -   5        $��Kurs-Verwaltung��5      $��2��6E   6W   �� 5   
   -   5        $��Event-Verwaltung��5      $��3��6G   6Y   �� 5   
   -   5        $��Besuchertipps��5      $��4��6D   6V   �� 5   
   -   5        $��Öffnungszeiten��5      $��5��6L   6^   �� 5   
   -   5         ��Name$ contentcontroller��5      $��0��64   $��1��6D   $��6��6Q   6g   5!      5"      