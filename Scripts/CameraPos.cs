using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPos : MonoBehaviour
{
    public Transform playerposition;
    public Vector3 campos;
    void Start()
    {
        
    }

    void Update()
    {
        this.gameObject.transform.position = playerposition.position + campos;
        
    }
}
