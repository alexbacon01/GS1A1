using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileCollsion : MonoBehaviour
{
    // Start is called before the first frame update

    public bool destroyOnCollision = true;
    public GameObject objectToDestroy;
    public float damageAmount = -10f;
    public Boolean hasHit = false; //boolean to keep track if the collison has already occured

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Wall"))
        {
            destroyOnCollision = false;
        }
        else
        {
            destroyOnCollision = true;
        }
        if (destroyOnCollision)
        {
            objectToDestroy.GetComponent<Health>().changeAmount = damageAmount;
            objectToDestroy.GetComponent<Health>().collision = true;

        }

    }
}
