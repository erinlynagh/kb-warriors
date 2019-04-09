using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ScoreController : MonoBehaviour
{
    public Text dashbaord;
    public static ScoreHistory scoreHistory = new ScoreHistory();


    private void Start()
    {
        displayDashboard();
    }


    void displayDashboard()
    {
        Debug.Log("test");
        List<Score> records = scoreHistory.getRecord();
        Debug.Log(records.Count);
        string dashboardText = "User      Score    Time\n";

        foreach (Score record  in records)
        {
            dashboardText += record.userName + "      " + record.score.ToString() + "        " + record.timestamp + "\n";
        }
        Debug.Log(dashboardText);
        dashbaord.text = dashboardText;

    }



}
