using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MoveScript : MonoBehaviour
{
    public GameObject pointA;
    public GameObject pointB;
    private Rigidbody2D rb;
    private Animator anim;
    private Transform currentPoint;
    public float speed;
    private float timer;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        currentPoint = pointB.transform;
        anim.SetBool("isRunning", true);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = currentPoint.position - transform.position;
        if(currentPoint == pointB.transform) {
            rb.velocity = new Vector2(speed, 0);
        } else {
            rb.velocity = new Vector2(-speed, 0);
        } 

        if (Vector2.Distance(transform.position, currentPoint.position) < .5f && currentPoint == pointB.transform) {
            anim.SetBool("isRunning", false);
            timer += Time.deltaTime;
            if (timer > 4) {
                timer = 0;
                anim.SetBool("isRunning", true);
                flip();
                currentPoint = pointA.transform;
            }
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < .5f && currentPoint == pointA.transform) {
            anim.SetBool("isRunning", false);
            timer += Time.deltaTime;
            if (timer > 4) {
                timer = 0;
                anim.SetBool("isRunning", true);
                flip();
                currentPoint = pointB.transform;
            }
        }
    }
    private void flip() {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
}
