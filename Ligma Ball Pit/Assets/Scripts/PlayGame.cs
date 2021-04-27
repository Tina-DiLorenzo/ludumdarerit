using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    public float radius = 1;
    public int scene;
    public GameObject player;
    public bool checkingRadius;
    public bool checkRunning;

    private void OnMouseDown()
    {
        if (checkRunning && !PlayerMove.running) return;
        if (checkingRadius && !CheckRadius()) return;

        SceneManager.LoadScene(scene);
    }
    private bool CheckRadius()
    {

        if (Vector2.Distance(this.gameObject.transform.position, player.gameObject.transform.position) < radius)
        {
            return true;
        }

        return false;
    }
}
