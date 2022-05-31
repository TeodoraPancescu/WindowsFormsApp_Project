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
    public partial class FormPasager : Form
    {
        private IPasagerRepository _pasagerRepository;
        public FormPasager()
        {
            InitializeComponent();

            _pasagerRepository = new PasagerRepository();
            PasagerDataGridView.AutoGenerateColumns = false;
            PasagerDataGridView
                 .AddColumn(0, "Id", "Id")
                 .AddColumn(1, "Nume", "Nume")
                 .AddColumn(2, "Prenume", "Prenume")
                 .AddColumn(3, "Mail", "Mail");


            PasagerDataGridView.DataSource=_pasagerRepository.GetAll();
           
        }
        
       

        private void BackButton1_Click(object sender, EventArgs e)
        {
            var addFormPrincipal=new FormPrincipal();
            Hide();
            addFormPrincipal.ShowDialog();
        }

        private void AdaugareButton1_Click(object sender, EventArgs e)
        {
            var addAdaugarePasagerForm = new FormAdaugaPasager();
            addAdaugarePasagerForm.ShowDialog();
            var data=_pasagerRepository.GetAll();

            PasagerDataGridView.RefreshDataGridView(data)
                .RefreshDataGridView(data);
        }

       
        private void ContinuareButton_Click(object sender, EventArgs e)
        {
            var addFormRuta = new FormRuta();
            Hide();
            addFormRuta.ShowDialog();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //DialogResult = DialogResult.Cancel;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
