using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootCannoball : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public float forceAmount = 1f;
    public bool destroyOnCollision = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        moveCannonball();
    }

    void moveCannonball()
    {
        rb.AddForce(transform.up * forceAmount, ForceMode2D.Impulse);
        Debug.Log("fired");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (destroyOnCollision)
        {
            Destroy(collision.gameObject);
        }
    }
}
