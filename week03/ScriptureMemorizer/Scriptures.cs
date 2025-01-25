using System;
using System.Collections.Generic;

public class Scripture
{
    public Reference Reference { get; private set; }
    public List<Word> Words { get; private set; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = new List<Word>();
        foreach (var word in text.Split(' '))
        {
            Words.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(Reference.GetFormattedReference());
        foreach (var word in Words)
        {
            Console.Write($"{word.GetDisplayText()} ");
        }
        Console.WriteLine();
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        for (int i = 0; i < count; i++)
        {
            var visibleWords = Words.FindAll(w => !w.IsHidden);
            if (visibleWords.Count == 0) break;

            var wordToHide = visibleWords[random.Next(visibleWords.Count)];
            wordToHide.Hide();
        }
    }
}
