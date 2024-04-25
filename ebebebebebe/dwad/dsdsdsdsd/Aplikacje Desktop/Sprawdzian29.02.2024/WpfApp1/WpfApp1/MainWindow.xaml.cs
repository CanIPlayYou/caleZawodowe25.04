using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textBlockWithTime.Text = (DateTime.Now).ToString();
        }

        class RejestracjaCzasu
        {
            public string imie;
            public string nazwisko;
            public string stanowisko;
            public int czasPrzyjscia;
            public int czasZakonczenia;

            public void ZarejestrujPrzyjscie(string imie, string nazwisko, string stanowisko, TextBlock textBlock)
            {
                textBlock.Text = "Zarejestrowano przyjście: " + imie + " " + nazwisko + " (" + stanowisko + ") o "+ DateTime.Now.ToLongTimeString();
                textBlock.Background = Brushes.Gray;
                textBlock.Foreground = Brushes.White;
                textBlock.Height = 50;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string imie = textBoxImie.Text;
            string nazwisko = textBoxNazwisko.Text;
            string stanowisko = comboBoxStanowisko.Text;
            TextBlock textBlockk = new TextBlock();

            RejestracjaCzasu czas = new RejestracjaCzasu();
            czas.ZarejestrujPrzyjscie(imie, nazwisko, stanowisko, textBlockk);

            gridForTextBlocks.Children.Add(textBlockk);
        }
    }
}
