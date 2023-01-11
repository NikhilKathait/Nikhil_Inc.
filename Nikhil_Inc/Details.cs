class Details
{
    static void Main()
    {
        Employee.OrganizationName = "Nikhil_INC.";

        Employee Emp = new Employee();
        Emp.empdetail();

        Emp.displaydetail();

        Console.WriteLine("do u want to coninue for next employee");

        for (int i = 1; i < 10; i++)
        {
            string y = System.Console.ReadLine();
            if (y == "Yes")
            {
                Emp.empdetail();
                Emp.displaydetail();
                Console.WriteLine("do u want to coninue for next employee");
            }
            else
            {
                break;
            }
        }
        Console.ReadKey();
    }
}