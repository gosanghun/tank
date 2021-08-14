using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
    
{   
    public float speed_m = 10f;
    public float speed_r = 10f;
    public Transform fire_pos;
    public GameObject cannonballflying;

    public Transform cannon;
    public Transform tower;
    //public Transform ball;
    //Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        

        //Debug.Log(h +","+v);
        transform.Translate(0, 0, v * speed_m);
        transform.Rotate(0, h * speed_m* 10, 0);

        /*
          float mh = Input.GetAxis("Mouse X");
        float mv = Input.GetAxisRaw("Mouse Y");

        tower.transform.Rotate(0, mh * speed_r, 0);
        cannon.transform.Rotate(mv * speed_r,0, 0);
        */

        /*
        float ch = Input.GetAxis("Horizontal cannon");
        float cv = Input.GetAxis("Vertical cannon");
        tower.transform.Rotate(0, ch * speed_r, 0);
        cannon.transform.Rotate(cv * speed_r, 0, 0);
        */
        if(Input.GetKey(KeyCode.K))
            tower.transform.Rotate(0, speed_r, 0);

        if (Input.GetKey(KeyCode.H))
            tower.transform.Rotate(0, -speed_r, 0);

        if (Input.GetKey(KeyCode.U)&&cannon.localEulerAngles.x < 40)
                cannon.transform.Rotate(speed_r, 0, 0);

        if (Input.GetKey(KeyCode.J)&&cannon.localEulerAngles.x > 1)
                cannon.transform.Rotate(-speed_r, 0, 0);

            Debug.Log(cannon.transform.localEulerAngles.x);

       if (Input.GetKeyDown(KeyCode.Space)) 
            Instantiate(cannonballflying, fire_pos.position, fire_pos.rotation); 

      
  

    }







}
  

