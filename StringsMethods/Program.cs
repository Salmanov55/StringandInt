using System;

namespace StringsMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task 3
            //    Console.WriteLine("Enter a word:");
            //    string input = Console.ReadLine();

            //    string reversed = ReverseString(input);
            //    reversed = reversed.ToUpper();

            //    Console.WriteLine("Reversed word is: " + reversed);


            //static string ReverseString(string input)
            //{
            //    char[] charArray = input.ToCharArray();
            //    Array.Reverse(charArray);
            //    return new string(charArray);
            //}
            #endregion


            #region task 2
            //Console.WriteLine("Enter a word:");
            //string input = Console.ReadLine();

            //int vowelCount = CountVowels(input);
            //int consonantCount = CountConsonants(input);

            //Console.WriteLine("Vowels: " + vowelCount + ", Consonants: " + consonantCount);


            //static int CountVowels(string input)
            //{
            //    int vowelCount = 0;

            //    foreach (char c in input)
            //    {
            //        if (IsVowel(c))
            //        {
            //            vowelCount++;
            //        }
            //    }

            //    return vowelCount;
            //}

            //static int CountConsonants(string input)
            //{
            //    int consonantCount = 0;

            //    foreach (char c in input)
            //    {
            //        if (IsConsonant(c))
            //        {
            //            consonantCount++;
            //        }
            //    }

            //    return consonantCount;
            //}

            //static bool IsVowel(char c)
            //{
            //    return "AEƏIOÖÜUaeəioöuü".Contains(c);
            //}

            //static bool IsConsonant(char c)
            //{
            //    return char.IsLetter(c) && !IsVowel(c);
            //}
            #endregion

            #region task 1
            //Console.WriteLine("Enter a word:");
            //string input = Console.ReadLine();

            //int wordCount = CountWords(input);

            //Console.WriteLine("Total number of words in the string is: " + wordCount);
        

            //static int CountWords(string input)
            //{
            //    string[] words = input.Split(new char[] { ' ' });
            //    return words.Length;
            //}
            #endregion
        }
    }
}
