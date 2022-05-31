using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Proiect_1.Entities
{
    public class Ruta
    {
        public string PunctPlecare { get; set; }
        public string PunctSosire { get; set; }
        public double Distanta { get; set; }
        public string Durata { get; set; }
        public DateTime DataPlecare { get; set; }
        public DateTime DataSosire { get; set; }
    }
}
