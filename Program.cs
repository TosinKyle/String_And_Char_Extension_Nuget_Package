using System.Text.RegularExpressions;

namespace StringExtension
{
    public static class Program
    {
        static void Main(string[] args)
        {
 
        }
        public static string AddCharacterAfterEveryWordThatStartsWithUpperCase(this string sentence, char characterToAdd)
        {
            string[] splitResult = sentence.Split(' ');
            for (int i = 0; i < splitResult.Length; i++)
            {
                if (char.IsUpper(splitResult[i][0]))
                {
                    splitResult[i] += characterToAdd;
                }
            }
            return string.Join(" ", splitResult);
        }
        public static bool IsCharacterVowel(this char character)
        {
            char[] vowels = { 'a','e','i','o','u'};
            foreach (char vowel in vowels)
            {
                if (char.ToLower(character)==vowel) 
                { 
                 return true;
                }
            }
            return false;

        }
        public static bool IsCharacterConsonant(this char character)
        {
            char[] consonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
            foreach (char consonant in consonants)
            {
                if (char.ToLower(character) == consonant)
                {
                    return true;
                }
            }
            return false;
        }
        public static int CountVowel(this string sentence)
        {
            string[] words =sentence.Split(' ');         
            int count = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            foreach (string word in words) 
            {
                string lowerWord = word.ToLower();
                foreach (char d in lowerWord)
                {
                    if (vowels.Contains(d))
                    {
                        count++;
                    }
                }
            }
            return count;

        }
        public static int CountConsonant(this string sentence)
        {
            string[] words = sentence.Split(' ');
            int count = 0;
            char[] consonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
            foreach (string word in words)
            {
                string lowerWord = word.ToLower();
                foreach (char d in lowerWord)
                {
                    if (consonants.Contains(d))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public static bool IsEmail(this string emailAddress) 
        {
            string emailFormat = @"^[A-Za-z0-9._%+-]{1,30}@[a-zA-Z.-]{3,10}\.[a-z]{3}$";
            Regex regex = new Regex(emailFormat);
           bool response= regex.IsMatch(emailAddress);
            return response;
        }
    }

}