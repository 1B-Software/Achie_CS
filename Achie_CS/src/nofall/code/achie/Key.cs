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
            
            String parent = id.Contains(".") ? id : "a"; 

            if (id.Contains(".")) {
                String child = id.Substring(id.IndexOf("."), (id.Length-id.IndexOf(".")));
                return child;
            }
            return null;
        }

        /// <summary>
        /// Gets a child or a parent in a keychain.
        /// <para></para>
        /// ERROR CODES:
        /// <br></br>
        /// -1: Unable to find a key that matches the specified id.
        /// <br></br>
        /// -2: No children found.
        /// <br></br>
        /// -3: The index is bigger than the amount of children in the keychain OR its less than 0.
        /// </summary>
        public String getHeirarchyElement(String id, int index) {
            String result = "";
            // Child Count
            int childC = childCount(id);
            int pointers = 0;

            if (index > childC || index < 0) return "-3";

            // If there are children.
            if (childC != 0) {
                for (int i = 0; i < id.Length; i++) {
                    if (id[i].ToString().Equals(".")) {
                        pointers++;
                    }
                    if (pointers == index) {
                        result = childC != index ? id.Substring(i+1, id.Substring(i+1).ToString().IndexOf(".")) : id.Substring(i+1);
                        Console.WriteLine("RESULT: " + result);
                        return result;
                    } else if (i == id.Length) return "-2";
                }
            } else if (childC == 0) {
                result = id;
            } else {
                Console.Error.WriteLine("Unable to find key by the name of " + "\"" + id + "\"");
                return "-1";
            }
            return result;
        }


        /// <summary>
        /// Counts how many children a parent key has.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private int childCount(String id) {
            int childCount = 0;
            for (int i = 0; i < id.Length; i++)
            {
                if (id[i] == '.') childCount++;
            }
            return childCount;
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
