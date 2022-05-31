using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp_Proiect_1.DataBase;
using WindowsFormsApp_Proiect_1.Entities;

namespace WindowsFormsApp_Proiect_1.Repository
{
    public class RutaRepository : IRutaRepository
    {
        public List<Ruta> GetAll()
        {
            return FakeDataBase.Rute;
        }
        public void Delete(Ruta ruta)
        {
            FakeDataBase.Rute.Remove(ruta);
        }
       
        public void Add(Ruta ruta)
        {
            FakeDataBase.Rute.Add(ruta);
        }
    }
}
