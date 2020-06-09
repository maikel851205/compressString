using System;

// BbB
//48. String Compression BbB
//Question : Given a string, write a function to compress it by shortening every sequence
//of the same character to that character followed by the number of repetitions.If the
//compressed string is longer than the original, you should return the original string.
//eg.
//compress( "a" ) = "a"
//compress( "aaa" ) = "a3"
//compress( "aaabbb" ) = "a3b3"
//compress( "aaabccc" ) = "a3b1c3"




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

            char[] str = ("aaaacccbbc").ToCharArray();
            compressString(str);
            Console.ReadLine();

        }
    }
}
