   M S B A M L   `   `   `  ����?  ;comn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:comn.Scriptcomn.Script  5          comn.Script.AllUsersxaml   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:comn.Script     5      -   5          N� Title$  AllUsersxaml��5	      .��5
      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5         ��Name$
 BAdd��5      $	��Add��5      $��0 0 5 0q�5      �� 5      -   5        $ BEdit��5      $
��Edit��5      $��0 0 5 0q�5      �� 5      -   5        $ BRemove��5      $��Remove��5      $��0 0 5 0q�5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DGUsers��5         AutoGenerateColumns .     
IsReadOnly . $��1��5          Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 5$   %   �� *Name+  5&      $
 Role��6%   	 5'   %   �� *	Role.Name+5)      5*      5+      