using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp_Proiect_1.Entities;

namespace WindowsFormsApp_Proiect_1.Repository
{
    public interface IPasagerRepository
    {
        List<Pasager> GetAll();
        Pasager GetById(Guid id);
        void Add(Pasager pasager);

    }
}
