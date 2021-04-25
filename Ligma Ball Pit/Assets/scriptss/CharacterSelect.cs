using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour
{
    // Start is called before the first frame update
    Camera cam;
    private float velo;
    public float maxVelo;
    public float devisor = 3f;
    public float acceleration = 2;
    private float accel;
    private float dist;
    private Vector3 mouse;
    private bool right;
    private bool left;
    Vector3 pos;
    RectTransform rt;
    public Image[] arrows = new Image[2];
    public float alpha = 170f;
    private Color color;
    private Color colorChanged;

    public float radius = 20;

    void Start()
    {
        //Set up
        rt = GetComponent<RectTransform>();
        cam = Camera.main;
        pos = transform.position;
        velo = 0;
        color = arrows[0].color;
        colorChanged = color;
        colorChanged.a = 0;
        accel = 0;
    }

    // Update is called once per frame
    void Update()
    {
        dist = 0;
        mouse = cam.ScreenToWorldPoint(Input.mousePosition);
        dist = 0 - mouse.x;

        //Distance between mouse and center
        if(Mathf.Abs(dist) > radius)
        {
            accel = acceleration * (dist / devisor); //gets faster farther away
        }
        else
        {
            //STOP moving bitch
            accel = 0;
            velo = 0;
        }

        //Set values and clamp
        velo += accel * Time.deltaTime;
        if (velo > maxVelo) velo = maxVelo;
        if (velo < -maxVelo) velo = -maxVelo;
        pos.x += velo;

        //Dont go too far! Sets bounds
        if (pos.x > 1800)
        {
            arrows[1].color = colorChanged; //arrow is transparent!
            pos.x = 1800;
            accel = 0;
            return;
        }
        else if (pos.x < 100)
        {
            arrows[0].color = colorChanged; //arrow is transparent!
            pos.x = 100;
            accel = 0;
            return;
        }
        else
        {
            arrows[0].color = color;
            arrows[1].color = color;
        }

        transform.position = pos;
        
    }
}
