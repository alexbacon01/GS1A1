using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCollisionListener : MonoBehaviour
{
    // 2D Collider Docs
    // https://docs.unity3d.com/ScriptReference/Collider2D.html

    // Collision Object returned from Collision (passed as parameter)
    // https://docs.unity3d.com/ScriptReference/Collision2D.html

    // Collision Event
    // https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnCollisionEnter2D.html


    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(this.gameObject.name + " OnCollisionEnter2D event called from collision with " + col.otherCollider.gameObject.name);
    }
}
