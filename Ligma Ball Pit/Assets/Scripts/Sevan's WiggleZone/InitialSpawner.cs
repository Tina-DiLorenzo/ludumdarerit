using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    public int amountOfBalls = 10;

    public float ballsPerSecond = 0.5f;
    private float timer = 0;
    private float range = 0.1f;

    void Start()
    {

    }

    void Update()
    {
        if (timer < Time.realtimeSinceStartup && amountOfBalls > 0)
		{
            amountOfBalls--;

            GameObject newBall = Instantiate(ballPrefab);

            Vector3 newPosition = transform.position;
            newPosition.x += Random.Range(-range, range);
            newPosition.y += Random.Range(-range, range);
            newBall.transform.position = transform.position;

            timer = Time.realtimeSinceStartup + ballsPerSecond;
        }
    }
}
