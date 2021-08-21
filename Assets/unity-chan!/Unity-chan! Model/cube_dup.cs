using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_dup : MonoBehaviour
    
{
  
    //public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            // Instantiate(cube);
            Instantiate(Resources.Load("1/Cube (1)"));

    }
}
