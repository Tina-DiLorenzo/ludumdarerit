using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{


    public SpriteRenderer sprite;
    public float randScaleMin = 0.7f;
    public float randScaleMax = 1.2f;
    private List<Color> colors;
    private CircleCollider2D collider;

    void Start()
    {
        colors = new List<Color>();
        colors.Add(new Color(255f / 255f, 55f / 255f, 55f / 255f, 1f));
        colors.Add(new Color(55f / 255f, 255f / 255f, 55f / 255f, 1f));
        colors.Add(new Color(55f / 255f, 55f / 255f, 255f / 255f, 1f));
        int rng = Random.Range(0, colors.Count);
        Debug.Log(colors.Count);

        sprite.color = new Color(Random.Range(0.1f, 1f), Random.Range(0.1f, 1f), Random.Range(0.1f, 1f), 1f);
        collider = GetComponent<CircleCollider2D>();

        Vector3 newScale = transform.localScale;
        float randScale = Random.Range(randScaleMin, randScaleMax);
        newScale.x *= randScale;
        newScale.y *= randScale;
        transform.localScale = newScale;
        //collider.radius = 

    }


    void Update()
    {

    }
}
