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

    public float wanderRadius = 2f;
    private float currentTimer = 0;
    private float maxTimer;
    private bool isMoving = false;
    public float moveSpeed = 2f;
    private Vector3 newPosition;
    public float turnSpeed = 1f;
    private bool collided = false;
    private Vector2 initialPos;
    private void Start()
    {
        newPosition = newPos();
        initialPos = transform.position;
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

        Vector2 pos = initialPos;
        pos += Random.insideUnitCircle * wanderRadius;
  
        return pos;
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("colliding");
        newPosition = newPos();
    }


}


