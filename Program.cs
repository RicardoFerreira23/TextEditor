using System;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();            
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("What do you want to do");
            Console.WriteLine("1. Edit File");
            Console.WriteLine("2. New File");
            Console.WriteLine("0. Leave");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0:System.Environment.Exit(0); break;
                case 1:EditFile(); break;
                case 2:NewFile();break;
                default: Menu(); break;
            }

            static void EditFile()
            {
                
            }

            static void NewFile()
            {

            }
        }
    }
}