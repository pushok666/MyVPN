   M S B A M L   `   `   `  ����E  ADesctopApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:DesctopApp
DesctopApp  5   	       DesctopApp.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:DesctopApp     5   	     � Title$  
MainWindow��5   	   $	��550��6   $	��800��6)    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	   .��5      � -   5         �Name$ MainPage��5      ���	#FFFEFAFA � ColumnDefinitions 5   
   �� 5      -   5         ��Name$ FirstCol��5      $	��160 �61   �� 5      .+�5   
   � -   5        $ WorkArea��5      ���	#FFFEFAFA$	��640��5      $	��550��5      $��Bottom=�5      $��Right=�5      $��1��5      .+�5      �� -   5         ��Name$ DataContent��5      5      � 5   
   -   5        $ 	sidePanel��5      ���	#FF0F4E7A$
��Left=�5      $	��160��5       $��0��5!      .+�5"      �� .+�5#      � $��50��6   ���	#FF0F4E7A.+�5&      �� -   5        $
��Left=�5&      $��35��5'      $��40��5(      $	��Top=�5)      
������ $��	10,10,0,0q�5+      ��5-      �� 5.       �� ImageSource$ /icons/menu.png��6)   50      51      � 52      -   5        $��50��52      $��0,30,0,0q�53      
������ .+�57      ��  �� Orientation$ 
Horizontal=�6!   .+�58      �� $��30��6    $��30��59      $
��Left=�5:      $	��Top=�5;      $��	11,16,0,0q�5<      
������ ��5>      �� 5?   "   $ /icons/home.png��6-   5A      �� 5B      $��40��6    $��Center=�5C      $��Center=�5D      $
��Home��5E      $��25(�5F      $��28,0,0,0q�5G      ���#FFFFFF$	��Top=�5I      5J      5K      � 5L      -   5        $��50��5L      $��0,30,0,0q�5M      
������ .+�5Q      �� $ 
Horizontal=�6!   .+�5R      �� $��30��6    $��30��5S      $
��Left=�5T      $	��Top=�5U      $��	11,16,0,0q�5V      
������ ��5X      �� 5Y   "   $ /icons/about.png��6-   5[      �� 5\      $��40��6    $��Center=�5]      $��Center=�5^      $��About��5_      $��25(�5`      $��28,0,0,0q�5a      ���#FFFFFF$	��Top=�5c      5d      5e      5f      5g      5i      5j      