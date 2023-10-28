using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Rigidbody2D rb;
    private Collider2D col;

    public float speed;

    public float x;
    public float y;

    private Vector2 direction;
    private Vector2 wallRight;
    int randomValue = 0;
    protected virtual void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
    }
    protected virtual void Start()
    {
        do
        {
            randomValue = Random.Range(-1, 2);
        } while (randomValue == 0);
        direction.x = randomValue;
        do
        {
            randomValue = Random.Range(-1, 2);
        } while (randomValue == 0);
        direction.y = randomValue;
    }

    protected virtual void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            ApplyEffect();

            Vector2 wallNormal = collision.transform.right;

            Vector2 reflectedDirection = Vector2.Reflect(direction, wallNormal);

            direction = reflectedDirection;

        }
    }
    protected virtual void ApplyEffect()
    {

    }
}
