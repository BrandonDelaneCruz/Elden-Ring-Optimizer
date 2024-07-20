#region Character infromation.
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Transactions;

string characterName = "Unknown";
bool hasNameBeenSet = true;
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
    if(hasNameBeenSet == true)
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
   

}


