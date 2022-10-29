using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Логика взаимодействия для Exercise5.xaml
    /// </summary>
    public partial class Exercise5 : Window
    {
        public Exercise5()
        {
            InitializeComponent();
        }
        public static class ArrExtension
        {
            public static DataTable ToDataTable(int[,] array)
            {
                var res = new DataTable();

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    res.Columns.Add("col" + j);
                }

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    var row = res.NewRow();

                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        row[j] = array[i, j];
                    }

                    res.Rows.Add(row);
                }

                return res;
            }
        }
        private void Done5_btn_Click(object sender, RoutedEventArgs e)
        {
            int n, m;
            if (int.TryParse(n_txtbx.Text, out n) && int.TryParse(m_txtbx.Text, out m)) //создание и заполнение массива по заданным пропорциям
            {
                int[,] mas = new int[n, m];
                Random rnd = new Random();

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        mas[i, j] = rnd.Next(-10, 10);
                    }
                }
                firstarr_dtgr.ItemsSource = ArrExtension.ToDataTable(mas).DefaultView;
                //Сортировка массива
                int[] l = new int[n * m];

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        l[j + i * m] = mas[i, j];// из двумерного в одномерный
                    }
                }
                int min = l.Min();
                int max = l.Max();
                max_lbl.Content = max;
                min_lbl.Content = min;

                void Preobraz(int[] arr)
                {
                    int i = 0;
                    while (i < n)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            mas[i, j] = arr[j + i * m];//вычисляем индекс одномерого массива 012345 , по индексу записываем в двумерный.
                        }
                        i++;
                    }
                }
                BubbleSort(l);
                Preobraz(l);
                secondarr_dtgr.ItemsSource = ArrExtension.ToDataTable(mas).DefaultView;

                BubbleSort(l);
                Array.Reverse(l);
                Preobraz(l);
                thirdarr_dtgr.ItemsSource = ArrExtension.ToDataTable(mas).DefaultView;
            }

        }
        static int[] BubbleSort(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }
    }

}
