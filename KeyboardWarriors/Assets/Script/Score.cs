using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Score : MonoBehaviour
{
    public string userName { get; set; }
    public int score { get; set; }
    public string timestamp { get; set; }

    public Score(string userName, int score, string timestamp)
    {
        this.userName = userName;
        this.score = score;
        this.timestamp = timestamp;
    }

}
