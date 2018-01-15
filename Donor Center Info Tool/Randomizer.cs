﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;


namespace Donor_Center_Info_Tool
{
    internal class Randomizer
    {
        /* Needs to generate SOX Compliant password for use in the production environment
           - At least 8 characters
           - At least one Capital Letter
           - At least 2 numbers
           - At least one special symbol (! @ # $ % & ?) 
           - No more than 2 repeating characters in a row
        */

        // initialize the random class here prevents repeats due to the default seed depending on the pcs clock. 
        // certain loop contructs are too fast for the seed to update
        static Random random = new Random();

        public static string GeneratePassword(int lowercase, int uppercase, int numerics, int symbol)
        {
            string lowers = "abcdefghijklmnopqrstuvwxyz";
            string uppers = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numbers = "0123456789";
            string symbols = "!@#$%?";

            // starts with an invalid character so the string has a length into which new characters can be injected
            string generated = "!";

            // since these passwords will be used as temporary passwords, I don't feel that its necessary to use something stronger than the
            // built in random class. Whie it isn't as secure as the rngcryptoservice class, it's faster and easier to convert into something useable 
            

            // on each iteration for each of the 4 args, we loop from 1 to length of the args and insert a random character at a random position in the string
            // repeats 4 times

            for (int i = 1; i <= lowercase; i++)
                generated = generated.Insert(
                    random.Next(generated.Length), 
                    lowers[random.Next(lowers.Length)].ToString());

            for (int i = 1; i <= uppercase; i++)
                generated = generated.Insert(
                    random.Next(generated.Length),
                    uppers[random.Next(uppers.Length)].ToString());


            for (int i = 1; i <= numerics; i++)
                generated = generated.Insert(
                    random.Next(generated.Length),
                    numbers[random.Next(numbers.Length)].ToString());


            for (int i = 1; i <= symbol; i++)
                generated = generated.Insert(
                    random.Next(generated.Length),
                    symbols[random.Next(symbols.Length)].ToString());
                

            return generated.Replace("!", string.Empty);

        }

        public static void GeneratePasswordFile(int amount)
        {
            string[] passwords = new string[amount];

            for (int i = 0; i < passwords.Length; i++)
            {
                passwords[i] = GeneratePassword(3, 2, 2, 1);
                
            }

            SaveFileDialog save = new SaveFileDialog
            {
                FileName = "passwords.txt",
                Filter = "Text File | *.txt"
            };

            if (save.ShowDialog() != DialogResult.OK) return;
            StreamWriter writer = new StreamWriter(save.OpenFile());
            foreach (var t in passwords)
            {
                writer.WriteLine(t);
            }
            writer.Dispose();
            writer.Close();
        }
    }
}
