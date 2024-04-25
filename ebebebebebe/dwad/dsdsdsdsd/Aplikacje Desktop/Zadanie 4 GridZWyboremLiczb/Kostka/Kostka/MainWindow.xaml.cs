using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace Kostka
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GenerujSiatke();
        }

        private void GenerujSiatke()
        {
            int liczbaWylosowanadoSumy;
            int sumaLiczbWybranychWGuzikach = 0;

            StackPanel stackPanel = new StackPanel();

            Random rnd = new Random();
            int liczbaDoLabel = rnd.Next(1, 100);
            Label label = new Label();
            label.Content = "Suma: "+ liczbaDoLabel;
            label.FontSize = 20;
            label.HorizontalAlignment = HorizontalAlignment.Center;
            stackPanel.Children.Add(label);

            Grid siatka = new Grid();
            

            for (int i = 0; i < 5; i++)
            {
                siatka.ColumnDefinitions.Add(new ColumnDefinition());
                siatka.RowDefinitions.Add(new RowDefinition());
            }


            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Border obramowka = new Border();
                    obramowka.BorderBrush = Brushes.Black;
                    obramowka.BorderThickness = new Thickness(1);

                    Button guzik = new Button();
                    guzik.Content = rand.Next(1, 101);
                    guzik.Background = Brushes.Moccasin;

                    guzik.Click += (sender, e) =>
                    {
                        guzik.Background = Brushes.Red;
                        sumaLiczbWybranychWGuzikach += Convert.ToInt32(guzik.Content);
                        liczbaWylosowanadoSumy = liczbaDoLabel;

                        if(sumaLiczbWybranychWGuzikach == liczbaWylosowanadoSumy)
                        {
                            MessageBox.Show("Wygrałeś!!");
                        }
                        else if(sumaLiczbWybranychWGuzikach > liczbaWylosowanadoSumy)
                        {
                            MessageBox.Show("Przekroczyłeś wartość sumy!");
                        }
                    };

                    guzik.HorizontalAlignment = HorizontalAlignment.Stretch;
                    guzik.VerticalAlignment = VerticalAlignment.Stretch;

                    obramowka.Child = guzik;

                    Grid.SetRow(obramowka, i);
                    Grid.SetColumn(obramowka, j);
                    

                    siatka.Children.Add(obramowka);
                }
            }

            siatka.Width = 600;
            siatka.Height = 250;

            stackPanel.Children.Add(siatka);

            Content = stackPanel;
        }
    }
}
