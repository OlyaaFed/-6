using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace пр6
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
        /// <summary>
        /// выполнение основного алгоритма
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnResult_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int index = LstInput.SelectedIndex;
                string str = (string)LstInput.Items[index];
                List<int> list = new List<int>();
                list.AddRange(str.Split(' ').Select(int.Parse));
                int count = 0;
                int i = 0;
                while (i < list.Count)
                {
                    if (list[i] % 2 == 0)
                    {
                        count++;
                    }
                    i++;
                }
                CountOfEvenNumbers.Text = "Количество четных чисел = " + count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnLstFromFle_Click(object sender, RoutedEventArgs e)
        {
            LstInput.Items.Clear();
            StreamReader sr = new StreamReader(@"файл.txt", Encoding.UTF8);

            while (!sr.EndOfStream)
            {
                LstInput.Items.Add(sr.ReadLine());
            }
        }
    }
}