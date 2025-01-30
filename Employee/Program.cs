using System;
class Employee
{
    public string EmployeeID{get; }
    public string Name{get; }
    public double salary;
    public double Salary
    
    {
        get {return salary; }
        set
        {
            if (value<0)
            {
                throw new ArgumentException("Invaalid salary amount.");
            }
            salary = value;
        }
    }
    public string Position {get; private set; }
    public Employee(string employeeID, string name, double salary, string position)
    {
        EmployeeID = employeeID;
        Name = name;
        Salary = salary;
        Position = position;
    }
    public void Promote(string newPosition, double newSalary)
    {
        if (newSalary < 0)
        {
            throw new ArgumentException("Invalid saklary amount.");
        }
    }

}

class Program
{
    static void Main()
    {
        Employee emp = new Employee("A123", "Anukesh Byanjankar", 2000, "Intern");
        Console.WriteLine($"EmployeeID: {emp.EmployeeID}");
        Console.WriteLine($"Name: {emp.Name}");
        Console.WriteLine($"Salary: {emp.Salary}");
        Console.WriteLine($"Position: {emp.Position}");
        
        emp.Promote ("Full time worker", 3500);
        Console.WriteLine($"New Position: {emp.Position}");
        Console.WriteLine($"New Salary: {emp.Salary}");
    }
}