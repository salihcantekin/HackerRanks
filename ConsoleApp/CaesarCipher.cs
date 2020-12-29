using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp
{
    public class CaesarCipher
    {
        //static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int n = Convert.ToInt32(Console.ReadLine());

        //    string s = Console.ReadLine();

        //    int k = Convert.ToInt32(Console.ReadLine());

        //    string result = caesarCipher(s, k);

        //    textWriter.WriteLine(result);

        //    textWriter.Flush();
        //    textWriter.Close();
        //}

        static string caesarCipher(string s, int k)
        {
            char[] orj = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            if (String.IsNullOrEmpty(s)) return String.Empty;

            char[] resArr = s.ToCharArray();

            for (int i = 0; i < resArr.Length; i++)
            {
                char ch = resArr[i];
                if (!char.IsLetter(ch)) continue;

                int index = Array.IndexOf(orj, char.ToLower(ch));

                int letterPos = (index += k) % 26;

                resArr[i] = char.IsUpper(ch) ? char.ToUpper(orj[letterPos]) : orj[letterPos];
            }

            return new String(resArr);
        }
    }
}
