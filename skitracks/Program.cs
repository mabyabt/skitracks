using System;

namespace skitracks
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            fileIO.readio();
                controller.createList();
           

            foreach (var  mountain  in controller.mountains) {
                Console.WriteLine("name: {0} height: {1}", mountain.name, mountain.heigh);
            }
            Console.ReadKey();


        }
    }
}
