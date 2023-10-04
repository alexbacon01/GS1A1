using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootCannoball : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public float forceAmount = 1f;
    public float damageAmount = -10;
    public GameObject objectHit;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if(rb != null)
        {
            moveCannonball();
        }
    }

    void moveCannonball()
    {
        rb.AddForce(transform.up * forceAmount, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Health>() != null)
        {
            collision.gameObject.GetComponent<Health>().changeAmount = damageAmount;
            collision.gameObject.GetComponent<Health>().collision = true;
        }
        Destroy(gameObject);
    }
}
