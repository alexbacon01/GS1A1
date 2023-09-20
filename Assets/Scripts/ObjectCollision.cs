using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class ObjectCollision : MonoBehaviour
    
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
        if (destroyOnCollision)
        {
            objectToDestroy.GetComponent<Health>().changeAmount = damageAmount;
            objectToDestroy.GetComponent<Health>().collision = true;
        }
        if (destroyOnCollision && collision.gameObject.name.Contains("Enemy"))
        {
           Destroy(objectToDestroy);
        }
    }
}
