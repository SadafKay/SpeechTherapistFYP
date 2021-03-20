using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFly : MonoBehaviour
{
    public Rigidbody2D sprite;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            sprite.gravityScale = -0.1F;

        }
    }
}
