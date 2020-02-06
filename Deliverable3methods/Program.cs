/*
    Author: Thomas Yi
    Date: 2/4/2020
    Comments: This C# Console application code s Deliverable 3: Methods for ISM 4041 
*/
using System;

namespace Methods
{
    public class Program
    {
        string name;
        public void GetName()
        {
            Console.WriteLine("Please Enter Your Name");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "!");
            Console.ReadLine();
        }//end of GetName()

        static void Main()
        {
            Program p = new Program();
            p.GetName();
            Console.ReadLine();
        }//end of static Main()

    }
} // end of namespace