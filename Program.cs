using System;

namespace Det_hemliga_talet_del_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Var vänlig att skriv in ett tal mellan 1-100:");// Ber andvändare skirva  in ett tal mellan 1-100    
            double x = Convert.ToDouble(Console.ReadLine());//Konveratera det användare skriver in till en double
            Random randomerare = new Random(); //Ger ett slumpmässig tal.
            int slump_tal = randomerare.Next(1, 101); // int som kommer ge oss ett tal mellan 1-100.
            Console.WriteLine(slump_tal); //skriver ut det slumpmässiga talet så användare kommer se vad det är.
            if (x > slump_tal) // om x (Det talet som användare har skrivit) är större än det det slumpmässiga talet kolla nästa kommentar.
            {
                Console.WriteLine("Det talet du valde var högre!"); //kommer detta skrivas ut.
            }
            else if (x < slump_tal) //om inte alltså att det slumpmässiga talet är större än det talet som användare har skrivit.
            {
                Console.WriteLine("Det slumpmässiga talet är högre! du valde " + x + " och det slumpmässiga talet var " + slump_tal + "!"); //kommer detta skrivas ut. Väljer att ha med både slumptalet samt det talet andvändare skrivit ut lite snyggare touch*/
            }
            else if  (x == slump_tal)
            { //om det skulle vara så att användaren lyckas pricka in det samma tal som det slumptalet kommer
                Console.WriteLine("Grattis! Du pricka rätt!");// detta skrivas ut
            }
            Console.ReadKey();//så programmet inte stängs ner.

        }
    }
}
