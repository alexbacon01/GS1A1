using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxHealth = 100;
    public float currentHealth;
    public Boolean collision = false; //check if it has collided
    public float changeAmount;
    public Image healthBar;
    public float lives = 3;
    public Vector3 startPos;
    public GameObject map;
    void Start()
    {
        healthBar.GetComponent<Image>();
        startPos = transform.position;
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        changeHealth();
        destroyObject();
    }

    public void changeHealth()
    {
        if (collision)
        {
            currentHealth += changeAmount;
            updateHealthBar();
           
            collision = false;
        }
    }

    public void destroyObject()
    {

        if (currentHealth <= 0)
        {
            lives--;
            makeMap();
            gameObject.SetActive(false);
            if (lives > 0)
            {
                respawn();
            }
        }
    }
    
    public void updateHealthBar()
    {
        healthBar.fillAmount = currentHealth / 100;
    }

    public void respawn()
    {
        transform.position = startPos;
        currentHealth = maxHealth;
        updateHealthBar() ;
        gameObject.SetActive(true);
    }
   
    public void makeMap()
    {
        if (gameObject.GetComponent<Health>().lives == 0)
        {
            Instantiate(map);
            Debug.Log("MAP");
        }
    }

}
