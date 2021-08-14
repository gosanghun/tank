using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particle : MonoBehaviour
   
{
    
    public GameObject onhitparticle;
    public Transform parpos;

    void Start()


    {
        transform.Translate(0, 0, 100 * Time.deltaTime);
        Destroy(gameObject, 7f);

    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ground")
        { Destroy(gameObject, 0.1f);
            Instantiate(onhitparticle, parpos.position, parpos.rotation);
        }

        if (collision.gameObject.tag == "enemy")
        {
            Destroy(gameObject, 0.1f);
            Instantiate(onhitparticle, parpos.position, parpos.rotation);
        }

    }
}
