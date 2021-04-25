using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableObject : MonoBehaviour
{
    // Enums for each of the different item types
    public enum ItemType
    {
        pointIncrease,
        flashbang,
        stickyCaltrops

    }
    public ItemType thisItem;
    private Vector3 pos;
    

    // Start is called before the first frame update
    void Start()
    {
        // Set the items sprite based on the enum typ
        switch(thisItem)
        {
            case ItemType.pointIncrease:
                break;
            case ItemType.flashbang:
                break;
            case ItemType.stickyCaltrops:
                break;
        }
    }

    // Called by the item manager whenever an item is picked up by the player
   void CollisionEvent()
   {
        switch (thisItem)
        {
            case ItemType.pointIncrease:
                break;
            case ItemType.flashbang:
                break;
            case ItemType.stickyCaltrops:
                break;
        }
    }
}
