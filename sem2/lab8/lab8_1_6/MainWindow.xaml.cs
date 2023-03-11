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

namespace lab8_1_6
{
    public class Helper
    {
        public static int[] returnRandomArray()
        {
            Random r = new Random();
            int n = 6;
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = r.Next(20);
            }
            return array;
        }
        public static int getMaxNum(int[] array)
        {
            return array.OrderBy(x => x).Reverse().ToArray()[0];
        }
        public static string arrayToText(int[] array)
        {
            string s = "";
            foreach (int i in array)
            {
                s += i.ToString() + " ";
            }
            return s;
        }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int[] ints = Helper.returnRandomArray();
            int max = Helper.getMaxNum(ints);
            richTextBox.Document.Blocks.Add(new Paragraph(new Run(Helper.arrayToText(ints))));
            answer.Document.Blocks.Add(new Paragraph(new Run("Ответ: ")));
            answer.Document.Blocks.Add(new Paragraph(new Run(max.ToString())));

        }
    }
}
