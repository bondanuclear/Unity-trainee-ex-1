using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour
{

    public void GoToNextScene()
    {
        int currScene = SceneManager.GetActiveScene().buildIndex;
        currScene += 1;
        SceneManager.LoadScene(currScene); 
    }
    public void GoToPreviousScene()
    {
        int currScene = SceneManager.GetActiveScene().buildIndex;
        currScene -= 1;
        currScene = Mathf.Max(currScene, 0);
        SceneManager.LoadScene(currScene);
    }
    
}
