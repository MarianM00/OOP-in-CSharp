using System;

namespace Incapsularea
{


    public class DemoIncapsulare
    {

        // private variables declared
        // these can only be accessed by
        // public methods of class
        private String studentName;
        private int studentAge;

        // using accessors to get and 
        // set the value of studentName
        public string Name { get; set; }

        // using accessors to get and 
        // set the value of studentAge
        public int Age { get; set; }


    }
    class Program
    {
        static void Main(string[] args)
        {

            // creating object
            DemoIncapsulare obj = new DemoIncapsulare();

            // calls set accessor of the property Name, 
            // and pass "Ankita" as value of the 
            // standard field 'value'
            obj.Name = "Ankita";

            // calls set accessor of the property Age, 
            // and pass "21" as value of the 
            // standard field 'value'
            obj.Age = 21;

            // Displaying values of the variables
            Console.WriteLine("Name: " + obj.Name);
            Console.WriteLine("Age: " + obj.Age);
        }
    }
}
