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
using WindowsFormsApp_Proiect_1.Repository;

namespace WindowsFormsApp_Proiect_1
{
    public partial class FormAdaugaPasager : Form
    {
        private IPasagerRepository _pasagerRepository;
        public FormAdaugaPasager()
        {
            InitializeComponent();
            _pasagerRepository = new PasagerRepository();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (FormIsValid())
            {


                var pasager = new Pasager();
                pasager.Id = Guid.NewGuid();
                pasager.Nume = NumeTextBox.Text;
                pasager.Prenume = PrenumeTextBox.Text;
                pasager.Mail = MailTextBox.Text;
                _pasagerRepository.Add(pasager);
                Hide();
            }
            else
            {
                MessageBox.Show("Trebuie sa completati toate campurile");
            }

            
        }
        private void SetError(Control control)
        {
            ErrorProvider.SetError(control, String.IsNullOrEmpty(control.Text) ? "Campul trebuie completat" : string.Empty);
        }
        private bool FormIsValid()
        {
            if (string.IsNullOrEmpty(NumeTextBox.Text))
                return false;
            if (string.IsNullOrEmpty(PrenumeTextBox.Text))
                return false;
            if (string.IsNullOrEmpty(MailTextBox.Text))
                return false;
            return true;
        }

        private void Nume_validating(object sender, CancelEventArgs e)
        {
            SetError(NumeTextBox);
        }

        private void Prenume_validating(object sender, CancelEventArgs e)
        {
            SetError(PrenumeTextBox);
        }

        private void Mail_validating(object sender, CancelEventArgs e)
        {
            SetError(MailTextBox);

        }
    }
}
