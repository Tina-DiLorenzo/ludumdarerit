using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class WiggleAnimate : MonoBehaviour
{
    public Animator wiggleAniamator;
    Dictionary<string, int> playerDict = new Dictionary<string, int>();
    public static bool selected;
    public static string characterName;


    private void Start()
    {
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
        if (characterName == null) return;

        wiggleAniamator.SetInteger("Character", playerDict[characterName]);

    }
}
