using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achie_CS.src.nofall.code.achie.utils {
    // C# DOESNT ACCEPT VARS WITH INTERFACES... A CLASS IT IS THEN! :(
    internal class SyntaxCharacters {
        public static char START_VARIABLE = '<';
        public static char END_VARIABLE = '>';
        public static char START_CURLY_BRACE = '{';
        public static char END_CURLY_BRACE = '}';
        public static char START_VALUE = ':';
        public static char END_VALUE = ';';
        public static char COMMENT = '#';
    }
}
