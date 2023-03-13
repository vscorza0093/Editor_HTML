using System;
using System.Threading;

namespace Editor_HTML
{
    public static class Menu
    {
        public static void Show()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawMenu("initial");
        }

        public static void DrawMenu(string menu)
        {
            switch (menu)
            {
                case "initial":
                    Console.Clear();
                    DrawLine(30);
                    DrawColumns(30, 30);
                    DrawLine(30);
                    Console.SetCursorPosition(10, 2); // To write something in an specific point of the screen
                    Console.Write("HTML Editor");
                    Console.SetCursorPosition(1, 3);
                    Console.Write("-------------------------------");
                    WriteOptions();
                    break;
                    
                case "quit":
                    Console.Clear();
                    DrawLine(30);
                    DrawColumns(30, 30);
                    DrawLine(30);
                    Console.SetCursorPosition(10, 2); // To write something in an specific point of the screen
                    Console.Write("HTML Editor");
                    Console.SetCursorPosition(1, 3);
                    Console.Write("-------------------------------");
                    break;
            }
        }
        public static void DrawLine(int columns)
        {
            Console.Write("+");
            for (int column = 0; column <= columns; column++)
                Console.Write("-");
            Console.WriteLine("+");
        }
        public static void DrawColumns(int columns, int lines)
        {
            for (int line = 0; line <= lines;line++)
            {
                Console.Write("|"); 
                for (int column = 0; column <= columns; column++)
                    Console.Write(" ");
                Console.Write("|");
                Console.Write("\n");
            }
        }
        public static void WriteOptions()
        {

            Console.SetCursorPosition(4, 4);
            Console.Write("Select an option below");
            Console.SetCursorPosition(3, 6);
            Console.Write("1 - New File");
            Console.SetCursorPosition(3, 7);
            Console.Write("2 - Open");
            Console.SetCursorPosition(3, 8);
            Console.Write("0 - Quit");
            Console.SetCursorPosition(3, 10);
            Console.Write("Option:");
            char option = char.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void HandleMenuOption(char option)
        {
            switch (option)
            {
                case '1': break;
                case '2': break;
                case '0': CloseApplication(); break;
                default:  Show(); break;
            }
        }

        public static void NewFile()
        {

        }

        public static void OpenFile()
        {

        }

        public static void CloseApplication()
        {
            DrawMenu("quit");
            Console.SetCursorPosition(7, 5);
            Console.Write("Thanks for using");
            Thread.Sleep(2000);
            Console.Clear();
            System.Environment.Exit(1);
        }
    }
}