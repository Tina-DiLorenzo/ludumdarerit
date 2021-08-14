using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loading : MonoBehaviour
{
    [SerializeField] private BallSpawner ballSpawner;

    public BallSpawner BallSpawner
    {
        get { return ballSpawner; }
    }

    // Update is called once per frame
    void Update()
    {
        if(ballSpawner.BallsToCreate == 0)
        {
            this.gameObject.SetActive(false);
        }
    }
}
