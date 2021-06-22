using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //Movement vectors
    public float pos;
    public float velo;
    public Camera cam;
    private  Sprite sprite;
    private bool running = false;

    //Movement floats
    public float maxSpeed = 1f;
    public float radius = .2f;
    public static bool walking = false;

    //Testing force
    private Vector3 targetPos;

    float mousePos;
    Vector3 mouseScreen;

    public bool Running
    {
        get { return running; }
        set { running = value; }
    }

    public Sprite Sprite
    {
        get { return sprite; }
        set { sprite = value; }
    }

    void Start()
    {   //Starting positioning
        cam = Camera.main;
        pos = transform.position.x;
        targetPos = transform.position;
        running = false;

    }


    protected void Update()
    {
        if (!running) return;

        //Get mouse location on click
        if (Input.GetMouseButtonDown(0))
        {
            //Move player to spot on screen
            mouseScreen = Input.mousePosition;
            mouseScreen = cam.ScreenToWorldPoint(mouseScreen);
            targetPos.x = mouseScreen.x;
            walking = true;
        }

        //Makes sure animation is smooth
        if (walking == false) return;
        transform.position = Vector3.MoveTowards(transform.position, targetPos, maxSpeed);
    }


}
