using System;
using System.Collections.Generic;
public class Scripture
//Keeps track of both the reference and the text 
//of the scripture. Can hide words and get the rendered display of the text.
{
    private Reference _reference;
    private List<Word>_words = new List<Word>();

   
    public Scripture(Reference Reference, string text)
    
    {
        _reference = Reference;
        _words = new List<Word>();

        string[] words = text.Split(' ');

        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
        
    }

   

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        

        for (int i = 0; i < numberToHide; i++)
        {
            int number = random.Next(_words.Count);

            _words[number].Hide();
        }
    }
    public string GetDisplayText()
    {
       string result = _reference.GetDisplayText();
       foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }
        return result;
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }



}