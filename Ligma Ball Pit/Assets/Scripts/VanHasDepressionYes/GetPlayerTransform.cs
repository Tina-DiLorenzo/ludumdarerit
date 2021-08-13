using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPlayerTransform : MonoBehaviour
{
    [SerializeField]private GameObject gameObject; 
    public Transform Transform
    {
        get { return gameObject.transform; }
    }

    public GameObject GameObject
    {
        get { return gameObject; }
    }

}
