   M S B A M L   `   `   `  ����C  ?Restoran, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:RestoranRestoran  5   	       Restoran.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Restoran     5   	     � Title$  Restoran��5   	   $	��450��6   $	��850��6'   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridCentralni��5
      $��Center=�6.   $��Center=�6K   $
��auto��6f   $
��auto��6s      
IsReadOnly$
 true��5         AlternatingRowBackground
 �P��   CanUserAddRows$ False��5         SelectionMode$ Single=�6*      SelectionUnit$ FullRow=�6A   �� 5   
   $��Center=�6   $��30��62   $	��Top=�6>   $
��auto��5       �� Orientation$ 
Horizontal=�6"   .+�5      �� -   5         ��Name$ btnKonobari��5      $��Konobari��6*   $
��Left=�6=   $��50,1,0,0q�6X   $	��Top=�6j   �� 5      -   5        $ btnMenadzeri��5      $��	Menadzeri��6/   $
��Left=�6C   $��50,1,0,0q�6^   $	��Top=�6p   �� 5      -   5        $ 	btnKuvari��5      $��Kuvari��6(   $
��Left=�69   $��50,1,0,0q�6T   $	��Top=�6f   �� 5      -   5        $ btnGosti��5      $��Gosti��6'   $
��Left=�67   $��50,1,0,0q�6R   $	��Top=�6d   �� 5      -   5        $ btnRezervacije��5      $��Rezervacije��6-   $
��Left=�6C   $��50,1,0,0q�6^   $	��Top=�6p   �� 5      -   5        $ btnPorudzbine��5      $��
Porudzbine��6,   $
��Left=�6A   $��50,1,0,0q�6\   $	��Top=�6n   �� 5      -   5        $ btnVrsteJela��5      $��
Vrste jela��6+   $
��Left=�6@   $��50,1,0,0q�6[   $	��Top=�6m   �� 5      -	   5        $ btnJelo��5      $
��Jelo��6&   $
��Left=�65   $��50,1,0,0q�6P   $	��Top=�6b   5      �� 5   
   $��Center=�6   $��30��62   $��Bottom=�6>   $
��auto��5      $ 
Horizontal=�6"   5      �� 5   
   -
   5        $ btnDodaj��5      $��Dodaj��6#   $��30��64   $��75��6@   $��200,404,575,0q�6K   �� 5   
   -   5        $ 	btnIzmeni��5      $��Izmeni��6$   $��30��65   $��75��6A   $��388,404,387,0q�6L   �� 5   
   -   5        $ 	btnObrisi��5      $��Obrisi��6$   $��30��65   $��75��6A   $��568,404,207,0q�6L   5!      5"      