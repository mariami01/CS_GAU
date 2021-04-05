using System;
namespace HealthRecords
{
    class HealthProfile
    {
        private int _patientYearOfBirth;
        private string _patientGender;

        public HealthProfile(string fname, string lname, int yob, string gender, float height, float weight)
        {
            PatientFirstName = fname;
            PatientLastName = lname;
            PatientYearOfBirth = yob;
            PatientGender = gender;
            PatientHeight = height;
            PatientWeight = weight;
        }

        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public float PatientHeight { get; set; }
        public float PatientWeight { get; set; }

        public int PatientYearOfBirth
        {
            get { return _patientYearOfBirth; }
            set
            {
                while (value < 1900 || value > 2021)
                {
                    Console.WriteLine("Invalid Year Of Birth. Please re-enter:");
                    value = Convert.ToInt32(Console.ReadLine());
                }

                _patientYearOfBirth = value;
            }
        }

        public string PatientGender
        {
            get { return _patientGender; }
            set
            {
                while (value.ToUpper() != "M" && value.ToUpper() != "F")
                {
                    Console.WriteLine("Please enter valid gender (M or F)");
                    value = Console.ReadLine();
                }

                _patientGender = value;
            }
        }

        public int Age
        {
            get { return DateTime.Today.Year - PatientYearOfBirth; }
        }

        public int MaxHeartRate
        {
            get { return 220 - Age; }
        }

        public int MaxTargetRate
        {
            get { return (Convert.ToInt32(MaxHeartRate * 0.85)); }
        }

        public int MinTargetRate
        {
            get { return (Convert.ToInt32(MaxHeartRate * 0.5)); }
        }

        public double Bmi
        {
            get { return ((PatientWeight / PatientHeight/ PatientHeight)*10000); }
        }

        public string BmiEvaluation()
        {
            if (Bmi < 18.5)
                return "Underweight";
            else if (Bmi < 25)
                return "Normal";
            else if (Bmi < 30)
                return "Overweight";
            else
                return "Obese";
        }
    }
}
