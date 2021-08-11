using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointTracker : MonoBehaviour
{

    [SerializeField] private Text scoreText;
    private float points;
    public float Points
    {
        get { return points; }
    }

    private void Start()
    {
        points = 0;
        scoreText.text = "Score: " + points;
    }

    public void AddToScore(float score)
    {
        points += score;
        scoreText.text = "Score: " + points;
    }

}
