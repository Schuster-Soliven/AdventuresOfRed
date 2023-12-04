using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    
    
    Vector3 defaultPos;
    [SerializeField] private float fallDelay = 0.15f, respawnTime = 2f;
    [SerializeField] Rigidbody2D rb;

    void Start()
    {
        defaultPos = transform.position;
        Debug.Log("Default Position is" + defaultPos);
        rb.GetComponent<Rigidbody2D>();
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
      if (collision.gameObject.CompareTag("Player"))
     {
            StartCoroutine(Fall());
     }
    }
    private IEnumerator Fall()
    {
        yield return new WaitForSeconds(fallDelay);
        rb.bodyType = RigidbodyType2D.Dynamic;
        yield return new WaitForSeconds(respawnTime);
        Reset();
    }

    private void Reset()
    {
        rb.bodyType = RigidbodyType2D.Static;
        transform.position = defaultPos;
    }
}
