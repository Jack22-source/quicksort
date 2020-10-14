using System;

namespace sort_text
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorting sorting = new Sorting();
            Display display = new Display();

            DisplayMainMenu();

            ConsoleKeyInfo keyinfo;
            do
            {
                keyinfo = Console.ReadKey();

                if(keyinfo.KeyChar == '1')
                {
                    display.Clear();
                    
                    string sortedData = sorting.QuickSort("Contrary to popular belief, the pink unicorn flies east.");
                    display.WriteLine("Contrary to popular belief, the pink unicorn flies east. ==>");
                    display.WriteLine(sortedData);
                    display.WriteLine("Press r to return to menu.");
                }
                else if(keyinfo.KeyChar == 'r')
                {
                    DisplayMainMenu();
                }
                else if(keyinfo.KeyChar == '2')
                {
                    display.Clear();
                    display.WriteLine("Please Enter a string to be sorted.");
                    
                    var data = display.ReadLine();

                    string sortedData = sorting.QuickSort(data);

                    display.WriteLine(sortedData);
                    display.WriteLine("Press r to return to menu.");

                }

            }
            while (keyinfo.Key != ConsoleKey.X);
        }

        private static void DisplayMainMenu()
        {
            var display = new Display();
            display.Clear();
            display.WriteLine("=======================================");
            display.WriteLine("1.) press 1 to show text sort =========");
            display.WriteLine("2.) press 2 to add custom text=========");
            display.WriteLine("2.) press x to exit          ==========");
            display.WriteLine("=======================================");

        }
    }
}
