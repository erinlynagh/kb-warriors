using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageGenerator : MonoBehaviour
{
    public GameObject[] objects;
    public Vector3[] Level1Spots;

    void Start()
    {
        int rand = Random.Range(0,3);
        Instantiate(objects[0], Level1Spots[rand], Quaternion.identity);
    }

    void Update()
    {
        
    }
}
