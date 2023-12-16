using Achie_CS.src.nofall.code.achie.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achie_CS.src.nofall.code.achie {
    public class Keys {

        List<String> contents = Reader.contents;

        public Keys() {

        }

        public String getKey(String id) {
            // The dot specifies that we are going deeper into the hierarchy of the elements.
            //if (!contents.Contains(id)) return "-1";

            defineKey(id);
            Console.WriteLine("SOMETHING");

            for (int i = 0; i < contents.Count; i++) {
                String currentLine = contents[i];


            }

            return null;
        }

        /// <summary>
        /// Tells if what is parameterized is a key.
        /// <para></para>
        /// Uses the rules of syntaxing.
        /// <para></para>
        /// RULES:
        /// <br></br>
        /// - Every key needs to have a starting and ending naming space.
        /// To name a key, it must start with "&lt;" and end with "&gt;".
        /// <br></br>
        /// EXAMPLE: 
        /// <br>A</br>
        /// &lt;myName&gt;:
        /// <br></br>
        /// Note that is must have a colon as a sign of equalization.
        /// <para></para>
        /// - A key can equal to anything, even a list of keys. A list of keys is called a KeyChain
        /// which we can define with a starting "{" and an ending "}".
        /// <br></br>
        /// EXAMPLE: 
        /// <br></br>
        /// &lt;myName>: {
        /// <br></br>
        /// &lt;myOtherName&gt;: "something";
        /// <br></br>
        /// &lt;anotherName&gt;: 10;
        /// }
        /// </summary>
        /// <returns></returns>
        public bool defineKey(String id) {
            bool result = false;

            Console.WriteLine("DEFINEKEY");

            int idLocation = 0;

            Console.WriteLine(idLocation);

            for (int i = 0; i < getTotalLines(); i++) {
                idLocation = contents[i].IndexOf(id);
                if (i == idLocation && contents[i - 1] == SyntaxCharacters.START_VARIABLE.ToString()) {
                    Console.WriteLine("YES: " + contents[i - 1]);
                }
            }

            return result;
        }

        /// <summary>
        /// Gets the total number of lines in the achie file.
        /// <br></br>
        /// "\n" counts!
        /// </summary>
        public int getTotalLines() {
            int result = 0;
            for (int i = 0; i < contents.Count; i++) {
                result = i;
            }
            return result;
        }

        /// <summary>
        /// Gets a child or a parent in a keychain. (INDEX 0 is the root parent)
        /// <para></para>
        /// ERROR CODES:
        /// <br></br>
        /// -1: Unable to find a key that matches the specified id.
        /// <br></br>
        /// -2: No children found.
        /// <br></br>
        /// -3: The index is bigger than the amount of children in the keychain OR its less than 0.
        /// </summary>
        public String getKeyInId(String id, int index) {
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
                // Meaning that the id has no children.
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
            for (int i = 0; i < getTotalLines(); i++) {
                if (results[i].Trim() == SyntaxCharacters.START_VARIABLE + key + SyntaxCharacters.END_VARIABLE) {
                    String queried = results[i];
                }
            }
            return null;
        }
    }
}
