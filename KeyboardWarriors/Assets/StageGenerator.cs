using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageGenerator : MonoBehaviour
{
    public GameObject[] objects;
    public Vector3[] Level1Spots;

    void Start()
    {
        int randObject = Random.Range(0, objects.Length);
        int randStage = Random.Range(0, Level1Spots.Length);

        int randObject2 = Random.Range(0, objects.Length);
        int randStage2 = Random.Range(0, Level1Spots.Length);

        int randObject3 = Random.Range(0, objects.Length);
        int randStage3 = Random.Range(0, Level1Spots.Length);

        Instantiate(objects[randObject], Level1Spots[randStage], Quaternion.identity);
        Instantiate(objects[randObject2], Level1Spots[randStage2], Quaternion.identity);
        Instantiate(objects[randObject3], Level1Spots[randStage3], Quaternion.identity);
    }

    void Update()
    {
        
    }
}
