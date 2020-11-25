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
            double kredietInput;
            //Rekening rekening1 = new Rekening("BE3456789123", 1000, new DateTime(1999, 06, 01));

            //Console.WriteLine(rekening1);
            //Console.WriteLine();

            //Console.WriteLine("Hoeveel wilt u storten?");
            //input = Convert.ToDouble(Console.ReadLine());
            //rekening1.Storten(input);
            //Console.WriteLine(rekening1);
            //Console.WriteLine("******************************");


            //SpaarRekening spaarRekening1 = new SpaarRekening("BE1234567891", 0, new DateTime(2001,07,02));
            //Console.WriteLine($"SpraarRekening1:{spaarRekening1}");
            //Console.WriteLine();

            //Console.WriteLine("Hoeveel wilt u storten?");
            //input = Convert.ToDouble(Console.ReadLine());
            //spaarRekening1.Storten(input);
            //Console.WriteLine(spaarRekening1);
            //Console.WriteLine("******************************");

            Console.WriteLine("Kies je max krediet(negatief getal):");
            kredietInput = Convert.ToDouble(Console.ReadLine());

            ZichtRekening zichtRekening1 = new ZichtRekening("BE9876543210", 0, new DateTime(2003, 09, 20), kredietInput);

            Console.WriteLine($"ZichtRekening1:{zichtRekening1}");

            Console.WriteLine();

            Console.WriteLine("Welke bewerking wil je uitvoeren?");
            input = Convert.ToDouble(Console.ReadLine());
            zichtRekening1.Storten(input);
            Console.WriteLine(zichtRekening1);
        }
    }
}
