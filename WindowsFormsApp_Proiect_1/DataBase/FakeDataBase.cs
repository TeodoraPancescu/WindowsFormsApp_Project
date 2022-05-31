using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp_Proiect_1.Entities;

namespace WindowsFormsApp_Proiect_1.DataBase
{
    public static class FakeDataBase
    {
        public static List<Pasager> Pasageri = new List<Pasager>()
        {
            new Pasager()
            {
                Id=Guid.NewGuid(),
                Nume="Iona",
                Prenume="Mihail",
                Mail="ionaMihail@gmail.com"
            },
            new Pasager()
            {
                Id=Guid.NewGuid(),
                Nume="Pancescu",
                Prenume="Teodora",
                Mail="pancescuteodora20@stud.ase.ro"
            },
            new Pasager()
            {
                Id=Guid.NewGuid(),
                Nume="Popescu",
                Prenume="Emil",
                Mail="popescuemil10@yahoo.com"
            },
            new Pasager()
            {
                Id=Guid.NewGuid(),
                Nume="Marinescu",
                Prenume="Bogdan",
                Mail="bogdanmarinescu@gmail.com"
            },
            new Pasager()
            {
                Id=Guid.NewGuid(),
                Nume="Vintila",
                Prenume="Razvan",
                Mail="VRazvan132@yahoo.com"
            },
            new Pasager()
            {
                Id=Guid.NewGuid(),
                Nume="Andronic",
                Prenume="Andreea",
                Mail="andrandr123@gmail.com"
            },
        };

        public static List<Ruta> Rute = new List<Ruta>()
        {
            new Ruta()
            {
                PunctPlecare="Bacau",
                PunctSosire="Iasi",
                Distanta=127,
                Durata="2 ore",
                DataPlecare=new DateTime(2022,05,08),
                DataSosire=new DateTime(2022,05,08)

            },
             new Ruta()
            {
                PunctPlecare="Adjud",
                PunctSosire="Bucuresti",
                Distanta=228,
                Durata="3 ore si 30 minute",
                DataPlecare = new DateTime(2022, 05, 08),
                DataSosire = new DateTime(2022, 05, 08)
            },
              new Ruta()
            {
                PunctPlecare="Brasov",
                PunctSosire="Cluj",
                Distanta=271.8,
                Durata="4 ore",
                DataPlecare = new DateTime(2022, 04, 06),
                DataSosire = new DateTime(2022, 04, 06)

            },
              new Ruta(){
                PunctPlecare="Constanta",
                PunctSosire="Bucuresti",
                Distanta=224,
                Durata="2 ore si 18 minute",
                DataPlecare = new DateTime(2022, 04, 30),
                DataSosire = new DateTime(2022, 05, 01)
              },
              new Ruta(){
               PunctPlecare="Galati",
                PunctSosire="Timisoara",
                Distanta=224,
                Durata="9 ore si 12 minute",
                DataPlecare = new DateTime(2022, 03, 14),
                DataSosire = new DateTime(2022, 03, 14)
              },
              new Ruta(){
                PunctPlecare="Saru Bucovinei",
                PunctSosire="Sovata",
                Distanta=150,
                Durata="2 ore si 50 minute",
                DataPlecare = new DateTime(2022, 03, 10),
                DataSosire = new DateTime(2022, 03, 10)
              },
        };
        public static List<Rezervare> Rezervari = new List<Rezervare>()
        {
            new Rezervare(){
                Loc=12,
                Pret=40,
                TipulBiletului=TipulBiletului.Standard
            },
            new Rezervare(){
                Loc=23,
                Pret=70,
                TipulBiletului=TipulBiletului.Standard
            },
            new Rezervare(){
                Loc=1,
                Pret=130,
                TipulBiletului=TipulBiletului.VIP
            },
             new Rezervare(){
                Loc=10,
                Pret=100,
                TipulBiletului=TipulBiletului.VIP
            },
            new Rezervare(){
                Loc=36,
                Pret=65,
                TipulBiletului=TipulBiletului.Standard
            },
            new Rezervare(){
                Loc=2,
                Pret=200,
                TipulBiletului=TipulBiletului.VIP
            },
        };
        
    }
}
