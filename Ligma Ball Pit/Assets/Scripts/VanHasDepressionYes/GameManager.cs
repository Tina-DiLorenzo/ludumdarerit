using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Spawns in items (including win objective)
/// Manages collisions between the player and objects in the
/// game scene. 
/// Manages win and lose condition
/// </summary>
public class GameManager : MonoBehaviour
{
    #region fields
    //prefabs
    public GameObject chewedGum;
    public GameObject gum;
    public GameObject boba;
    public GameObject ticket;
    public GameObject miku;
    public GameObject tiger;

    //player prefabs
    public GameObject VanPrefab;
    public GameObject TinaPrefab;

    //objects in scene
    public GameObject player;
    public GameObject hand;
    public List<GameObject> items;

    public GameObject spawnPoint;

    //values passed between scenes
    public float playerSelected; //number of player picked and what skin should be assigned to player/win objective

    private float points; //points accumulated this round, passed to the victory/lose scene

    public float spawnAreaHeight = 10;
    public float spawnAreaWidth = 10;

    #region singleton
    public static GameManager instance;
    private void Awake()
    {
        instance = this;
    }
    #endregion

    #endregion

    #region start
    void Start()
    {
        playerSelected = PlayerPrefs.GetFloat("charNum");
        switch (playerSelected)
        {
            //spawns player based off which # is selected
            case 1.0f:
                Instantiate(TinaPrefab, spawnPoint.transform);
                break;
            default:
                Instantiate(VanPrefab, spawnPoint.transform);
                break;
        }
    }
    #endregion

    #region update
    void Update()
    {

    }
    #endregion

    #region Red square used to show spawn area
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, new Vector3(spawnAreaWidth, spawnAreaHeight, 0));
    }
    #endregion

    #region toDoList
    //comments to read later on what needs to be done
    //collision checks for prefabs
    //spawning prefabs in random locations inside the spawn area
    //link selection menu to game scene and game scene to end credits
    #endregion

}
