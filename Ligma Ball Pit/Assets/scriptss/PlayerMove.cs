using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //Movement vectors
    public float pos;
    public float velo;
    public Camera cam;
    public static Sprite sprite;
    public static bool running = false;

    //Movement floats
    public float maxSpeed = 1f;
    public float radius = .2f;
    public static bool walking = false;

    //Testing force
    private Vector3 targetPos;

    float mousePos;
    Vector3 mouseScreen;


    void Start()
    {   //Starting positioning
        cam = Camera.main;
        pos = transform.position.x;

        targetPos = transform.position;
    }


    protected void Update()
    {
        if (!running) return;
        else
        {
            this.GetComponent<SpriteRenderer>().sprite = sprite;
        }

        //Get mouse location on click
        if (Input.GetMouseButtonDown(0))
        {
            mouseScreen = Input.mousePosition;
            mouseScreen = cam.ScreenToWorldPoint(mouseScreen);
            targetPos.x = mouseScreen.x;
            walking = true;
        }

        if (walking == false) return;
        //for animation
        //if (Mathf.Abs(transform.position.x - pos) < radius) walking = false;

        //Player walks towards position
        transform.position = Vector3.MoveTowards(transform.position, targetPos, maxSpeed);
    }


}
