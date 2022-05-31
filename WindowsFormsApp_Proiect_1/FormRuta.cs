using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_Proiect_1.Entities;
using WindowsFormsApp_Proiect_1.Extensions;
using WindowsFormsApp_Proiect_1.Repository;

namespace WindowsFormsApp_Proiect_1
{
    public partial class FormRuta : Form
    {
        private IRutaRepository _rutaRepository;
        public FormRuta()
        {
            InitializeComponent();
            _rutaRepository = new RutaRepository();
            RutaDataGridView.AutoGenerateColumns = false;

            RutaDataGridView
                .AddColumn(0, "Punct Plecare", "PunctPlecare")
                .AddColumn(1, "Punct Sosire", "PunctSosire")
                .AddColumn(2, "Distanta", "Distanta")
                .AddColumn(3, "Durata", "Durata")
                .AddColumn(4, "Data Placare", "DataPlecare")
                .AddColumn(5, "Data Sosire", "DataSosire");

            RutaDataGridView.AddButtonColumn("Sterge", "Sterge", string.Empty); 
            RutaDataGridView.DataSource = _rutaRepository.GetAll();
            RutaDataGridView.CellClick += RutaDataGridView_cellClick;

        }

        private void RutaDataGridView_cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == RutaDataGridView.Columns["Sterge"].Index)
            {
                var ruta = (Ruta)RutaDataGridView.CurrentRow.DataBoundItem;
                _rutaRepository.Delete(ruta);
                RutaDataGridView.DataSource = null;
                var data = _rutaRepository.GetAll();
                RutaDataGridView.DataSource = data;
            }
        }

        

        private void AdaugaRutaButton1_Click_1(object sender, EventArgs e)
        {   
            var addFormRuta = new FormAdaugaRuta();
            var result=addFormRuta.ShowDialog();
            
            var data = _rutaRepository.GetAll();
            RutaDataGridView.RefreshDataGridView(data)
                .RefreshDataGridView(data);
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Ruta a fost adaugata cu succes!");
            }
        }
        

        private void ContinuareButton2_Click_1(object sender, EventArgs e)
        {
            var addFormRezervare = new FormRezervare();
            Hide();
            addFormRezervare.ShowDialog();
        }
        private void ContinuareButton2_Click(object sender, EventArgs e)
        {

        }
        private void AdaugaRutaButton1_Click(object sender, EventArgs e)
        {

        }

        private void BackButton1_Click(object sender, EventArgs e)
        {
            var addFormPasager = new FormPasager();
            Hide();
            addFormPasager.ShowDialog();
        }
    }
}
