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
    private int pointValue;
    private Vector3 pos;
    

    // Start is called before the first frame update
    void Start()
    {
        // Set the items sprite and other fields based on the enum type
        switch(thisItem)
        {
            case ItemType.pointIncrease:
                pointValue = 10;
                break;
            case ItemType.flashbang:
                pointValue = 5;
                break;
            case ItemType.stickyCaltrops:
                pointValue = 5;
                break;
        }
    }

    // Called by the item manager whenever an item is picked up by the player
   public void CollisionEvent()
   {
        // When point
        PointIncrease();
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

    // Increase the point score 
    void PointIncrease()
    {

    }
}
