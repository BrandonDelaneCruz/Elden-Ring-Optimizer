#region Character infromation.
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Transactions;

string characterName = "Unknown";
bool hasNameBeenSet = false;
string classChosen = "Unknown";
bool hasClassBeenSet = false;
string startingItem = "Unknown";
bool hasStartingItemBeenSet = false;
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


#region Starting character sheet
Console.Clear();
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
Console.Write("Press enter to start character creation");
Console.ReadLine();
#endregion

bool isUserCreatingCharacter = true;
while (isUserCreatingCharacter)
{
    string userResponse = "";

    #region ManageCharacterName
    if (hasNameBeenSet == true)
    {
        Console.Clear();
        Console.WriteLine($"Character name: {characterName}");
        Console.WriteLine();
        Console.Write("Would you like to change your characters name (y/n)? ");
        userResponse = Console.ReadLine();

        bool isUserChoosingNewName = true;
        while (isUserChoosingNewName)
        {
            if (userResponse == "y")
            {
                bool isNameCorrect = true;
                while (isNameCorrect)
                {
                    Console.Clear();
                    Console.Write("Enter Characters name: ");
                    characterName = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine($"Character name: {characterName}");
                    Console.WriteLine();
                    Console.Write("Is this name correct (y/n)? ");
                    userResponse = Console.ReadLine();

                    if (userResponse == "y")
                    {
                        isUserChoosingNewName = false;
                        isNameCorrect = false;
                    }
                    else if (userResponse != "y" && userResponse != "n")
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid entry.");
                        Console.WriteLine();
                        Console.Write("Press enter to continue.");
                        Console.ReadLine();
                    }
                }
            }
            else if (userResponse == "n")
            {
                isUserChoosingNewName = false;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid entry.");
                Console.WriteLine();
                Console.Write("Press enter to continue.");
                Console.ReadLine();

                isUserChoosingNewName = false;
            }
        }
    }
    else
    {
        bool isNameCorrect = true;
        while (isNameCorrect)
        {
            Console.Clear();
            Console.Write("Enter Characters name: ");
            characterName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Character name: {characterName}");
            Console.WriteLine();
            Console.Write("Is this name correct (y/n)? ");
            userResponse = Console.ReadLine();

            if (userResponse == "y")
            {
                isNameCorrect = false;
                hasNameBeenSet = true;
            }
            else if (userResponse != "y" && userResponse != "n")
            {
                Console.Clear();
                Console.WriteLine("Invalid entry.");
                Console.WriteLine();
                Console.Write("Press enter to continue.");
                Console.ReadLine();
            }
        }
    }
    #endregion

    #region ManageCharacterClass
    if (hasClassBeenSet == true)
    {
        Console.Clear();
        Console.WriteLine($"Character class: {classChosen}");
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
        Console.Write("Would you like to change your characters class (y/n)? ");
        userResponse = Console.ReadLine();

        bool isUserChoosingNewClass = true;
        while (isUserChoosingNewClass)
        {
            if (userResponse == "y")
            {
                bool isClassCorrect = true;
                while (isClassCorrect)
                {
                    Console.Clear();
                    Console.WriteLine($"Character class: {classChosen}");
                    Console.WriteLine();
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
                    Console.WriteLine();
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
                        Console.Clear();
                        Console.WriteLine("Invalid entry.");
                        Console.WriteLine();
                        Console.Write("Press enter to continue.");
                        Console.ReadLine();
                    }

                    Console.Clear();
                    Console.WriteLine($"Character class: {classChosen}");
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
                    Console.Write("Is this Class correct (y/n)? ");
                    userResponse = Console.ReadLine();

                    if (userResponse == "y")
                    {
                        isUserChoosingNewClass = false;
                        isClassCorrect = false;
                    }
                    else if (userResponse != "n")
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid entry.");
                        Console.WriteLine();
                        Console.Write("Press enter to continue.");
                        Console.ReadLine();
                    }
                }
            }
            else if (userResponse == "n")
            {
                isUserChoosingNewClass = false;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid entry.");
                Console.WriteLine();
                Console.Write("Press enter to continue.");
                Console.ReadLine();

                isUserChoosingNewClass = false;
            }
        }
    }
    else
    {
        bool isClassCorrect = true;
        while (isClassCorrect)
        {
            bool newClassSelection = true;
            while (newClassSelection)
            {
                Console.Clear();
                Console.WriteLine("CLASSES");
                Console.WriteLine();
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
                Console.WriteLine();
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

                    newClassSelection = false;
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

                    newClassSelection = false;
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

                    newClassSelection = false;
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

                    newClassSelection = false;
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

                    newClassSelection = false;
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

                    newClassSelection = false;
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

                    newClassSelection = false;
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

                    newClassSelection = false;
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

                    newClassSelection = false;
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

                    newClassSelection = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid entry.");
                    Console.WriteLine();
                    Console.Write("Press enter to continue.");
                    Console.ReadLine();
                }
            }

            Console.Clear();
            Console.WriteLine($"Character class: {classChosen}");
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
            Console.Write("Is this Class correct (y/n)? ");
            userResponse = Console.ReadLine();

            if (userResponse == "y")
            {
                isClassCorrect = false;
            }
            else if (userResponse != "n")
            {
                Console.Clear();
                Console.WriteLine("Invalid entry.");
                Console.WriteLine();
                Console.Write("Press enter to continue.");
                Console.ReadLine();
            }
        }
    }

    #endregion
    #region CharacterSheetReview
    Console.Clear();
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
    Console.Write("Is this correct (y/n)");
    userResponse = Console.ReadLine();

    if (userResponse == "y")
    {
        isUserCreatingCharacter = false;
    }
    else if (userResponse != "y" && userResponse != "n")
    {
        Console.Clear();
        Console.WriteLine("Invalid entry.");
        Console.WriteLine();
        Console.Write("Press enter to continue.");
        Console.ReadLine();
    }
    #endregion
}


