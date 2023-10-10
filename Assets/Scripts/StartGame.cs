using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public void LoadLevel()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level1");
    }
}
