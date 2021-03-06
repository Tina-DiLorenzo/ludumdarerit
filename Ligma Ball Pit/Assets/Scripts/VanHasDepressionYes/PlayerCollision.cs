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
            case "Ticket":
                ItemManager.instance.Items.Remove(collision.collider.gameObject);
                GameObject.Destroy(collision.collider.gameObject);
                pointTracker.AddToScore(5f);
                break;
            case "Bottle":
                PlayerPrefs.SetFloat("pointsCollected", pointTracker.Points);
                SceneManager.LoadScene("endScene");
                break;
            case "Cat":
                PlayerPrefs.SetFloat("pointsCollected", pointTracker.Points);
                SceneManager.LoadScene("endScene");
                break;
            case "Dino":
                PlayerPrefs.SetFloat("pointsCollected", pointTracker.Points);
                SceneManager.LoadScene("endScene");
                break;
            case "Miku":
                PlayerPrefs.SetFloat("pointsCollected", pointTracker.Points);
                SceneManager.LoadScene("endScene");
                break;
            case "Tiger":
                PlayerPrefs.SetFloat("pointsCollected", pointTracker.Points);
                SceneManager.LoadScene("endScene");
                break;
            case "Boba":
                PlayerPrefs.SetFloat("pointsCollected", pointTracker.Points);
                SceneManager.LoadScene("endScene");
                break;


            default:
                //Debug.Log("I HIT " + collision.collider.gameObject.tag);
                break;

        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("Handy no touchy UwU");
        if (other.gameObject.tag == "Hand")
        {
            //Debug.Log("1");
            //a fun way so the hand can't kill the player before they load into the game
            if (pointTracker.Points > 4)
            {
                //Debug.Log("2");
                PlayerPrefs.SetFloat("pointsCollected", pointTracker.Points);
                SceneManager.LoadScene("endScene");
            }
            
        }
    }
}
