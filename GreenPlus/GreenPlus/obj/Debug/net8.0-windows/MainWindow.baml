   M S B A M L   `   `   `  ����D  @GreenPlus, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:GreenPlus	GreenPlus  5   	   ;"clr-namespace:GreenPlus.ViewModelsGreenPlus.ViewModels  5   	   9!clr-namespace:GreenPlus.UtilitiesGreenPlus.Utilities  5   	       GreenPlus.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:GreenPlus     5   	   1vm"clr-namespace:GreenPlus.ViewModels     5   	   2Menu!clr-namespace:GreenPlus.Utilities     5   	   c _MahApps.Metro.IconPacks.Core, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5	   	     � Title$  
MainWindow��5   	   $	��720��6   $
��1280��6)    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ CanMinimize=�5   	    � WindowState$ 	Maximized=�5   	    � DataContext 5      &   GreenPlus.ViewModels.NavegacaoVM  5   
   .��5      � .+�5   
   �� ���#E9E9E96   � 5   
    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      .+�5      � -   5         �Name$ SideBar��5      $
��Left=�5      $��60��5      .+�5"      �� ���#FFF �� CornerRadius$ 	0,20,20,0��5#      � 5$       � RowDefinitions 5%      �� 5&      $
��Auto �6(   �� 5'      $
��Auto �6(   �� 5(      $
��Auto �6(   �� 5)      $
��Auto �6(   �� 5*      $
��Auto �6(   �� 5+      $
��Auto �6(   �� 5,      $
��Auto �6(   �� 5-      $
��Auto �6(   .+�50      �� $��80��6!   .+�51      �� $��	0,75,0,10q�6$   52         GreenPlus.Utilities.Btn  55         BtnStyle#��[  6   $��2��57      	 d� 	IsChecked$
	 TrueY�58      ��56      �� *HomeCommand+.��59      �  5:      �� 5;   "   $��60 �63   �� 5<   "   $��* �63   .+�5?      .  (MahApps.Metro.IconPacks.PackIconMaterial  
   Kind$

 Home=�64   $��30��5@   4   $��30��5A   4   $��Center=�5B   4   $��Center=�5C   4   �� 5E      -   5         ��Name$ txtHome��5F   (   $��1��5E   (   $
��Home��5G   (     	txtStyles#��[ 5H   (   5J      5K        5N      -   5          Name$ Cadastro��5N      #��[  5O      $��3��5Q      ��5P      �� *ProdutoCommand+.��5R      �  5S      �� 5T   "   $��60 �63   �� 5U   "   $��* �63   .+�5X        $
 CalendarPlus=�64   $��30��5Y   4   $��30��5Z   4   $��Center=�5[   4   $��Center=�5\   4   �� 5^      -   5        $ txtCadastro��5_   (   $��1��5^   (   #��[ 5`   (   $��Cadastro��5a   (   5c      5d        5g         GreenPlus.Utilities.Btn   Click$ 	Btn_Click��5i   #   #��[  5g      $��4��5h   #   .��5j      �  5k   "   �� 5l   &   $��60 �67   �� 5m   &   .+�5o   "     $
 Sprout=�68   $��30��5p   4   $��30��5q   4   $��Center=�5r   4   $��Center=�5s   4   �� 5u   "   -   5        $ txtProducao��5w   (   $��
Produção��5u   ,   #��[ 5v   (   $��1��5x   (   5y      5z      �� 5|      -   5         ��Name$ ConteudoDrop��5|   !   $y�	Collapsed=�67   $��5��5}   %   .+�5~      �  5   "   �� 5�   &   $��30 �67   �� 5�   &   $��* �67   .+�5�   "   �� $��Stretch=�6,   $��1��5�   ,   $��2q�5�   ,   ���#387c515�   ,   �� 5�   "   $��1��6-   .+�5�   &   ��  	 Hover#��[ 61   .+�5�   *   �� -   5         ��Name$ cadastro��5�   1     BotaoDropdown#��[ 5�   1   $��4,7,0,0q�5�   1   .��6B   
Calendario6N   5�   '   �� 5�   &   #��[ 61   .+�5�   *   �� -   5        $ Plantio��5�   1   #��[ 5�   1   $��4,7,0,0q�5�   1   .��6B   	Plantio6K   5�   '   �� 5�   &   #��[ 61   .+�5�   *   �� -	   5        $ Colheita��5�   1   #��[ 5�   1   $��4,7,0,0q�5�   1   .��6B   
Colheita6L   5�   '   �� 5�   &   #��[ 61   .+�5�   *   �� -
   5        $ irrigar��5�   1   #��[ 5�   1   $��4,7,0,0q�5�   1   .��6B   Irrigação6M   5�   '   5�   #   5�      5�        5�      #��[  6   $��6��5�      .��5�      �  5�      �� 5�   "   $��60 �63   �� 5�   "   $��* �63   .+�5�        $
 Archive=�64   $��30��5�   4   $��30��5�   4   $��Center=�5�   4   $��Center=�5�   4   �� 5�      -   5        $ 
txtEstoque��5�   (   $��Estoque��5�   (   #��[ 5�   (   $��1��5�   (   5�      5�      5�      5�      � 5�      $��1��6   .+�5�      �� -   5         ��Name$ Pages��5�   !   ��5�   !   �� *CurrentView+5�      5�      5�      5�      