using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a text: ");
        string input = Console.ReadLine();

        string[] sentences = input.Split('.');

        for (int i = 0; i < sentences.Length; i++) 
        { 
            if (!string.IsNullOrEmpty(sentences[i]))
            {
                sentences[i] = sentences[i].Trim();
                if (!string.IsNullOrEmpty(sentences[i]))
                {
                    char[] sentenceChars = sentences[i].ToCharArray();
                    sentenceChars[0] = char.ToUpper(sentenceChars[0]);
                    sentences[i] = new string(sentenceChars);
                }
            }
        }
        string result = string.Join(". ", sentences);
        Console.Write("Result: " + result);
    }
}