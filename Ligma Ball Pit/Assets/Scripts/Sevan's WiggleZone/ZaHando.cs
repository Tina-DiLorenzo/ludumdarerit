using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZaHando : MonoBehaviour
{
    public GameObject player;
    public float speed;
    void Update()
    {
        gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, player.transform.position, speed * Time.deltaTime);
    }
}
