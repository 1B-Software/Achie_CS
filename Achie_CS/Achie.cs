using Achie_CS.src.nofall.code.achie;
using System;

namespace Achie_CS {
    class Achie {

        public static void Main(String[] args) {
            Reader reader = new Reader("../../../data/sample.achie");
            Console.WriteLine("READER: " + reader.Read());
        }

    }
}