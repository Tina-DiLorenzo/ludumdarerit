using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public GameObject player;
    public List<GameObject> balls;
    public float freezeRange = 20f;
    void Start()
    {
        balls = new List<GameObject>();
    }

    void Update()
    {
		for (int i = 0; i < balls.Count; i++)
		{
            Vector3 distance = transform.position - player.transform.position;
            float length = distance.sqrMagnitude;
            Debug.Log(length);
        }
    }
}
