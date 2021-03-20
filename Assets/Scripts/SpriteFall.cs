using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFall : MonoBehaviour
{
    public Rigidbody2D sprite;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            sprite.gravityScale = 0.3F;


            //Vector2 newPos = new Vector2(startPos.x, startPos.y + dir.y);
            //transform.position = newPos;
        }
    }

}
