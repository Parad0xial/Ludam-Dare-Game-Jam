﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;


    public Animator animator;
    public Animator musicAnim;
    private int levelToLoad;
    
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
    public void OnTriggerEnter2D(Collider2D other)
    {
       Debug.Log("hit");
       DeathAnimation sn = other.GetComponent<DeathAnimation>();
       sn.DeathEffect();
       FadeToLevel(1);  
    }

    void RotateLeft () {
        transform.Rotate (Vector3.forward * speed);
    }

    void RotateRight () {
        transform.Rotate (Vector3.forward * -speed);
    }

    public void FadeToLevel (int levelIndex)
    {
        levelToLoad = levelIndex;
        musicAnim.SetTrigger("fadeOut");
        Debug.Log("music trigger");
        animator.SetTrigger("SamFadeOut");
	}

    
    
}
