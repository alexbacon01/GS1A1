using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject objectToFollow;
    public Vector3 objectPos;
    // Start is called before the first frame update
    void Start()
    {
        objectPos = objectToFollow.transform.position;
        gameObject.transform.position = objectPos;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(objectToFollow.transform.position.x, objectToFollow.transform.position.y, objectToFollow.transform.position.z - 10); //offset Z so that you can see objects


    }
}
