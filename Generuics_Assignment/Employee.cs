using System;
using System.Collections.Generic;
using System.Text;


namespace Generuics_Assignment
{
    public class Employee<T>
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public int Id { get; set; }
        //Creating a List that uses generic type Employee when initilized
        public List<T> Things { get; set; }
    }
}


