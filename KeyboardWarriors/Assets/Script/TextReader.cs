using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextReader : MonoBehaviour
{

    public List<Score> list;

    public void generate()
    {
        Debug.Log("123");
        list.Add(new Score("test1", 100, "123"));
        list.Add(new Score("test2", 80, "123"));
        list.Add(new Score("test3", 70, "123"));

        DashboardIO.writeScoresToFile(list);

        list = DashboardIO.readScoresFromFile();

        Debug.Log(list.Count);
        foreach (Score record in list)
        {
            Debug.Log(record.userName);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
