using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _231120Oefening_rekening.Models
{
   public class ZichtRekening : Rekening
    {
        private double maxkrediet = -1000;     
       
        public double MaxKrediet
        {
            get { return maxkrediet; }

            set
            {
                if (value > maxkrediet)
                {
                    Console.WriteLine("Het maximum krediet mag niet meer dan 1000 zijn (-1000)");
                }
                else
                {
                   
                    maxkrediet = value;
                }
            }

        }
        public ZichtRekening(string rekeningnummer, double saldo, DateTime creatieDatum) : base(rekeningnummer, saldo, creatieDatum)
        {

        }
    }
}
