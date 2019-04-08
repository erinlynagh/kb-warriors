using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{

    public List<Word> words;

    public WordSpawner wordSpawner;

    private bool hasCurrentWord;
    private Word currentWord;

    public int wordCount = 0;

    private void Start()
    {
        AddWord();
    }

    private void Update()
    {
        if (wordCount > 2)
        {
            SceneManager.LoadScene("StageScreen");
        }

        if (Userdata.lifepoint <= 0)
        {
            SceneManager.LoadScene("MainScreen");
            Userdata.lifepoint = 4;
        }

        if  (hasCurrentWord && currentWord.IsCompleted()){ 
            hasCurrentWord = false;
            words.Remove(currentWord);
            wordCount += 1;
            AddWord();
        } else if (hasCurrentWord && WordDisplay.wordPosition < -8)
        {
            hasCurrentWord = false;
            words.Remove(currentWord);
            wordCount += 1;
            Userdata.setlifepoint(-1);
            AddWord();
        }
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


    }

}
