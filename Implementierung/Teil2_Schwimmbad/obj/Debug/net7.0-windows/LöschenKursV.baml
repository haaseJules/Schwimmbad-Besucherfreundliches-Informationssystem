   M S B A M L   `   `   `  ����K  GTeil2_Schwimmbad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Teil2_SchwimmbadTeil2_Schwimmbad  5      $    Teil2_Schwimmbad.LöschenKursV   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Teil2_Schwimmbad     5      .��5	      � 
�������  � RowDefinitions  5   
   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   �� $��	0,0,0,179q�6   .��6$   *(Welcher Kurs soll gelöscht werden? (ID)6M   �� 5   
   $	��ID:��6   $��80��6   $��27,39,293,150q�6)   �� 5   
   -   5        $��idkurs��5      $	��200��6    $��69,39,131,154q�6,   �� 5   
   -   5        $��Löschen��5      $	��100��6@   $��30��6L   $��112,96,188,99q�6X   &   System.Windows.Controls.DataGrid  5   
   -   5        $��dataGridKurs��5      $��0��6'   $��1��67   $��2��6D      CanUserDeleteRows$
 True��6X      AutoGenerateColumns$ False��6�   $��10q�6�      SelectionMode$ Single=�6�   ��6q   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6L      
IsReadOnly$
 True��6W   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 61   �� *KursId+6W     5      $
 Name��6%   $	 200 6L   	 63   �� *Text+6L     5      $ Uhrzeit��6%   $	 300 6R   	 66   �� *	Uhrzeit+6R     5       $ Kursleitung��6%   $	 300 6Y   	 6:   �� *
Kursleiter+6Y   5"      5#      5$      