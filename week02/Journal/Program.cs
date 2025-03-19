// Exceed Requirement by Add SearchEntries allowing user to search Journal entries by date or keyword.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int response =0;
        List<string> prompt = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today? ",
            "What was the strongest emotion I felt today? ",
            "If I had one thing I could do over today, what would it be? "
        };

        Random randomGenerator = new Random();
        Journal myJournal = new Journal();

        while (response != 6)
        {
            Console.WriteLine("Pick and option from the menu by input the number. e.g (1 or 2)");
            Console.WriteLine("1). Write a new entry");
            Console.WriteLine("2). Display the journal.");
            Console.WriteLine("3). Save journal to a file");
            Console.WriteLine("4). Load journal from a file");
            Console.WriteLine("5). Search Journal Entries");
            Console.WriteLine("6). Exit");
            string userReply = Console.ReadLine();
            response = int.Parse(userReply);

            if (response == 1){
                int index = randomGenerator.Next(prompt.Count);
                Console.WriteLine(prompt[index]);
                string userResponse = Console.ReadLine();

                Entry myEntry = new Entry
                {
                _date = DateTime.Now.ToString("yyyy/MM/dd"),
                _prompt = prompt[index],
                _userResponse = userResponse
                };

                myJournal.AddEntry(myEntry);

            }
            else if (response == 2)
            {
                myJournal.DisplayEntries();
            }
            else if (response == 3)
            {
                Console.Write("Enter file name: ");
                string file = Console.ReadLine();
                myJournal.StoreToFile(file);
            }
            else if (response == 4)
            {
                Console.WriteLine("Enter file name ? ");
                string file = Console.ReadLine();
                myJournal.LoadFile(file);
            }
            else if (response == 5)
            {
                Console.WriteLine("Enter a keyword or date (YYYY/MM/DD) to");
                string searchInput = Console.ReadLine();
                myJournal.SearchEnteries(searchInput);
            }
        }

    }
}