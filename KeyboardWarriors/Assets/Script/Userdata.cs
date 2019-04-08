using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Userdata : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // public InputField mainInputfield;

    void Start()
    {
        // mainInputfield.text = "Enter text there";
    }

    private void Update()
    {
        // setUserName(mainInputfield.text);
        tester();
    }

    public static string userName;
    public static int currentScore = 0;
    public static int lifepoint = 4;


    private void setUserName(string name)
    {
        userName = name;
    }

    public static void setCurrentScore(int points)
    {
        currentScore += points;
    }

    public static void setlifepoint(int life)
    {
        lifepoint += life;
    }

    public void tester()
    {
        Debug.Log(userName);
        Debug.Log(currentScore);
        Debug.Log(lifepoint);
    }

}
