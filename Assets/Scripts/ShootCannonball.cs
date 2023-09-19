using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCannonball : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cannonball;
    public Transform shipPos;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shipPos = GetComponent<Transform>();
        if (Input.GetButtonDown("Jump"))
       {
            createCannonball();
       }
    }


    void createCannonball()
    {
        Instantiate(cannonball, shipPos.position, shipPos.rotation);
        Debug.Log(shipPos.position);
    }
}
