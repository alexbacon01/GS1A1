using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectMap : MonoBehaviour
{
    // Start is called before the first frame update
    public float numOfMaps;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name.Contains("Map")) ;
        {
            numOfMaps++;
            Destroy(collision.gameObject);
        }
    }
}
