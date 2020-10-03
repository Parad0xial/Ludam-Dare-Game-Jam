using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelChanger : MonoBehaviour
{
    public Animator animator;
    private int LevelToLoad;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FadeToMenu(int levelIndex){
        LevelToLoad = levelIndex;
        animator.SetTrigger("FadeOut");
    }
    public void OnFadeComplete(){
        SceneManager.LoadScene(LevelToLoad);
    }
}
