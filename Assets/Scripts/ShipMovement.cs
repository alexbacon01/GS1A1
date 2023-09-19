using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class ShipMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector2 input;
    public Rigidbody2D rb;
    public float forceAmount = 25f;
    public Transform selfTransform;
    public Vector2 normalizedInput;
    public float torque = 0.1f;
    void Start()
    {
        selfTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        normalizedInput = input.normalized;

    }

     void FixedUpdate()
    {
        moveship();
        rotateShip();
    }

    //move ship using input and force
    void moveship()
    {
        rb.AddRelativeForce(normalizedInput * forceAmount);
    }

    //rotate ship using signed angle between input and ship direction forward
    void rotateShip()
    {
        /*
        float signedAngle = Vector2.SignedAngle(selfTransform.up, input); //gets angle between forward direction and input direction
        selfTransform.Rotate(new Vector3(0, 0, signedAngle));
        Debug.DrawLine(transform.position, transform.position + (Vector3)selfTransform.up * 5f);
        */
        float turn = Input.GetAxis("Horizontal");
        rb.AddTorque(torque * -turn);
    }
}
