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

namespace PokeApi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string path = "https://pokeapi.co/api/v2/pokemon?offset=0&limit=964";

            PokemonApi pokemonInfo = new PokemonApi();

            using (var client = new HttpClient()) //used to connect to a web server
            {
                client.BaseAddress = new Uri(path);
                string json = client.GetStringAsync(path).Result;

                pokemonInfo = JsonConvert.DeserializeObject<PokemonApi>(json);
            }

            foreach (var pokemon in pokemonInfo.results)
            {
                lstPokemon.Items.Add(pokemon);
            }

        }

        private void lstPokemon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedPokemon = (resultObject)lstPokemon.SelectedItem; //this is called casting bc we know that the lst box is made up of result objects

            pokemonObject pokemon;
            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(selectedPokemon.url).Result;

                pokemon = JsonConvert.DeserializeObject<pokemonObject>(json);
            }

            imgSprite.Source = new BitmapImage(new Uri(pokemon.sprite.frontDefault));
        }
    }
}
