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

namespace Bingo
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
            StackPanel stackPanel = new StackPanel();

            Random rnd = new Random();
            int liczbaDoLabel = rnd.Next(1, 100);
            Label label = new Label();
            label.Content = "Wylosowana liczba: " + liczbaDoLabel;
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
                    guzik.Content = rand.Next(1, 100);
                    guzik.Background = Brushes.Moccasin;

                    guzik.Click += (sender, e) =>
                    {
                        if(liczbaDoLabel != Convert.ToInt32(guzik.Content))
                        {
                            MessageBox.Show("Zaznaczona liczba nie zgadza się z wylosowaną liczbą");
                        }
                        else
                        {
                            guzik.Background = Brushes.Red;
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

            Button guzikNext = new Button();
            guzikNext.Content = "Dalej";
            guzikNext.Background = Brushes.Moccasin;
            guzikNext.Width = 150;
            guzikNext.Height = 75;

            guzikNext.Click += (sender, e) =>
            {
                liczbaDoLabel = rnd.Next(1, 100);
                label.Content = "Wylosowana liczba: " + liczbaDoLabel;
            };



            stackPanel.Children.Add(siatka);
            stackPanel.Children.Add(guzikNext);

            Content = stackPanel;
        }
    }
}
