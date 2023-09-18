using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class ObjectCollision : MonoBehaviour
    
{
    // Start is called before the first frame update

    public bool destroyOnCollision = true;
    public GameObject objectToDestroy;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Wall"))
        {
            destroyOnCollision = false;
        } else
        {
            destroyOnCollision = true; 
        }
        if (destroyOnCollision)
        {
            Destroy(objectToDestroy);
        }

    }
}
