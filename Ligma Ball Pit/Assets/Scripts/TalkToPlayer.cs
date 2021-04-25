using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkToPlayer : MonoBehaviour
{
    public GameObject player;
    public float radius = .3f;
    private AudioSource talk;
    public CanvasGroup talkArea;
    public Text talkText;
    private bool talking;
    private Queue<char> parser = new Queue<char>();
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        talkArea.alpha = 0;
        talk = this.gameObject.GetComponent<AudioSource>();
        talkText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if(talking)
        {
            timer += Time.deltaTime;
            if(timer > .2)
            {
                timer = 0;
                if(parser.Count != 0) talkText.text = talkText.text + parser.Dequeue();
                else
                {
                    talking = false;
                    talkArea.alpha = 0;

                }
            }
        }
    }

    private void OnMouseDown()
    {
        if(Vector2.Distance(this.gameObject.transform.position, player.gameObject.transform.position) < radius)
        {
            talking = true;
            PlayerMove.running = false;
            talkArea.alpha = 1;
            Parse("mama mia!");
            talk.Play();
        }
    }

    private void Parse(string str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            parser.Enqueue(str[i]);
        }
    }


}
