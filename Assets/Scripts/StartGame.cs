using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    private bool startGame = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (startGame)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Level1");
        }
    }

   public void LoadLevel()
    {
        startGame = true;
    }
}
