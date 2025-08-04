using System;

namespace CSProjectGroup5
{
    public class Patient
    {
        // Private fields
        private string firstName;
        private string lastName;
        private double weight; // in kg
        private double height; // in cm

        // Public properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        // Constructor
        public Patient(string fName, string lName, double w, double h)
        {
            FirstName = fName;
            LastName = lName;
            Weight = w;
            Height = h;
        }

        // Method to determine blood pressure status
        public string GetBloodPressureStatus(int systolic, int diastolic)
        {
            if (systolic < 120 && diastolic < 80)
                return "NORMAL";
            else if (systolic >= 120 && systolic <= 129 && diastolic < 80)
                return "ELEVATED";
            else if ((systolic >= 130 && systolic <= 139) || (diastolic >= 80 && diastolic <= 89))
                return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 1";
            else if ((systolic >= 140 && systolic <= 180) || (diastolic >= 90 && diastolic <= 120))
                return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 2";
            else if (systolic > 180 || diastolic > 120)
                return "HYPERTENSIVE CRISIS - CONSULT YOUR DOCTOR IMMEDIATELY!";
            else
                return "UNABLE TO DETERMINE STATUS - PLEASE CHECK VALUES!";
        }

        // Private method for BMI calculation
        private double CalculateBMI()
        {
            double heightInMeters = Height / 100; // Convert cm to m
            return Weight / (heightInMeters * heightInMeters);
        }

        // Public method to print patient info
        public void PrintPatientInfo(int systolic, int diastolic)
        {
            Console.WriteLine("\n--- Patient Information ---");
            Console.WriteLine($"Full Name: {FirstName} {LastName}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Height: {Height} cm");

            string bpStatus = GetBloodPressureStatus(systolic, diastolic);
            Console.WriteLine($"Blood Pressure Status: {bpStatus}");

            double bmi = CalculateBMI();
            Console.WriteLine($"BMI: {bmi:F2}");

            string bmiStatus = (bmi >= 25.0) ? "Overweight" :
                               (bmi >= 18.5 && bmi <= 24.9) ? "Normal (Healthy Range)" :
                               "Underweight";
            Console.WriteLine($"BMI Status: {bmiStatus}");
            Console.WriteLine("----------------------------\n");
        }
    }
}

