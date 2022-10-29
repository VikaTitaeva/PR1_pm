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
    /// Логика взаимодействия для Exercise2.xaml
    /// </summary>
    public partial class Exercise2 : Window
    {
        public Exercise2()
        {
            InitializeComponent();
        }

        private void Done2_btn_Click(object sender, RoutedEventArgs e)
        {
            double z;
            string s = Input2_txtbx.Text;
            try
            {
                z = Convert.ToDouble(s);
                if (Convert.ToInt32(z) == z)
                    Output2_txtbx.Text = "1";
                else
                    Output2_txtbx.Text = "2";
            }
            catch
            {
                Output2_txtbx.Text = "0";
            }
        }
    }
}
