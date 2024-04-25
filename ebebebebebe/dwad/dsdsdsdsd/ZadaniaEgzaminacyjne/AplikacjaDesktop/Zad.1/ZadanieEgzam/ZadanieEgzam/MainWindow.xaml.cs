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

namespace ZadanieEgzam
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string haslo = "";

        private void zatwierdzButton_Click(object sender, RoutedEventArgs e)
        {
            string imie = imieInput.Text;
            string nazwisko = nazwiskoInput.Text;
            string stanowisko = stanowiskoCombobox.Text;

            MessageBox.Show("Dane pracownika: " + imie + " " + nazwisko + " " + stanowisko + ", Hasło: "+ haslo);
            haslo = "";
        }

        private void generujhasloButton_Click(object sender, RoutedEventArgs e)
        {
            int iloscZnakow = Convert.ToInt32(ileznakowInput.Text);
      
            int[] cyfry = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] znakiSpecjalne = { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "+", "-", "=" };
            string[] znakiMaleiDuze = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P" };

            if (maleiwielkieCheckbox.IsChecked == true && cyfryCheckbox.IsChecked == false && znakispecCheckbox.IsChecked == false)
            {
                for (int i = 0; i < iloscZnakow; i++)
                {
                    haslo += znakiMaleiDuze[i];
                }
            }
            else if(maleiwielkieCheckbox.IsChecked == true && cyfryCheckbox.IsChecked == true && znakispecCheckbox.IsChecked == false)
            {
                haslo += cyfry[2].ToString();

                for (int i = 0; i < iloscZnakow - 1; i++)
                {
                    haslo += znakiMaleiDuze[i];
                }
            }
            else if(maleiwielkieCheckbox.IsChecked == true && cyfryCheckbox.IsChecked == true && znakispecCheckbox.IsChecked == true)
            {
                haslo += cyfry[3].ToString();
                haslo += znakiSpecjalne[4];

                for (int i = 0;i < iloscZnakow - 2; i++)
                {
                    haslo += znakiMaleiDuze[i];
                }
            }
            else if (maleiwielkieCheckbox.IsChecked == true && cyfryCheckbox.IsChecked == false && znakispecCheckbox.IsChecked == true)
            {
                haslo += znakiSpecjalne[4];

                for (int i = 0; i < iloscZnakow - 1; i++)
                {
                    haslo += znakiMaleiDuze[i];
                }
            }
            else if (maleiwielkieCheckbox.IsChecked == false && cyfryCheckbox.IsChecked == true && znakispecCheckbox.IsChecked == true)
            {
                haslo += znakiSpecjalne[4];

                for (int i = 0; i < iloscZnakow - 1; i++)
                {
                    haslo += cyfry[i];
                }
            }
            else if (maleiwielkieCheckbox.IsChecked == false && cyfryCheckbox.IsChecked == true && znakispecCheckbox.IsChecked == false)
            {

                for (int i = 0; i < iloscZnakow; i++)
                {
                    haslo += cyfry[i];
                }
            }
            else if (maleiwielkieCheckbox.IsChecked == false && cyfryCheckbox.IsChecked == false && znakispecCheckbox.IsChecked == true)
            {

                for (int i = 0; i < iloscZnakow - 1; i++)
                {
                    haslo += znakiSpecjalne[i];
                }
            }
        }
    }
}
