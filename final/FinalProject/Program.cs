using System;

public class Program
{
    public static void Main()
    {
        Menu menu = new Menu();
        int choice = 0; 

        while (choice !=9) 
        {
            Console.Clear();
            Menu.ShowMenu();
            choice = Menu.GetUserChoice(); 
            menu.RunMenu(choice); 

            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }
    }
}