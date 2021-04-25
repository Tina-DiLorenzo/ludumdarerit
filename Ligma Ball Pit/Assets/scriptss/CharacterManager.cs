using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;// Required when using Event data.

public class CharacterManager : MonoBehaviour
{
    public static GameObject selected;
    public GameObject canvas;
    public AudioSource sound;


    private void Update()
    {
        Button btn = this.gameObject.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        if (selected != null)
        {
            PlayerMove.sprite = selected.GetComponent<Image>().sprite;
            sound.Play();
            PlayerMove.running = true;
            Destroy(canvas);
        }
    }

}
