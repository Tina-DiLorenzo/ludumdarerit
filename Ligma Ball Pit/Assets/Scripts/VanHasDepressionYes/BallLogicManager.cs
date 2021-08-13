using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLogicManager : MonoBehaviour
{
    #region Field
    
    [SerializeField] private float lowGravityRange = 60f;
    [SerializeField] private BallSpawner ballSpawner;

    private GameObject player;
    private GameObject hand;

    #endregion

    #region Properties
    public GameObject Player
    {
        get { return player; }
    }

    #endregion

    #region Start & Update
    // Start is called before the first frame update
    void Start()
    {
        player = GameManager.instance.Player.transform.Find("Player").gameObject;
        hand = GameManager.instance.Hand;

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < ballSpawner.Balls.Count; i++)
        {
            GravityCheck(ballSpawner.Balls[i]);
            UpdateShakeValues(ballSpawner.Balls[i]);
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
