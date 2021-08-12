using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLogicManager : MonoBehaviour
{
    #region Field
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject hand;
    [SerializeField] private float lowGravityRange = 60f;

    private List<Ball> balls;

    #endregion

    #region Properties
    public GameObject Player
    {
        get { return player; }
    }
    public GameObject Hand
    {
        get { return hand; }
    }

    public List<Ball> Balls
    {
        get { return balls; }
    }

    #endregion

    #region Start & Update
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < balls.Count; i++)
        {
            GravityCheck(balls[i]);
            UpdateShakeValues(balls[i]);
        }
    }
    #endregion

    #region Functions
    void GravityCheck(Ball ball)
    {
        Vector3 distance = ball.gameObject.transform.position - player.transform.position;
        float length = distance.sqrMagnitude;

        if (length > lowGravityRange)
        {

            ball.body.gravityScale = 0.2f;
        }
        else
        {
            ball.body.gravityScale = 0.5f;
        }
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
            ball.shakeValue = 0.2f * (length / 5f);
        }
        else
        {
            ball.shakeValue = 0f;
        }
    }
    #endregion

}
