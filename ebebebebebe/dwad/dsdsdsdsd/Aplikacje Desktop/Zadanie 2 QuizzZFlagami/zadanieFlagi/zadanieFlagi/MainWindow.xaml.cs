using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;

namespace zadanieFlagi
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        List<int> liczbaPytan = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int qNum = 0;
        int i;
        int wynik;
        string nazwaGracza = "";

        int koncowyWynik;

        bool isEndedOnce = false;

        public MainWindow()
        {
            InitializeComponent();

            /*DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();*/
        }
        /*void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Content = DateTime.Now.ToLongTimeString();
        }*/

        private void closeAppButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void statsButton_Click(object sender, RoutedEventArgs e)
        {
            statsButton.Visibility = Visibility.Collapsed;
            closeAppButton.Visibility = Visibility.Visible;
            startQuizButton.Visibility = Visibility.Collapsed;
            myCanvas.Visibility = Visibility.Collapsed;
            endGameLabel.Visibility = Visibility.Collapsed;
            statsButton2.Visibility = Visibility.Collapsed;

            mainLabel.Content = "Statystyki";

            if (isEndedOnce)
            {
                restartGameButton.Visibility = Visibility.Visible;
                statsLabel.Visibility = Visibility.Visible;
                statsLabel.Content = "Gracz: " + nazwaGracza + "  ||  Wynik: " + koncowyWynik.ToString() + "/" + liczbaPytan.Count.ToString();
            }
            else
            {
                restartGameButton.Visibility = Visibility.Collapsed;
                statsLabel.Visibility = Visibility.Visible;
                returnFormStatsButton.Visibility = Visibility.Visible;
                statsLabel.Content = "Brak statystyk!";
            }
            
        }

        private void startQuizButton_Click(object sender, RoutedEventArgs e)
        {
            mainLabel.Content = "Jakie państwo symbolizuje ta flaga";
            statsButton.Visibility = Visibility.Collapsed;
            closeAppButton.Visibility = Visibility.Collapsed;
            startQuizButton.Visibility = Visibility.Collapsed;
            returnFormStatsButton.Visibility = Visibility.Collapsed;

            myCanvas.Visibility = Visibility.Visible;

            StartGame();
            NextQuestion();
        }

        private void sprawdzOdpowiedz(object sender, RoutedEventArgs e)
        {
            Button senderButton = sender as Button;

            if(senderButton.Tag.ToString() == "1")
            {
                wynik++;
            }


            if (qNum < 0)
            {
                qNum = 0;
            }
            else
            {
                qNum++;
            }

            scoreText.Content = "Wynik: " + wynik + "/" + liczbaPytan.Count;
            NextQuestion();
        }

        private void NextQuestion()
        {
            
            if (qNum < liczbaPytan.Count)
            {
                i = liczbaPytan[qNum];
            }
            else if(qNum == liczbaPytan.Count)
            {
                mainLabel.Content = "Gratulację!";
                myCanvas.Visibility = Visibility.Collapsed;

                endGameLabel.Content = "Udało ci się zakończyć grę z wynikiem: " + wynik + "/" + liczbaPytan.Count;

                koncowyWynik = wynik;

                endGameLabel.Visibility = Visibility.Visible;
                restartGameButton.Visibility = Visibility.Visible;
                statsButton2.Visibility = Visibility.Visible;
                isEndedOnce = true;
            }
            else
            {
                mainLabel.Content = "Gratulację!";
                myCanvas.Visibility = Visibility.Collapsed;

                endGameLabel.Content = "Udało ci się zakończyć grę z wynikiem: " + wynik + "/" + liczbaPytan.Count;

                koncowyWynik = wynik;

                endGameLabel.Visibility = Visibility.Visible;
                restartGameButton.Visibility = Visibility.Visible;
                statsButton2.Visibility = Visibility.Visible;
                isEndedOnce = true;
            }
            
            foreach (var x in myCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";
            }
            
            
            switch (i)
            {
                case 1:
                    buttonOdpowiedzNr1.Content = "Hiszpania";
                    buttonOdpowiedzNr2.Content = "Aruba";
                    buttonOdpowiedzNr3.Content = "Albania";
                    buttonOdpowiedzNr4.Content = "Argentyna";

                    buttonOdpowiedzNr2.Tag = "1"; 
                    
                    imageShoww.Source = new BitmapImage(new Uri("pack://application:,,,/imgRess/aw.png")); 
                    break;
                case 2:
                    buttonOdpowiedzNr1.Content = "Wyspy Alandzkie";
                    buttonOdpowiedzNr2.Content = "Szwecja";
                    buttonOdpowiedzNr3.Content = "Grecja";
                    buttonOdpowiedzNr4.Content = "Ukraina";

                    buttonOdpowiedzNr1.Tag = "1";
                    
                    imageShoww.Source = new BitmapImage(new Uri("pack://application:,,,/imgRess/ax.png"));
                    break;
                case 3:
                    buttonOdpowiedzNr1.Content = "Wielka Brytania";
                    buttonOdpowiedzNr2.Content = "Stany Zjednoczone";
                    buttonOdpowiedzNr3.Content = "Australia";
                    buttonOdpowiedzNr4.Content = "Monako";

                    buttonOdpowiedzNr3.Tag = "1";

                    imageShoww.Source = new BitmapImage(new Uri("pack://application:,,,/imgRess/au.png"));
                    break;
                case 4:
                    buttonOdpowiedzNr1.Content = "Polska";
                    buttonOdpowiedzNr2.Content = "Portugalia";
                    buttonOdpowiedzNr3.Content = "Wyspy Owcze";
                    buttonOdpowiedzNr4.Content = "Antarktyda";

                    buttonOdpowiedzNr4.Tag = "1";

                    imageShoww.Source = new BitmapImage(new Uri("pack://application:,,,/imgRess/aq.png"));
                    break;
                case 5:
                    buttonOdpowiedzNr1.Content = "Antigua i Barbuda";
                    buttonOdpowiedzNr2.Content = "Krym";
                    buttonOdpowiedzNr3.Content = "Albania";
                    buttonOdpowiedzNr4.Content = "Meksyk";
                    
                    buttonOdpowiedzNr1.Tag = "1";

                    imageShoww.Source = new BitmapImage(new Uri("pack://application:,,,/imgRess/ag.png"));
                    break;
                case 6:
                    buttonOdpowiedzNr1.Content = "Włochy";
                    buttonOdpowiedzNr2.Content = "Hiszpania";
                    buttonOdpowiedzNr3.Content = "Andora";
                    buttonOdpowiedzNr4.Content = "Polska";

                    buttonOdpowiedzNr3.Tag = "1";

                    imageShoww.Source = new BitmapImage(new Uri("pack://application:,,,/imgRess/ad.png"));
                    break;
                case 7:
                    buttonOdpowiedzNr1.Content = "Indonezja";
                    buttonOdpowiedzNr2.Content = "Bahrajn";
                    buttonOdpowiedzNr3.Content = "Malta";
                    buttonOdpowiedzNr4.Content = "Cypr";

                    buttonOdpowiedzNr2.Tag = "1";

                    imageShoww.Source = new BitmapImage(new Uri("pack://application:,,,/imgRess/bh.png"));
                    break;
                case 8:
                    buttonOdpowiedzNr1.Content = "Madagaskar";
                    buttonOdpowiedzNr2.Content = "Mozambik";
                    buttonOdpowiedzNr3.Content = "Jamajka";
                    buttonOdpowiedzNr4.Content = "Burundi";

                    buttonOdpowiedzNr4.Tag = "1";

                    imageShoww.Source = new BitmapImage(new Uri("pack://application:,,,/imgRess/bi.png"));
                    break;
                case 9:
                    buttonOdpowiedzNr1.Content = "Serbia";
                    buttonOdpowiedzNr2.Content = "Chorwacja";
                    buttonOdpowiedzNr3.Content = "Bośnia i Hercegowina";
                    buttonOdpowiedzNr4.Content = "Bułgaria";

                    buttonOdpowiedzNr3.Tag = "1";

                    imageShoww.Source = new BitmapImage(new Uri("pack://application:,,,/imgRess/ba.png"));
                    break;
                case 10:
                    buttonOdpowiedzNr1.Content = "Samoa Amerykańskie";
                    buttonOdpowiedzNr2.Content = "Portoryko";
                    buttonOdpowiedzNr3.Content = "Fidżi";
                    buttonOdpowiedzNr4.Content = "Wyspy Marshalla";

                    buttonOdpowiedzNr1.Tag = "1";

                    imageShoww.Source = new BitmapImage(new Uri("pack://application:,,,/imgRess/as.png"));
                    break;
            }
        }
        private void StartGame()
        {
            myCanvas.Visibility = Visibility.Visible;
            var randomList = liczbaPytan.OrderBy(a => Guid.NewGuid()).ToList();
            
            liczbaPytan = randomList;
        }

        private void restartGameButton_Click(object sender, RoutedEventArgs e)
        {
            wynik = 0;
            qNum = 0;
            i = 0;

            scoreText.Content = "Wynik: " + wynik + "/" + liczbaPytan.Count;

            restartGameButton.Visibility = Visibility.Collapsed;
            endGameLabel.Visibility = Visibility.Collapsed;
            statsButton2.Visibility = Visibility.Collapsed;
            closeAppButton.Visibility = Visibility.Collapsed;
            statsLabel.Visibility = Visibility.Collapsed;

            NextQuestion();
            StartGame();
            mainLabel.Content = "Jakie państwo symbolizuje ta flaga";
        }

        private void nicknameAccept_Click(object sender, RoutedEventArgs e)
        {
            nazwaGracza = usernameBoxText.Text;

            if(nazwaGracza=="")
            {
                MessageBox.Show("Nie podano nazwy!");
            }
            else
            {
                mainLabel.Visibility = Visibility.Visible;
                startQuizButton.Visibility = Visibility.Visible;
                statsButton.Visibility = Visibility.Visible;
                closeAppButton.Visibility = Visibility.Visible;

                loginFormBorder.Visibility = Visibility.Collapsed;
            }    
        }

        private void returnFormStatsButton_Click(object sender, RoutedEventArgs e)
        {
            mainLabel.Visibility = Visibility.Visible;
            startQuizButton.Visibility = Visibility.Visible;
            statsButton.Visibility = Visibility.Visible;
            closeAppButton.Visibility = Visibility.Visible;

            statsLabel.Visibility = Visibility.Collapsed;
            mainLabel.Content = "Quiz o flagach";
        }
    }
}
