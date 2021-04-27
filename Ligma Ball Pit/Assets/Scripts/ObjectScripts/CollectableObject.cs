using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectableObject : MonoBehaviour
{
    // Enums for each of the different item types
    public enum ItemType
    {
        pointIncrease,
        stickyCaltrops,
        chewedGum,
        gameWinningObject
    }
    // Enum to represent the Item Type
    public ItemType thisItem;

    // The value of points that the item awards
    public int pointValue;
    
    // Wether or no the item is set to its correct sprite/point value
    private Vector3 pos;
    

    public void InitializeItem(ItemType newItemTpye)
    {
        thisItem = newItemTpye;
     
            // Set the individual point value and sprite
            switch (thisItem)
            {
                case ItemType.pointIncrease:
                    pointValue = 10;
                    break;
                case ItemType.gameWinningObject:
                    pointValue = 0;
                    break;
                case ItemType.chewedGum:
                    pointValue = 0;
                    break;
                case ItemType.stickyCaltrops:
                    pointValue = 5;
                    break;
            }

        
    }

    // Called by the item manager whenever an item is picked up by the player
    // Score increas is handled by the object manager
    public void CollisionEvent()
   {
        switch (thisItem)
        {
            case ItemType.pointIncrease:
                break;
            case ItemType.gameWinningObject: 
                SceneManager.LoadScene(0);
                break;
            case ItemType.chewedGum:
                break;
            case ItemType.stickyCaltrops:
                InitializeItem(ItemType.chewedGum);
                break;
            

        }
   }
}
