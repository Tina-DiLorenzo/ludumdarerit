using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitialSpawner : MonoBehaviour
{
    public BallManager manager;
    public GameObject stand;
    public GameObject ballPrefab;
    public Text loading;
    public CanvasGroup group;
    public int amountOfBalls = 10;

    public float ballsPerSecond = 0.5f;
    public float range = 0.1f;

    private float timer = 0;
    
    void Update()
    {
        if (timer < Time.realtimeSinceStartup && amountOfBalls > 0)
		{
            amountOfBalls--;

            GameObject newBall = Instantiate(ballPrefab);

            Vector3 newPosition = transform.position;
            newPosition.x += Random.Range(-range, range);

            newBall.transform.position = newPosition;

            manager.balls.Add(newBall.GetComponent<Ball>());

            timer = Time.realtimeSinceStartup + ballsPerSecond;
        }

        if(amountOfBalls <= 0 && stand != null)
        {
            group.alpha = 0;
            Destroy(stand);
        }
        else
        {
            loading.text = (100-(amountOfBalls / 100)).ToString() + "%";
        }
    }
}
