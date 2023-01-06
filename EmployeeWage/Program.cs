class Program
{
    public const int Full_Time = 1;
    public const int Part_Time = 2;
    public const int Wedge_Rate = 20;
    public const int Working_Days = 20;
    public const int Max_Working_Houors = 100;

    static void Main(string[] args)
    {
        int EmpHours = 0;
        int Total_Hours = 0;
        int Total_Days = 0;
        while (Total_Hours <= Max_Working_Houors && Total_Days <= Working_Days) ;
        {
            Total_Days++;
            Random random = new Random();
            int EmpCheck = random.Next(0, 3);
            switch (EmpCheck)
            {
                case Full_Time:
                    EmpHours = 8;
                    break;
                case Part_Time:
                    EmpHours = 4;
                    break;
                default:
                    EmpHours = 0;
                    break;
            }
            Total_Hours += EmpHours;
            Console.WriteLine("Total Days :" + Total_Days + "Total Hours: " + Total_Hours);
        }
        int EmpWedge = Total_Hours * Wedge_Rate;
        Console.WriteLine("Total Wedge :" + EmpWedge);
    }

}