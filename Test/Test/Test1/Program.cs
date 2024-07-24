
        using Test.Test1;

        People people = new People("minh",true,25);
        Console.WriteLine("Properties Demo");
        Console.WriteLine("Person details: " );
        Console.WriteLine(people);
        people.Age += 10;
        Console.WriteLine("Person details (apter incrementing age):");
        Console.WriteLine(people);
        //TEst2
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

        int CountOccurrences(string input, string word)
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
        