using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Windows;
using static UnityEngine.GraphicsBuffer;
using Random = UnityEngine.Random; //use unity random

public class EnemyMovement : MonoBehaviour
{
    // Start is called before the first frame update

    /*
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
    */

    public float wanderRadius = 2f;
    private float currentTimer = 0;
    private float maxTimer;
    private bool isMoving = false;
    public float moveSpeed = 2f;
    private Vector3 newPosition;
    public float turnSpeed = 1f;

    private void Start()
    {
        newPosition = newPos();
    }

    private void Update()
    {
        Rotate();
    }

    private void Move()
    {
   
        if (transform.position != newPosition)
        {
            transform.position = Vector3.MoveTowards(transform.position, newPosition, moveSpeed *Time.deltaTime);
  
        } 
        if(transform.position == newPosition)
        {
            Debug.Log("current pos:" + transform.position + "newPos: " + newPosition);
           newPosition = newPos();
        }

    }

    private Vector3 newPos()
    {
        return Random.insideUnitCircle * wanderRadius;
    }

    private void Rotate()
    {
        Vector3 target = newPosition - transform.position;
        transform.up = Vector3.RotateTowards(transform.up, target, turnSpeed * Time.deltaTime,0);
        if(transform.up == Vector3.RotateTowards(transform.up, target, turnSpeed * Time.deltaTime, 0))
        {
            Move();
        }
    }
    }


