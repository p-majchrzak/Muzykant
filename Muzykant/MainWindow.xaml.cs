using System.ComponentModel;
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

namespace Muzykant
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Muzyka> Lista = new List<Muzyka>();
        int licznik = 0;
        public MainWindow()
        {
            InitializeComponent();
            Lista = Odczytaj();
            UstawWyglad(Lista[licznik]);
        }
        public void UstawWyglad(Muzyka muzyka)
        {
            Nazwa.Content = muzyka.Artysta;
            Album.Content = muzyka.Album;
            IloscPobran.Content = muzyka.IloscPobran;
            IloscUtworow.Content = muzyka.IloscPiosenek + " utworów";
            Rok.Content = muzyka.Rok;
        }
        public List<Muzyka> Odczytaj()
        {
            List<Muzyka> lista = new List<Muzyka>();
            StreamReader sr = new StreamReader("Data.txt");
            while(!sr.EndOfStream)
            {
                Muzyka muzyka = new Muzyka(sr.ReadLine(), sr.ReadLine(), int.Parse(sr.ReadLine()), int.Parse(sr.ReadLine()), int.Parse(sr.ReadLine()));
                sr.ReadLine(); //skip line
                lista.Add(muzyka);
            }
            return lista;
        }
        private void Poprzedni_Click(object sender, RoutedEventArgs e)
        {
            licznik--;
            if(licznik >= 0)
            {
                UstawWyglad(Lista[licznik]);
            }
            else
            {
                licznik = Lista.Count-1;
                UstawWyglad(Lista[licznik]);
            }
        }
        private void Nastepny_Click(object sender, RoutedEventArgs e)
        {
            licznik++;
            if (licznik < Lista.Count)
            {
                UstawWyglad(Lista[licznik]);
            }
            else
            {
                licznik = 0;
                UstawWyglad(Lista[licznik]);
            }
        }
        private void Pobierz_Click(object sender, RoutedEventArgs e)
        {
            Lista[licznik].IloscPobran++;
            UstawWyglad(Lista[licznik]);
        }
    }
}