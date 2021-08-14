using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
    
{
    public GameObject bullet;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "cannonball")
            Destroy(gameObject, 0.1f);

        
    }
}