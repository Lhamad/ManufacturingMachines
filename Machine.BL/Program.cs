using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Machine.BL
{
    class Program
    {
        static void Main(string[] args)
        {

            bool cont = true;
            while (cont == true)
            {
                Console.Clear();
                Console.WriteLine("Hello, What are you looking to do?");
                Console.WriteLine("1: Add Machine to Database");
                Console.WriteLine("2: Lookup Machine");
                Console.WriteLine("3: Get Machine list");
                string userInput = Console.ReadLine();


                if (userInput == "1" || userInput == "Add Machine to Database")
                {
                    machine.GetMachineInfo();
                }

                else if (userInput == "2" || userInput == "Lookup machine")
                {

                    string filename = @"machinedatabase.txt";

                    Console.WriteLine("Enter the machine you would like to search for name: ");
                    string searchName = Console.ReadLine();

                    Console.WriteLine(string.Join("", readRecord(searchName, filename, 1)));
                    Console.ReadLine();
                }

                else if (userInput == "3" || userInput == "quit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Selection");
                }

            }




        }

        public static void AddRecord(string Name, string Type, string location, string FrequencyOfUse, string InjurySeverity, string ProbablityOfInjury)
        {

            string filename = @"machinedatabase.txt";

            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, true))
                {
                    file.WriteLine(Name + "," + Type + "," + location + "," + FrequencyOfUse + "," + InjurySeverity + "," + ProbablityOfInjury);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error", ex);
            }

        }

        public static string[] readRecord(string searchterm, string filepath, int positionofsearchterm)
        {

            string filename = @"machinedatabase.txt";

            positionofsearchterm--;
            string[] recordnotfound = { "Record not found" };

            try
            {
                string[] lines = System.IO.File.ReadAllLines(filename);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] fields = lines[i].Split(',');
                    if (recordMatches(searchterm, fields, positionofsearchterm))
                    {
                        Console.WriteLine("Record Found");
                        return fields;
                    }
                }

                return recordnotfound;
            }

            catch (Exception ex)
            {
                Console.WriteLine("Record does not exits");
                return recordnotfound;
                throw new ApplicationException("Application cannot find record.", ex);
            }
        }

        public static bool recordMatches(string searchTerm, string[] record, int positionOfSearchTerm)
        {
            if(record[positionOfSearchTerm].Equals(searchTerm))
            {
                return true;
            }

            return false;
        }

    }
}

        
    


