using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DashboardIO : MonoBehaviour
{
    private static string FILEPATH = "Assets/Resources/test.txt";
    private static char DELIMITER = ',';
    
    public static List<Score> readScoresFromFile()
    {
        StreamReader file = new StreamReader(FILEPATH);
        string line;
        List<Score> records = new List<Score>();

        while ((line = file.ReadLine()) != null)
        {
            string[] record = line.Trim().Split(DELIMITER);
            records.Add(new Score(record[0], int.Parse(record[1]), record[2]));
        }
        file.Close();

        return records;
    }

    public static void writeScoresToFile(List<Score> records)
    {
        StreamWriter file = new StreamWriter(FILEPATH, false);
        foreach (Score record in records)
        {
            file.WriteLine(record.userName + DELIMITER + record.score + DELIMITER + record.timestamp);
        }
        file.Close();
    }

}
