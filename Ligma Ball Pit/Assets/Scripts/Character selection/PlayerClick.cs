using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerClick : MonoBehaviour
{
    public GameObject charMan;


    // Update is called once per framev
    private void Start()
    {
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        //Selected character
        charMan.GetComponent<CharacterManager>().Selected = this.gameObject;
    }
}
