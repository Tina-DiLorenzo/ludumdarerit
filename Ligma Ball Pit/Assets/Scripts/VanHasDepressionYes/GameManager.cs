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
    #region chewedGum
    [SerializeField] private GameObject chewedGum;
    public GameObject ChewedGum
    {
        get { return chewedGum; }
    }
    #endregion

    #region gum
    [SerializeField] private GameObject gum;
    public GameObject Gum
    {
        get { return gum; }
    }
    #endregion

    #region boba
    [SerializeField] private GameObject boba;
    public GameObject Boba
    {
        get { return boba; }
    }
    #endregion

    #region ticket
    [SerializeField] private GameObject ticket;
    public GameObject Ticket
    {
        get { return ticket; }
    }
    #endregion

    #region miku
    [SerializeField] private GameObject miku;
    public GameObject Miku
    {
        get { return miku; }
    }
    #endregion

    #region tiger
    [SerializeField] private GameObject tiger;
    public GameObject Tiger
    {
        get { return tiger; }
    }
    #endregion


    //player prefabs
    #region vanPrefab
    [SerializeField] private GameObject vanPrefab;
    public GameObject VanPrefab
    {
        get { return vanPrefab; }
    }
    #endregion

    #region tinaPrefab
    [SerializeField] private GameObject tinaPrefab;
    public GameObject TinaPrefab
    {
        get { return tinaPrefab; }
    }
    #endregion


    //objects in scene
    private GameObject player;
    private GameObject hand;

    #region pointsText
    [SerializeField] private GameObject pointsText;

    public GameObject PointsText
    {
        get { return pointsText; }
    }
    #endregion

    #region items
    private List<GameObject> items;
    public List<GameObject> Items
    {
        get { return items; }
    }
    #endregion

    #region spawnPoint
    [SerializeField] private GameObject spawnPoint;
    public GameObject SpawnPoint
    {
        get { return spawnPoint; }
    }
    #endregion


    //number of player picked and what skin should be assigned to player/win objective
    #region playerSelected;
    private float playerSelected;
    public float PlayerSelected
    {
        get { return playerSelected; }
    }
    #endregion

    private float points; //points accumulated this round, passed to the victory/lose scene

    #region spawnAreaHeight
    [SerializeField] private float spawnAreaHeight = 10;
    public float SpawnAreaHeight
    {
        get { return spawnAreaHeight; }
    }
    #endregion

    #region spawnAreaWidth
    [SerializeField] private float spawnAreaWidth = 10;
    public float SpawnAreaWidth
    {
        get { return spawnAreaWidth; }
    }
    #endregion

    #region singleton definition
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
                player = Instantiate(TinaPrefab, spawnPoint.transform);
                break;
            default:
                player = Instantiate(VanPrefab, spawnPoint.transform);
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
    //collision checks for prefabs
    //link selection menu to game scene and game scene to end credits
    #endregion

}
