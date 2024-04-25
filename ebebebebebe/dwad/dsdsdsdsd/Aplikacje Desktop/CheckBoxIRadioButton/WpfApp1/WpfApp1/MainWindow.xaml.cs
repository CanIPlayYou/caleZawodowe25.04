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
            bool isChecked = checkB.IsChecked.GetValueOrDefault();

            /*for(int row = 0; row < 3;  row++)
            {
                for(int col = 0; col < 3; col++)
                {
                    CheckBox checkBox = new CheckBox();
                    checkBox.Content = $"Check {row * 3 + col + 1}";

                }
            }*/
        }

        private void checkB_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checkB_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Color_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            switch(radioButton.Content.ToString())
            {
                case "Czerwony":
                    myLabel.Background = Brushes.Red;
                    break;
                case "Zielony":
                    myLabel.Background= Brushes.Green;
                    break;
                case "Niebieski":
                    myLabel.Background = Brushes.Blue;
                    break;
            }
        }
    }
}
