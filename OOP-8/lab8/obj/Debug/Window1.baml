   M S B A M L   `   `   `  ����?  ;lab8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:lab8lab8  5   	       lab8.Window1   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:lab8     5   	   -   5          � Title$  Window1��5   	   $	��500��6   $	��800��6&    � 	Resources 5	         studentsViewSource  hostelViewSource��%:   &	        &	      �� 5
   
   6   �� 5   
   6   5      .��5      � .+�5   
   �  � DataContext# [  6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ studentsDataGrid��5         AutoGenerateColumns .     EnableRowVirtualization . $��	0,0,0,316q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6l   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        	ageColumn��,  &System.Windows.Controls.DataGridColumn   Header$	 Age��5   T   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 184 6a   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6<   �� *Age+6a     5      -   5        idColumn��$ Id��5   R   $		 200 6^   
 6;   �� *Id+6^     5      -   5        
nameColumn��$
 Name��5   V   $		 200 6d   
 6=   �� *Name+6d     5      -   5        s_nameColumn��$ S name��5   Z   $		 200 6j   
 6?   �� *S_name+6j   5      �� 5      -   5        $��ad_st��5      $	��Add��6"   $
��Left=�60   $��45��6K   $��
45,192,0,0q�6W   $	��Top=�6k   $	��148��6�   6�   �� 5      -   5        $��del_st��5      $��Delete��6#   $
��Left=�64   $��45��6O   $��237,192,0,0q�6[   $	��Top=�6p   $	��148��6�   6�   �� 5      -	   5        $��ch_st��5      $��Change��6"   $
��Left=�63   $��45��6N   $��437,192,0,0q�6Z   $	��Top=�6o   $	��148��6�   6�   5      � 5   
   # [ 6   .+�5        -
   5        $ hostelDataGrid��5       .   . $��0,269,579,0q�6�   $ VisibleWhenSelected=�6�   ��6j   ��  5        5      -   5        	idColumn1��$ Id��5   S   $	 50 6_   
 6<   �� *Id+6_     5      -   5        nameColumn1��$
 Name��5   W   $		 155 6e   
 6>   �� *Name+6e   5!      �� 5"      -   5        $��ad_host��5"      $	��Add��6$   $
��Left=�62   $��45��6M   $��247,269,0,0q�6Y   $	��Top=�6n   $	��148��6�   6�   �� 5#      -   5        $��del_host��5#      $��Delete��6%   $
��Left=�66   $��45��6Q   $��247,343,0,0q�6]   $	��Top=�6r   $	��148��6�   6�   �� 5$      -   5        $��ch_host��5$      $��Change��6$   $
��Left=�65   $��45��6P   $��247,414,0,0q�6\   $	��Top=�6q   $	��148��6�    � 5%      -   5        $��fr��5%   4     � NavigationUIVisibility$ Hidden=�6   $��Right=�6?   $	��200��6[   $��Bottom=�6i   $	��350��6�   �� 5&      -   5        $y�Hidden=�5&      $��Sort 1��6)   $
��Left=�6:   $��45��6U   $��615,192,0,0q�6a   $	��Top=�6v   $��59��6�   6�   �� 5'      -   5        $y�Hidden=�5'      $��Sort 2��6)   $
��Left=�6:   $��45��6U   $��698,192,0,0q�6a   $	��Top=�6v   $��53��6�   6�   5)      5*      5+      