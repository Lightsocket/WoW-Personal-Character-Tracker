using DocumentFormat.OpenXml.Office2010.ExcelAc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using toon;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.IO;


namespace PersonalCharacterTracker

{
    class Program
    {
        static void Main(string[] args)
        {
            var CSVConfig = new CsvConfiguration(CultureInfo.CurrentCulture);
            using var StreamReader = File.OpenText("ToonTracker.csv");
            using var csvReader = new CsvReader(StreamReader, CSVConfig);
            string GetData;
            var isLineOne = true;
                     List<Toon> toons = new List<Toon>();
                     List<Toon> toonList = toons;
                    /* toonList.Add(new Toon());
                     toonList[0].ToonName = "Lightsocket";
                     toonList[0].ToonClass = "Paladin";
                     toonList[0].ToonRace = "Human";

                     toonList.Add(new Toon());
                    
                     toonList[1].ToonName = "Bic";
                     toonList[1].ToonClass = "Mage";
                     toonList[1].ToonRace = "Void Elf";
                     
                     toonList.Add(new Toon());
                     toonList[2].ToonName = "Popsocket";
                     toonList[2].ToonClass = "Shaman";
                     toonList[2].ToonRace = "Dwarf";

                     toonList.Add(new Toon());
                     toonList[3].ToonName = "Lightspring";
                     toonList[3].ToonClass = "Rogue";
                     toonList[3].ToonRace = "Night Elf";*/
            while(csvReader.Read())
            {
                if (isLineOne == true)
                {
                    isLineOne = false;

                } else 

                {
                    Toon toon = new Toon();
                    string Name;
                    string Class;
                    string Race;
                    csvReader.TryGetField<string>(0, out Name);
                    csvReader.TryGetField<string>(1, out Class);
                    csvReader.TryGetField<string>(2, out Race);
                    toon.ToonName = Name; 
                    toon.ToonClass = Class;
                    toon.ToonRace = Race;  
                    toonList.Add(toon);
                   
                
                }
               
               
                

            }




                
            
           {
                     var toon = new Toon();
                     string userInput;
                     int mvault = 0;
                     int raidvault = 0;
                     string ToonName;
                     string ToonClass;
                     string ToonRace;
                     


                    
                    


                     do
                     {
                         Console.WriteLine("Thank you for using the Too Many Alts character tracker. You can type 'EXIT' at anytime to exit this application.");
                         Console.WriteLine("Please enter 'E' if you are looking for an existing character. Please enter 'N' if you are adding a new character.");
                         userInput = Console.ReadLine();
                         switch (userInput)
                         {
                            case "N":
                            new Toon();
                            break;

                            

                            
                         }

                         if (userInput != "EXIT")
                         {



                             if (userInput != "E")
                             {
                                 toon = new Toon();
                                 Console.WriteLine("Please Enter the name of your new character.");
                                 toon.ToonName = Console.ReadLine();
                                 Console.WriteLine("Please Enter your characters Class using one of the following.");
                                 Console.WriteLine("Warrior, Hunter, Mage, Rogue, Priest, Warlock, Paladin, Druid, Shaman, Monk, Demon Hunter, Death Knight.");
                                 toon.ToonClass = Console.ReadLine();
                                 Console.WriteLine("Please enter your character's race using one of the following.");
                                 Console.WriteLine("Human, Dwarf, Night Elf, Gnome, Draenei, Worgen, Pandaren, Void Elf, Lightforged Draenei, Dark Iron Dwarf, Kultiran, Mechagnome");
                                 Console.WriteLine("Orc, Undead, Tauren, Troll, Blood Elf, Goblin, Nightborne, Highmountain Tauren, Zandalari Troll, Vulpera.");
                                 toon.ToonRace = Console.ReadLine();
                                 Console.WriteLine("Thank you! Your new character " + toon.ToonName + " has been added.");
                                 toonList.Add((Toon)toon);
                                


                             }
                             else
                             {
                                int counter = 1;
                                foreach (Toon character in toonList) 
                                {
                                  Console.WriteLine(counter.ToString() + ", " + character.ToonName + " " + character.ToonRace + " " + character.ToonClass + ".");
                                  counter++;
                                
                                }
                             
                            
                                 

                                 

                                 Console.WriteLine("Which toon from the list above would you Like to view?");                                 
                                 var v = Convert.ToInt32((Console.ReadLine()));


                                 Console.WriteLine("Would you like to view current information for this toon, or update information? Please type 'V' to view or 'U' to update.");
                                 userInput = Console.ReadLine();

                                   if (userInput != "U") 
                                   {
                                     DateTime today = DateTime.Today;
                                     int daysUntilTuesday = ((int)DayOfWeek.Tuesday - (int)today.DayOfWeek + 7) % 7;
                                     DateTime nextTuesday = today.AddDays(daysUntilTuesday);



                                     Console.WriteLine("Okay! " + toonList[v - 1].ToonName + ", has " + mvault + " Mythic + Vaults and " + raidvault + " Raid Vaults available in " + daysUntilTuesday + " days!");



                                   }
                                   else if (userInput != "V")
                                   {
                                     Console.WriteLine("How many Mythic + Vaults has this character unlocked for the week?");
                                     mvault = Convert.ToInt32((Console.ReadLine()));
                                     Console.WriteLine("How many Raid Vaults has this character unlocked for this week?");
                                     raidvault = Convert.ToInt32((Console.ReadLine()));

                                   }






                             }
                         }

                     } while (userInput != "EXIT");










           }                       
               
                              

                 
                

                
             
        }
    } 
}






