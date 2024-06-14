using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    void Update()
    {
        this.gameObject.transform.Rotate(0, 0, 100f*Time.deltaTime);
    }
}
