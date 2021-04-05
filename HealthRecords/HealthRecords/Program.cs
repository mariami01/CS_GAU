using System;

namespace HealthRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your first name? ");
            var fname = Console.ReadLine();
            Console.Write("What is your last name? ");
            var lname = Console.ReadLine();
            Console.Write("What is your year of birth? ");
            var yob = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is your gender? ('M' or 'F') ");
            var gender = Console.ReadLine();
            Console.Write("What is your height in cm? ");
            var height = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is your weight? ");
            var weight = Convert.ToInt32(Console.ReadLine());

            var healthProfile = new HealthProfile(fname, lname, yob, gender, height, weight);

            Console.WriteLine("Name: {0} {1}", healthProfile.PatientFirstName, healthProfile.PatientLastName);
            Console.WriteLine("Year Of Birth: {0}", healthProfile.PatientYearOfBirth);
            Console.WriteLine("Age: {0}", healthProfile.Age);
            Console.WriteLine("Gender: {0}", healthProfile.PatientGender.ToUpper() == "M" ? "Male" : "Female");
            Console.WriteLine("Max safe heart rate: {0}. Workout heart rate target range {1} to {2}",
                        healthProfile.MaxHeartRate, healthProfile.MinTargetRate, healthProfile.MaxTargetRate);
            Console.WriteLine("Height: {0}cm. Weight {1}kg", healthProfile.PatientHeight, healthProfile.PatientWeight);
            Console.WriteLine("BMI: {0:##.##}%, which means you are {1}", healthProfile.Bmi, healthProfile.BmiEvaluation());
            Console.ReadKey();
        }
    }
}
