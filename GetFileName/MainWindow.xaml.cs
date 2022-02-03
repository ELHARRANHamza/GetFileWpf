using System;
using System.Collections.Generic;
using System.IO;
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

namespace GetFileName
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnGetFileName.Click += BtnGetFileName_Click;
        }

        private void BtnGetFileName_Click(object sender, RoutedEventArgs e)
        {
            var path = @"E:\WPF\BootUsingWebView\WpfApp2\bin\Debug\netcoreapp3.1";
            string[] fileArray = Directory.GetFiles(path);
            SaveFile(@"E:\My\MyTest.txt", fileArray);
        }
        public void SaveFile(string path, string[] files)
        {
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                  foreach(var file in files)
                    {
                        sw.WriteLine(file);
                    }
                }
            }
        }
    }
}
