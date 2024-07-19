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

    #region Character Sheet edit 
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
    #endregion

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

                if (userResponse == "1")
                {
                    isResponseValid = false;
                }
            }
            //Class selection
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
                Console.Write("Please select a class: ");
                userResponse = Console.ReadLine();
                Console.Clear();

                //Astrologer
                if (userResponse == "1")
                {
                    classChosen = "Astrologer";
                    vig = "9";
                    mind = "15";
                    end = "9";
                    str = "8";
                    dex = "12";
                    intel = "16";
                    faith = "7";
                    arc = "9";
                }
                //Bandit
                else if (userResponse == "2")
                {
                    classChosen = "Bandit";
                    vig = "10";
                    mind = "11";
                    end = "10";
                    str = "9";
                    dex = "13";
                    intel = "9";
                    faith = "8";
                    arc = "14";
                }
                //Confessor
                else if (userResponse == "3")
                {
                    classChosen = "Confessor";
                    vig = "10";
                    mind = "13";
                    end = "10";
                    str = "12";
                    dex = "12";
                    intel = "9";
                    faith = "14";
                    arc = "9";
                }
                //Hero
                else if (userResponse == "4")
                {
                    classChosen = "Hero";
                    vig = "14";
                    mind = "9";
                    end = "12";
                    str = "16";
                    dex = "9";
                    intel = "7";
                    faith = "8";
                    arc = "11";
                }
                //Prisoner
                else if (userResponse == "5")
                {
                    classChosen = "Prisoner";
                    vig = "11";
                    mind = "12";
                    end = "11";
                    str = "11";
                    dex = "14";
                    intel = "14";
                    faith = "6";
                    arc = "9";
                }
                //Prophet
                else if (userResponse == "6")
                {
                    classChosen = "Prophet";
                    vig = "10";
                    mind = "14";
                    end = "8";
                    str = "11";
                    dex = "10";
                    intel = "7";
                    faith = "16";
                    arc = "10";
                }
                //Samurai
                else if (userResponse == "7")
                {
                    classChosen = "Samurai";
                    vig = "12";
                    mind = "11";
                    end = "13";
                    str = "12";
                    dex = "15";
                    intel = "9";
                    faith = "8";
                    arc = "8";
                }
                //Vagabond
                else if (userResponse == "8")
                {
                    classChosen = "Vagabond";
                    vig = "15";
                    mind = "10";
                    end = "11";
                    str = "14";
                    dex = "13";
                    intel = "9";
                    faith = "9";
                    arc = "7";
                }
                //Warrior
                else if (userResponse == "9")
                {
                    classChosen = "Warrior";
                    vig = "11";
                    mind = "12";
                    end = "11";
                    str = "10";
                    dex = "16";
                    intel = "10";
                    faith = "8";
                    arc = "9";
                }
                //Wretch
                else if (userResponse == "10")
                {
                    classChosen = "Wretch";
                    vig = "10";
                    mind = "10";
                    end = "10";
                    str = "10";
                    dex = "10";
                    intel = "10";
                    faith = "10";
                    arc = "10";
                }
                else
                {
                    isResponseValid = false;
                }
            }
            else if (userResponse == "3")
            {
                Console.Clear();
                Console.WriteLine("This Feature is not yet Implemented.");
                Console.Write("Press enter to continue.");
                userResponse = Console.ReadLine();
                Console.Clear();

                if(userResponse == "")
                {
                    isResponseValid = false;
                }
            }
            else if (userResponse == "4")
            {
                Console.Clear();
                Console.WriteLine("This Feature is not yet Implemented.");
                Console.Write("Press enter to continue.");
                userResponse = Console.ReadLine();
                Console.Clear();

                if (userResponse == "")
                {
                    isResponseValid = false;
                }
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
