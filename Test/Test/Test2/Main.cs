namespace Test.Test2;
using System;
public class Main{
    public static void main(String[] args)
    {
        Console.Write("Nhap a string: ");
        string inputString = Console.ReadLine();
        Console.Write("Nhap the word to search for: ");
        string searchWord = Console.ReadLine();
        if (string.IsNullOrEmpty(searchWord))
        {
            Console.WriteLine("Search word cannot be empty.");
            return;
        }
        int count = CountOccurrences(inputString, searchWord);
        Console.WriteLine($"The word '{searchWord}' appears {count} time(s) in the string.");
    }

    public static int CountOccurrences(string input, string word)
    {
        if (string.IsNullOrEmpty(input))
        {
            return 0;
        }

        int count = 0;
        int index = 0;

        while ((index = input.IndexOf(word, index, StringComparison.OrdinalIgnoreCase)) != -1)
        {
            count++;
            index += word.Length; 
        }

        return count;
    }
}