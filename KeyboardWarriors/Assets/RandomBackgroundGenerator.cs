using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBackgroundGenerator : MonoBehaviour
{

    public Sprite[] Backgrounds; //this is an array of type sprite

    public SpriteRenderer Render; //this is a variable of type sprite renderer

    // Use this for initialization
    void Start()
    {
        Render = GetComponent<SpriteRenderer>();
        Render.sprite = Backgrounds[Random.Range(0, Backgrounds.Length)];
    }
    void Update()
    {

    }
}