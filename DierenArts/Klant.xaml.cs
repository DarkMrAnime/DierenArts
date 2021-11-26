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
using System.Windows.Shapes;

namespace DierenArts
{
    /// <summary>
    /// Interaction logic for Klant.xaml
    /// </summary>
    public partial class Klant : Window
    {
        DataClasses1DataContext conn = new DataClasses1DataContext();
        public Klant()
        {
            InitializeComponent();
            dgKlant.ItemsSource = conn.Baas.ToList();
        }

        private void BtnAddC_Click(object sender, RoutedEventArgs e)
        {
            string sVn = txtVoornaam.Text;
            string sAn = txtAchternaam.Text;
            string sAd = txtAdress.Text;
            string sPo = txtPostcode.Text;
            string sWo = txtWoon.Text;
            string iPh = txtTel.Text;
            string sMa = txtMail.Text;

            Baa klant = new Baa();
            klant.Voornaam = sVn;
            klant.Achternaam = sAn;
            klant.Adress = sAd;
            klant.Postcode = sPo;
            klant.Woonplaats = sWo;
            klant.Telefoon = Convert.ToInt32(iPh);
            klant.Email = sMa;

            conn.Baas.InsertOnSubmit(klant);
            conn.SubmitChanges();

            dgKlant.ItemsSource = conn.Baas.ToList();
        }

        private void dgKlant_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
