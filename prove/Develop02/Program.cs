using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    static void Main(string[] args)
    {
        Menu MenuItem1 = new Menu();
        MenuItem1._menu1 = "1. Write on your jounal";
        Menu MenuItem2 = new Menu();
        MenuItem2._menu1 = "2. Display you journal";
        Menu MenuItem3 = new Menu();
        MenuItem3._menu1 = "3. Save Journal";
        Menu MenuItem4 = new Menu();
        MenuItem4._menu1 = "4. Load Journal";
        Menu MenuItem5 = new Menu();
        MenuItem5._menu1 = "5. Quit Journal";


        List<Menu> MenuList = new List<Menu>();

        MenuList.Add(MenuItem1);
        MenuList.Add(MenuItem2);
        MenuList.Add(MenuItem3);
        MenuList.Add(MenuItem4);
        MenuList.Add(MenuItem5);

        
        int choice = 0;
        string filename;
        PromptsGenerator prompts = new PromptsGenerator();
        {
            Journal jounal = new Journal();
            
            
            while (choice !=5 )
            {
                foreach(Menu item in MenuList)
                {
                    Console.WriteLine(item._menu1);
                }
                    Console.Write("what do you want to do? ");
                    choice = int.Parse(Console.ReadLine());
                    
                if (choice == 1)
                {
                    jounal.AddEntries();
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Displaying...");
                    jounal.DisplayEntry();
                    Console.WriteLine("");
                }
                else if (choice == 3)
                {
                    //Journal save = new Journal();
                    Console.WriteLine("what is the filename?");
                    Console.Write(">");
                    filename = Console.ReadLine();
                    jounal.SaveToFile(filename);
                    Console.WriteLine($"Your journal has been updated at {filename}");
                }
                else if (choice == 4)
                {
                    Console.WriteLine("what is the filename?");
                    Console.Write(">");
                    filename = Console.ReadLine();
                    jounal.ReadFromFile(filename);
                }

                else if (choice == 5)
                {
                    Console.WriteLine("thanks for using the journal App");
                }
                else
                {
                    Console.WriteLine("oops! please chose a number 1-5.");
                }
            }
            
        }
    
    }
}