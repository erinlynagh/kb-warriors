using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHistory : MonoBehaviour
{
    private List<Score> records;

    public ScoreHistory() {
        records = DashboardIO.readScoresFromFile();
    }

    public List<Score> getRecord()
    {
        return records;
    }

    public void addScore(Score record)
    {
        if (records.Count == 0 || record.score < records[records.Count - 1].score)
        {
            records.Add(record);
        }
        else {
            for (int i = 0; i < records.Count; i++)
            {
                if (record.score >= records[records.Count - 1].score)
                {
                    records.Insert(i, record);
                    break;
                }
            }
        }

        DashboardIO.writeScoresToFile(records);
    }

    public void removeAll() {
        records = new List<Score>();
        DashboardIO.writeScoresToFile(records);
    }
}
