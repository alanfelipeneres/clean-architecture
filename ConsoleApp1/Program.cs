using System;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //string s = Console.ReadLine();

            //string t = Console.ReadLine();

            //int K = Convert.ToInt32(Console.ReadLine().Trim());

            string s = "hffk";
            string t = "larb";
            int K = 3;

            int result = Result.sameSubstring(s, t, K);

            Console.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }

    class Result
    {

        /*
         * Complete the 'sameSubstring' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. STRING s
         *  2. STRING t
         *  3. INTEGER K
         */

        public static int sameSubstring(string s, string t, int K)
        {

            int k = K;

            for (int i = 0; i < s.Count(); i++)
            {
                char s2 = s[i];
                char t2 = t[i];

                int r = t2 - s2;

                if (r < k)
                {
                    k = k - (t2 - s2);
                    break;
                }

                
            }

            if (k == K)
                return 0;

            return K;
        }

    }
}
