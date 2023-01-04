namespace EmployeeWage
{
    public class Program
    {
        static void Main(string[] args)
        {
            int Full_Time = 1;
            Random random= new Random();
            int EmpCheck = random.Next(0,2);

            if(EmpCheck == 1)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}