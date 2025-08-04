using System;

namespace CSProjectGroupX
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Patient First Name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Patient Last Name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter Patient Weight (in kg):");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Patient Height (in cm):");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Systolic Pressure (upper number):");
            int systolic = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Diastolic Pressure (lower number):");
            int diastolic = Convert.ToInt32(Console.ReadLine());

            // Create Patient object
            Patient patient = new Patient(firstName, lastName, weight, height);

            // Display patient information
            patient.PrintPatientInfo(systolic, diastolic);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
