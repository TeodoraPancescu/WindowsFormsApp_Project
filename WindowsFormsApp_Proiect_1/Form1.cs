using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Proiect_1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void DateButton_Click(object sender, EventArgs e)
        {
            var addFormPasager = new FormPasager();
            Hide();
            addFormPasager.ShowDialog();
            
            
        }

        private void InformatiiButton_Click(object sender, EventArgs e)
        {
            var addFormInformatii= new FormInformatii();
            Hide();
            addFormInformatii.ShowDialog();
        }

        private void VehiculeButton_Click(object sender, EventArgs e)
        {
            var addFormAutovehicule = new FormAutovehicule();
            Hide();
            addFormAutovehicule.ShowDialog();
        }

        private void AutentificareButton_Click(object sender, EventArgs e)
        {
            var addAutentificareForm = new FormAutentificare();
            Hide();
            addAutentificareForm.ShowDialog();

        }
    }
}
