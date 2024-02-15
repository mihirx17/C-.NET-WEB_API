using System;

namespace Demo_Constructor_
{
    public class ParaConstructor
    {
        // Member variables
        string Name;
        int age;
        int year;
        string Stream;
        string Company;
        int Phone_Number;

        // Parameterized constructor
        public ParaConstructor(string name, int age, int year, string stream, string company, int phoneNumber)
        {
            Name = name;
            this.age = age;
            this.year = year;
            Stream = stream;
            Company = company;
            Phone_Number = phoneNumber;
        }

        public static void Main(string[] args)
        {
            // Creating an instance of ParaConstructor with parameters
            ParaConstructor instance = new ParaConstructor("Mihir Gupta", 21, 2002, "BCA", "LTIMindtree", 12334);
            Console.WriteLine(instance.Name);
            Console.WriteLine(instance.age);
            Console.WriteLine(instance.year);
            Console.WriteLine(instance.Stream);

            // Creating another instance without parameters
            P
        }
    }
}
