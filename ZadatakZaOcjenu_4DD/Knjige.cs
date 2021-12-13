using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakZaOcjenu_4DD
{
    public class Knjige
    {

        public string ImePrezimeAutora { get; set; }
             public string NazivKnjige { get; set; }
             public string DatumIzdavanja { get; set; }
             public string IdKnjige { get; set; }
             public string StanjeKnjige { get; set; }

        
        

    }
    public class Program_Knjiz
    {
        static void Main(string[] args) 
        {
            List<Knjige> Knjiga = new List<Knjige>(){
            new Knjige() { IdKnjige =  1, NazivKnjige = "John", DatumIzdavanja = 1898, ImePrezimeAutora = "John Claine", StanjeKnjige = "Odlicno" },
            new Knjige() { IdKnjige =  2, NazivKnjige = "Steve",  DatumIzdavanja = 2176, ImePrezimeAutora = "Steve Jobs", StanjeKnjige = "Lose" },
            new Knjige() { StudentID = 3, NazivKnjige = "Bill",  DatumIzdavanja = 2556, ImePrezimeAutora = "Bill Clinton", StanjeKnjige = "Dobro" },
            new Knjige() { StudentID = 4, NazivKnjige = "Ram" , DatumIzdavanja = 2012, ImePrezimeAutora = "Ram´s cars", StanjeKnjige = "Dobro" },
            new Knjige() { StudentID = 5, NazivKnjige = "Ron" , DatumIzdavanja = 3176, ImePrezimeAutora = "Ron´s aligator", StanjeKnjige = "Dobro" },
            new Knjige() { StudentID = 6, NazivKnjige = "Chris",  DatumIzdavanja = 1723, ImePrezimeAutora = "Chris Hemsworth (The next lighting SpiderMan)", StanjeKnjige = "Odlicno" },
            new Knjige() { StudentID = 7, NazivKnjige = "Donald",DatumIzdavanja = 1976, ImePrezimeAutora = "Donald (The Idiot) Trump", StanjeKnjige = "Lose"  },
        };
        }
    }
}
