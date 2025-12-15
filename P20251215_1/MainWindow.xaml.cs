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
using NUnit.Framework;
using NUnit;

namespace P20251215_1
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

        public void szamol_Click(object sender, RoutedEventArgs e)
        {
            DateTime date = DateTime.Now;
            szulev.Content = $"Születési éved:  {date.Year - Convert.ToInt16(eletkor.Text)}";

        }
        [TestClass]
        public class test
        {
            [TestMethod]
            public void Test()
            {
                Assert.Equals  (100, 100);
            }
        }
    }
}
