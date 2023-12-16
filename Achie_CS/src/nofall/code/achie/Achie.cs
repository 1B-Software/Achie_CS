using System;

namespace Achie_CS.src.nofall.code.achie
{
    class Achie
    {

        public static void Main(string[] args)
        {
            Reader reader = new Reader("../../../data/sample.achie");
            reader.read();
            Keys key = new Keys();
            //Console.WriteLine("Heirarchy: " + key.getKeyInId("Robatortas.stuff.game.code", 2));
            key.getKey("bed");
        }

    }
}