using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

{
    static void Main(string[] args)
    {
        EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
        EmpWageBuilderObject Reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
        dMart.computeEmpWage();
        Console.WriteLine(dMart.toString());
        Reliance.computeEmpWage();
        Console.WriteLine(Reliance.toString());
    }
}

public class EmpWageBuilderObject
{
    public const int Is_Full_Time = 1;
    public const int Is_Part_Time = 2;

    private string company;
    private int empRatePerHour;
    private int numOfWorkingDays;
    private int maxHoursPerMonth;
    private int totalEmpWage;

    public EmpWageBuilderObject(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
    {
        this.company = company;
        this.empRatePerHour = empRatePerHour;
        this.numOfWorkingDays = numOfWorkingDays;
        this.maxHoursPerMonth = maxHoursPerMonth;
    }
    public void computeEmpWage()
    {
        int empHrs = 0, empWage = 0, TotalWorkingDays = 0, totalEmpHrs = 0;

        while (totalEmpHrs <= maxHoursPerMonth && TotalWorkingDays < numOfWorkingDays)
        {
            TotalWorkingDays++;
            Random randomObj = new Random();
            int checkPresent = randomObj.Next(0, 3);
            //Console.WriteLine("Random Number is " + checkPresent);

            switch (checkPresent)
            {
                case Is_Full_Time:
                    empHrs = 8;
                    //  Console.WriteLine("Employee is Present");
                    break;

                case Is_Part_Time:
                    empHrs = 4;
                    // Console.WriteLine("Employee is Present");
                    break;

                default:
                    empHrs = 0;
                    // Console.WriteLine("Employee is Absent");
                    break;
            }
            totalEmpHrs += empHrs;
            Console.WriteLine("Days :" + TotalWorkingDays + "EmployeeHrs :" + empHrs);
        }
        int totalEmpWage = totalEmpHrs * empRatePerHour;
        Console.WriteLine("Company Name :- " + company + " And Total Wage Of Emplyoee:" + totalEmpWage);
    }
    public string toString()
    {
        return "Total Emp Wage for Company: " + this.company + " is: " + this.company;
    }
}

