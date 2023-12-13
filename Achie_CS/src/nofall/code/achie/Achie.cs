using System;

namespace Achie_CS.src.nofall.code.achie
{
    class Achie
    {

        public static void Main(string[] args)
        {
            Reader reader = new Reader("../../../data/sample.achie");
            reader.Read();
            Key robat = new Key();
            Console.WriteLine("Heirarchy: " + robat.getHeirarchyElement("Robatortas.stuff.game.code", 4));
            Console.WriteLine("hergehgr: " + robat.childCount("Robatortas"));
            Console.WriteLine("KEY: " + robat.getAllElementsInKey("ID"));
        }

    }
}