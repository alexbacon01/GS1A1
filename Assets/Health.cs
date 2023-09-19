using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update
    public float currentHealth;
    public Boolean collision = false; //check if it has collided
    public float changeAmount;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        changeHealth();
        destroyObject();
        Debug.Log(currentHealth);
        Debug.Log(changeAmount);
    }

    public void changeHealth()
    {
        if (collision)
        {
            currentHealth += changeAmount;
           
            collision = false;
        }
    }

    public void destroyObject()
    {

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
