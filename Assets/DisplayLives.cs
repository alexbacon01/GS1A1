using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayLives : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject character;
    public GameObject heart;
    public GameObject parent;
    private int lives;
    void Start()
    {
        Vector3 pos = new Vector3(-860, 467, 0);
        lives = (int)character.GetComponent<Health>().lives;
        GameObject[] arrayOfLives = new GameObject[lives];
        for (int i = 0; i < arrayOfLives.Length; i++)
        {
            Debug.Log(i);
            arrayOfLives[i] = Instantiate(heart, pos, Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
