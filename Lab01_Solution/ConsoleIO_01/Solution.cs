using System;

namespace ConsoleIO_01
{
    public static class Solution
    {
        /// <summary>
        ///  Vytvoreni konzolove aplikace, ktera uzivatele postupne vyzve k zadani dvou celych cisel
        /// (prvnim z nich bude zaklad a druhe bude predstavovat exponent, tedy pro 3 a 2 vypise 3^2).
        /// Po zadani obou cisel se provede jejich validace(preferovana je metoda TryParse() ).
        /// V pripade spatneho vstupu program vypise chybovou hlasku a ukonci se.
        /// Pokud je vstup validni, vypisi se obe vstupni cisla i vysledna mocnina ve formatu s
        /// cislicemi oddelenymi carkou po trech (thousand separator): napr: 100^2 = 10000 program vypise 10,000
        /// 
        /// Tip: pro vypocet mocniny lze napriklad vyuzit statickou tridu Math
        /// </summary>
        public static void Task01()
        {
            int baseNum, powerNum;
            Console.WriteLine("Compute power:");
            Console.Write("Base: ");
            string temp1 = Console.ReadLine();
            Console.Write("Exponent: ");
            string temp2 = Console.ReadLine();
            if (int.TryParse(temp1, out baseNum) && int.TryParse(temp2, out powerNum))
            {
                // use standard number (thousand) separator with rounding to 1 decimal digit
                Console.WriteLine($"Result is: {Math.Pow(baseNum, powerNum):0,0}");
            }
            else
            {
                Console.WriteLine("Input is not a number");
            }
            Console.ReadKey();
        }
    }
}
