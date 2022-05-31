using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_Proiect_1.DataBase;
using WindowsFormsApp_Proiect_1.Entities;
using WindowsFormsApp_Proiect_1.Repository;

namespace WindowsFormsApp_Proiect_1
{
    public partial class FormAdaugaRezervare : Form
    {
        private IRezervareRepository _rezervareRepository;
        
        public FormAdaugaRezervare()
        {
            InitializeComponent();
            TipComboBox.DataSource = Enum.GetValues(typeof(TipulBiletului));
            _rezervareRepository = new RezervareRepository();
        }

        private void AdaugareButton3_Click(object sender, EventArgs e)
        {
            var nr = LocNumericUpDown1.Value;
            if (FakeDataBase.Rezervari.Any(x => x.Loc == nr))
            {
                MessageBox.Show("Locul a fost deja rezervat!");
            }
            else
            {
                var rezervare = new Rezervare();
                rezervare.Loc = LocNumericUpDown1.Value;
                rezervare.TipulBiletului = (TipulBiletului)TipComboBox.SelectedItem;
                rezervare.Pret = Convert.ToDouble(PretTextBox.Text);
                _rezervareRepository.Add(rezervare);
                Hide();
            }
        }
    }
}
