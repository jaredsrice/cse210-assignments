using System;

public class Program
{
    public static void Main()
    {
        Menu menu = new Menu();
        int choice = 0; 

        while (choice != 7) 
        {
            Menu.ShowMenu();
            choice = Menu.GetUserChoice(); 
            menu.RunMenu(choice); 
        }
    }
}