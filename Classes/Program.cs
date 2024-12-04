// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        // Two types of ways to call a class
        
        /* First one we instantiate the class and then call the method/field inside the class
         * not static methods or fields require an instance of the class to be called
         */
        
        var sampleClass = new SampleClass(25);
        sampleClass.NonStaticClassMethod();
        Console.WriteLine($"Some integer input from user: {sampleClass.someIntFromUser}");

        Console.WriteLine("********************************************");
        
        /* Second way is to call the class directly without instantiating the class
          * static methods and fields can be called without an instance of the class
          */
        SampleClass.StaticClassMethod();
        Console.WriteLine(SampleClass.staticClassField);
        
        Console.WriteLine("********************************************");
        
        // Using getters and setters of a class
        
        var sampleClassWithGetterAndSetter = new SampleClassWithGetterAndSetter();
        var input = sampleClassWithGetterAndSetter.SampleInt;
        input = sampleClassWithGetterAndSetter.SampleInt = "100";
        

        if (int.TryParse(input, out var result))
        {
            Console.WriteLine($"{result} is a valid integer");
        } else {
            Console.WriteLine($"{input} is not a valid integer");
        }
        
    }

    public class SampleClass
    {
        // Class fields are declared here
        public string publicClassField = "I am a public class field";
        private string privateClassField = "I am a private class field";
        protected string protectedClassField = "I am a protected class field";

        public static string staticClassField = "I am a static class field";
        public int someIntFromUser;
        
        // Constructor
        public SampleClass(int someInt)
        {
            someIntFromUser = someInt;
        }

        public void NonStaticClassMethod()
        {
            Console.WriteLine(privateClassField);
            Console.WriteLine("I am a non static class method");
        }
        
        public static void StaticClassMethod()
        {
            Console.WriteLine("I am a static class method");
        }
    }
    
    // Class with getter and setter

    public class SampleClassWithGetterAndSetter
    {
        private string sampleInt;
        public string SampleInt
        {
            get => sampleInt;
            set => sampleInt = value;
        }
    }
}