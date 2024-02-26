using FormatDemo;

// PersonModel person = new()
// {
//     Title = "Mr",
//     FirstName = "Nicolas",
//     MiddleName = "NotTelling",
//     LastName = "Cruz"
// };

// Console.WriteLine(person);
// Console.WriteLine(person.ToString("FLL"));
// Console.WriteLine(person.ToString("LL, T FF M."));
// Console.WriteLine(person.ToString("T FF MM LL"));

EmployeeModel employee = new()
{
    FirstName = "TIM",
    MiddleName = "NotTelling",
    LastName = "Corey"
};

Console.WriteLine(employee);
Console.WriteLine(employee.ToString("G"));
Console.WriteLine(employee.ToString("SORTABLE"));
Console.WriteLine(employee.ToString("LOGIN"));
Console.WriteLine(employee.ToString("L"));