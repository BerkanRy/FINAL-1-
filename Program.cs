using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int zemin = 20; // m
            int kova = 0;   // m
            double su = 5;           // lt 
            double kaybedilenSu = 0; // lt
                                     // kovayi yukari cekerken

            for (zemin = 20; kova <= zemin; kova++)
            {
                // +1m => su -%0.1
                kaybedilenSu = su * 0.001;
                su = su - kaybedilenSu;
            }
            Console.Write(su);
        }
    }
}
   

