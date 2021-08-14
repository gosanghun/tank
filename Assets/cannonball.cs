using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonball : MonoBehaviour
    
{ 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
       void FixedUpdate()
    {

        transform.Translate(0, 0, 100 * Time.deltaTime);
        Destroy(gameObject, 7f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ground")
            Destroy(gameObject, 0.1f);

        if (collision.gameObject.tag == "enemy")
            Destroy(gameObject,0.1f);
    }
}
