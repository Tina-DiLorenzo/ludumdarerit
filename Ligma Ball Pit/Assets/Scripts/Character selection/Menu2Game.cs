using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu2Game : MonoBehaviour
{

    /// <summary>
    /// Just changes to pizzaria scene
    /// </summary>
    private void OnMouseDown()
    {
        SceneManager.LoadScene(1);
    }
}
