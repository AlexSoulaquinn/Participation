using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace GOTQuotes
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Quote randomQuote = new Quote();

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync("https://got-quotes.herokuapp.com/quotes").Result;

                randomQuote = JsonConvert.DeserializeObject<Quote>(json);
            }

            txtQuote.Text = randomQuote.quote;
            txtCharacter.Text = randomQuote.character;
        }
    }
}
