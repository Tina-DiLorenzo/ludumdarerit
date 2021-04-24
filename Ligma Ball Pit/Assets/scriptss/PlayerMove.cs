using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //Movement vectors
    public float pos;
    public float velo;
    public Camera cam;

    //Movement floats
    public float maxSpeed = 1f;
    public float radius = .2f;
    bool walking = false;

    //Testing force
    private Vector3 targetPos;

    float mousePos;
    Vector3 mouseScreen;


    protected void Start()
    {   //Starting positioning
        cam = Camera.main;
        pos = transform.position.x;

        targetPos = transform.position;
    }


    protected void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            mouseScreen = Input.mousePosition;
            mouseScreen = cam.ScreenToWorldPoint(mouseScreen);
            targetPos.x = mouseScreen.x;
            walking = true;
        }

        if (Mathf.Abs(transform.position.x - pos) < radius)
        {
            walking = false;
        }
        transform.position = Vector3.MoveTowards(transform.position, targetPos, maxSpeed);
    }


}
