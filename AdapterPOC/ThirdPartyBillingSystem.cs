namespace AdapterPOC;

public class ThirdPartyBillingSystem
{
    //ThirdPartyBillingSystem accepts employee's information as a List to process each employee's salary
    public void ProcessSalary(List<Employee> listEmployee)
    {
        foreach (var employee in listEmployee)
        {
            Console.WriteLine("$" + employee.Salary + " Salary Credited to " + employee.Name + " Account.");
        }
    }
}