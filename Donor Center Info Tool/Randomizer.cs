using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;


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

        public static string GenerateRNGCryptoPassword(int length)
        {
            // all the valid characters we can use for out password
            const string valid = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKMNOPQRSTUVWXYZ1234567890!@#$%?";

            // string to dumb generated text into
            StringBuilder res = new StringBuilder();
            // loop over the length of the password until we have no more spaces in the string
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                // create a buffer the size of unsigned integer
                byte[] uintBuffer = new byte[sizeof(uint)];

                while (length-- >= 1)
                {
                    // dump each byte into the buffer
                    rng.GetBytes(uintBuffer);
                    // convert the bit to a 32bit integer
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    // normalize value by using the remainder of the converted integer by
                    // the length of the valid string contant (as an unsigned integer)
                    // and append it to the stringbuilder string
                    res.Append(valid[(int)(num % (uint)valid.Length)]);
                }
            }
        return res.ToString();
        }
    }
}
