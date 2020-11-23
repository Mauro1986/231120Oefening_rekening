using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _231120Oefening_rekening.Models
{
    class SpaarRekening : Rekening
    {
        private double intrest;

        public double Interst
        {
            get {  return intrest; }


            set { 
            
                }

        }
        public SpaarRekening(string rekeningnummer, double saldo, DateTime creatieDatum) : base(rekeningnummer, saldo, creatieDatum)
        { 
        
        }

    }
}
