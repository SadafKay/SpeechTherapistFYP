using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bubble : MonoBehaviour
{
    [SerializeField] Vector3 force;
    [SerializeField] Sprite[] bubbleSprites;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    private UIManager UIMgr;

    // Start is called before the first frame update
    void Start()
    {

        UIMgr = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();

        rb = GetComponent<Rigidbody2D>();
        
        spriteRenderer = GetComponent<SpriteRenderer>();

        spriteRenderer.sprite = bubbleSprites[Random.Range(0, 15)];

        transform.position = new Vector3(Random.Range(-1f, 0.83f), transform.position.y, transform.position.z);

        force = new Vector3(Random.Range(-100, 100), Random.Range(150, 250), 0);
        rb.AddForce(force);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "TopBoundary")
        {
            Destroy(this.gameObject);
        }
    }
    
    
    void OnMouseDown()
    {
        Debug.Log("Destroyed!!!");
        Destroy(gameObject);
        UIMgr.UpdateScore();
    }

    
}
