using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SamFadeScript : MonoBehaviour
{
    public int levelToLoad;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnFadeComplete (){
        SceneManager.LoadScene(levelToLoad);
	}
}
