using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstSentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine(firstSentence);
            Console.WriteLine("Search for a word in the first sentence.");
            string userInput = Console.ReadLine();
            string caseInsensitive;
            caseInsensitive = userInput.ToLower();
            string noCase;
            noCase = firstSentence.ToLower();
            int match;
            match = noCase.IndexOf(caseInsensitive);
            if (match >= 0)
            {
                Console.WriteLine("True, word was found at location " + match + ". " + "Word has length of " + userInput.Length + ".");
                string remove = firstSentence.Substring(match, caseInsensitive.Length);
                Console.WriteLine(remove);
                string newSentence;
                newSentence = firstSentence.Substring(0, match) + firstSentence.Substring(match, caseInsensitive.Length - caseInsensitive.Length);
                Console.WriteLine(newSentence);
            } else {
                Console.WriteLine("False, word is not in the sentence.");
            }

        }
    }
}
