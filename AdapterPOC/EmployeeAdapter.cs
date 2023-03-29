namespace AdapterPOC;

public class EmployeeAdapter : ITarget
{
    private readonly ThirdPartyBillingSystem _thirdPartyBillingSystem;

    public EmployeeAdapter(ThirdPartyBillingSystem thirdPartyBillingSystem)
    {
        _thirdPartyBillingSystem = thirdPartyBillingSystem;
    }
    //The following will accept the employees in the form of string array
    //Then convert the employee string array to List of Employees
    //After conversation, it will call the Adaptee's Method to Process the Salaries
    public void ProcessCompanySalary(string[,] employeesArray)
    {
        var listEmployee = Enumerable.Range(0, employeesArray.GetLength(0))
            .Select(i => new Employee {
                Id = Convert.ToInt32(employeesArray[i, 0]),
                Name = employeesArray[i, 1], 
                Designation = employeesArray[i, 2],
                Salary = Convert.ToDecimal(employeesArray[i, 3])
            }).ToList();
        Console.WriteLine("Adapter converted Array of Employee to List of Employee");
        Console.WriteLine("Then delegate to the ThirdPartyBillingSystem for processing the employee salary\n");
        _thirdPartyBillingSystem.ProcessSalary(listEmployee);
    }
}