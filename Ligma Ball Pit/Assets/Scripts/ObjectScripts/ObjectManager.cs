using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    // fields

    public GameObject itemPrefab;
    public GameObject playerPrefab;
    public Rect pitCorrdinate;
    public float totalItems = 5;
    public List<GameObject> Items;

    // Maximum and Minimamu range for which items can spawn
    // Currently Unsure how items will spawn in the y direction
    private float maxX;
    private float minX;
    private float maxY;
    private float minY;




    // Start is called before the first frame update
    void Start()
    {
        SpawnAllItems();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject i in Items)
        {
            // If the player made contact with one of the items trigger it's affect 
            if(CollisionOccured(i, playerPrefab))
            {
                i.GetComponent<CollectableObject>().CollisionEvent();
            }
        }
    }
 

    // Spawns all the items in the pit
    void SpawnAllItems()
    {
        for (int i = 0; i < totalItems; i++)
        {

            //float XPosition = Random.Range(p)
        }
    }

    // Handle collision between the player and an object
    bool CollisionOccured(GameObject item, GameObject player)
    {
        //bool collision;
        //return true;
        return false;


    }

}
