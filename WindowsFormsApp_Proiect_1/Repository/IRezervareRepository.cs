using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Proiect_1.Entities
{
    public interface IRezervareRepository
    {
        List<Rezervare> GetAll();
        void Delete(Rezervare rezervare);
        void Add(Rezervare rezervare);

    }
}
