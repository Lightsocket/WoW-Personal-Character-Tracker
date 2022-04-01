using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using toon;


namespace PersonalCharacterTracker

{
    class Program
    {
        static void Main(string[] args)
        {

            List<Toon> toonList = ReadToons();

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
                    PrintOutput();
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



                                Console.WriteLine("Okay! " + toonList[v - 1].ToonName + ", has " + toonList[v - 1].mvault + " Mythic + Vaults and " + toonList[v - 1].raidvault + " Raid Vaults available in " + daysUntilTuesday + " days!");



                            }
                            else if (userInput != "V")
                            {
                                Console.WriteLine("How many Mythic + Vaults has this character unlocked for the week?");
                                toonList[v - 1].mvault = Convert.ToInt32((Console.ReadLine()));
                                Console.WriteLine("How many Raid Vaults has this character unlocked for this week?");
                                toonList[v - 1].raidvault = Convert.ToInt32((Console.ReadLine()));

                            }






                        }
                    }

                } while (userInput != "EXIT");

                WriteToons(toonList);











            }








        }
        public static void WriteToons(List<Toon> toons)
        {
            using (var writer = new StreamWriter("ToonTracker.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(toons);
            }

        }
        public static List<Toon> ReadToons() 
        {
            var CSVConfig = new CsvConfiguration(CultureInfo.CurrentCulture);
            using var StreamReader = File.OpenText("ToonTracker.csv");
            using var csvReader = new CsvReader(StreamReader, CSVConfig);
            string GetData;
            var isLineOne = true;
            List<Toon> toonList = new List<Toon>();

            while (csvReader.Read())
            {
                if (isLineOne == true)
                {
                    isLineOne = false;

                }
                else

                {
                    Toon toon = new Toon();
                    string Name;
                    string Class;
                    string Race;
                    int mvault = 0;
                    int raidvault = 0;
                    csvReader.TryGetField<string>(0, out Name);
                    csvReader.TryGetField<string>(1, out Class);
                    csvReader.TryGetField<string>(2, out Race);
                    csvReader.TryGetField<int>(3, out mvault);
                    csvReader.TryGetField<int>(4, out raidvault);
                    toon.ToonName = Name;
                    toon.ToonClass = Class;
                    toon.ToonRace = Race;
                    toon.mvault = mvault;
                    toon.raidvault = raidvault;

                    toonList.Add(toon);


                }




            }
            StreamReader.Close();
            csvReader.Dispose();
            return toonList;

        }
        public static void PrintOutput()
        {
           Console.WriteLine("Thank you for using Too Many Alts -- Please type 'EXIT' at anytime to exit the appliction.");
        }
    }
}






