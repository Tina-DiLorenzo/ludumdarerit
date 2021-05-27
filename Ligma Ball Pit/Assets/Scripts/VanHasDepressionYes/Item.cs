using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //amount of points the item is worth
    public int pointValue = 0;
    void Start()
    {
        
    }

    /// <summary>
    /// Method that triggers when player and item collides
    /// Will by default return 0
    /// </summary>
    int Collided()
    {
        //by default this should just delete the item
        return pointValue;
    }
}
