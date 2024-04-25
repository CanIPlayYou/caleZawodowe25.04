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

namespace Zadanie1
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

        private void buttonPrzelicz_Click(object sender, RoutedEventArgs e)
        {
            int liczbaPodana = Convert.ToInt32(liczbPodanaTextBox.Text);
            string zJakiejJednost = zJakiejWartosciComboBox.Text;
            string naJakaJednost = naJakaWartoscComboBox.Text;

            //Centymetry: 
            if (zJakiejJednost == "Centymetr" && naJakaJednost == "Centymetr")
            {
                labelWynik.Content = "Wybrano tą samą jednostkę";
            }

            if (zJakiejJednost == "Centymetr" && naJakaJednost == "Metr")
            {
                labelWynik.Content = liczbaPodana.ToString() + "cm = " + (liczbaPodana * 0.01).ToString() + "m";
            }

            if (zJakiejJednost == "Centymetr" && naJakaJednost == "Kilometr")
            {
                labelWynik.Content = liczbaPodana.ToString() + "cm = " + (liczbaPodana * 0.00001).ToString() + "km";
            }

            if (zJakiejJednost == "Centymetr" && naJakaJednost == "Cal(inch)")
            {
                labelWynik.Content = liczbaPodana.ToString() + "cm = "+ (liczbaPodana * 0.39370).ToString()+"in";
            }

            if (zJakiejJednost == "Centymetr" && naJakaJednost == "Stopa(foot)")
            {
                labelWynik.Content = liczbaPodana.ToString() + "cm = " + (liczbaPodana * 0.032808).ToString() + "ft";
            }

                ///
                if (zJakiejJednost == "Centymetr" && naJakaJednost == "Gram")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }
                if (zJakiejJednost == "Centymetr" && naJakaJednost == "Kilogram")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }
                if (zJakiejJednost == "Centymetr" && naJakaJednost == "Uncja(ounce)")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }
                if (zJakiejJednost == "Centymetr" && naJakaJednost == "Funt(pound)")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }


            //Metr:
            if (zJakiejJednost == "Metr" && naJakaJednost == "Centymetr")
            {
                labelWynik.Content = liczbaPodana.ToString() + "m = " + (liczbaPodana * 100).ToString() + "cm";
            }
            if (zJakiejJednost == "Metr" && naJakaJednost == "Metr")
            {
                labelWynik.Content = "Wybrano tą samą jednostkę";
            }
            if (zJakiejJednost == "Metr" && naJakaJednost == "Kilometr")
            {
                labelWynik.Content = liczbaPodana.ToString() + "m = " + (liczbaPodana * 0.001).ToString() + "km";
            }
            if (zJakiejJednost == "Metr" && naJakaJednost == "Cal(inch)")
            {
                labelWynik.Content = liczbaPodana.ToString() + "m = " + (liczbaPodana * 39.370).ToString() + "in";
            }
            if (zJakiejJednost == "Metr" && naJakaJednost == "Stopa(foot)")
            {
                labelWynik.Content = liczbaPodana.ToString() + "m = " + (liczbaPodana * 3.280).ToString() + "ft";
            }
                ///
                if (zJakiejJednost == "Metr" && naJakaJednost == "Gram")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }
                if (zJakiejJednost == "Metr" && naJakaJednost == "Kilogram")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }
                if (zJakiejJednost == "Metr" && naJakaJednost == "Uncja(ounce)")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }
                if (zJakiejJednost == "Metr" && naJakaJednost == "Funt(pound)")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }


            //Kilometr:
            if (zJakiejJednost == "Kilometr" && naJakaJednost == "Centymetr")
            {
                labelWynik.Content = liczbaPodana.ToString() + "km = " + (liczbaPodana * 100000).ToString() + "cm";
            }
            if (zJakiejJednost == "Kilometr" && naJakaJednost == "Metr")
            {
                labelWynik.Content = liczbaPodana.ToString() + "km = "+ (liczbaPodana * 1000).ToString() + "m";
            }
            if (zJakiejJednost == "Kilometr" && naJakaJednost == "Kilometr")
            {
                labelWynik.Content = "Wybrano tą samą jednostkę";
            }
            if (zJakiejJednost == "Kilometr" && naJakaJednost == "Cal(inch)")
            {
                labelWynik.Content = liczbaPodana.ToString() + "km = " + (liczbaPodana * 39370.0787).ToString() + "in";
            }
            if (zJakiejJednost == "Kilometr" && naJakaJednost == "Stopa(foot)")
            {
                labelWynik.Content = liczbaPodana.ToString() + "km = " + (liczbaPodana * 3280.8399).ToString() + "ft";
            }
                ///
                if (zJakiejJednost == "Kilometr" && naJakaJednost == "Gram")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }
                if (zJakiejJednost == "Kilometr" && naJakaJednost == "Kilogram")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }
                if (zJakiejJednost == "Kilometr" && naJakaJednost == "Uncja(ounce)")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }
                if (zJakiejJednost == "Kilometr" && naJakaJednost == "Funt(pound)")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }


            //Cale:
            if (zJakiejJednost == "Cal(inch)" && naJakaJednost == "Centymetr")
            {
                labelWynik.Content = liczbaPodana.ToString() + "in = " + (liczbaPodana * 2.54).ToString() + "cm";
            }
            if (zJakiejJednost == "Cal(inch)" && naJakaJednost == "Metr")
            {
                labelWynik.Content = liczbaPodana.ToString() + "in = " + (liczbaPodana * 0.0254).ToString() + "m";
            }
            if (zJakiejJednost == "Cal(inch)" && naJakaJednost == "Kilometr")
            {
                labelWynik.Content = liczbaPodana.ToString() + "in = "+ (liczbaPodana * 0.00002540000).ToString() + "km";
            }
            if (zJakiejJednost == "Cal(inch)" && naJakaJednost == "Cal(inch)")
            {
                labelWynik.Content = "Wybrano tą samą jednostkę";
            }
            if (zJakiejJednost == "Cal(inch)" && naJakaJednost == "Stopa(foot)")
            {
                labelWynik.Content = liczbaPodana.ToString() + "in = " + (liczbaPodana * 0.0833333333).ToString() + "ft";
            }
                ///
                if (zJakiejJednost == "Cal(inch)" && naJakaJednost == "Gram")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }
                if (zJakiejJednost == "Cal(inch)" && naJakaJednost == "Kilogram")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }
                if (zJakiejJednost == "Cal(inch)" && naJakaJednost == "Uncja(ounce)")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }
                if (zJakiejJednost == "Cal(inch)" && naJakaJednost == "Funt(pound)")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }



            //stopy:
            if (zJakiejJednost == "Stopa(foot)" && naJakaJednost == "Centymetr")
            {
                labelWynik.Content = liczbaPodana.ToString() + "ft = " + (liczbaPodana * 30.48).ToString() + "cm";
            }
            if (zJakiejJednost == "Stopa(foot)" && naJakaJednost == "Metr")
            {
                labelWynik.Content = liczbaPodana.ToString() + "ft = " + (liczbaPodana * 0.3048).ToString() + "m";
            }
            if (zJakiejJednost == "Stopa(foot)" && naJakaJednost == "Kilometr")
            {
                labelWynik.Content = liczbaPodana.ToString() + "ft = " + (liczbaPodana * 0.0003048).ToString() + "km";
            }
            if (zJakiejJednost == "Stopa(foot)" && naJakaJednost == "Cal(inch)")
            {
                labelWynik.Content = liczbaPodana.ToString() + "ft = " + (liczbaPodana * 12).ToString() + "in";
            }
            if (zJakiejJednost == "Stopa(foot)" && naJakaJednost == "Stopa(foot)")
            {
                labelWynik.Content = "Wybrano tą samą jednostkę";
            }
                ///
                if (zJakiejJednost == "Stopa(foot)" && naJakaJednost == "Gram")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }
                if (zJakiejJednost == "Stopa(foot)" && naJakaJednost == "Kilogram")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }
                if (zJakiejJednost == "Stopa(foot)" && naJakaJednost == "Uncja(ounce)")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }
                if (zJakiejJednost == "Stopa(foot)" && naJakaJednost == "Funt(pound)")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }


            //gramy:
            if (zJakiejJednost == "Gram" && naJakaJednost == "Gram")
            {
                labelWynik.Content = "Wybrano tą samą jednostkę";
            }
            if (zJakiejJednost == "Gram" && naJakaJednost == "Kilogram")
            {
                labelWynik.Content = liczbaPodana.ToString() + "g = " + (liczbaPodana * 0.001).ToString() + "kg";
            }
            if (zJakiejJednost == "Gram" && naJakaJednost == "Uncja(ounce)")
            {
                labelWynik.Content = liczbaPodana.ToString() + "g = " + (liczbaPodana * 0.0352739619).ToString() + "oz";
            }
            if (zJakiejJednost == "Gram" && naJakaJednost == "Funt(pound)")
            {
                labelWynik.Content = liczbaPodana.ToString() + "g = " + (liczbaPodana * 0.00220462262).ToString() + "lb";
            }
                ///
                if (zJakiejJednost == "Gram" && naJakaJednost == "Centymetr")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }
                if (zJakiejJednost == "Gram" && naJakaJednost == "Metr")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }
                if (zJakiejJednost == "Gram" && naJakaJednost == "Kilometr")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }
                if (zJakiejJednost == "Gram" && naJakaJednost == "Cal(inch)")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }
                if (zJakiejJednost == "Gram" && naJakaJednost == "Stopa(foot)")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }



            //KILOGRAMY:
            if (zJakiejJednost == "Kilogram" && naJakaJednost == "Gram")
            {
                labelWynik.Content = liczbaPodana.ToString() + "kg = " + (liczbaPodana * 1000).ToString() + "g";
            }
            if (zJakiejJednost == "Kilogram" && naJakaJednost == "Kilogram")
            {
                labelWynik.Content = "Wybrano tą samą jednostkę";
            }
            if (zJakiejJednost == "Kilogram" && naJakaJednost == "Uncja(ounce)")
            {
                labelWynik.Content = liczbaPodana.ToString() + "kg = " + (liczbaPodana * 35.2739619).ToString() + "oz";
            }
            if (zJakiejJednost == "Kilogram" && naJakaJednost == "Funt(pound)")
            {
                labelWynik.Content = liczbaPodana.ToString() + "kg = " + (liczbaPodana * 2.20462262).ToString() + "lb";
            }
                ///
                if (zJakiejJednost == "Kilogram" && naJakaJednost == "Centymetr")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }
                if (zJakiejJednost == "Kilogram" && naJakaJednost == "Metr")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }
                if (zJakiejJednost == "Kilogram" && naJakaJednost == "Kilometr")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }
                if (zJakiejJednost == "Kilogram" && naJakaJednost == "Cal(inch)")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }
                if (zJakiejJednost == "Kilogram" && naJakaJednost == "Stopa(foot)")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }


            //uncje:
            if (zJakiejJednost == "Uncja(ounce)" && naJakaJednost == "Gram")
            {
                labelWynik.Content = liczbaPodana.ToString() + "oz = " + (liczbaPodana * 28.3495231).ToString() + "g";
            }
            if (zJakiejJednost == "Uncja(ounce)" && naJakaJednost == "Kilogram")
            {
                labelWynik.Content = liczbaPodana.ToString() + "oz = " + (liczbaPodana * 0.0283495231).ToString() + "kg";
            }
            if (zJakiejJednost == "Uncja(ounce)" && naJakaJednost == "Uncja(ounce)")
            {
                labelWynik.Content = "Wybrano tą samą jednostkę";
            }
            if (zJakiejJednost == "Uncja(ounce)" && naJakaJednost == "Funt(pound)")
            {
                labelWynik.Content = liczbaPodana.ToString() + "oz = " + (liczbaPodana * 0.0625).ToString() + "lb";
            }
                ///
                if (zJakiejJednost == "Uncja(ounce)" && naJakaJednost == "Centymetr")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }
                if (zJakiejJednost == "Uncja(ounce)" && naJakaJednost == "Metr")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }
                if (zJakiejJednost == "Uncja(ounce)" && naJakaJednost == "Kilometr")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }
                if (zJakiejJednost == "Uncja(ounce)" && naJakaJednost == "Cal(inch)")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }
                if (zJakiejJednost == "Uncja(ounce)" && naJakaJednost == "Stopa(foot)")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }


            //funty:
            if (zJakiejJednost == "Funt(pound)" && naJakaJednost == "Gram")
            {
                labelWynik.Content = liczbaPodana.ToString() + "lb = " + (liczbaPodana * 453.59237).ToString() + "g";
            }
            if (zJakiejJednost == "Funt(pound)" && naJakaJednost == "Kilogram")
            {
                labelWynik.Content = liczbaPodana.ToString() + "lb = " + (liczbaPodana * 0.45359237).ToString() + "kg";
            }
            if (zJakiejJednost == "Funt(pound)" && naJakaJednost == "Uncja(ounce)")
            {
                labelWynik.Content = liczbaPodana.ToString() + "lb = " + (liczbaPodana * 16).ToString() + "oz";
            }
            if (zJakiejJednost == "Funt(pound)" && naJakaJednost == "Funt(pound)")
            {
                labelWynik.Content = "Wybrano tą samą jednostkę";
            }
                ///
                if (zJakiejJednost == "Funt(pound)" && naJakaJednost == "Centymetr")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }
                if (zJakiejJednost == "Funt(pound)" && naJakaJednost == "Metr")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }
                if (zJakiejJednost == "Funt(pound)" && naJakaJednost == "Kilometr")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }
                if (zJakiejJednost == "Funt(pound)" && naJakaJednost == "Cal(inch)")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }
                if (zJakiejJednost == "Funt(pound)" && naJakaJednost == "Stopa(foot)")
                {
                    labelWynik.Content = "Wybrano nieprawidłową jednostkę do przeliczenia";
                }
        }
    }
}
