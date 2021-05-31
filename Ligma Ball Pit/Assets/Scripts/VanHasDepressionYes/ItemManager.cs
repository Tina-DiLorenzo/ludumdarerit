using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    //width and height of range items can spawn
    public Vector3 spawnBounds = new Vector3(10, 10, 0);
    //Character numerical value
    public int characterId;

    //list of item prefabs
    public List<GameObject> itemPrefabs;

    //number of random point items that want to be spawned in
    private int numberOfItems = 1;

    //list of items spawned in
    public List<GameObject> items;



    void Start()
    {
        items = new List<GameObject>();
        //temporary section to spawn items
        for (int i = 0; i < numberOfItems; i++)
        {
            items.Add(SpawnItem(itemPrefabs[0]));
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// Spawns the item into the game world
    /// </summary>
    GameObject SpawnItem(GameObject prefab)
    {
        GameObject newItem = Instantiate(prefab);
        Vector3 newPos = transform.position;
        newPos.x += Random.Range(-spawnBounds.x / 2, spawnBounds.x / 2);
        newPos.y += Random.Range(-spawnBounds.y / 2, spawnBounds.y / 2);
        newItem.transform.position = newPos;

        return newItem;
    }

    //used to spawn in the main item character has to find
    void SpawnItem(GameObject prefab, int characterId)
    {

    }

    //drawns a gizmos to identify the bounds of spawn area
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawCube(transform.position, spawnBounds);
    }

}
