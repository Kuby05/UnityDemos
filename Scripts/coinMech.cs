using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinMech : MonoBehaviour
{
    private GameManager manager;
    public int scorevalue;
    public AudioSource ses;
    void Start()
    {
        manager = FindObjectOfType<GameManager>();
        
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))     
        {
            manager.AddScore(scorevalue);
            ses.Play();
            Destroy(this.gameObject);
            

        }
    }
}
