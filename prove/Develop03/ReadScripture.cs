using System;
using System.Globalization;
using System.IO;
 
public class ScriptureReader
{
    private List<(string book, string chapter, string verse, string text)> scriptures;

    public ScriptureReader(string filePath)
    {
        scriptures = new List<(string book, string chapter, string verse, string text)>();
      
        string[] lines = File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            string[] parts = line.Split(':');
            string book = parts[0].Trim();
            string chapter = parts[1].Trim();
            string verse = parts[2].Trim();
            string text = parts[3].Trim();
            
            scriptures.Add((book, chapter, verse, text));
        }
    }

    public (string book, string chapter, string verse, string text) SelectRandomScripture()
    {

        Random rnd = new Random();
        int index = rnd.Next(scriptures.Count);
        return scriptures[index];
    }
}