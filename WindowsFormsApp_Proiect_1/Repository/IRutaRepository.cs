using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp_Proiect_1.Entities;

namespace WindowsFormsApp_Proiect_1.Repository
{
    public interface IRutaRepository
    {
        List<Ruta> GetAll();
        void Delete(Ruta ruta);
        void Add(Ruta ruta);

    }
}
