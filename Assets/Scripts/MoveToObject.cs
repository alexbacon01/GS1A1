using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToObject : MonoBehaviour
{

    // T1. 
    public Transform selfTransform;

    public GameObject playerObject;
    public GameObject npc;
    //make vectors for
    public Vector2 player;
    public Vector2 npcVector;
    public Vector2 vectorBetween;
   
    public float moveSpeed = 1f;


    // Start is called before the first frame update
    void Start()
    {
        selfTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        player = playerObject.transform.position; //vector for player
        npcVector = (npc.transform.position).normalized; //vector for npc
        vectorBetween = (player - npcVector).normalized; //target - player to find the vector between two spots
   
        //selfTransform.Translate(npcVector.magnitude * new Vector2(0, 1f) * Time.deltaTime * moveSpeed); 
       npc.transform.position = Vector2.MoveTowards(npc.transform.position, playerObject.transform.position, moveSpeed * Time.deltaTime); 
  
        RotateTowardsPlayer(); //rotate the object 
    }

    void RotateTowardsPlayer()
    {
        Vector2 up = selfTransform.up; //short hand for (0,1) direction

        Debug.DrawLine(transform.position, transform.position + (Vector3)up * 5f);
        
        Debug.DrawRay(transform.position, (Vector3)up * 5f);

        float signedAngle = Vector2.SignedAngle(up, vectorBetween); //angle between forward and the player

        selfTransform.Rotate(new Vector3(0, 0, signedAngle)); //adds the roation but has to be done in a Vector3 to add the rotation angle


    }

}

