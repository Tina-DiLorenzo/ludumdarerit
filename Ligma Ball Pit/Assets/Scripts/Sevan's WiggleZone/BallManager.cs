using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public GameObject player;
    public GameObject hand;
    public List<Ball> balls;
    public float lowGravityRange = 60f;
    void Start()
    {
        balls = new List<Ball>();
    }


    void GravityCheck(Ball ball)
	{
        Vector3 distance = ball.gameObject.transform.position - player.transform.position;
        float length = distance.sqrMagnitude;

        if (length > lowGravityRange)
        {

            ball.body.gravityScale = 0.08f;
        }
        else
        {
            ball.body.gravityScale = 0.7f;
        }

        //if (length > lowGravityRange*6f)
		//{
        //    ball.body.Sleep();
		//}
        //else
		//{
        //    ball.body.WakeUp();
        //}
    }

    void UpdateShakeValues(Ball ball)
	{
        Vector3 distance = ball.gameObject.transform.position - hand.transform.position;
        float length = distance.sqrMagnitude;

		if (length < 10f)
		{
            ball.shakeValue = 0.05f;
		}
        else if (length < 5f)
		{
            ball.shakeValue = 0.2f*(length/5f);
        }
        else
		{
            ball.shakeValue = 0f;
        }
    }

    void Update()
    {
		for (int i = 0; i < balls.Count; i++)
		{
            GravityCheck(balls[i]);
            UpdateShakeValues(balls[i]);
        }
    }

}
