using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    //contains the functions for buttons
    public void GotToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
