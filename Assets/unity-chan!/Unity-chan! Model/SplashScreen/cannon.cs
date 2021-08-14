using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannon : MonoBehaviour
   
{
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float h = Input.GetAxis("Mouse X");
        float v = Input.GetAxisRaw("Mouse Y");
        transform.Rotate(0, h * speed, 0);
        transform.Rotate(0, 0, -v * speed);

    }
}
