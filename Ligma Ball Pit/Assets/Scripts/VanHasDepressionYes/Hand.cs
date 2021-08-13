using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    #region Fields
    [SerializeField]private float speed = .5f;
    private Transform playerTransform;
    //private Transform something;
    #endregion

    #region Start & Update
    private void Start()
    {
        playerTransform = GameManager.instance.Player.transform.Find("Player");
    }
    void Update()
    {
        //Debug.Log(playerTransform.position);
        gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, playerTransform.position, speed * Time.deltaTime);
    }
    #endregion

}
