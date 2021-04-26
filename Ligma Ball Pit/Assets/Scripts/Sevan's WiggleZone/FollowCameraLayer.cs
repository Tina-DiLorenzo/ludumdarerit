using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCameraLayer : MonoBehaviour
{
    public GameObject cameraObject;
    public float yOffset = 10f;

    private float lastY;

    void Start()
    {
        lastY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 newPos = gameObject.transform.position;
        newPos.y = cameraObject.transform.position.y + yOffset;

        gameObject.transform.position = newPos;
        lastY = transform.position.y;

    }
}
