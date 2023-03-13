using System;
using System.Text;

namespace Editor_HTML
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("EDITING MODE");
            TextEditor();
        }

        public static void TextEditor()
        {
            var text = new StringBuilder();

            do
            {
                text.Append(Console.ReadLine());
                text.Append(Environment.NewLine);
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("----------");
            Console.WriteLine("Do you wish to save the text? Y/N");
            char option = char.Parse(Console.ReadLine().ToLower());
            GetSaveTextResponse(option, text.ToString());
        }

        public static void TextAlreadyExist()
        {
            
        }     
        public static void GetSaveTextResponse(char option, string text)
        {
            switch(option)
            {
                case 'y': 
                    Console.Clear();
                    Console.WriteLine("Write a path and text extension to save the text");
                    var path = Console.ReadLine();

                    Savetext(text, path);
                    break;
                case 'n': break;
            }
        }

        public static void Savetext(string text, string path)
        {
            using (var file = new StreamWriter(path))
                file.Write(text);
            
            Console.WriteLine($"File saved at {path}");
            Viewer.Show(text.ToString());
        }
    }
}