using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{ public Transform target;
    private Transform tr;
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        tr.position = new Vector3(target.position.x - 0.52f, target.position.y + 5, target.position.z - 10f);
        tr.LookAt(target);
    }
}
