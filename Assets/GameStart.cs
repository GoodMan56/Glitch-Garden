using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameStart : MonoBehaviour {
	void Start() {
        StartCoroutine(WaitForIt(8.0F));
    }

    private void Update()
    {

    }

    void OnMouseDown()
    {
        SceneManager.LoadScene("Start");
    }

    IEnumerator WaitForIt(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene("Start");
    }
}
