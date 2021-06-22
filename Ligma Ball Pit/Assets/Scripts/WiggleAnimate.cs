using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class WiggleAnimate : MonoBehaviour
{
    public Animator wiggleAniamator;
    Dictionary<string, int> playerDict = new Dictionary<string, int>();
    public static bool selected;
    public static string characterName;
    private bool set = false;

   


    private void Start()
    {
        //adds names of players to get sprite animating properly
        name = "";
        selected = false;
        playerDict.Add("miles", 5);
        playerDict.Add("emma", 3);
        playerDict.Add("tina", 0);
        playerDict.Add("sofia", 4);
        playerDict.Add("van",1);
        playerDict.Add("sevan",2);
    }

    void Update()
    {
        if (characterName == null && !set) return;

        //makes sure correrect animation is playing
        set = true;
        wiggleAniamator.SetInteger("Character", playerDict[characterName]);

    }
}
