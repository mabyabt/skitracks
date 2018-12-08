using System;
using System.Collections.Generic;
using System.Text;

namespace skitracks
{
    class mountain
    {
       public static string name;
       public static int heigh;

        public mountain(string n) {
          String[] subn=  n.Split(",");
           name =  subn[0];
            heigh = Convert.ToInt32(subn[1]);
        }


        public static void getName() {
            Console.WriteLine(name);


        }
    }
}
