using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class MainWindow : Window
    {
        public int howMuchChecked = 0;
        public double howMuchCheckedToPercentage = 0.0;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void createItem(string quantity, string name)
        {
            if (quantity != null && name != "")
            {
                listBoxWysw.Items.Add(quantity +" "+ name);
            }
            else
            {
                MessageBox.Show("Błędne dane");
            }
        }

        public void calculateHowMuchItemsPacked()
        {
            howMuchCheckedToPercentage = ((double)howMuchChecked / (double)listBoxWysw.Items.Count) * 100;
            testLabel.Content = $"Masz w swojej liście {listBoxWysw.Items.Count.ToString()} przedmiotów, aktualnie spakowane: {howMuchCheckedToPercentage}%";
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            createItem(itemQuantity.Text, itemName.Text);

            calculateHowMuchItemsPacked();
        }

        private void deleteItem_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            listBoxWysw.Items.Remove(btn.DataContext);

            calculateHowMuchItemsPacked();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            howMuchChecked++;
            calculateHowMuchItemsPacked();
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            howMuchChecked--;
            calculateHowMuchItemsPacked();
        }
    }
}
