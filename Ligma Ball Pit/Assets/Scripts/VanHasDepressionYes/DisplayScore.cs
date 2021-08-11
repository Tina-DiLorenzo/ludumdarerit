using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Final Score: " + PlayerPrefs.GetFloat("pointsCollected");
    }
}
