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
    public partial class FormAdaugaRuta : Form
    {
        private IRutaRepository _rutaRepository;
        public FormAdaugaRuta()
        {
            InitializeComponent();
            _rutaRepository=new RutaRepository();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private DateTimePicker GetPlecareDateTimePicker()
        {
            return PlecareDateTimePicker;
        }

        private void PlecareDateTimePicker_ValueChanged(object sender, EventArgs e, DateTimePicker plecareDateTimePicker)
        {
            DateTime pDate;
            DateTime sDate;
            pDate = plecareDateTimePicker.Value;
            pDate = PlecareDateTimePicker.Value;
            pDate = PlecareDateTimePicker.Value;

            MessageBox.Show("Data de plecare selectata este" + pDate);
            sDate = SosireDateTimePicker.Value;
            MessageBox.Show("Data de sosire selectata este" + sDate);
        }
        private void AdaugareButton2_Click(object sender, EventArgs e)
        {
            if (FormIsValid())
            {
                var ruta = new Ruta();
                ruta.PunctPlecare = PlecareTextBox.Text;
                ruta.PunctSosire = SosireTextBox.Text;
                ruta.Distanta = Convert.ToDouble(DistantaTextBox.Text);
                DateTime pDate;
                DateTime sDate;
                pDate = PlecareDateTimePicker.Value;
                sDate = SosireDateTimePicker.Value;
                ruta.Durata = DurataTextBox.Text;
                ruta.DataPlecare = pDate;
                ruta.DataSosire = sDate;
                _rutaRepository.Add(ruta);

                DialogResult = DialogResult.OK;

                // Hide();
            }
            else
            {
                MessageBox.Show("Formularul este invalid! Punctul Plecarii sau Puncul Sosirii este null!");
            }
        }

        private void PunctPlecare(object sender, CancelEventArgs e)
        {
            SetError(PlecareTextBox);
        }
        private void PunctSosire_validating(object sender, CancelEventArgs e)
        {
            SetError(SosireTextBox);
        }
        private void SetError(Control control)
        {
            errorProvider1.SetError(control,string.IsNullOrEmpty(control.Text)?"Campul nu poate fi gol":string.Empty);
           

        }

        private bool FormIsValid()
        {
            if(string.IsNullOrEmpty(PlecareTextBox.Text))
                return false;
            if (string.IsNullOrEmpty(SosireTextBox.Text))
                return false;
            return true;
        }
        
    }
}
