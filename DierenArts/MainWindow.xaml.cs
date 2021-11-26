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

namespace DierenArts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataClasses1DataContext conn = new DataClasses1DataContext();
        ToevoegenAfspraak Hannes = new ToevoegenAfspraak();
        Klant Jannes = new Klant();
        ToevoegenDier Mannes = new ToevoegenDier();
        public MainWindow()
        {
            InitializeComponent();
            dgAfspraak.ItemsSource = conn.Afspraaks.ToList();
            dgKlanten.ItemsSource = conn.Baas.ToList();
            dgDieren.ItemsSource = conn.Diers.ToList();
        }

        private void BtnAddAfspraak_Click(object sender, RoutedEventArgs e)
        {
            Hannes.Show();
        }

        private void BtnAddKlant_Click(object sender, RoutedEventArgs e)
        {
            Jannes.Show();
        }

        private void BtnAddDier_Click(object sender, RoutedEventArgs e)
        {
            Mannes.Show();
        }

        private void dgAfspraak_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
