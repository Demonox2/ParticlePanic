using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour {

    public LevelChanger fader;
    public string levelName;

    public void Select ()
    {
        // fader.OnFadeComplete(levelName);
        SceneManager.LoadScene(levelName);
    }

}
