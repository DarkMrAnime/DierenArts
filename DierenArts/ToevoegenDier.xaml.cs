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
    /// Interaction logic for ToevoegenDier.xaml
    /// </summary>
    public partial class ToevoegenDier : Window
    {
        DataClasses1DataContext conn = new DataClasses1DataContext();
        Baa Eigenaar;
        public ToevoegenDier()
        {
            InitializeComponent();
            cbBazen.ItemsSource = conn.Baas.ToList();
            dgDier.ItemsSource = conn.Baas_Diers.ToList();
        }

        private void BtnAddD_Click(object sender, RoutedEventArgs e)
        {
            string sNaam = txtNaam.Text;
            string sSoort = txtSoort.Text;
            Eigenaar = (Baa)cbBazen.SelectedItem;

            
            Dier Beest = new Dier();
            Beest.Naam = sNaam;
            Beest.DierSoort = sSoort;

            //conn.Diers.InsertOnSubmit(Beest);
            //conn.SubmitChanges();
            
            //Koppeling van baas met dier
            Baas_Dier koppel = new Baas_Dier();
            koppel.Baa = Eigenaar;
            koppel.Dier = Beest;

            conn.Baas_Diers.InsertOnSubmit(koppel);
            conn.SubmitChanges();

            dgDier.ItemsSource = conn.Diers.ToList();
        }

        private void cbBazen_SelectionChanged()
        {

        }
    }
}
