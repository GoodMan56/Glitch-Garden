using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoad : MonoBehaviour {

    public void LoadOnClick(string name)
    {
        Debug.Log("sceneName to load: " + name);
        SceneManager.LoadScene(name);
    }
}
