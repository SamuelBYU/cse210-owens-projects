using System;

public class Journal
{
    public List<Entry>_entries;

    public void AddEntry(Entry newEntry)
    {
        
    }

    public void DisplayAll()
    {
        // The Journal display method could iterate through all 
        // Entry objects and call the Entry display method. 
        // The Journal wouldn't have to worry about the details 
        // of how the Entry was displayed, this would all be 
        // contained within the Entry class.
    }

    public void SaveToFile(string file)
    {
        
    }

    public void LoadFromFile(string file)
    {
        
    }
}