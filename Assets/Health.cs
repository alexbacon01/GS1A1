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
        Debug.Log(currentHealth);
        Debug.Log(changeAmount);
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
        Debug.Log("lives: " + lives);
    }
   

}
