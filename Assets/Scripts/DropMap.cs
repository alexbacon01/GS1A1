using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropMap : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject map;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.GetComponent<Health>().lives == 0)
        {
            Instantiate(map);
            Debug.Log("MAP");
        }
        Debug.Log("LIVES: " + gameObject.GetComponent<Health>().lives);
    }
}
