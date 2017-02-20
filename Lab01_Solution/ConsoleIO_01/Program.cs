using System;

namespace ConsoleIO_01
{
    class Program
    {
        /// <summary>
        /// Par prikladu pro jednoduchou praci s tridou Console
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //reseni samostatne prace (zadani viz nize)
            //Solution.Task01();
            //return;
            

            // .Write() - bez \n
            Console.WriteLine("Hello World!"); 
            // new line 
            Console.WriteLine();

            // (Pro zajimavost) nastaveni nazvu spousteneho okna konzole
            Console.Title = "Console I/O sample";

            Console.WriteLine("press any key...");
            // Ceka na stisk libovolne klavesy od uzivatele
            Console.ReadKey();

            Console.WriteLine("type any number single digit number...");
            // precte prvni znak ze vstupu, respektive vrati ASCII hodnotu prvniho zadaneho znaku (pro 2 to bude 50)
            int inputChar = Console.Read();
            // proc se nemusi typ int prevadet - .ToString() ?             
            Console.WriteLine(inputChar); 

            // pri pouziti .Read() se do promene inputChar dostane pouze prvni znak, zbytek lze nacist:
            Console.ReadLine();

            Console.WriteLine("type any number again...");
            // precte zadane znaky z konzole (vse az do stisknuti enteru)
            string inputLine = Console.ReadLine();
            // vypsani vstupu (nekontroluje se zda uzivatel opravdu zadal cislo)
            Console.WriteLine(inputLine);

            int number;
            // konverze ze stringu na int, pri neplatnem vstupu vyhazuje vyjimku           
            //int number = int.Parse(inputLine); 
            // bezpecny typ konverze, out je vystupni promena, nemusi byt inicializovana pred vstupem
            bool parseResult = int.TryParse(inputLine, out number); 
            // neuspech
            if (!parseResult)
            {
                // {0} specifikuje pozici hodnoty, ktera se ma vypsat (substituce {0} -> number)
                Console.WriteLine("{0} is not a number !", inputLine);
            }
            else
            {
                // zapis ekvivalentni substituci pomoci spojovani retezcu
                Console.WriteLine(number + " is valid");
            }
            //lze ekvivalentne zapsat ternarnim operatorem
            Console.WriteLine(!parseResult ? "Thats not a number !" : "OK");

            Console.WriteLine("press any key...");
            Console.ReadKey();

            FormattingSamples();
        }

        /// <summary>
        /// CheatSheet pro formaty stringu: http://old.dylanbeattie.net/cheatsheets/dot_net_string_format_cheat_sheet.pdf
        /// </summary>
        private static void FormattingSamples()
        {
            // vypise aktualni datum, viz trida DateTime (podrobnosti o tride: najeti kurzoru nad tridu + stisk klavesy F1)
            Console.WriteLine("DateTime Now: " + DateTime.Now);
            // formatovani data: Monday, February, 2016
            Console.WriteLine("Today is {0:dddd}, {0:MMMM}, {0:yyy}", DateTime.Now);
            // zarovna Hi o 10 znaku doprava (viz druhy argument), zaporna cisla zarovnaji vlevo          
            Console.WriteLine(String.Format("{0, 12}", "Hi"));
            // format vypisujici pouze 2 desetinna mista
            Console.WriteLine("{0:F2}", 12.2218648);
            // ekvivalent, vice info: https://msdn.microsoft.com/en-us/library/0c899ak8(v=vs.110).aspx#Specifier0 
            Console.WriteLine(String.Format("{0:0.00}", 12.2218648));
            // Stejne formatovani s vyuzitim interpolace stringu - C# 6.0 featura)
            Console.WriteLine($"{12.2218648:0.00}");
            Console.WriteLine("press any key...");
            Console.ReadKey();
        }

        /* samostatna prace

        Vytvoreni konzolove aplikace, ktera uzivatele postupne vyzve k zadani dvou celych cisel
        (prvnim z nich bude zaklad a druhe bude predstavovat exponent, tedy pro 3 a 2 vypise 3^2).
        Po zadani obou cisel se provede jejich validace (preferovana je metoda TryParse() ).
        V pripade spatneho vstupu program vypise chybovou hlasku a ukonci se.
        Pokud je vstup validni, vypisi se obe vstupni cisla i vysledna mocnina ve formatu s 
        cislicemi oddelenymi carkou po trech: napr: 100^2 = 10000 program vypise 10,000

        Tip: pro vypocet mocniny lze napriklad vyuzit statickou tridu Math

        */
    }
}
