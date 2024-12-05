// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        bool isActive = true;
        bool isIdle = true;
          
        // If Else   
          if (isActive)
          {
            Console.WriteLine("User is active");       
          }
          else
          {
              Console.WriteLine("User is inactive");
          }
      
          // If IfElse Else
          if (isActive)
          {
              Console.WriteLine("User is active");
          } else if (isIdle && isActive)
          {
              Console.WriteLine("User is idle");
          }
          else
          {
              Console.WriteLine("User is inactive");
          }
          
          Console.WriteLine("********************************************");
          // Switch Case
          var userType = "Admin";
          switch (userType)
          {
              case "Admin":
              case "Moderator":
                  Console.WriteLine("User is an Admin or a Moderator");
                  break;    
              case "User":
                  Console.WriteLine("User is a user");
                  break;
              default:
                  Console.WriteLine("User is not an admin or a user");
                  break;
          }
          
          Console.WriteLine("********************************************");
          // While Loop - Executes until condition is false
          int i = 0;
          while (i < 10)
          {
              Console.WriteLine($"i is {i}");
              i++;
          }
          
          Console.WriteLine("********************************************");
          // Do While Loop - Executes atleast once
          int j = 0;
          do
          {
              Console.WriteLine($"j is {j}");
              j++;
          } while (j < 10);
          
          Console.WriteLine("********************************************");
          // For Loop - Executes a specified number of times
          for (int k = 0; k < 10; k++)
          {
              Console.WriteLine($"k is {k}");
          }
          
          Console.WriteLine("********************************************");
          // Foreach Loop - Executes for each item in a collection
          var numbers = new List<int> {1, 2, 3, 4, 5};
          for (var index = numbers.Count; index >= 0; index--)
          {
              int numberToAdd = Convert.ToInt32(Console.ReadLine());
              numbers.Add(numberToAdd);
          }
          foreach (var number in numbers)
          {
              Console.WriteLine($"number is {number}");
          }

    }
}