using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPlayerTransform : MonoBehaviour
{
    [SerializeField ]private Transform transform;
    public Transform Transform
    {
        get { return transform; }
    }

}
