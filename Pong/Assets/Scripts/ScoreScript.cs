﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int PlayerScore = 0;
    public static int EnemyScore = 0;
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Player: " + PlayerScore + " - " + "Enemy: " + EnemyScore;
    }
}
