using Achie_CS.src.nofall.code.achie.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achie_CS.src.nofall.code.achie {
    public class Key {

        List<String> contents = Reader.contents;

        public Key() {

        }

        public String getKey(String id) {
            // The dot specifies that we are going deeper into the hierarchy of the elements.
            if (id.Contains(".")) {
                String child = id.Substring(id.IndexOf("."), (id.Length-id.IndexOf(".")));
            }
            return null;
        }

        // Gets all the elements (Keys), inside the specified key.
        // If the specified key equals to root, it will get everything from the root key, which just means that it will get everything.
        public List<String> getAllElementsInKey(String key) {
            List<String> results = this.contents;
            if (key == "root") return results;
            for (int i = 0; i < results.Count(); i++) {
                if (results[i].Trim() == SyntaxCharacters.START_VARIABLE + key + SyntaxCharacters.END_VARIABLE) {
                    String queried = results[i];
                }
            }
            return null;
        }
    }
}
