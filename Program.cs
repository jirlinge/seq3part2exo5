using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("renseignez un mois");
            string month =  Console.ReadLine().ToLowerInvariant();

            switch (month)
            {
                case ("decembre"):
                case ("janvier"):
                case ("fevrier"):
                    Console.WriteLine("la saison du mois est l'hiver");
                    break;
                case ("mars"):
                case ("avril"):
                case ("mai"):
                    Console.WriteLine("la saison du mois est le printemps");
                    break;
                case ("juin"):
                case ("juillet"):
                case ("aout"):
                    Console.WriteLine("la saison du mois est l'été");
                    break;
                case ("septembre"):
                case ("octobre"):
                case ("novembre"):
                    Console.WriteLine("la saison du mois est l'automne");
                    break;
                default:
                    Console.WriteLine("ce que vous avez tapé n'est pas un mois");
                    break;


            }
        }
    }
}

