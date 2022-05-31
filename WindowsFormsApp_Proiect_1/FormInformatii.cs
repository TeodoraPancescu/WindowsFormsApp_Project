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
    public partial class FormInformatii : Form
    {
        public FormInformatii()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BackButton2_Click(object sender, EventArgs e)
        {

            var addFormPrincipal = new FormPrincipal();
            Hide();
            addFormPrincipal.ShowDialog();
        }
    }
}
