using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitScript : MonoBehaviour
{
    // Start is called before the first frame update



    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
