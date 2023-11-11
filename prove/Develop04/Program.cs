using System;

class Program
{
    static void Main(string[] args)
    {
        List<Menu> menuItems = new();
        Menu MenuItem1 = new();
        MenuItem1._menuItems = "1. Start Breathing Activity";
        Menu MenuItem2 = new();
        MenuItem2._menuItems = "2. Start Reflecting Acitivity";
        Menu MenuItem3 = new();
        MenuItem3._menuItems = "3. Start Listing Activity";
        Menu MenuItem4 = new();
        MenuItem4._menuItems = "4. Quit";

        menuItems.Add(MenuItem1);
        menuItems.Add(MenuItem2);
        menuItems.Add(MenuItem3);
        menuItems.Add(MenuItem4);
        
        int choice = 0;
        // int duration;
        
        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options");
            foreach (Menu item in menuItems)
                {
                    Console.WriteLine($"    {item._menuItems}");
                }
                Console.Write("Please select a choice from the Menu ");
                choice = int.Parse(Console.ReadLine());
            if(choice == 1)
            {
                // Console.WriteLine("option one");
                // PUT "How long would you like to do the activity?"
                Breathing breathing = new();
                breathing.RunBreathingActivity();
                
            }
            else if(choice == 3)
            {
                // Console.Write("How long, in seconds would you like for your session? ");
                // duration = int.Parse(Console.ReadLine());
                Listing listing =new Listing();
                listing.RunListingActivity();
            }
            else if(choice == 2)
            {
                
                Reflection reflection = new();
                reflection.RunReflectionActivity();
            }
            else if (choice == 4)
            {
                Console.WriteLine("thanks for using the app");
                break;
            }
            else
            {
                Console.WriteLine("enter a number 1-4");
            }
        }
    }
}