/*
    Author: Thomas Yi
    Date: 2/4/2020
    Comments: This C# Console application code s Deliverable 3: Methods for ISM 4041 
*/
using System;

namespace Methods_Deliverable_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get input from user
            Console.WriteLine("Please Enter Your Name.");

            // user try-catch to prevent unexpected user input
            try
            {
                // this variable is used to capture what the user has entered.
                string input = Console.ReadLine();
                // this variable is used to record the message after executing the function PrintMessage.
                string message = PrintMessage(input);
                // display the entire message on console
                Console.WriteLine(message);
            } // End of try
            catch
            {
                //display message to let user know what to enter.
                Console.WriteLine("You Must Enter a String Value. Please Exit and Try Again.");
                Console.WriteLine("Press Any Key to Exit the Program and Try Again ...");
                Console.ReadKey(true);
            }

        }
        //create new method to generate the hello message.
        private static string PrintMessage(string get_input)
        {
            // this variable is used to create a new message based on the user input.
            string final_message = "Hello " + get_input + "!";
            // return new message generated.
            return final_message;

        }
    }
}