using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkToPlayer : MonoBehaviour
{
    public GameObject player;
    public float radius = .3f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if(Vector2.Distance(this.gameObject.transform.position, player.gameObject.transform.position) < radius)
        {
            Debug.Log("blah blah!");
        }
    }
}
