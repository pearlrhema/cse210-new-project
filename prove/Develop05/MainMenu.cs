using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

public class MainMenu
{
    public String item;
    public MainMenu(String item)
    {
        this.item = item;
    }

// }
// public class MainMenu
// {
//     private string _menuItem;
//     public MainMenu(string item)
//     {
//         _menuItem = item;
//     }
//     public static void DisplayMenu()
//     {
//         List<MainMenu> menu = new();
//         MainMenu menu1 = new("Create new Goal");
//         MainMenu menu2 = new("List Goal");
//         MainMenu menu3 = new("Save Goal");
//         MainMenu menu4 = new("Load Goal");
//         MainMenu menu5 = new("Record Event");
//         MainMenu menu6 = new("Quit");

//         menu.Add(menu1);
//         menu.Add(menu2);
//         menu.Add(menu3);
//         menu.Add(menu4);
//         menu.Add(menu5);
//         menu.Add(menu6);
//         foreach (MainMenu item in menu)
//         {
//             Console.WriteLine(item._menuItem);
//         }
//     }
}