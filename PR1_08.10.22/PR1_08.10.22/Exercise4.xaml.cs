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
    /// Логика взаимодействия для Exercise4.xaml
    /// </summary>
    public partial class Exercise4 : Window
    {
        public Exercise4()
        {
            InitializeComponent();
        }

        private void Done4_btn_Click(object sender, RoutedEventArgs e)
        {
            Input4_txtbx.Clear();
            Output4_txtbx.Clear();
            int m = 2;
            int n = 5;
            int length = m + n;
            int[] mas = new int[length];
            Random r = new Random();

            for (int i = 0; i < length; i++)
            {
                mas[i] = r.Next(1, 10);
                Input4_txtbx.Text += mas[i].ToString() + " ";
            }
            
            for (int k = 0; k<m;k++)
            {
                for (int j = 0; j < (n + 1); j++)
                {
                    int temp = mas[0];
                    for (int i = 0; i < mas.Length - 1; ++i)
                    {
                        mas[i] = mas[i + 1];
                    }
                    mas[mas.Length - 1] = temp;
                }
            }

            foreach (int i in mas)
            {
                Output4_txtbx.Text += i.ToString() + " ";
            }
          
        }
    }
}
