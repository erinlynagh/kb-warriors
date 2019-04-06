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

    void Start()
    {
        var input = gameObject.GetComponent<InputField>();
        input.onEndEdit.AddListener(GetInput);
    }

    private void Update()
    {
        tester();
    }

    public static string Name;
    public static int score;

    private void GetInput(string input)
    {
        Name = input;
    }

    public static void ScoreUpdate(int points)
    {
        score += points;
    }

    public void tester()
    {
        Debug.Log(Name);
        Debug.Log(score);
    }

}
