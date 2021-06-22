using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Script to get name of player
/// Useful for getting attributes
/// </summary>
public class KeepName : MonoBehaviour
{
    [SerializeField]
    private string characterName;

    //I recommend using this for getting the characters associated objects
    public string CharacterName
    {
        get { return characterName; }
    }


    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        WiggleAnimate.characterName = characterName;
    }

    /// <summary>
    /// Sets name of player. This should be a property, but i think i wrote this method duringa  gamejam moment and I genuinely do not 
    /// feel like hunting thru all the scripts to fix it if it was used I am so sorry
    /// </summary>
    /// <param name="name"></param>
    public void SetName(string name)
    {
        characterName = name;
    }
}
