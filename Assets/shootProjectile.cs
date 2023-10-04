using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootProjectile : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody2D rb; //the rigid body of projectile
    public float forceAmount = 1f; //force amount
    public GameObject target; //game object for target
    public float damage = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //get componenet rigid body
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void FixedUpdate()
    {
        if (rb != null) //if rb is not null
        {
            MoveProjectile(); //move the projectile
        }
    }

    //function to move the projectile
    void MoveProjectile()
    {
        rb.AddForce(target.transform.position * forceAmount, ForceMode2D.Impulse); //add force with impulse to shoot it instantly
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<Health>() != null)
        {
            collision.gameObject.GetComponent<Health>().changeAmount = damage;
        }

        Destroy(gameObject);
    }
}
