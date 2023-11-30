using System;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;

public class Program
{
    public static void Main(string[] args)
    {
        // List<MainMenu> menu = new();
        // MainMenu menu1 = new("1. Create new Goal");
        // MainMenu menu2 = new("2. List Goal");
        // MainMenu menu3 = new("3. Save Goal");
        // MainMenu menu4 = new("4. Load Goal");
        // MainMenu menu5 = new("5. Record Event");
        // MainMenu menu6 = new("6. Quit");

        // menu.Add(menu1);
        // menu.Add(menu2);
        // menu.Add(menu3);
        // menu.Add(menu4);
        // menu.Add(menu5);
        // menu.Add(menu6);

        string savePath = "data.txt";
        GoalsOverview goalsManager = new();
        goalsManager.ReadFromFile(savePath);
        Console.WriteLine($"\tYou have {goalsManager.Score} points");

        int choice;
        do
        {
            Console.WriteLine("Welcome to the Goal Tracker!\n"
            + "1) Create New Goal\n"
            + "2) Display Goals\n"
            + "3) Save Goal\n"
            + "4) Load Goals\n"
            + "5) Record Event\n"
            + "6) Quit");

            Console.Write("select a choice from the menu ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                goalsManager.CreateNewGoal();
            }
            else if (choice == 2)
            {
                goalsManager.DisplayGoals();
            }
            else if (choice == 3)
            {
                //as creativity, the program gives the user the option of saving chosing to either save goals into the defualt file or create another file of differently 
                Console.WriteLine("Save to (1)defualt location or (2)choose a file?");
                string input = Console.ReadLine();
                if (input == "2")
                {
                    Console.Write("File Path\n> ");
                    string newPath = Console.ReadLine();
                    goalsManager.SaveToFile(newPath);
                }
                else if (input == "1")
                    goalsManager.SaveToFile(savePath);
                else
                    Console.WriteLine("Invalid input");
            }
            else if (choice == 4)
            {
                //As creativity, the program gives the user the option of chosing which file to load goals from.
                Console.WriteLine("Load from (1)defualt location or (2)choose a file?");
                string input = Console.ReadLine();
                if (input == "2")
                {
                    Console.Write("File Path\n> ");
                    string newPath = Console.ReadLine();
                    goalsManager.ReadFromFile(newPath);
                }
                else if (input == "1")
                    goalsManager.ReadFromFile(savePath);
                else
                    Console.WriteLine("Invalid input");
            }
            else if (choice == 5)
            {
                goalsManager.RecordGoalEvent();
            }
            else if (choice == 6)
            {
                Console.WriteLine("Thanks for using the app!");
            }
            
        } while (choice != 6);
        Console.Clear();
    }
}