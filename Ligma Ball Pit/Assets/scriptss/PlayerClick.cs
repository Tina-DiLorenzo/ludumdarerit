using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerClick : MonoBehaviour
{
    public Button yourButton;

    // Update is called once per framev
    private void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        //Selected character
        CharacterManager.selected = this.gameObject;
    }
}
