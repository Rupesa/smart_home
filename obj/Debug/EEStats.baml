   M S B A M L   `   `   `  ����b  ^Syncfusion.SfChart.WPF, Version=18.1460.0.52, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89eGclr-namespace:Syncfusion.UI.Xaml.Charts;assembly=Syncfusion.SfChart.WPFSyncfusion.UI.Xaml.Charts  5   	   E AIHCProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:IHCProject
IHCProject 5   	      IHCProject.EEStats   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   YchartGclr-namespace:Syncfusion.UI.Xaml.Charts;assembly=Syncfusion.SfChart.WPF     5   	   *localclr-namespace:IHCProject     5   	     � Title$  EEStats��5	   	   $	��667��6   $	��375��6&    � WindowStartupLocation$ CenterScreen=�62    � WindowStyle$
 None=�6W    � 
ResizeMode$ NoResize=�6j   ���	#FFF2F2F7 � DataContext 5        IHCProject.ViewModel  5   
   .��5      � .+�5   
   �� $
��Left=�6   $��30��6+   $��0,0,0,0q�67   $	��Top=�6H   $	��375��6`   $��Resources/topBar.png��6l   �� 5   
   $
��Left=�6   $��50��6+   $��1,618,0,-249q�67   $	��Top=�6M   $	��374��6e   $��Resources/navBar.png��6q   $
��Fill=�6�   �� 5   
   -   5        $
��Left=�5      $��50��6,   $��250,618,0,-249q�68   $	��Top=�6P   $	��125��6h    J� Opacity$ 0Q�6t   6�   �� 5   
   -   5        $
��Left=�5      $��50��6,   $��125,618,0,-249q�68   $	��Top=�6P   $	��125��6h   $ 0Q�6t   6�   �� 5   
   -   5        $
��Left=�5      $��50��6,   $��0,618,0,-249q�68   $	��Top=�6N   $	��125��6f   $ 0Q�6r   6~   �� 5   
   -   5         ��Name$ 
TitleLabel��5      $��Eletric Energy��6$   $
��Left=�6=   $��45��6X   $��
155,59,0,0q�6d   $	��Top=�6x   $	��193��6�   $��Trebuchet MS)�6�   $��28(�6�      
titleColor#��[  6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 2Q�6#   	   Opacity$
	 0.25Q�62   
   ShadowDepth$
 2Q�6A   5      �� 5   
   #��[  6   $
��Left=�67   $��2��6R   $��
42,122,0,0q�6]   #��[  6q   $	��Top=�6�   $	��291��6�   �� 5   
   $
��Left=�6   $��36��6+   $��	42,59,0,0q�67   $	��Top=�6J   $��36��6b   $��Resources/backArrow.png��6m   �� 5   
   -   5        $
��Left=�5      $��36��6,   $��	42,59,0,0q�68   $	��Top=�6K   $��36��6c   $ 0Q�6n   6z   �� 5   
   $
��Left=�6   $��32��6+   $��18,544,0,-157q�67   $	��Top=�6N   $��55��6f   $��Trebuchet MS)�6q   $��20(�6�   $
��Now:��6�   $
��Bold"�6�    5        5       $ 2Q�6#   $
	 0.25Q�62   $
 2Q�6A   5"      �� 5#   
   $
��Left=�6   $��32��6+   $��171,544,0,0q�67   $	��Top=�6L   $��95��6d   $��Trebuchet MS)�6o   $��20(�6�   $��Medium:��6�   $
��Bold"�6�    5$        5%      $ 2Q�6#   $
	 0.25Q�62   $
 2Q�6A   5'      �� 5(   
   $
��Left=�6   $��32��6+   $��
73,544,0,0q�67   $	��Top=�6K   $��93��6c   $��Trebuchet MS)�6n   $��20(�6�   $��2.4 kWh��6�    5)        5*      $ 2Q�6#   $
	 0.25Q�62   $
 2Q�6A   5,      �� 5-   
   $
