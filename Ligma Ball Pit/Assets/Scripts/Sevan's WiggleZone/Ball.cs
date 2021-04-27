using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{


    public SpriteRenderer sprite;
    public GameObject spriteHolder;
    public Rigidbody2D body;
    public List<Sprite> spriteList = new List<Sprite>();

    public float randScaleMin = 0.7f;
    public float randScaleMax = 1.2f;

    public float shakeValue = 0f;

    private new CircleCollider2D collider;

    void Start()
    {
        collider = GetComponent<CircleCollider2D>();
        sprite.sprite = spriteList[Random.Range(0, 6)];

        Vector3 newScale = transform.localScale;
        float randScale = Random.Range(randScaleMin, randScaleMax);
        newScale.x *= randScale;
        newScale.y *= randScale;
        transform.localScale = newScale;
    }

    void Update()
    {
        spriteHolder.transform.localPosition = new Vector3(Random.Range(-shakeValue, shakeValue), Random.Range(-shakeValue, shakeValue), sprite.transform.localPosition.z);
    }
}
