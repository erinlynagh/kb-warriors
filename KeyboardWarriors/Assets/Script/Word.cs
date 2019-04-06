using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Word {

    public string word;
    private int typeIndex;


    WordDisplay display;


    public Word(string _word, WordDisplay _display) {
        word = _word;
        display = _display;
        display.SetWord(word);
        typeIndex = 0;
    }

    public char GetNextLetter()
    {
        return word[typeIndex];
    }

    public void TypeLetter()
    {
        typeIndex++;
        display.RemoveLetter();
    }

    public bool IsCompleted()
    {
        bool isCompleted = (typeIndex >= word.Length);
        if (isCompleted)
        {
            display.RemoveWord();

        }
        return isCompleted;
    }
}
