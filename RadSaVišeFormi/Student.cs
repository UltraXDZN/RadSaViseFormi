using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadSaVišeFormi
{
    public class Student
    {
        string ime;
        string prezime;
        string smjer;
        int brojIndexa;
        DateTime datumRodjenja;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Smjer { get => smjer; set => smjer = value; }
        public int BrojIndexa { get => brojIndexa; set => brojIndexa = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }

        public Student(string ime, string prezime, string smjer, int brojIndexa, DateTime datumRodjenja)
        {
            Ime = ime;
            Prezime = prezime;
            Smjer = smjer;
            BrojIndexa = brojIndexa;
            DatumRodjenja = datumRodjenja;
        }

        public string ShowData()
        {
            return $"{Ime}\t\t{Prezime}\t\t{Smjer}\t\t{BrojIndexa}\t\t{DatumRodjenja}\r\n";
        }
    }
}
