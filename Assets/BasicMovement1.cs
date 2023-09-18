using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public Vector2 playerInput;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        playerInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        Vector2 normalizedInput = playerInput.normalized;
        Vector2 moveWithSpeed = normalizedInput * speed;

        transform.Translate(moveWithSpeed * Time.deltaTime); 
        Debug.Log("Magnitude: " + normalizedInput.magnitude);
    }
}
