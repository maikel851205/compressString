using System;

namespace compressString
{
    class Program
    {
        static void Main()
        {
            void compressString(char[] str)
            {

                int count = 1;
                string newString = "";


                for (int i = 0; i < str.Length - 1; i++)
                {
                    if (str[i] == str[i + 1])
                        count++;
                    else
                    {
                        newString = newString + str[i] + count.ToString();
                        count = 1;
                    }

                }
                newString = newString + str[str.Length - 1] + count.ToString();
                Console.WriteLine(newString);

            }

            char[] str = { 'a', 'a', 'b', 'b', 'b', 'c','c','d'};

            compressString(str);
        }
    }
}
