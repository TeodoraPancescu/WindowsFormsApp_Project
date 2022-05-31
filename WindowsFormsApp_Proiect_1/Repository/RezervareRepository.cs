using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp_Proiect_1.DataBase;
using WindowsFormsApp_Proiect_1.Entities;

namespace WindowsFormsApp_Proiect_1.Repository
{
    public class RezervareRepository : IRezervareRepository
    {
        public void Delete(Rezervare rezervare)
        {
            FakeDataBase.Rezervari.Remove(rezervare);
        }
        public List<Rezervare> GetAll()
        {
            return FakeDataBase.Rezervari;
        }
        public void Add(Rezervare rezervare)
        {
            FakeDataBase.Rezervari.Add(rezervare);
        }
        
        

        
    }
}
