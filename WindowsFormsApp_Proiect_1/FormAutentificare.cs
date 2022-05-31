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
    public partial class FormAutentificare : Form
    {
        public FormAutentificare()
        {
            InitializeComponent();
        }
        
        private void LogInButton_Click(object sender, EventArgs e)
        {
            if(UserTextBox.Text =="Nume" && PassTextBox1.Text == "1234")
            {
                MessageBox.Show("Te-ai logat cu succes!");
                Hide();
            }
            else
            {
                MessageBox.Show("UserName sau Password gresit! Mai incearca!");
                UserTextBox.Clear();
                PassTextBox1.Clear();
            }
        }

        private void BackButton4_Click(object sender, EventArgs e)
        {
            var addFormPrincipal = new FormPrincipal();
            Hide();
            addFormPrincipal.ShowDialog();
        }
    }
}
