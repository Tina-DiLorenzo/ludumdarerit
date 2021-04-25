using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    public int amountOfBalls = 10;
    public float range = 10f;

    private float ballsPerSecond = 0.5f;
    private float timer = 0;

    void Start()
    {

    }

    void Update()
    {
        if (timer < Time.realtimeSinceStartup && amountOfBalls > 0)
		{
            amountOfBalls--;

            GameObject newBall = Instantiate(ballPrefab);

            newBall.transform.position = transform.position;

            timer = Time.realtimeSinceStartup + ballsPerSecond;
        }
    }
}
