using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private float movement;
    public float hiz = 1000f;
    public float speed = 15f;
    public Vector3 spawnpoint;
    public GameManager gameManager;

    void Start()
    {
        spawnpoint = transform.position;
        rb = this.gameObject.GetComponent<Rigidbody>();
        gameManager = FindObjectOfType<GameManager>();
    }

    private void FixedUpdate()
    {
        movement = Input.GetAxis("Horizontal");

        if (Input.GetKey("space"))
        {
            rb.AddForce(0, 0, hiz * Time.fixedDeltaTime);
        }
        rb.velocity = new Vector3(speed * movement, rb.velocity.y, rb.velocity.z);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Barrier"))
        {
            gameManager.RespawnPlayer();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("finisher"))
        {
            gameManager.LevelUp();

        }
        if (other.CompareTag("lastfinisher"))
        {
            SceneManager.LoadScene(0);
        }

    }
    
}