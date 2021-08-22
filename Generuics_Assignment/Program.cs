using System;
using System.Collections.Generic;
using System.Text;


namespace Generuics_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initanilsing generic employee with string data type
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>() { "William", "John", "Tony", "Dave"};

            foreach (string i in employee.Things)
            {
                Console.WriteLine("{0}" , i);
            }

            //Initanilsing generic employee with int data type
            Employee<int> employer = new Employee<int>();
            employer.Things = new List<int>() { 10,9,8,7,6,5,4,3,2,1,0};

            foreach (int i in employer.Things)
            {
                Console.WriteLine("{0}" , i);
            }
        }
    }
}







