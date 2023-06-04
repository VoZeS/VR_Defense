using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    
    public string SceneName = "Level_1";

    private void Start()
    {
        SceneName = "Level_1";
    }
    // Update is called once per frame
    public void LoadTargetScene()
    {
        SceneManager.LoadScene(SceneName);
    }
}
