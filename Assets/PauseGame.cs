using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    // Start is called before the first frame update
    public bool paused = false;
    public GameObject screen;
    public GameObject level;
    public GameObject hDisplay;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Pause();
 
        if (paused)
        {
            screen.SetActive(true);
            level.SetActive(false);
            hDisplay.SetActive(false);
        } else
        {
            screen.SetActive(false);
            level.SetActive(true);
            hDisplay.SetActive(true);
        }
    }

    private void Pause()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = true;
        }
    }

    public void unPause()
    {
        paused = false;
    }

}
