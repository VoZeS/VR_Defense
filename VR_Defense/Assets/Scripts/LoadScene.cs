using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    
    public string SceneName = "";

    // Update is called once per frame
    public void LoadTargetScene()
    {
        SceneManager.LoadScene(SceneName);
    }
}
