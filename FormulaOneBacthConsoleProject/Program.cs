using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormulaOneDll;

namespace FormulaOneBacthConsoleProject
{
    class Program
    {
        static DbTools db = new DbTools();

        static void Main(string[] args)
        {
            Console.WriteLine("*** FORMULA ONE - BATCH SCRIPTS ***");
            
            char scelta = '\0';
            do
            {
                Menu();
                scelta = Char.ToUpper(Console.ReadKey(true).KeyChar);
                Console.Clear();
                switch (scelta)
                {
                    case '1': CallExecuteSqlScript("CreateCountries"); break;
                    case '2': CallExecuteSqlScript("CreateTeams"); break;
                    case '3': CallExecuteSqlScript("CreateDrivers"); break;
                    case '4': CallExecuteSqlScript("CreateCircuits"); break;
                    case '5': CallExecuteSqlScript("CreateRaces"); break;
                    case '6': CallExecuteSqlScript("CreateRacesScores"); break;
                    case '7': CallExecuteSqlScript("CreateScores"); break;
                    case '0': CallExecuteSqlScript("SetConstraints"); break;
                    case 'A': CallExecuteSqlScript("DropCountries"); break;
                    case 'B': CallExecuteSqlScript("DropTeams"); break;
                    case 'C': CallExecuteSqlScript("DropDrivers"); break;
                    case 'D': CallExecuteSqlScript("DropCircuits"); break;
                    case 'E': CallExecuteSqlScript("DropRaces"); break;
                    case 'F': CallExecuteSqlScript("DropRacesScores"); break;
                    case 'G': CallExecuteSqlScript("DropScores"); break;
                    case 'R': ResetDB(); break;
                    default:
                        Console.WriteLine("Uncorrect Choice - Try Again");
                        break;
                    case 'X': return;
                }
                Console.Write("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
            while (scelta != 'X');
        }

        private static bool CallExecuteSqlScript(string scriptName)
        {
            try
            {
                db.ExecuteSqlScript($"{scriptName}.sql");
                Console.WriteLine($"{scriptName} - SUCCESS.\n");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{scriptName} - {ex.Message}\n");
                return false;
            }
        }

        private static void ResetDB()
        {
            char scelta;
            Console.Write("This operation delete the all Database, are you sure? (Y/n) ");
            scelta = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.Write("\n");
            if (scelta == 'Y')
                try
                {
                    Console.Clear();
                    if (
                        CallExecuteSqlScript("RemoveConstraints") &&
                        CallExecuteSqlScript("DropTeams") &&
                        CallExecuteSqlScript("DropDrivers") &&
                        CallExecuteSqlScript("DropCountries") &&
                        CallExecuteSqlScript("DropCircuits") &&
                        CallExecuteSqlScript("DropRaces") &&
                        CallExecuteSqlScript("DropRacesScores") &&
                        CallExecuteSqlScript("DropScores") &&
                        CallExecuteSqlScript("CreateCountries") &&
                        CallExecuteSqlScript("CreateTeams") &&
                        CallExecuteSqlScript("CreateDrivers") &&
                        CallExecuteSqlScript("CreateCircuits") &&
                        CallExecuteSqlScript("CreateRaces") &&
                        CallExecuteSqlScript("CreateRacesScores") &&
                        CallExecuteSqlScript("CreateScores") &&
                        CallExecuteSqlScript("SetConstraints")
                    )
                        Console.WriteLine("DATABASE Reset completed\n");
                    else
                        throw new Exception();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Sorry, something went wrong. - {ex.Message}");
                }
            else if (scelta == 'N')
                Console.WriteLine("Ok, the Database won't be deleted.");
            else
                Console.WriteLine("Uncorrect choice.");
        }

        private static void Menu()
        {
            Console.WriteLine("1 - CREATE Countries");
            Console.WriteLine("2 - CREATE Teams");
            Console.WriteLine("3 - CREATE Drivers");
            Console.WriteLine("4 - CREATE Circuits");
            Console.WriteLine("5 - CREATE Races");
            Console.WriteLine("6 - CREATE RacesScores");
            Console.WriteLine("7 - CREATE Scores");
            Console.WriteLine("0 - CREATE Constraints");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("A - DROP Countries");
            Console.WriteLine("B - DROP Teams");
            Console.WriteLine("C - DROP Drivers");
            Console.WriteLine("D - DROP Circuits");
            Console.WriteLine("E - DROP Races");
            Console.WriteLine("F - DROP RacesScores");
            Console.WriteLine("G - DROP Scores");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("R - RESET DATABASE");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("X - Exit");
        }
    }
}
