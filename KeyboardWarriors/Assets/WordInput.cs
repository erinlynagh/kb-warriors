using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordInput : MonoBehaviour
{
    public GameController gameController;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (char letter in Input.inputString)
        {
            gameController.TypeLetter(letter);
        }
    }
}
