using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Achie_CS.src.nofall.code.achie {
    internal class Reader {

        String PATH;
        StreamReader FILE;

        public Reader(String path) {
            this.PATH = path;
            this.FILE = new StreamReader(path);

        }
    }
}
