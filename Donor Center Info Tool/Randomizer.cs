using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using System.Linq;


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
        // for use with the RNGcrypto method

        const string valid = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%?";

        static Random random = new Random();

        // depreciated in favor of more secure rngcryptoserviceprovider function //
        public static string GeneratePassword(int lowercase, int uppercase, int numerics, int symbol)
        {
            string lowers = "abcdefghijklmnopqrstuvwxyz";
            string uppers = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numbers = "0123456789";
            string symbols = "!@#$%?";

            // starts with an invalid character so the string has a length into which new characters can be injected
            string generated = "!";

            // since these passwords will be used as temporary passwords, I don't feel that its necessary to use something stronger than the
            // built in random class. While it isn't as secure as the rngcryptoservice class, it's faster and easier to convert into something useable 
            

            // on each iteration for each of the 4 args, we loop from 1 to length of the args and insert a random character at a random position in the string
            // repeats once for each type of character

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
                passwords[i] = GenerateFixedCryptoPassword(8);
                
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
            //writer.Close();
        }

        public static string GenerateFixedCryptoPassword(int length)
        {
            
            // list of valid characters
            const string valid = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ1234567890!@#$%&";

            // create a mutable string to hold generated password
            StringBuilder result = new StringBuilder();

            // create random range to insert symbol of non was generated
            Random r = new Random();
            StringBuilder symbols = new StringBuilder("!@#$%&");

            // random seeds for result and symbol strings
            int rint_result = r.Next(0, length);
            int cint_result = r.Next(0, symbols.Length);
            
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];

                while (result.Length < length)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    char converted_int = valid[(int)(num % (uint)valid.Length)];

                    // checks if char is already in the string. if not, add to string
                    // other wise generate a new char
                    if (!result.ToString().ToLower().Contains(converted_int.ToString().ToLower()))
                    {
                        result.Append(converted_int);
                    }  
                }
                
                // ensure at least one special symbol has been added to the password
                Console.WriteLine(result.ToString());

                if (!result.ToString().Any(c => char.IsPunctuation(c))) {
                    string new_result = result.ToString().Substring(1).Insert(rint_result, symbols[cint_result].ToString());
                    return new_result;
                }

                else {
                    return result.ToString();
                }             
            }
            
            
        }
    }
}
