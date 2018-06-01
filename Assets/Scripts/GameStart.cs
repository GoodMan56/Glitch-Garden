using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameStart : MonoBehaviour {
    public CanvasGroup background;

	void Start() {
        StartCoroutine(FadeOut(8.0F));
    }

    private void Awake()
    {
        StartCoroutine(FadeIn());
    }

    void OnMouseDown()
    {
        StartCoroutine(FadeOut(0F));
    }
    
    IEnumerator FadeIn()
    {
        background.alpha = 0;
        while (background.alpha < 1)
        {
            background.alpha += Time.deltaTime / 1f;
            yield return null;
        }
    }

    IEnumerator FadeOut(float waitTime)
    {

        yield return new WaitForSeconds(waitTime);

        while (background.alpha > 0)
        {
            background.alpha -= Time.deltaTime / 1f;
            yield return null;
        }

        SceneManager.LoadScene("Start");
    }
}
