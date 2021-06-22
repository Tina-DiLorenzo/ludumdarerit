using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipCutscene : MonoBehaviour
{
    public GameObject talkArea;
    private TalkToPlayer talk;
    // Start is called before the first frame update
    void Start()
    {
        talk = talkArea.GetComponent<TalkToPlayer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (talk.CanSkip)
        {
            talk.Talking = false;
        }
    }
}
