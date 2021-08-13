using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    public float radius = 1;
    public GameObject player;

    /// <summary>
    /// Game starts if player is close enough and the game object is clicked
    /// </summary>
    private void OnMouseDown()
    {
        if (!player.GetComponent<PlayerMove>().Running) return;
        if (!CheckRadius()) return;

        SceneManager.LoadScene("newGameScene");
    }

    /// <summary>
    /// Checks radius between current gameobject and player
    /// </summary>
    /// <returns></returns>
    private bool CheckRadius()
    {
        if (Vector2.Distance(this.gameObject.transform.position, player.gameObject.transform.position) < radius)
        {
            return true;
        }
        return false;
    }
}
