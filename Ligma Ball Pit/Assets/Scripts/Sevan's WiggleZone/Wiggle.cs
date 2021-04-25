using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wiggle : MonoBehaviour
{
    public new Camera camera;
    public Rigidbody2D playerBody;
    public float wiggleThresh = 1f;

    private Vector3 mousePosition;
    private Vector3 worldPosition;
    private Vector3 lastPos;
    private Vector3 delta;
    void Start()
    {
        mousePosition = Vector3.zero;
        worldPosition = Vector3.zero;
        lastPos = Vector3.zero;
        delta = Vector3.zero;
        lastPos = Vector3.zero;
    }


    void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition.z = camera.nearClipPlane;
        worldPosition = camera.ScreenToWorldPoint(mousePosition);


        delta = worldPosition - lastPos;

        float velocity = delta.magnitude * 40f;


        Vector3 direction = worldPosition - transform.position;
        direction = direction.normalized;


        if (velocity > wiggleThresh)
        {
            playerBody.AddForceAtPosition(velocity * direction, gameObject.transform.position + gameObject.transform.up * -0.7f);
        }
        else if (Input.GetMouseButton(0))
        {
            playerBody.AddForceAtPosition(20f * direction, gameObject.transform.position + gameObject.transform.up * -0.7f);
        }
        lastPos = worldPosition;
    }
}