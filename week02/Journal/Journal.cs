using System;
using System.Collections.Generic;
using System.IO;

public class Journal{

    public List<Entry> _entries= new List<Entry>();

    public void AddEntry(Entry info)
    {
        _entries.Add(info);
        Console.WriteLine("Entry Successfully Saved.");
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void StoreToFile(string filename)
    {
        using (var writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                string details = $"{entry._date} | {entry._prompt} | {entry._userResponse}";
                writer.WriteLine(details);
            }
        }
        Console.WriteLine("Journal Successfully Saved.");
    }
    public void LoadFile(string filename)
    {
        if (!File.Exists(filename)){
            Console.WriteLine("Error: File does not exist!");
            return;
        }

        _entries.Clear();
        using (var reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                Entry myentry = new Entry();
                myentry._date = parts[0];
                myentry._prompt = parts[1];
                myentry._userResponse = parts[2];

                _entries.Add(myentry);
            }
        }
        Console.WriteLine("Loaded Successfully!");
    }

    public void SearchEntries(string searchword)
    {
        List<Entry> results = new List<Entry>();

        foreach (Entry entry in _entries)
        {
            if (entry._date.Contains(searchword) || entry._prompt.ToLower().Contains(searchword.ToLower())
            || entry._userResponse.ToLower().Contains(searchword.ToLower())){
                results.Add(entry);
            }
        }

        if (results.Count == 0)
        {
            Console.WriteLine("No such entries found.");
        }
        else{
            Console.WriteLine("Search Results:");
            foreach(Entry entry in results){
                Console.WriteLine("Date: " + entry._date);
                Console.WriteLine("prompt: " + entry._prompt);
                Console.WriteLine("Response: " + entry._userResponse);
            }
        }
    }
}