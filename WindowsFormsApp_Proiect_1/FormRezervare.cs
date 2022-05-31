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
using WindowsFormsApp_Proiect_1.Extensions;
using WindowsFormsApp_Proiect_1.Repository;

namespace WindowsFormsApp_Proiect_1
{
    public partial class FormRezervare : Form
    {
        private IRezervareRepository _rezervareRepository;
       
        public FormRezervare()
        {
            InitializeComponent();
            calculSuma();
            _rezervareRepository = new RezervareRepository();
            RezervareDataGridView.AutoGenerateColumns = false;

            RezervareDataGridView.
                AddColumn(0, "Loc", "Loc")
                .AddColumn(1, "Pret", "Pret")
                .AddColumn(2, "Tipul Locului", "TipulBiletului");

          
            RezervareDataGridView.DataSource = _rezervareRepository.GetAll();
        }

        

        private void AdaugareLocButton_Click(object sender, EventArgs e)
        {
            var adaugaRezervare = new FormAdaugaRezervare();
            adaugaRezervare.ShowDialog();
            var data = _rezervareRepository.GetAll();
            RezervareDataGridView.RefreshDataGridView(data)
                .RefreshDataGridView(data);
            calculSuma();
                  
        }
        public void calculSuma()
        {
            double SumaStandard = 0;
            double SumaVIP = 0;
            SumaStandard = FakeDataBase.Rezervari.Where(x => x.TipulBiletului == TipulBiletului.Standard).Sum(x => x.Pret);
            SumaVIP = FakeDataBase.Rezervari.Where(x => x.TipulBiletului == TipulBiletului.VIP).Sum(x => x.Pret);
            StandardSumLabel.Text = Convert.ToString(SumaStandard);
            VIPSumLabel.Text = Convert.ToString(SumaVIP);
        }

        private void BackButton1_Click(object sender, EventArgs e)
        {
            var addFormRuta = new FormRuta();
            Hide();
            addFormRuta.ShowDialog();
        }
    }
}