��Left=�6   $��32��6+   $��264,544,0,0q�67   $	��Top=�6L   $	��109��6d   $��Trebuchet MS)�6p   $��20(�6�   $��	374.2 kWh��6�    5.        5/      $ 2Q�6#   $
	 0.25Q�62   $
 2Q�6A   51      '   !Syncfusion.UI.Xaml.Charts.SfChart  55   
   $	��375��6   $	��350��6$      PrimaryAxis 56      ,   &Syncfusion.UI.Xaml.Charts.CategoryAxis  57         SecondaryAxis 5:      -   'Syncfusion.UI.Xaml.Charts.NumericalAxis  5;      $y�	Collapsed=�6&   )   #Syncfusion.UI.Xaml.Charts.ChartBase   Legend 5>      +   %Syncfusion.UI.Xaml.Charts.ChartLegend  5?         Series. 5A      ,   &Syncfusion.UI.Xaml.Charts.ColumnSeries  /	   )Syncfusion.UI.Xaml.Charts.ChartSeriesBase 	  Palette$
 None=�6!    	  Label$ Eletric Energy kWh��60    	  XBindingPath$ Month��6j   ,
   &Syncfusion.UI.Xaml.Charts.XyDataSeries 
  YBindingPath$ Value��6    	  ItemsSource 6K   �� *DataEE+/   )Syncfusion.UI.Xaml.Charts.AdornmentSeries   AdornmentsInfo 5B      2   ,Syncfusion.UI.Xaml.Charts.ChartAdornmentInfo  5C      6   0Syncfusion.UI.Xaml.Charts.ChartAdornmentInfoBase   	ShowLabel . 6/   5E      5F      �� 5I   
   -   5        $
��Left=�5I      $��36��6,   $��1,477,0,-94q�68   $	��Top=�6M   $��72��6e   $ 0Q�6p   6|   �� 5J   
   -   5        $
��Left=�5J      $��36��6,   $��78,477,0,-94q�68   $	��Top=�6N   $��72��6f   $ 0Q�6q   6}   �� 5K   
   -   5        $
��Left=�5K      $��36��6,   $��155,477,0,-94q�68   $	��Top=�6O   $��72��6g   $ 0Q�6r   6~   �� 5L   
   -	   5        $
��Left=�5L      $��36��6,   $��232,477,0,-94q�68   $	��Top=�6O   $��67��6g   $ 0Q�6r   6~   �� 5M   
   -
   5        $��36��5M      $��304,477,0,0q�6   $	��Top=�62   $ 0Q�6J   6V   �� 5N   
   #��[  6   $
��Left=�67   $��2��6R   $��1,513,0,-96q�6]   #��[  6r   $	��Top=�6�   $	��374��6�   �� 5O   
   #��[  6   $
��Left=�67   $��2��6R   $��59,494,0,-77q�6]   #��[  6s   $	��Top=�6�   $��32��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5P      V� 5Q      .~�5R      �� �� 5S      �� 5T       �� Angle$ 90Q�6&   T� 5U      5V      5X      �� 5Y   
   #��[  6   $
��Left=�67   $��2��6R   $��135,494,0,-77q�6]   #��[  6t   $	��Top=�6�   $��32��6�   $ 0.5,0.5&�6�   z�5Z      V� 5[      .~�5\      �� �� 5]      �� 5^      $ 90Q�6&   T� 5_      5`      5b      �� 5c   
   #��[  6   $
��Left=�67   $��2��6R   $��210,494,0,-77q�6]   #��[  6t   $	��Top=�6�   $��32��6�   $ 0.5,0.5&�6�   z�5d      V� 5e      .~�5f      �� �� 5g      �� 5h      $ 90Q�6&   T� 5i      5j      5l      �� 5m   
   #��[  6   $
��Left=�67   $��2��6R   $��285,494,0,-77q�6]   #��[  6t   $	��Top=�6�   $��32��6�   $ 0.5,0.5&�6�   z�5n      V� 5o      .~�5p      �� �� 5q      �� 5r      $ 90Q�6&   T� 5s      5t      5v      5x      5y      