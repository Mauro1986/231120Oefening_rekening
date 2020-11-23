using _231120Oefening_rekening.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _231120Oefening_rekening
{
    class Program
    {
        static void Main(string[] args)
        {
            double input;

            Rekening rekening1 = new Rekening("BE3456789123", 1000, new DateTime(1999,06,01));

            Console.WriteLine(rekening1);
            Console.WriteLine();

            Console.WriteLine("Hoeveel wilt u storten?");
            input = Convert.ToDouble(Console.ReadLine());
            rekening1.Storten(input);
            Console.WriteLine(rekening1);
            Console.WriteLine("******************************");




        }
    }
}
