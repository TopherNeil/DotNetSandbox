using LambdaProgram;
class Program
{
    static void Main(string[] args)
    {
        
        var listOfNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

        var listOfOddNumbers = new List<int>();
        
        #region -- foreach --
        // // using foreach to check through the list
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
        

        #region  -- LINQ --
            // LINQ
            // Console.WriteLine("\n******************");
            // Console.WriteLine("Using LINQ");
            // var linqOddNumbers = from number in listOfNumbers where number % 2 == 1 select number;
            // Console.WriteLine("List of Odd Numbers: ");
            // foreach (var oddNumber in linqOddNumbers)
            // {
            //     Console.Write($"{oddNumber}, ");   
            // }
            
            // More examples using LINQ
            // var mixNames = new List<string> { "Chon", "Chin", "Chan", "Edwin", "Elsie", "Petericon" };
            // var linqNames = from name in mixNames
            //     where name.Length < 7
            //     orderby name descending
            //     select name;
            // foreach (var name in linqNames)
            // {
            //     Console.Write($"{name} ");
            // }
            
            #endregion

            #region using LINQ and class

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

            var query = from company in companies
                join employee in employees on company.Name equals employee.Employer
                where (company.Age <= 45 && company.Name.Length <= 6 && employee.IsRegular)
                select new
                {
                    company.Name,
                    EmployeeName = employee.Name
                };

            foreach (var companyAndEmployee in query)
            {
                Console.WriteLine($"Company name: {companyAndEmployee.Name}");
                Console.WriteLine($"Employee Name: {companyAndEmployee.EmployeeName}\n");
                // Console.WriteLine($"Company type: {company.Type}\n");
            }


            #endregion


    }
}