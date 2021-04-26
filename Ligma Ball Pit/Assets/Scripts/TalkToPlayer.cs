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
    public static bool talking = false;
    private Queue<char> parser = new Queue<char>();
    private float timer;
    public static bool canSkip;
    Queue<string> scripts = new Queue<string>();
    public Text nameField;

    //Script chat 
    //Yes i originally said this would be .txt based. Then i looked at calc grade ;_; so we are speed running
    string script1 = "Pizza Man: Mamamia why does the ball pit smell like blood?";
    string script2 = "Pizza Man: That's a spicy sauce!";
    string script4 = "Pizza Man: Would you like a sawcon shake?";
    string script5 = "Pizza Man: Want some ligma pizza? The pizza is so good that I wanna ligma fingers!";
    string[] scriptToSay;
    public static int scriptCount = 0;




    // Start is called before the first frame update
    void Start()
    {
        canSkip = false;
        timer = 0;
        talkArea.alpha = 0;
        talk = this.gameObject.GetComponent<AudioSource>();
        talkText.text = "";
        scripts.Enqueue(script2);
        scripts.Enqueue(script5);
        scripts.Enqueue(script1);
        scripts.Enqueue(script4);
    }

    // Update is called once per frame
    void Update()
    {
        if (talking)
        {
            timer += Time.deltaTime;
            if(timer > .02)
            {
                timer = 0;
                if(parser.Count != 0) talkText.text = talkText.text + parser.Dequeue();
                canSkip = true;
            }
        }
        else if(scriptCount <= 0)
        {
            talking = false;
            talkArea.alpha = 0;
            talk.Stop();
            PlayerMove.running = true;
            canSkip = false;
        }
    }

    private void OnMouseDown()
    {
        if(Vector2.Distance(this.gameObject.transform.position, player.gameObject.transform.position) < radius && !talking 
                            && scripts.Count > 0)
        {
            talking = true;
            PlayerMove.running = false;
            talkText.text = "";
            talkArea.alpha = 1;
            parser.Clear();
            GetCurrentScript();
            Parse(scriptToSay[1]);
            nameField.text = scriptToSay[0];

            canSkip = false;
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
    private void GetCurrentScript()
    {
        scriptToSay = scripts.Dequeue().Split(':');
    }
}
