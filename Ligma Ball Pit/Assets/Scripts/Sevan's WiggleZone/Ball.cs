using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{


    public SpriteRenderer sprite;

    public float randScaleMin = 0.7f;
    public float randScaleMax = 1.2f;


    private CircleCollider2D collider;

    void Start()
    {
        // Temp color
        sprite.color = new Color(Random.Range(0.1f, 1f), Random.Range(0.1f, 1f), Random.Range(0.1f, 1f), 1f);
       
        collider = GetComponent<CircleCollider2D>();

        Vector3 newScale = transform.localScale;
        float randScale = Random.Range(randScaleMin, randScaleMax);
        newScale.x *= randScale;
        newScale.y *= randScale;
        transform.localScale = newScale;
    }

    void Update()
    {

    }
}
