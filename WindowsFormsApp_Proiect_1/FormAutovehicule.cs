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
    public partial class FormAutovehicule : Form
    {
        int nrPoze = 1;
        public FormAutovehicule()
        {
            InitializeComponent();
            SchimbarePoze(nrPoze);
        }

        
        private void SchimbarePoze(int nrPoze)
        {
            switch (nrPoze)
            {
                case 1:
                    PozeAutovehiculePictureBox.Image = Properties.Resources.electric1;
                    LabelDenumire.Text = "Furia electrica";
                    LabelTip.Text = "Electric";
                    break;
                case 2:
                    PozeAutovehiculePictureBox.Image = Properties.Resources.electric2;
                    LabelDenumire.Text = "The Friend Of Nature";
                    LabelTip.Text = "Electric";
                    break;
                case 3:
                    PozeAutovehiculePictureBox.Image = Properties.Resources.hidrogen1;
                    LabelDenumire.Text = "AutoHidro";
                    LabelTip.Text = "Pe hidrogen";
                    break;
                case 4:
                    PozeAutovehiculePictureBox.Image = Properties.Resources.hidrogen2;
                    LabelDenumire.Text = "HidroBus";
                    LabelTip.Text = "Pe hidrogen";
                    break;
                case 5:
                    PozeAutovehiculePictureBox.Image = Properties.Resources.electric3;
                    LabelDenumire.Text = "ElectraBus";
                    LabelTip.Text = "Electric";
                    break;

            }
        }
        private void PrevButton_Click(object sender, EventArgs e)
        {
            nrPoze -= 1;
            if (nrPoze < 1)
            {
                nrPoze = 5;
            }
            SchimbarePoze(nrPoze);
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            nrPoze += 1;
            if (nrPoze > 6)
            {
                nrPoze = 1;
            }
            SchimbarePoze(nrPoze);
        }

        private void PozeAutovehiculePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void BackButton4_Click(object sender, EventArgs e)
        {
            var addFormPrincipal = new FormPrincipal();
            Hide();
            addFormPrincipal.ShowDialog();
        }
    }
}
