using System;

namespace PasswordGenerator
{
    class PasswordGenerator
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int s1 = 1; s1 <= n; s1++)
            {
                for (int s2 = 1; s2 <= n; s2++)
                {
                    for (int s3 = 0; s3 < l; s3++)
                    {
                        string alphabet = "abcdefghi";
                        char digitS3 = alphabet[s3];
                        for (int s4 = 0; s4 < l; s4++)
                        {
                            alphabet = "abcdefghi";
                            char digitS4 = alphabet[s4];
                            for (int s5 = 1; s5 <= n; s5++)
                            {
                                if (s5 > s1 && s5 > s2)
                                {
                                    Console.Write($"{s1}{s2}{digitS3}{digitS4}{s5} ");
                                }

                            }
                        }
                    }
                }
            }
        }
    }
}
