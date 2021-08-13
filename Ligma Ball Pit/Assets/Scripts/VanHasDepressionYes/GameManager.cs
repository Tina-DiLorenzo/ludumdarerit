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
    #region Fields
    [Header("Collectibles")]
    [SerializeField] private GameObject chewedGum;
    [SerializeField] private GameObject gum;
    [SerializeField] private GameObject boba;
    [SerializeField] private GameObject ticket;
    [SerializeField] private GameObject miku;
    [SerializeField] private GameObject tiger;
    [SerializeField] private GameObject bottle;
    [SerializeField] private GameObject cat;
    [SerializeField] private GameObject dino;

    [Header("Players")]
    [SerializeField] private GameObject vanPrefab;
    [SerializeField] private GameObject tinaPrefab;
    [SerializeField] private GameObject emmaPrefab;
    [SerializeField] private GameObject sevanPrefab;

    [Header("Objects in scene")]
    [SerializeField] private GameObject pointsText;
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] private GameObject handSpawnPoint;
    [SerializeField] private float spawnAreaHeight = 10;
    [SerializeField] private float spawnAreaWidth = 10;

    //number of player picked and what skin should be assigned to player/win objective
    private float playerSelected;
    private List<GameObject> items;
    private GameObject player;

    [SerializeField] private GameObject handPrefab;

    private GameObject hand;

    #region Singleton definition
    public static GameManager instance;
    private void Awake()
    {
        instance = this;
    }
    #endregion

    #endregion

    #region Properties
    public GameObject Hand
    {
        get { return hand; }
    }
    public GameObject ChewedGum
    {
        get { return chewedGum; }
    }
    public GameObject Gum
    {
        get { return gum; }
    }
    public GameObject Boba
    {
        get { return boba; }
    }
    public GameObject Ticket
    {
        get { return ticket; }
    }
    public GameObject Miku
    {
        get { return miku; }
    }
    public GameObject Tiger
    {
        get { return tiger; }
    }
    public GameObject Bottle
    {
        get { return bottle; }
    }
    public GameObject Cat
    {
        get { return cat; }
    }
    public GameObject Dino
    {
        get { return dino; }
    }
    public GameObject VanPrefab
    {
        get { return vanPrefab; }
    }
    public GameObject EmmaPrefab
    {
        get { return emmaPrefab; }
    }
    public GameObject SevanPrefab
    {
        get { return sevanPrefab; }
    }
    public GameObject TinaPrefab
    {
        get { return tinaPrefab; }
    }
    public GameObject PointsText
    {
        get { return pointsText; }
    }
    public List<GameObject> Items
    {
        get { return items; }
    }
    public GameObject SpawnPoint
    {
        get { return spawnPoint; }
    }
    public float SpawnAreaHeight
    {
        get { return spawnAreaHeight; }
    }
    public float PlayerSelected
    {
        get { return playerSelected; }
    }
    public float SpawnAreaWidth
    {
        get { return spawnAreaWidth; }
    }
    public GameObject Player
    {
        get { return player; }
    }
    #endregion

    #region Start & Update
    
    void Start()
    {
        playerSelected = PlayerPrefs.GetFloat("charNum");
        switch (playerSelected)
        {
            //spawns player based off which # is selected
            case 0.0f: //Van
                player = Instantiate(vanPrefab, spawnPoint.transform.position, Quaternion.identity);
                break;
            case 1.0f: //Emma
                player = Instantiate(emmaPrefab, spawnPoint.transform.position, Quaternion.identity);
                break;
            case 2.0f:
                player = Instantiate(sevanPrefab, spawnPoint.transform.position, Quaternion.identity);
                break;
            case 3.0f:
                player = Instantiate(TinaPrefab, spawnPoint.transform.position, Quaternion.identity);
                break;
            case 4.0f:
                player = Instantiate(TinaPrefab, spawnPoint.transform.position, Quaternion.identity);
                break;
            case 5.0f:
                player = Instantiate(TinaPrefab, spawnPoint.transform.position, Quaternion.identity);
                break;
            default:
                player = Instantiate(VanPrefab, spawnPoint.transform.position, Quaternion.identity);
                break;
        }
        hand = Instantiate(handPrefab, handSpawnPoint.transform);
    }
    void Update()
    {
    }
    #endregion

    #region Gizmos
    //draws red square to show spawn area
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, new Vector3(spawnAreaWidth, spawnAreaHeight, 0));
    }
    #endregion

    #region ToDoList

    #endregion

}
