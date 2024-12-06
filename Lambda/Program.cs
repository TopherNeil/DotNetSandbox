namespace LambdaProgram;
class Program
{
    static void Main(string[] args)
    {       
        // var listOfNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
        //
        // var listOfOddNumbers = new List<int>();
        //
        #region -- Foreach approach --
        //
        // Console.WriteLine("Using foreach");
        // foreach (var number in listOfNumbers)
        // {
        //     if (number % 2 == 1)
        //     {
        //         listOfOddNumbers.Add(number);
        //     }
        // }
        // Console.WriteLine("List of odd numbers");
        // foreach (var oddNumber in listOfOddNumbers)
        // {
        //     Console.Write($"{oddNumber}, ");
        // }

        #endregion

        #region -- Lambda approach--
        
        // Console.WriteLine("\n******************");
        // Console.WriteLine("Using Lamda");
        // var lamdaOddNumbers = listOfNumbers.Where(number => number % 2 == 1);
        // Console.WriteLine("List of Odd Numbers: ");
        // foreach (var oddNumber in lamdaOddNumbers)
        // {
        //     Console.Write($"{oddNumber}, ");   
        // }
        //
        // // more examples 
        // Console.WriteLine("\n******************");
        // var mixedNames = new[] { "Chon", "Chin", "Chan", "Edwin", "Elsie", "Petericon" };
        // var lambdaNames = mixedNames
        //         .Where(name => name.Length <= 5)
        //         .OrderBy(name => name)
        //         .Select(number => number);
        // foreach (var name in lambdaNames)
        // {
        //     Console.Write($"{name} ");
        // }

        #endregion

        #region -- Lambda and class --

        var companies = new List<Company>
        {
            new Company(){ Name = "Amazon", Age = 25, Type = "Shipping"  },
            new Company(){ Name = "Oracle", Age = 45, Type = "Tech" },
            new Company(){ Name = "Microsoft", Age = 65, Type = "Tech" }
        };

        var employees = new List<Employee>
        {
            new Employee() { Name = "Jeff Bezos", Position = "CEO", Employer = "Amazon", IsRegular = true },
            new Employee() { Name = "Larry Ellison", Position = "CTO", Employer = "Oracle",  IsRegular = true },
            new Employee() { Name = "Bill Gates", Position = "CEO", Employer = "Microsoft", IsRegular = true }
        };

        var lambdaQuery = companies.Join(
            employees.Where(employee => employee.IsRegular),
            company => company.Name,
            employee => employee.Employer,
            (company, employee) => new
            {
                company.Name,
                EmployeeName = employee.Name,
                company.Age,
            } 
            ).OrderBy(company => company.Age).ThenBy(company => company.Name);
        foreach(var companyAndEmployee in lambdaQuery)
        {
            Console.WriteLine($"Company Name: {companyAndEmployee.Name} \nCompany Age: {companyAndEmployee.Age}");
        }
        #endregion

    }
    
}

public class Company
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Type { get; set; }
}

public class Employee
{
    public string Name { get; set; }
    public string Position { get; set; }
    public bool IsRegular { get; set; }
    
    public string Employer { get; set; }
    
}