using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreScript : MonoBehaviour
{
    InGame ig;
    public Text scoreText;
    // Start is called before the first frame update 
    void Start()
    {
        ig = GameObject.FindGameObjectWithTag("GameController").GetComponent<InGame>();
        scoreText.text = "0";
    }
    public void UpdateScore()
    {
        scoreText.text = (ig.IncrementScore()).ToString(); 
    }


}
