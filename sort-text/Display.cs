using sort_text.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace sort_text
{
    public class Display : IDisplay
    {
        public void Write(string value)
        {
            Console.Write(value);
        }

        public void WriteLine(string value)
        {
            Console.WriteLine(value);
        }
        public void Clear()
        {
            Console.Clear();
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
