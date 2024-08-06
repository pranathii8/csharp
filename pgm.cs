using System;
using System.Collections.Generic;
using System.Linq;

public class Employee
{
    // Properties with public visibility
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double CTC { get; set; }
}

public class Operation
{
    // Member variable with default visibility
    private IList<Employee> EmployeeList;

    // Method to add an employee to the list
    public void AddEmployee(Employee employee)
    {
        try
        {
            // Attempt to add employee to the list
            EmployeeList.Add(employee);
        }
        catch (NullReferenceException)
        {
            // Initialize the list if it's null
            EmployeeList = new List<Employee>();
            // Add the employee to the newly initialized list
            EmployeeList.Add(employee);
        }
    }

    // Method to get the highest paid employee
    public Employee GetHighestPaidEmployee()
    {
        // Check if the list is null or empty
        if (EmployeeList == null || !EmployeeList.Any())
        {
            // Throw an exception with a message if the list is null or empty
            throw new InvalidOperationException("Cannot get the highest paid employee");
        }

        // Return the employee with the highest CTC
        return EmployeeList.OrderByDescending(e => e.CTC).FirstOrDefault();
    }
}

// Sample usage
public class Program
{
    public static void Main()
    {
        var operation = new Operation();
        
        // Adding employees
        operation.AddEmployee(new Employee
        {
            Id = 25,
            Name = "John",
            CTC = 560000,
            Department = "R&D"
        });
        operation.AddEmployee(new Employee
        {
            Id = 48,
            Name = "Michal",
            CTC = 860000,
            Department = "Operations"
        });
        operation.AddEmployee(new Employee
        {
            Id = 10,
            Name = "Kerry",
            CTC = 600000,
            Department = "Finance"
        });
        
        // Get the highest paid employee
        try
        {
            var highestPaidEmployee = operation.GetHighestPaidEmployee();
            Console.WriteLine($"Id: {highestPaidEmployee.Id}, Name: {highestPaidEmployee.Name}, Department: {highestPaidEmployee.Department}, CTC: {highestPaidEmployee.CTC}");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
