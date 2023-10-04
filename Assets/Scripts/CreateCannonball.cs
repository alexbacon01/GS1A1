using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootCannonball : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public float forceAmount = 5f;
    public GameObject cannonball;
    public Transform shipPos;
    public float currentTime = 2f;
    public bool isTimerRunning = false;
    public float coolDown = 2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coolDownTimer();
        shipPos = GetComponent<Transform>();
        if (Input.GetButtonDown("Jump") && currentTime >= coolDown)
       {
            createCannonball();
            currentTime = 0;
       }
    }


    void createCannonball()
    {
        Vector2 cannonballPos = new Vector2((shipPos.position.x + 5), shipPos.position.y);
        Instantiate(cannonball, cannonballPos, shipPos.rotation);
        isTimerRunning = true;
    }

    void coolDownTimer()
    {
        if (isTimerRunning)
        {
            currentTime += Time.deltaTime;
        }
    }
}
