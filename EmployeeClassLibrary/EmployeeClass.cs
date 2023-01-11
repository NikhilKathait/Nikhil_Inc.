public class Employee
{
    public int EmpID;
    public string EmpName;
    public int SalaryPerHour;
    public int NoOfWorkingHours;
    public int NetSalary;

    public static string OrganizationName;

    public const string TypeOfEmployee = "Contract Based";

    public readonly string DepartmentName;

    public Employee()
    {
        DepartmentName = "Finance Department";
    }

    public void empdetail()

    {

        Console.WriteLine("Entre Emp ID : ");

        EmpID = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Entre Emp Name : ");

        EmpName = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Entre Salary per Hour : ");

        SalaryPerHour = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Entre No. Of Working Hours : ");

        NoOfWorkingHours = Convert.ToInt32(Console.ReadLine());

        NetSalary = Convert.ToInt32(NoOfWorkingHours * SalaryPerHour);

    }

    public void displaydetail()

    {

        Console.WriteLine("Emp Id : " + EmpID);

        Console.WriteLine("Emp name : " + EmpName);

        Console.WriteLine("salary Per Hour :  " + SalaryPerHour);

        Console.WriteLine("No. Of Working hours : " + NoOfWorkingHours);

        Console.WriteLine("Net Salary : " + NetSalary);

        Console.WriteLine("Organizatin Name : " + OrganizationName);

        Console.WriteLine("Type of Employee : " + TypeOfEmployee);

        Console.WriteLine("Department Name : " + DepartmentName);

    }
}