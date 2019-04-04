using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public List<Word> words;

    public WordSpawner wordSpawner;

    private bool hasCurrentWord;
    private Word currentWord;

    private void Start()
    {
        AddWord();
    }

    private void Update()
    {
    }

    public void AddWord()
    {
        Word word = new Word(RandomWordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
        Debug.Log(word.word);

        words.Add(word);
    }

    public void TypeLetter(char letter)
    {
        if (hasCurrentWord)
        {
            if (currentWord.GetNextLetter() == letter)
            {
                currentWord.TypeLetter();
            }
        }
        else
        {
            foreach (Word word in words)
            {
                if (word.GetNextLetter() == letter)
                {
                    currentWord = word;
                    hasCurrentWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }

        if (hasCurrentWord && currentWord.IsCompleted())
        {
            hasCurrentWord = false;
            words.Remove(currentWord);
            AddWord();

        }

    }

}
