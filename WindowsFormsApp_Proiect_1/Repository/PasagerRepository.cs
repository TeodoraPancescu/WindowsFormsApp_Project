using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp_Proiect_1.DataBase;
using WindowsFormsApp_Proiect_1.Entities;

namespace WindowsFormsApp_Proiect_1.Repository
{
    public class PasagerRepository : IPasagerRepository
    {
        public void Add(Pasager pasager)
        {
            pasager.Id = Guid.NewGuid();
            FakeDataBase.Pasageri.Add(pasager);
        }

        public List<Pasager> GetAll()
        {
            return FakeDataBase.Pasageri;
        }

        
        public Pasager GetById(Guid id)
        { 
            return FakeDataBase.Pasageri.FirstOrDefault(x => x.Id==id);
        }
        
    }
}
