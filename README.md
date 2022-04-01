# WoW-Personal-Character-Tracker
A simple console app to track your characters in WoW. WIP
The purpose of this app currently is to keep track of all of your World of Warcraft character's progress in a given week. In its current state, it is keeping track of three of my personal wow characters. When clicking "E" for existing at the start, it will populate a list of the added character's. Depending on the character selected, it will pull that character's information up. I'm in the process of adding a feature to say "All" and have the system populate all characters who will have a vault in that week. 
--Application Path--
Add your New Character by pressing "N" (All entries are CASE Sensitive)
View Existing Characters by pressing "E" (All entries are CASE Sensitive)

New Character will Prompt you for character (toon) information in the following Order:
*Name- Put the name of your Character
*Class- Enter the name of your class (This is not restricted to allow this application to work in the case that someone wants to add their spec or for future classes.)
*Race- Enter your characters race (this is not restricted as some people prefer to use nicknames etc. for Races and I want to allow that freedom)

Once doing this you will have the option to add another character or view characters.
When viewing existing characters with Input "E" it will ask which character from the list you want to view.
Enter the number of the character you wish to select and click enter.
This will then prompt to ask you if you wish to Update or View character information.


To update type "U" (all enteries are CASE sensitive)
This will then ask How many Mythic + vaults this character has unlocked
Type any number and press enter to store this data to the respective toon.

It will then ask how many Raid Vaults this character has unlocked.
Type any number and press enter to store this data to the respective toon.

When you press "V" to View (all enteries are CASE sensitive)
THis will display the Vault information for the respective toon and tell you how many days until you can recieve this vault (Days till Tuesday).





*** Intended feature list ***
Calculate and display data based on an external factor (ex: get the current date, and display how many days remaining until some event(found in lines 130-137)

Implement a “master loop” console application where the user can repeatedly enter commands/perform actions, including choosing to exit the program'(Lines 75-159)

Create a dictionary or list, populate it with several values, retrieve at least one value, and use it in your program(lines 52-72)

Read data from an external file, such as text, JSON, CSV, etc and use that data in your application


Future goal 
--- 6 months time --- 
Take this application and turn it into a desktop application or website where this information can be stored and pulled at will by individuals with created accounts.
--- 3 years time ---
This is a long way to look forward, but within three years time I would like to implement this as an addon in CurseForge to be utilized and updated directly by the game. Thus allowing it to send you push notifications on your Desktop, Website, or IN GAME to remind you of things you may need to do on alts that week. Only beginning with a list of which toons you still haven't checked who potentitally have upgrades waiting in their vaults (formally known as weekly-chest).
