﻿using Achie_CS.src.nofall.code.achie.utils;
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

        public Key key;

        public Reader(String path) {
            this.PATH = path;
            this.FILE = new StreamReader(path);
            FindFile(path);
        }

        private void FindFile(String path) {
            if (!File.Exists(path)) {
                Console.Error.WriteLine("Specified path does not exist.");
                Environment.Exit(1);
            }
            else Console.WriteLine("File by the name of " + "\"" + Path.GetFileName(path) + "\"" + " found");
        }

        public List<String> Read() {
            try {
                String[] contents = File.ReadAllLines(this.PATH);
                List<String> result = contents.ToList<String>();
                result = RemoveComments(result);
                for (int i = 0; i < result.Count(); i++) {
                    Console.WriteLine(i + ": " + result[i]);
                }
                this.contents = result;
                return result;
            } catch {
                Console.Error.WriteLine("Unable to read file!");
            }
            return null;
        }

        public List<String> RemoveComments(List<String> fileContents) {
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
