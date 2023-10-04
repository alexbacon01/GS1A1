using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtController : MonoBehaviour
{
    //Reference to Sprite Renderer
    public SpriteRenderer spRenderer;
    private Vector2 input;

    //Refernce to Sprites
    public Sprite idleSprite;
    public Sprite walkSprite;

    public void Update()
    {
        //Input
        input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        //Update art according to input
        if(input.x <= 0.1f && input.x >= -0.1f){
            //Idle state
            spRenderer.sprite = idleSprite;
        } else if(input.x > 0.1f){
            //Walk right
            spRenderer.sprite= walkSprite;

        } else if(input.x < -0.1f){
            //Walk left
            spRenderer.sprite = walkSprite;
        } else {
            Debug.Log("Uh oh"); //shouldnt be here
        }
    }
}
