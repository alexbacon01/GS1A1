using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Windows;

public class EnemyMovement : MonoBehaviour
{
    // Start is called before the first frame update


    public Rigidbody2D rb;
    public float currentTimer = 0;
    public float maxTimer;
    public bool isTimerRunning = false;
    public float force = 1f;
    public float direction = 0;


    void Start()
    {
        isTimerRunning = true;
        direction = Random.Range(-1, 1);
        rotateEnemy();
        while(direction ==0)
        {
            direction = Random.Range(-1, 1); 
        }
   
        rb = GetComponent<Rigidbody2D>();
        maxTimer = Random.Range(4, 10);
    }

    // Update is called once per frame
    void Update()
    {

        moveEnemy();
       
    }

    void timer()
    {
        
        if (rb != null && isTimerRunning)
        {
            currentTimer += Time.deltaTime;
        }
    }

    void moveEnemy()
    {
        if (rb != null && currentTimer < maxTimer)
        {
            rb.AddForce(new Vector2(0, direction * force));
            currentTimer += Time.deltaTime;
        }
        if (currentTimer >= maxTimer)
        {
            direction *= -1;
            currentTimer = 0;
            maxTimer = Random.Range(4, 10);
            rotateEnemy();
        }
    }

    void rotateEnemy()
    {
            float signedAngle = Vector2.SignedAngle(transform.up, transform.up * -1);
            transform.Rotate(new Vector3(0, 0, signedAngle));
    }
}
