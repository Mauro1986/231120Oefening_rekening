using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _231120Oefening_rekening.Models
{
    public class Rekening
    {
        private string rekeningnummer;

        public string Rekeningnummer
        {
            get { return rekeningnummer; }
            set
            {
                if (value.Length != 12)
                {
                    Console.WriteLine("Rekeningnummer is niet geldig");
                }
                else
                {
                    rekeningnummer = value;
                }
            }
        }
        public double Saldo { get; set; }

        public DateTime creatieDatum;
        public DateTime CreatieDatum
        {
            get { return creatieDatum; }
            set 
            {
                if (value.Year < 1990)
                {
                    Console.WriteLine("Creatie datum niet geldig(<1990)");
                }
                else
                {
                    creatieDatum = value;
                }
            }
        }

        public Rekening(string rekeningnummer, double saldo, DateTime creatieDatum)
        {
            Rekeningnummer = rekeningnummer;
            Saldo = saldo;
            CreatieDatum = creatieDatum;
        }

        public void Afbeelden()
        {
            Console.WriteLine($"Rekeningnummer {Rekeningnummer}");
            Console.WriteLine($"Saldo {Saldo}");
            Console.WriteLine($"CreatieDatum {CreatieDatum}");
        }

        public void Storten(double bedrag)
        {
            
            Saldo = Saldo + bedrag;

        }

        public override string ToString()
        {
            return $"Rekeningnummer:{Rekeningnummer}  Saldo:{Saldo}  Creatiedatum:{CreatieDatum.ToShortDateString()}";
        }
    }   
}
