using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIME : MonoBehaviour
{   
    [SerializeField] float timetowait = 1f;
    MeshRenderer render; 
    Rigidbody rigid; 
    // Start is called before the first frame update
    void Start()
    {
      render = GetComponent<MeshRenderer>();
      rigid = GetComponent<Rigidbody>();  
      render.enabled = false;
      rigid.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
      
        if(Time.time > timetowait)
        {
            render.enabled = true;
            rigid.useGravity = true;
        }
    }
}
