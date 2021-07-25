using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;
using UnityEngine.EventSystems;// Required when using Event data.

public class CharacterManager : MonoBehaviour
{
    [SerializeField]
    private GameObject selected;

    public GameObject[] destroy;
    public AudioSource sound;
    public KeepName saveName;
    public GameObject charObj;
    public Button btn;


    public GameObject Selected
    {
        get { return selected; }
        set { selected = value; }
    }

    void Start()
    {
        btn.onClick.AddListener(TaskOnClick);
    }


    /// <summary>
    /// Selects character image 
    /// </summary>
    private void TaskOnClick()
    {
        //Destroys character select screen 
        if (selected != null)
        {
            saveName.SetName(selected.name);
            charObj.GetComponent<SpriteRenderer>().sprite = selected.GetComponent<Image>().sprite;

            PlayerPrefs.SetFloat("charNum", selected.GetComponent<PlayerClick>().charNum);
            
            sound.Play();
            charObj.GetComponent<PlayerMove>().Running = true;
            for(int i = 0; i < destroy.Length; i++)
            {
                Destroy(destroy[i]);
            }
            Destroy(gameObject);
        }
    }
}
