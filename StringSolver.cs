using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperations
{
    internal class StringSolver
    {
        //1.function to count total number of vowels and consonants in a string
        public List<int> CountVowelsConsonant(string s)
        {
            List<int> answer = new List<int>();
            int countVowels = 0;
            int countConsonant = 0;
            string temp = s.ToLower();
            foreach (char ch in temp)
            {
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    countVowels++;
                }
                else
                {
                    countConsonant++;
                }
            }
            answer.Add(countVowels);
            answer.Add(countConsonant);
            return answer;

        }

        //2.Function to count the total number of characters in a string
        public int NumberOfCharacters(string s)
        {
            int count = 0;
            foreach (char ch in s)
            {
                if(ch!=' ')
                {
                    count++;
                }
                
            }
            return count;
        }
        //3.Function to count the total number of words in a string
        public int NumberOfWords(string s)
        {
            int count = 0;
            string[] temp = s.Split(" ");
            foreach (string word in temp)
            {
                count++;
            }
            return count;

        }
        //4.Function to reverse the string
        public string ReverseString(string s)
        {
            string temp = s;
            int size = temp.Length;
            string answer = "";
            for (int i = 0; i < size; i++)
            {
                char ch = temp[size - 1 - i];
                answer += ch;

            }
            return answer;
        }
        //5.Function to find the frequency of the characters in a string
        public Dictionary<char, int> FrequencyOfCharacters(string s)
        {
            Dictionary<char, int> answer = new Dictionary<char, int>();
            foreach (char ch in s)
            {

                if (answer.ContainsKey(ch) && ch!=' ')
                {
                    answer[ch]++;
                }
                else if(ch!=' ')
                {
                    answer[ch] = 1;
                }

            }
            return answer;
        }

        //6.Function to replace lower-case characters with upper-case and vice versa
        public string ReplaceLowerUpper(string s)
        {
            string answer = "";
            foreach (char ch in s)
            {
                if (char.IsLower(ch))
                {
                    answer += char.ToUpper(ch);
                }
                else if (char.IsUpper(ch))
                {
                    answer += char.ToLower(ch);
                }
                else
                {
                    answer += ch;
                }
            }
            return answer;
        }

        //7.Function to Determine Whether a Given String is Palindrome
        public bool IsPalindrome(string s)
        {
            string temp = "";
            int size = s.Length;
            for (int i = 0; i < size; i++)
            {
                temp += s[size - 1 - i];
            }
            if (s == temp)
            {
                return true;
            }
            return false;
        }

        //8.Function to remove all the white spaces from a string
        public string RemoveWhiteSpace(string s)
        {
            string answer = "";
            foreach (char ch in s)
            {
                if (ch != ' ')
                {
                    answer += ch;
                }
            }
            return answer;
        }

        //9.Function to Find Maximum and Minimum Occurring Character in a String
        public List<char> MaxiMiniOccuringChar(string s)
        {
            List<char> answer = new List<char>();
            Dictionary<char, int> frequency = new Dictionary<char, int>();

            if (string.IsNullOrEmpty(s))
            {
                return answer; // Return empty list if input string is null or empty
            }

            int min = int.MaxValue;
            int max = int.MinValue;
            char minChar = '\0'; // Default char value
            char maxChar = '\0'; // Default char value

            // Count the frequency of each character
            foreach (char ch in s)
            {
                if (frequency.ContainsKey(ch) && ch!=' ')
                {
                    frequency[ch]++;
                }
                else if(!frequency.ContainsKey(ch) && ch!=' ')
                {
                    frequency[ch] = 1;
                }
            }

            // Find min and max occurring characters
            foreach (char key in frequency.Keys)
            {
                if (frequency[key] > max)
                {
                    max = frequency[key];
                    maxChar = key;
                }

                if (frequency[key] < min)
                {
                    min = frequency[key];
                    minChar = key;
                }
            }

            // Add the result to the list
            answer.Add(maxChar);
            answer.Add(minChar);

            return answer;

        }

        //10.Function to Find the Duplicate Characters in a String
        public List<char> DuplicateChars(string s)
        {
            List<char> answer = new List<char>();
            HashSet<char> set = new HashSet<char>();
            foreach (char ch in s)
            {
                if(ch!=' ')
                {
                    if (set.Contains(ch) && !answer.Contains(ch))
                    {
                        answer.Add(ch);
                    }
                    else if (!set.Contains(ch))
                    {
                        set.Add(ch);
                    }
                }
                
            }
            return answer;

        }
        //11.Function to Find the Duplicate Words in a String
        public List<string> DuplicateWords(string s)
        {
            List<string> answer = new List<string>();
            HashSet<string> set = new HashSet<string>();
            string[] wordList = s.Split(" ");
            foreach (string word in wordList)
            {
                if (set.Contains(word))
                {
                    answer.Add(word);
                }
                else
                {
                    set.Add(word);
                }

            }
            return answer;
        }
    }
}
