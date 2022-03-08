using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace PersonalCharacterTracker

{
    class Program
    {
        static void Main(string[] args)
        {
            var character = new Character();
            string userInput;
           do
            {
                Console.WriteLine("Is this a new or existing character in the Character Tracker?");
               userInput = Console.ReadLine();
                
                if (userInput != "new")
                {
                    Console.WriteLine("Please enter your new character's Name then press 'Enter'.");
                    userInput = Console.ReadLine();

                    Console.WriteLine("Please enter your new character's class then press 'Enter'.");
                    userInput = Console.ReadLine();

                    Console.WriteLine("Congrats your new character has been added!");
                    Console.WriteLine("If you would like to add another new character please type 'New'");
                    Console.WriteLine("If you are finished adding characters please type 'Exit' ");
                    userInput = Console.ReadLine();
                    
                    

                } 

            } while (userInput != "exit");
           

            

        } 


        




    }





    
}