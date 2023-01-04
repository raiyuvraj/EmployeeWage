namespace EmployeeWage
{
    public class Program
    {
        static void Main(string[] args)
        {
            int Full_Time = 1;
            int Rate_Per_Hour = 20;
            int empHours = 0;
            int empWage = 0;

            Random random= new Random();
            int EmpCheck = random.Next(0,2);

            if(EmpCheck == Full_Time)
            {
                empHours = 8;
            }
            else
            {
                empHours = 0;
            }

            empWage = empHours * Rate_Per_Hour;
            Console.WriteLine("Daily Employee Wage :" +empWage);
        }
    }
}