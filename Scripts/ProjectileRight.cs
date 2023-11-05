using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProjectileR : MonoBehaviour
{
    private Rigidbody2D rb;
    public float force;
    private float timer;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // Vector2 direction = transform.right;
        rb.velocity = new Vector2(1, 0).normalized * force;
    }
    void Update() 
    {
        timer += Time.deltaTime;
        if (timer > 2) {
            Destroy(gameObject);
        }
    }

     void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.CompareTag("Player")) 
        {
              //other.gameObject.GetComponent<Player>().health -= 1;
            Debug.Log("Collision Triggered");
            SceneManager.LoadScene(5);
        }
        if(other.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }
}
