using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour {

    public Animator animator;

    private int levelToLoad;
	
	// Update is called once per frame//removed for now
    

    public void FadeToLevel (int levelIndex)
    {
        //store in leveltoLoad variable
        levelToLoad = levelIndex;
        //start fading
        animator.SetTrigger("FadeOut");
    }

    // call function
    public void OnFadeComplete ()
    {
        //Load new Scene
        SceneManager.LoadScene(levelToLoad);
    }
}
