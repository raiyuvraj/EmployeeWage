using System.Reflection.Metadata;

namespace EmployeeWage
{
    public class Program
    {
        public const int Full_Time = 1;
        public const int Part_Time = 2;
        public const int Rate_Per_Hour = 20;
        public const int Num_Of_Working_Days = 20;
        static void Main(string[] args)
        {
            int empHours = 0;
            int empWage = 0;
            int totalWage = 0;
            for (int day = 0; day < Num_Of_Working_Days; day++)
            {
                Random random = new Random();
                int EmpCheck = random.Next(0, 3);

                switch (EmpCheck)
                {
                    case Full_Time:
                        empHours = 8; break;
                    case Part_Time:
                        empWage = 4; break;
                    default:
                        empHours = 0;
                        break;
                }

                empWage = empHours * Rate_Per_Hour;
                totalWage += empWage;
                Console.WriteLine("Daily Employee Wage: "+empWage);

            }
            Console.WriteLine("Employee Wage for months :" +totalWage);
        }
    }
}