using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public GameObject player;
    public List<Ball> balls;
    public float freezeRange = 2400f;
    void Start()
    {
        balls = new List<Ball>();
    }

    void Update()
    {
		for (int i = 0; i < balls.Count; i++)
		{
            Vector3 distance = transform.position - player.transform.position;
            float length = distance.sqrMagnitude;
            
            if (length < freezeRange)
			{

                balls[i].body.gravityScale = 0.1f;

			}
            else
			{
                balls[i].body.gravityScale = 0.7f;
            }
        }
    }
}
