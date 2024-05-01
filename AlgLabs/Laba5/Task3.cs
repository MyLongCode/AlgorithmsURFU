using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgLabs.Laba5
{

    public class Task3
    {
        public static void Solution()
        {
            string fileName = Console.ReadLine();
            string pattern = Console.ReadLine();

            bool isMatch = IsFileNameMatchPattern(fileName, pattern);

            if (isMatch)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        static bool IsFileNameMatchPattern(string fileName, string pattern)
        {
            int fileIndex = 0;
            int patternIndex = 0;

            while (patternIndex < pattern.Length)
            {
                if (pattern[patternIndex] == '*')
                {
                    if (patternIndex == pattern.Length - 1)
                    {
                        return true; // '*' в конце образца считается любым множеством символов
                    }
                    while (fileIndex < fileName.Length && fileName[fileIndex] != pattern[patternIndex + 1])
                    {
                        fileIndex++;
                    }
                }
                else if (pattern[patternIndex] == '?' || pattern[patternIndex] == fileName[fileIndex])
                {
                    fileIndex++;
                }
                else
                {
                    return false;
                }
                patternIndex++;
            }

            return fileIndex == fileName.Length && patternIndex == pattern.Length;
        }
    }
}
