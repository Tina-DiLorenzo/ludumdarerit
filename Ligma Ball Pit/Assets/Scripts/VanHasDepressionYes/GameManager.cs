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

    [Header("Players")]
    [SerializeField] private GameObject vanPrefab;
    [SerializeField] private GameObject tinaPrefab;

    [Header("Objects in scene")]
    [SerializeField] private GameObject pointsText;
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] private float spawnAreaHeight = 10;
    [SerializeField] private float spawnAreaWidth = 10;

    //number of player picked and what skin should be assigned to player/win objective
    private float playerSelected;
    private List<GameObject> items;
    private GameObject player;
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
    public GameObject VanPrefab
    {
        get { return vanPrefab; }
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
    #endregion

    #region Start & Update
    void Start()
    {
        playerSelected = PlayerPrefs.GetFloat("charNum");
        switch (playerSelected)
        {
            //spawns player based off which # is selected
            case 1.0f:
                player = Instantiate(TinaPrefab, spawnPoint.transform);
                break;
            default:
                player = Instantiate(VanPrefab, spawnPoint.transform);
                break;
        }
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
