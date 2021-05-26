using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    // fields
    public GameObject itemPrefab;
    public GameObject playerPrefab;
    public Rect pitCorrdinate;
    public int totalItems = 5;
    private int totalPoints;
    public GameObject gameWinningObject;
    public List<GameObject> itemsList;
    
    // Array of the different sprites the items will inherit
    public Sprite[] itemSprites;


    // Maximum and Minimamu range for which items can spawn
    // Currently Unsure how items will spawn in the y direction
    private float maxX;
    private float minX;
    private float maxY;
    private float minY;

    private float itemWidth;
    private float itemHeight;

    // Start is called before the first frame update
    void Start()
    {
        itemWidth = itemPrefab.GetComponent<SpriteRenderer>().bounds.size.x;
        itemHeight = itemPrefab.GetComponent<SpriteRenderer>().bounds.size.y;

        // The maximum x position that an item can be while within the bounds
        maxX = (pitCorrdinate.x + (pitCorrdinate.width/2) - itemWidth);
        // The maximum x position that an item can be while within the bounds
        minX = (pitCorrdinate.x - (pitCorrdinate.width / 2) + itemWidth);
        // The maximum y position that an item can be while within the bounds
        maxY = (pitCorrdinate.y + (pitCorrdinate.height / 2) - itemHeight);
        // The maximum y position that an item can be while within the bounds
        minY = (pitCorrdinate.y - (pitCorrdinate.height / 2) + itemHeight);

        // Instanciate the items
        SpawnAllItems();
        totalPoints = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // for all of the items spawned
        foreach (GameObject i in itemsList)
        {
            // If the player made contact with one of the items trigger it's affect 
            if(CollisionOccured(i))
            {
                i.GetComponent<CollectableObject>().CollisionEvent();
                totalPoints += PointIncrease(i);
            }
        }
    }
 

    // Spawns all the items in the pit
    void SpawnAllItems()
    {
        for (int i = 0; i < totalItems; i++)
        {
            // Generate an item enum type, does not include the final win game object
            int itemEnum = Random.Range(0, (itemSprites.Length-1));

            // Generate a specific item based on the type generated
            GameObject generatedItem = generateItem((CollectableObject.ItemType)itemEnum);

            // Generate a position for the object to inherit
            Vector3 intitalPosition = SpawnLocation(i);

            generatedItem.transform.position = intitalPosition;

            // instacate the item and add it to the list
            itemsList.Add(Instantiate(generatedItem, generatedItem.transform.position, Quaternion.identity));

        }
        // Add the game winning object to the list
        itemsList.Add(gameWinningObject);
    }

    

    GameObject generateItem(CollectableObject.ItemType spawnItemType)
    {
        GameObject itemToSpawn = itemPrefab;
        
        // Set the sprite of the item to spawn coresponds to the enumerable value passed in
       // itemToSpawn.GetComponent<SpriteRenderer>().sprite = itemSprites[(int)spawnItemType];

        // Set the point value and type of the item to spawn coresponding to the enumerable value passed in
        itemToSpawn.GetComponent<CollectableObject>().InitializeItem(spawnItemType);

        return itemToSpawn;
    }

    // Generate a random spawn location in the pit based on the item's order
    Vector3 SpawnLocation(int itemIndex)
    {
        Vector3 itemPosition = Vector3.zero;
        // Set the x position to a random value within the bounds
        itemPosition.x = Random.Range(minX, maxX);

        // Section off each item's spawning height range so they don't overlap 
        // Kind of having trouble with this one, so for the time being Im going to make spawning truely random
        //itemPosition.y = Random.Range(minY + (((totalItems-1) - itemIndex) / pitCorrdinate.height), maxY - (itemIndex/pitCorrdinate.height));
        itemPosition.y = Random.Range(minY, maxY);

        return itemPosition;
    }

    // When the player comes into contact with an item the score is increased by the item's value
    int PointIncrease(GameObject item)
    {
        return item.GetComponent<CollectableObject>().pointValue;
    }


    // Handle collision between the player and an object
    // Uses AABB collision
    bool CollisionOccured(GameObject item)
    {
        Bounds itemBounds = item.GetComponent<SpriteRenderer>().bounds;
        Bounds playerBounds = playerPrefab.GetComponent<SpriteRenderer>().bounds;


        // Check all the sides if they're overlapping
        if (itemBounds.max.y > playerBounds.min.y
            && itemBounds.min.y < playerBounds.max.y
            && itemBounds.max.x > playerBounds.min.x
            && itemBounds.min.x < playerBounds.max.x)
        {
            return true;
        }

        return false;
    }

//this is an error that is commented out for now
//- Van
<<<<<<< HEAD
=======

    // Check Collision between the hand and a trap
    // Uses AABB collision
<<<<<<< HEAD
    //bool TrapTriggered(GameObject trapItem)
    //{
    //    Bounds itemBounds = trapItem.GetComponent<SpriteRenderer>().bounds;
    //    Bounds HandBounds = handReference.GetComponent<SpriteRenderer>().bounds;


    //    // Check all the sides if they're overlapping
    //    if (itemBounds.max.y > HandBounds.min.y
    //        && itemBounds.min.y < HandBounds.max.y
    //        && itemBounds.max.x > HandBounds.min.x
    //        && itemBounds.min.x < HandBounds.max.x)
    //    {
    //        return true;
    //    }

    //    return false;
    //}

    //void OnGUI()
    //{
    //    string message = "Score : " + totalPoints;
    //    GUILayout.TextArea(message);
    //    GUI.skin.box.wordWrap = true;
    //}
>>>>>>> 0767f333ad4fd4b14e24ec8084fb916d835b411e
=======
    bool TrapTriggered(GameObject trapItem)
    {
        Bounds itemBounds = trapItem.GetComponent<SpriteRenderer>().bounds;
        Bounds HandBounds = handReference.GetComponent<SpriteRenderer>().bounds;


        // Check all the sides if they're overlapping
        if (itemBounds.max.y > HandBounds.min.y
            && itemBounds.min.y < HandBounds.max.y
            && itemBounds.max.x > HandBounds.min.x
            && itemBounds.min.x < HandBounds.max.x)
        {
            return true;
        }

        return false;
    }
>>>>>>> parent of 4ef43ca (Updated stuff)
}
