using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DisplayLives : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject character;
    public GameObject heart;
    public GameObject parent;
    private int startLives;
    private int lives;
    private GameObject[] arrayOfLives;
    void Start()
    {
        startLives = (int)character.GetComponent<Health>().lives;
        arrayOfLives = new GameObject[startLives];
        for (int i = 0; i < arrayOfLives.Length; i++)
        {
            float spacing = i*100f;
            Debug.Log(i);
            Vector3 pos = new Vector3(100+ spacing, parent.transform.position.y+parent.transform.position.y - 100, parent.transform.position.z);
            arrayOfLives[i] = Instantiate(heart,pos, parent.transform.rotation, parent.transform);
        }

    }

    // Update is called once per frame
    void Update()
    {
        lives = (int)character.GetComponent<Health>().lives;
        if (lives != startLives)
        {
            for(int i=0; i< startLives - lives; i++)
            {
                arrayOfLives[i].active= false; 
            }
        }
    }
}
