using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Machine.BL
{


    public class machine
    {

        public string MachineName { get; set; }

        public string MachineType { get; set; }
        public string MachineLocation { get; set; }
        public int? FrequencyOfUse { get; set; }
        public int? InjurySeverity { get; set; }
        public int? ProbablityOfInjury { get; set; }

        public string MachineDescription
        {
            get
            {
                string machineDescription = MachineName;
                if (!string.IsNullOrWhiteSpace(MachineType))
                {
                    if (!string.IsNullOrWhiteSpace(machineDescription))
                    {
                        machineDescription += ":";
                    }

                    machineDescription += MachineType;
                }

                return machineDescription;
            }
        }

        public static void GetMachineInfo()
        {
            var machine = new machine();

            Console.WriteLine("Enter the machine name: ");
            string MachineName = Console.ReadLine();

            Console.WriteLine("Enter your machine type: ");
            string MachineType = Console.ReadLine();

            Console.WriteLine("Enter your machine location: ");
            string MachineLocation = Console.ReadLine();

            Console.WriteLine("Enter your machine frequency of use: ");
            string FrequencyOfUse = (Console.ReadLine());

            Console.WriteLine("Enter your machine potential injury severity: ");
            string InjurySeverity = (Console.ReadLine());

            Console.WriteLine("Enter your machine probability of injury: ");
            string ProbablityOfInjury = (Console.ReadLine());

            AddRecord(MachineName, MachineType, MachineLocation, FrequencyOfUse, InjurySeverity, ProbablityOfInjury);

        }



        public static void AddRecord(string MachineName, string MachineType, string Machinelocation, string FrequencyOfUse, string InjurySeverity, string ProbablityOfInjury)
        {

            string filename = @"machinedatabase.txt";

            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, true))
                {
                    file.WriteLine(MachineName + "," + MachineType + "," + Machinelocation + "," + FrequencyOfUse + "," + InjurySeverity + "," + ProbablityOfInjury);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error", ex);
            }

        }
























        // Count the number of machines within our database
        public static int MachineCount { get; set; }

        // Validates that the data 

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(MachineName)) isValid = false;
            if (string.IsNullOrWhiteSpace(MachineLocation)) isValid = false;

            return isValid;

        }



    }
}
    
