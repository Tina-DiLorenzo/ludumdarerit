using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    private PointTracker pointTracker;

    private void Start()
    {
        pointTracker = GameManager.instance.PointsText.GetComponent<PointTracker>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //testing the tag of the object colliding into the player
        switch (collision.collider.gameObject.tag)
        {
            case "Miku":
                PlayerPrefs.SetFloat("pointsCollected", pointTracker.Points);
                SceneManager.LoadScene(3);
                break;
            default:
                Debug.Log("I HIT " + collision.collider.gameObject.tag);
                pointTracker.AddToScore(5f);
                break;

        }
    }
}
