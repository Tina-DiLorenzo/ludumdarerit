using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    #region Fields
    [SerializeField]private float speed = .5f;
    public GameObject player; //assigned in gameManager
    public Transform playerTransform;
    #endregion

    #region Start & Update
    private void Start()
    {
    }
    void Update()
    {
        gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, playerTransform.position, speed * Time.deltaTime);
    }
    #endregion

}
