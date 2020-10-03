using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //input detection
        if(Input.GetMouseButton(0)){
             RotateLeft();
        };
           
        if(Input.GetMouseButton(1)){
            RotateRight();
        };

        if (Input.GetKey("a")){
            RotateLeft();
		}

        if (Input.GetKey("d")){
            RotateRight();  
		}

        
    }

    //collision detections
    void OnCollisionEnter2D(Collision2D col)
    {
       Debug.Log("OnCollisionEnter2D");
    }

    void RotateLeft () {
        transform.Rotate (Vector3.forward * speed);
    }

    void RotateRight () {
        transform.Rotate (Vector3.forward * -speed);
    }
}
