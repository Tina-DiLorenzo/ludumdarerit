using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    #region fields
    //width and height of the spawn area
    private float xBounds;
    private float yBounds;
    //vector that holds these x and y values
    private Vector3 spawnBounds;

    //Selected character numerical value
    private float playerSelected;

    //number of random point items that want to be spawned in
    public int numberOfItems = 1;

    //list of items spawned in
    public List<GameObject> items;



    #endregion


    void Start()
    {

        xBounds = GameManager.instance.spawnAreaWidth;
        yBounds = GameManager.instance.spawnAreaHeight;
        spawnBounds = new Vector3(xBounds, yBounds, 0);

        playerSelected = GameManager.instance.playerSelected;

        items = new List<GameObject>();


        //spawn items that can be collected
        for (int i = 0; i < numberOfItems; i++)
        {
            items.Add(SpawnItem(GameManager.instance.ticket));
        }

        //spawn win condition item
        items.Add(SpawnItem(playerSelected));
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
    GameObject SpawnItem(float characterId)
    {
        GameObject winCondition;

        switch (characterId)
        {
            default:
                winCondition = SpawnItem(GameManager.instance.miku);
                break;
        }

        return winCondition;
    }

    //drawns a gizmos to identify the bounds of spawn area
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, spawnBounds);
    }

}
