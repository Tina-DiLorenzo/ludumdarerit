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
    private bool talking = false;
    private Queue<char> parser = new Queue<char>();
    private float timer;
    private bool canSkip;
    Queue<string> scripts = new Queue<string>();
    public Text nameField;
    public GameObject[] hideObjects;
    private PlayerMove gameRunning;

    //Script chat 
    //Yes i originally said this would be .txt based. Then i looked at calc grade ;_; so we are speed running
    string script1 = "Pizza Man: Mamamia why does the ball pit smell like blood?";
    string script2 = "Pizza Man: That's a spicy sauce!";
    string script4 = "Pizza Man: Would you like a sawcon shake?";
    string script5 = "Pizza Man: Want some ligma pizza? The pizza is so good that I wanna ligma fingers!";
    string[] scriptToSay;
    public static int scriptCount = 0;


    public bool CanSkip
    {
        get { return canSkip; }
        set { canSkip = value; }
    }

    public bool Talking
    {
        get { return talking; }
        set { talking = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        gameRunning = player.GetComponent<PlayerMove>();
        canSkip = false;
        timer = 0;
        talkArea.alpha = 0;
        talk = this.gameObject.GetComponent<AudioSource>();
        talkText.text = "";
        scripts.Enqueue(script2);
        scripts.Enqueue(script5);
        scripts.Enqueue(script1);
        scripts.Enqueue(script4);
        talking = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (talking)
        {
            //Hides player from view
            for (int i = 0; i < hideObjects.Length; i++)
            {
                hideObjects[i].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
            }

            //Character talks to character
            timer += Time.deltaTime;
            if(timer > .02)
            {
                timer = 0;
                if(parser.Count != 0) talkText.text = talkText.text + parser.Dequeue();
                canSkip = true;
            }
        }
        //Pizza man has nothing left to say and cannot be talked to again
        else if(scriptCount <= 0)
        {
            talking = false;
            talkArea.alpha = 0;
            talk.Stop();
            canSkip = false;
        }
        
        //Makes sure player is visible when the player is done talking. 
        if (!talking && !player.GetComponent<PlayerMove>().Running && player.GetComponent<SpriteRenderer>().sprite != null)
        {
            for (int i = 0; i < hideObjects.Length; i++)
            {
                hideObjects[i].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
            }
            player.GetComponent<PlayerMove>().Running = true;
        }
    }

    /// <summary>
    /// When the player clicks, pizza man SPEAKS if hes in range
    /// </summary>
    private void OnMouseDown()
    {
        //Check range
        if(Vector2.Distance(this.gameObject.transform.position, player.gameObject.transform.position) < radius && !talking 
                            && scripts.Count > 0)
        {
            //Talking visible and makes sure to clear past script
            talking = true;
            player.GetComponent<PlayerMove>().Running = false;
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

    /// <summary>
    /// Makes it so letters come out one by one
    /// </summary>
    /// <param name="str"></param>
    private void Parse(string str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            parser.Enqueue(str[i]);
        }
    }

    /// <summary>
    /// Gets new talking point from pizza man
    /// </summary>
    private void GetCurrentScript()
    {
        scriptToSay = scripts.Dequeue().Split(':');
    }
}
