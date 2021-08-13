using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    #region Fields
    //manages the gravity/shake value of balls
    [SerializeField] private BallLogicManager ballLogicManager;

    //intial platform used to hold up player before all the balls spawn
    [SerializeField] private GameObject stand;
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private float ballsToCreate = 1000f;
    [SerializeField] private float ballsPerSecond = 0.02f;
    [SerializeField] private float range = 6f;
    [SerializeField] private float timer = 0f;

    private List<Ball> balls;

    #endregion

    #region Properties
    public List<Ball> Balls
    {
        get { return balls; }
    }
    public BallLogicManager BallLogicManager
    {
        get { return ballLogicManager; }
    }
    public GameObject Stand
    {
        get { return stand; }
    }
    public GameObject BallPrefab
    {
        get { return ballPrefab; }
    }
    public float BallsToCreate
    {
        get { return ballsToCreate; }
    }
    public float BallsPerSecond
    {
        get { return ballsPerSecond; }
    }
    public float Range
    {
        get { return range; }
    }
    public float Timer
    {
        get { return timer; }
    }
    #endregion

    #region Start & Update
    // Start is called before the first frame update
    void Start()
    {
        balls = new List<Ball>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < Time.realtimeSinceStartup && ballsToCreate > 0)
        {
            ballsToCreate--;

            GameObject newBall = Instantiate(ballPrefab);
            Vector3 newPosition = transform.position;
            newPosition.x += Random.Range(-range, range);

            newBall.transform.position = newPosition;

            balls.Add(newBall.GetComponent<Ball>());

            timer = Time.realtimeSinceStartup + ballsPerSecond;
        }

        if (ballsToCreate <= 0 && stand != null)
        {
            //group.alpha = 0;
            Destroy(stand);
        }
        //else
        //{
        //    loading.text = (100 - (amountOfBalls / 100)).ToString() + "%";
        //}
    }
    #endregion
}
