using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lesson3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void getcount(object sender, RoutedEventArgs e)
        {
            int n;
            String[] s = numer_text.Text.Split(' ');
            n = s.Count();
            int[] arr = new int[n];
            if (n != 5)
            {
                MessageBox.Show("Incorrect input!");
                numer_text.Clear();
                Close();
            }
            for (int i = 0; i < n; i++)
            {
                try
                {
                    arr[i] = Int32.Parse(s[i]);
                }
                catch
                { 
                    numer_text.Clear();
                    break;
                }
            }
            int mult = 1;
            foreach (int element in arr)
            {
                if (element % 7 == 0 || element % 3 == 0)
                {
                    mult *= element;
                }
            }
            if (mult == 1)
            {
                MessageBox.Show("No numbers found");
                Close();
            }
            Window_show window = new Window_show();
            window.text_result.Text = mult.ToString();
            window.ShowDialog();
        }
        /*public int Func(ref int[] arr)
        {
            int mult = 1;
            foreach (int element in arr)
            {
                if (element % 7 == 0 || element % 3 == 0)
                {
                    mult *= element;
                }
            }
            if (mult == 1)
            {
               MessageBox.Show("No numbers found");
               return 0;
            }
            else
            {
             return mult;
            }
            
        }*/

    }
}
