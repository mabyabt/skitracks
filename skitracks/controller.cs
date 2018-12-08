using System;
using System.Collections.Generic;
using System.Text;

namespace skitracks
{
    class controller
    {
       public static List<mountain> mountains= new List<mountain>();
        public static void createList() {

            //String[] subline = fileIO.line.Split(",");
            var line = fileIO.line;
           


            mountains.Add(new mountain(line));


        }
        


    }
}
