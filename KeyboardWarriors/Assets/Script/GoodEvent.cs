using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GoodEvent : MonoBehaviour
{
    private void Awake()
    {
        Userdata.setCurrentScore(Random.Range(200, 300));
    }
}
