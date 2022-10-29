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
    /// Логика взаимодействия для Exercise1.xaml
    /// </summary>
    public partial class Exercise1 : Window
    {
        public Exercise1()
        {
            InitializeComponent();
        }

        private void Done1_btn_Click(object sender, RoutedEventArgs e)
        {
            string BinaryNumber = Input1_txtbx.Text;
            int DecimalNumber = 0;
            for (int i = 0; i < BinaryNumber.Length; i++)
            {
                if (BinaryNumber[BinaryNumber.Length - i - 1] == '0')
                {
                    continue;// по формуле цифра возводится в степень, а 0 в любой степени будет 0, поэтому проверяется следующая цифра
                }
                DecimalNumber += (int)Math.Pow(2, i);// остальные цифры возводятся в квадрат и складываются между собой
            }
            if (DecimalNumber % 15 == 0)
            {
                Output1_txtbx.Text = "Делится!";
            }
            else
            {
                Output1_txtbx.Text = "Не делится!";
            }
            //output_txtbx.Text= DecimalNumber.ToString();
        }

        private void Input1_txtbx_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
          
        }

        private void Input1_txtbx_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
