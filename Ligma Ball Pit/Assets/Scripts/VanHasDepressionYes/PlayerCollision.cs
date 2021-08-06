using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //testing the tag of the object colliding into the player
        switch (collision.collider.gameObject.tag)
        {
            default:
                Debug.Log("I HIT " + collision.collider.gameObject.tag);
                //GameManager.instance.Items.Remove(collision.collider.gameObject);
                //GameObject.Destroy(collision.collider.gameObject);
                break;
        }
        //if (collision.collider.gameObject.tag == "Coin")
        //{
            
        //}
        //else if (collision.collider.gameObject.tag == "Bomb")
        //{
        //    Debug.Log("I HIT THE BOMB");
        //    GameManager.instance.bombs.Remove(collision.collider.gameObject);
        //    GameObject.Destroy(collision.collider.gameObject);
        //    gameObject.GetComponent<UpdateGameState>().LoseMenu();
        //}
    }
}
