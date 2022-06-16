using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public SpriteRenderer rend;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponentInChildren<SpriteRenderer>();
        rend.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            //Debug.Log("powerup disappears"); //what happens when colliding with powerup
            rend.enabled = false;
        }

    }
}
