   M S B A M L   `   `   `  ????G  CPR1_08.10.22, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:PR1_08._10._22PR1_08._10._22  5   	       PR1_08._10._22.Exercise5   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:PR1_08._10._22     5   	     ? Title$  	Exercise5??5   	   $	??450??6   $	??800??6(   .??5	      ? .+?5
   
   ?? -   5         ??Name$ Ex5Text_txtbl??5
      $??Center=?6+   $??0,60,0,0q?6H   $????Сгенерировать массив размером M столбцов и N строк, содержащий числа от -10 до 10. Отобразить его пользователю. Отсортировать элементы в нем по возрастанию и по убыванию. Вывести результаты сортировки в двух таблицах. Найти максимальный и минимальный элементы массива. ??6Z   $
??Wrap=?6o  $	??Top=?6?  $??16(?6?   ?? TextAlignment$ Center=?6?  $	??684??6?  ?? 5   
   -   5         ??Name$ m_txtbx??5      $
??Left=?6#   $??257,150,0,0q?6>   $??Введите M??6S    ?? TextWrapping$
 Wrap=?6d   $	??Top=?6x   $	??120??6?   $??24??6?   ?? 5   
   -   5        $ n_txtbx??5      $
??Left=?6#   $??400,150,0,0q?6>   $??Введите N??6S   $
 Wrap=?6d   $	??Top=?6x   $	??120??6?   $??24??6?   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ firstarr_dtgr??5      $
??Left=?6*   $	??120??6E   $??
40,240,0,0q?6R   $	??Top=?6f   $	??225??6~     5   
   -   5        $ secondarr_dtgr??5      $
??Left=?6+   $	??120??6F   $??283,240,0,0q?6S   $	??Top=?6h   $	??225??6?     5   
   -   5        $ thirdarr_dtgr??5      $
??Left=?6*   $	??120??6E   $??526,240,0,0q?6R   $	??Top=?6g   $	??227??6   ?? 5   
   -   5         ??Name$ 	Done5_btn??5      $??Применить??6$   $
??Left=?68   $??257,193,0,0q?6S   $	??Top=?6h   $??24??6?   $	??263??6?   6?   ?? 5   
   -   5         ??Name$ max_lbl??5      $-??'Максимальный элемент??6!   $
??Left=?6@   $??203,378,0,0q?6[   $	??Top=?6p   ?? 5   
   -	   5        $ min_lbl??5      $+??%Минимальный элемент??6!   $
??Left=?6?   $??447,378,0,0q?6Z   $	??Top=?6o   5      5      