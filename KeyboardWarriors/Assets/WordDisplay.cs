using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WordDisplay : MonoBehaviour
{

    public Text text;
    public float moveSpeed;
    public static float wordPosition;

    public void SetWord(string word)
    {
        text.text = word;
    }

    public void RemoveLetter()
    {
        text.text = text.text.Remove(0,1);
        text.color = Color.gray;
    }

    public void RemoveWord()
    {
        Destroy(gameObject); 
    }


    void Start()
    {
        if (SceneManager.GetActiveScene().name == "GameScreen")
        {
            moveSpeed = 4;
        }
        else {
            moveSpeed = 15;
        }
    }

    void Update()
    {
        transform.Translate(-moveSpeed*Time.deltaTime, 0f,0f);
        wordPosition = transform.position.x;
    }

}
