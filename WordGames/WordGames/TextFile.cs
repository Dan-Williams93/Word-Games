using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WordGames
{
    class TextFile
    {
        public string file;
        public string text;

        public void getTextFile()
        {
            //file = @"../../Words.txt";
            file = @"Words.txt";
            text = File.ReadAllText(file);
        }
    }
}
