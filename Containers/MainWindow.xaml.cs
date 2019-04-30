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
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace Containers
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searcher.Text))
            {
                MessageBox.Show("Введите город");
            }
            else
            {
                string apiKey = "291468a296347eb959d0d25e679ec57a";

                string url = "api.openweathermap.org/data/2.5/forecast/daily?appid=";
                url += apiKey;

                url += searcher.Text;

                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse httpWebResponse = (HttpWebResponse)webRequest.GetResponse();

                using (StreamReader reader = new StreamReader(httpWebResponse.GetResponseStream()))
                {
                    //дописать что класс = JsonConvert.DeserializeObject(reader.ReadToEnd());
                }
            }
        }
    }
}
