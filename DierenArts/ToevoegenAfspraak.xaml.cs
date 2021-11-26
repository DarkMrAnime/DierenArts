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
    /// Interaction logic for ToevoegenAfspraak.xaml
    /// </summary>
    public partial class ToevoegenAfspraak : Window
    {
        DataClasses1DataContext conn = new DataClasses1DataContext();
        Dier Beest;
        Time Tijd;
        public ToevoegenAfspraak()
        {
            InitializeComponent();
            cbDier.ItemsSource = conn.Diers.ToList();
            cbTime.ItemsSource = conn.Times.ToList();
            dgAfspraak.ItemsSource = conn.Afspraaks.ToList();
        }

        private void btnAddA_Click(object sender, RoutedEventArgs e)
        {
            //DatePicker Date = dpDate;
            string sSoort = txtSoort.Text;
            Tijd = (Time)cbTime.SelectedItem;
            Beest = (Dier)cbDier.SelectedItem;

            Afspraak Appointment = new Afspraak();
            Appointment.Dier = Beest;
            Appointment.Datum = (DateTime)dpDate.SelectedDate;
            Appointment.Time = Tijd;
            Appointment.AfspraakSoort = sSoort;

            conn.Afspraaks.InsertOnSubmit(Appointment);
            conn.SubmitChanges();

            dgAfspraak.ItemsSource = conn.Afspraaks.ToList();
        }
    }
}
