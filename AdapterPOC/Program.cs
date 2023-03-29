using AdapterPOC;

string[,] employeesArray = new string[5, 4]
{
    {"101","John","SE","10000"},
    {"102","Smith","SE","20000"},
    {"103","Dev","SSE","30000"},
    {"104","Pam","SE","40000"},
    {"105","Sara","CTO","50000"}
};

Console.WriteLine("HR system passes employee string array to Adapter\n");
var thirdPartyBillingSystem = new ThirdPartyBillingSystem();
ITarget target = new EmployeeAdapter(thirdPartyBillingSystem);
target.ProcessCompanySalary(employeesArray);
Console.Read();