using System;

namespace Encapsulation
{
    public class DemoEncap
    {
        private String studentName;             // private variables declared these can only be accessed by public methods of class
        private int studentAge;
        public String Name
        {

            get
            {
                return studentName;
            }

            set
            {
                studentName = value;
            }

        }
        public int Age
        {

            get
            {
                return studentAge;
            }

            set
            {
                studentAge = value;
            }

        }


    } 
    class Program
    {
        static void Main(string[] args)
        {
            DemoEncap obj = new DemoEncap();
            obj.Name = "Ram";
            obj.Age = 23;
            Console.WriteLine("Name: " + obj.Name);
            Console.WriteLine("Age: " + obj.Age);
        }
    }
}
