using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _231120Oefening_rekening.Models
{
    public class ZichtRekening : Rekening
    {
    

        private double maxkrediet;

        public double MaxKrediet
        {
            get { return maxkrediet; }

            set
            {
                if (value < 0)
                {
                    maxkrediet = value;

                }
                else
                {
                    Console.WriteLine("Error: waarde moet negatief zijn");          
                }
            }

        }
        public ZichtRekening(string rekeningnummer, double saldo, DateTime creatieDatum, double maxkrediet) : base(rekeningnummer, saldo, creatieDatum)
        {
            MaxKrediet = maxkrediet;
        }

        public override string ToString()
        {
            return $"Rekeningnummer:{Rekeningnummer}  Saldo:{Saldo}  Creatiedatum:{CreatieDatum.ToShortDateString()} MaxKrediet: {maxkrediet}";
        }

        public new void Storten(double bedrag)
        {
            if ((Saldo + bedrag) < MaxKrediet)
            {
                Console.WriteLine("Bewerking niet uitgevoerd, Je bent over de limiet");
            }
            else
            {
                Saldo = Saldo + bedrag;
            }
        }
    }
}
