using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace skitracks
{
    class fileIO
    {       public static string line;

        private static void readFile() {
            StreamReader input= new StreamReader("input.txt");

            while ( input.ReadLine() != null) {
                line = input.ReadLine();
               // Console.WriteLine(line);
                            }
        }

        public static void readio() {
            readFile();

        }


    }
}
