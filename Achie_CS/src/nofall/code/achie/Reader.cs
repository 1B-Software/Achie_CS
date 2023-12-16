using Achie_CS.src.nofall.code.achie.utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Achie_CS.src.nofall.code.achie {
    public class Reader {

        String PATH;
        StreamReader FILE;
        public static List<String> contents;

        public Keys key;

        public Reader(String path) {
            this.PATH = path;
            this.FILE = new StreamReader(path);
            //Console.WriteLine(FILE.ReadToEnd());
            FindFile(path);
        }

        private void FindFile(String path) {
            if (!File.Exists(path)) {
                Console.Error.WriteLine("Specified path does not exist.");
                Environment.Exit(1);
            }
            else Console.WriteLine("File by the name of " + "\"" + Path.GetFileName(path) + "\"" + " found");
        }

        public String ReadToString() {
            for (int i = 0; i < read().Count(); i++) {
                return read()[i];
            }
            return null;
        }

        public List<String> read() {
            try {
                String[] contents = new string[File.ReadLines(this.PATH).Count()];
                for (int i = 0; i < File.ReadLines(this.PATH).Count(); i++) {
                    // Converts the file into an array of strings and removes any whitespaces for easier parsing.
                    contents[i] = File.ReadLines(this.PATH).ElementAt(i).Replace(" ", "");
                }
                List<String> result = contents.ToList();
                result = removeComments(result);
                for (int i = 0; i < result.Count(); i++) {
                    Console.WriteLine(i + ": " + result[i]);
                }
                Reader.contents = result;
                return result;
            } catch {
                Console.Error.WriteLine("Unable to read file!");
            }
            return null;
        }

        public List<String> removeComments(List<String> fileContents) {
            List<String> result = new List<String>();

            String line = null;
            bool isComment = false;

            for (int i = 0; i < fileContents.Count(); i++) {
                line = fileContents[i].Trim();

                if (line.StartsWith(Char.ToString(SyntaxCharacters.COMMENT))) {
                    isComment = true;
                }
                else isComment = false;

                if (!isComment) result.Add(line);
            }
            return result;
        }
    }
}