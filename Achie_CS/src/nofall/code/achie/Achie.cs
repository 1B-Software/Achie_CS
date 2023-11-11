using System;

namespace Achie_CS.src.nofall.code.achie
{
    class Achie
    {

        public static void Main(string[] args)
        {
            Reader reader = new Reader("../../../data/sample.achie");
            Console.WriteLine("READER: " + reader.Read());
            Key robat = new Key();
            Console.WriteLine(robat.getKey("Robatortas"));
        }

    }
}