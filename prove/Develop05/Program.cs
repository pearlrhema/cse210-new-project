using System;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;

public class Program
{
    public static void Main(string[] args)
    {
        string savePath = "data.txt";
        GoalsOverview goalsManager = new();
        
        int choice;
        do
        {
            Console.WriteLine($"\tYou have {goalsManager.Score} points\n");
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
    //as creativity, the program gives the user the option of chosing to either save/load goals into/from the defualt file or create another file 
    
}