#region Character infromation.
using System.Data;
using System.Globalization;

string characterName = "Unknown";
string classChosen = "Unknown";
string startingItem = "Unknown";
#endregion

#region Character stats.
string vig = "0";
string mind = "0";
string end = "0";
string str = "0";
string dex = "0";
string intel = "0";
string faith = "0";
string arc = "0";
#endregion

bool keepLooping = true;

Console.Write("What is your name: ");
characterName = Console.ReadLine();
Console.Clear();

while (keepLooping)
{
    String userResponse = "";
    bool isResponseValid = true;

    Console.WriteLine($"Charcter name: {characterName}");
    Console.WriteLine($"Class Chosen: {classChosen}");
    Console.WriteLine($"Starting Item: {startingItem}");
    Console.WriteLine();
    Console.WriteLine("===STATS===");
    Console.WriteLine($"Vigor: {vig}");
    Console.WriteLine($"Mind: {mind}");
    Console.WriteLine($"Endurance: {end}");
    Console.WriteLine($"Strength: {str}");
    Console.WriteLine($"Dexterity: {dex}");
    Console.WriteLine($"Intelligence: {intel}");
    Console.WriteLine($"Faith: {faith}");
    Console.WriteLine($"Arcane: {arc}");
    Console.WriteLine();
    Console.Write("Would you like to edit this character? (y/n): ");

    while (isResponseValid)
    {
        userResponse = Console.ReadLine();
        

        if (userResponse == "y")
        {
            Console.Clear();
            Console.WriteLine("CHARACTER EDIT");
            Console.WriteLine("1: Name");
            Console.WriteLine("2: Class");
            Console.WriteLine("3: Starting Item");
            Console.WriteLine("4: Stats");
            Console.Write("Select an option that you want to edit: ");

            userResponse = Console.ReadLine();

            if (userResponse == "1")
            {
                Console.Clear();
                Console.WriteLine($"Character name: {characterName}");
                Console.Write("New character name: ");
                characterName = Console.ReadLine();
                Console.Clear();

                if (userResponse == "1")
                {
                    isResponseValid = false;
                }
            }
            else if (userResponse == "2")
            {
                Console.Clear();
                Console.WriteLine("CLASSES");
                Console.WriteLine("1: Astrologer");
                Console.WriteLine("2: Bandit");
                Console.WriteLine("3. Confessor");
                Console.WriteLine("4: Hero");
                Console.WriteLine("5: Prisoner");
                Console.WriteLine("6: Prophet");
                Console.WriteLine("7: Samurai");
                Console.WriteLine("8: Vagabond");
                Console.WriteLine("9: Warrior");
                Console.WriteLine("10: Wretch");
                Console.WriteLine("Please select a class: ");
                
                if(userResponse = "")
                {

                }
                if (userResponse = "")
                {

                }
                if (userResponse = "")
                {

                }
                if (userResponse = "")
                {

                }
                if (userResponse = "")
                {

                }
                if (userResponse = "")
                {

                }
                if (userResponse = "")
                {

                }
                if (userResponse = "")
                {

                }
                if (userResponse = "")
                {

                }
                if (userResponse = "")
                {

                }
                else
                {

                }
            }
            else if (userResponse == "3")
            {

            }
            else if (userResponse == "4")
            {

            }
            else
            {
                isResponseValid = false;
            }
        }
        else if (userResponse == "n")
        {
            isResponseValid = false;

        }
        else
        {
            isResponseValid = false;
        }

    }

    if (userResponse == "n")
    {
        keepLooping = false;
    }
}

#region Final character sheet
Console.WriteLine($"Charcter name: {characterName}");
Console.WriteLine($"Class Chosen: {classChosen}");
Console.WriteLine($"Starting Item: {startingItem}");
Console.WriteLine();
Console.WriteLine("===STATS===");
Console.WriteLine($"Vigor: {vig}");
Console.WriteLine($"Mind: {mind}");
Console.WriteLine($"Endurance: {end}");
Console.WriteLine($"Strength: {str}");
Console.WriteLine($"Dexterity: {dex}");
Console.WriteLine($"Intelligence: {intel}");
Console.WriteLine($"Arcane: {arc}");
Console.WriteLine();
Console.Write("Enjoy your character!");
Console.Clear();
#endregion
