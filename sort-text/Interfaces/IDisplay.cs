using System;
using System.Collections.Generic;
using System.Text;

namespace sort_text.Interfaces
{
    public interface IDisplay
    {
        void Write(string value);
        void WriteLine(string value);
        void Clear();
        string ReadLine();



    }
}
