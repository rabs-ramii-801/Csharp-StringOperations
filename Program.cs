using System;
namespace StringOperations
{
    class StringManipulation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---WELCOME TO STRING MANIPULATION APP---");
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine() ?? string.Empty;
            Console.WriteLine();
            Console.WriteLine("Your inputted string is: ");
            Console.Write(str);
            Console.WriteLine();
            Console.WriteLine();
            StringSolver obj= new StringSolver();
            Console.WriteLine("--1.total number of vowels and consonants in the string is: ");
            List<int> result1 = obj.CountVowelsConsonant(str);
            Console.WriteLine("Vowels" + " " + "Consonants");
            foreach (int value in result1)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--2.total number of characters in the string is: ");
            int totalChar = obj.NumberOfCharacters(str);
            Console.Write(totalChar);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--3.the total number of words in the string is: ");
            int totalWords=obj.NumberOfWords(str);
            Console.Write(totalWords); 
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--4.Reverse of the string is: ");
            string revstr=obj.ReverseString(str);
            Console.Write(revstr);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--5.the frequency of each characters in the string is:");
            Dictionary<char,int>dict=obj.FrequencyOfCharacters(str);
            foreach(char value in dict.Keys)
            {

                Console.Write(value + ": " + dict[value]);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("--6.String after replacing lower-case characters with upper-case and vice versa");
            string result2=obj.ReplaceLowerUpper(str);
            Console.WriteLine(result2);
            Console.WriteLine();
            Console.WriteLine("--7.Whether the Given String is Palindrome or not");
            bool result3=obj.IsPalindrome(str);
            if (result3)
            {
                Console.WriteLine("The inputted string is Plaindrome");
            }
            else
            {
                Console.WriteLine("The inputted string is not Plaindrome");
            }
            Console.WriteLine();
            Console.WriteLine("--8.String after removing all white spaces: ");
            string result4=obj.RemoveWhiteSpace(str);
            Console.WriteLine(result4);
            Console.WriteLine();
            Console.WriteLine("--9.The Maximum and Minimum Occurring Character in the String is:");
            List<char>result5=obj.MaxiMiniOccuringChar(str);
            foreach(char ch in result5)
            {   
                Console.Write(ch+" "); 
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--10.the Duplicate Characters in the String are:");
            List<char>result6=obj.DuplicateChars(str);
            foreach (char ch in result6)
            {
                Console.Write(ch + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--11.the Duplicate Words in the String are:");
            List<string>result7=obj.DuplicateWords(str);
            if (result7.Any())
            {
                foreach (string word in result7)
                {
                    Console.Write(word + " ");
                }

            }
            else
            {
                Console.WriteLine("None");
            }
            
            Console.WriteLine();








        }
    }
}

