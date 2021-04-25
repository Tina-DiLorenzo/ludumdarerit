using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wiggle : MonoBehaviour
{
    public new Camera camera;
    public Rigidbody2D playerBody;
    public float wiggleThresh = 1f;
    public float wiggleForce = 40f;

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

        float force = delta.magnitude * wiggleForce;


        Vector3 direction = worldPosition - transform.position;
        direction = direction.normalized;


        //if (force > wiggleThresh)
        //{
        //    playerBody.AddForceAtPosition(force * direction, gameObject.transform.position + gameObject.transform.up * -0.8f);
        //}

        Vector3 forcePosition = gameObject.transform.position + gameObject.transform.up * -0.8f;
        forcePosition += gameObject.transform.right * Random.Range(-0.2f, 0.2f);
        if (Input.GetMouseButton(0))
        {
            playerBody.AddForceAtPosition(wiggleForce * direction, forcePosition);
        }
        lastPos = worldPosition;
    }
}