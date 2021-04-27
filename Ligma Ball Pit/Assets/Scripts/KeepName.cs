using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepName : MonoBehaviour
{
    private string characterName;

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

    public void SetName(string name)
    {
        characterName = name;
    }
}
