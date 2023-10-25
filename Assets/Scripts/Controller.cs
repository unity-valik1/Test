using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Rigidbody2D rb;
    private Collider2D col;

    public float speed;
    protected virtual void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
    }
    protected virtual void Start()
    {
        Vector2 force = new Vector2(Random.Range(-6, 6), Random.Range(-6, 6)) * speed;
        rb.AddForce(force);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            col.isTrigger = false;
            ApplyEffect();
        }
    }
    protected virtual void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            col.isTrigger = true;
        }
    }
    protected virtual void ApplyEffect()
    {

    }
}
