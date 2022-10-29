using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PR1_08._10._22
{
    /// <summary>
    /// Логика взаимодействия для Exercise3.xaml
    /// </summary>
    public partial class Exercise3 : Window
    {
        public Exercise3()
        {
            InitializeComponent();
        }

        private void Done3_btn_Click(object sender, RoutedEventArgs e)
        {
            Output3_txtbx.Clear();
            string[] str = Input3_txtbx.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int[] nums = new int[str.Length];
            for (int i = 0; i < nums.Length; i++)// производим махинации для избежания траблов с двойным пробелом и текста в массиве
            {
                try
                {
                    nums[i] = Convert.ToInt32(str[i]);
                }
                catch
                {
                    MessageBox.Show("Ошибка ввода");
                }
            }

            foreach (int number in nums)
            {
                if (Booltask(number))//Обращаемя к методы проверяещему число, если оно подходит, то выводится
                {
                    Output3_txtbx.Text += $" {Convert.ToString(number)}";
                }
            }

            bool Booltask(int number)//проаерка числа
            {
                bool result = true;
                if (number < 0)
                { number *= -1; }//избавляемя от отрицательности проверяемого числа, если это необходимо
                Char[] digits = number.ToString().ToCharArray();//разбиваем элемент на символы
                for (int i = 0; i<digits.Length-1; i++)
                {
                    if (digits[i] != digits[i + 1])//проверяем, если кажый последющий символ не равен преведущему, то число не подходит
                    { result = false; }
                }
                return result;
            }
        }
    }
}

