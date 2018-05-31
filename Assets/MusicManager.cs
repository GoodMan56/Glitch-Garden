using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MusicManager : MonoBehaviour {
    public AudioClip[] MusicArray;
    private AudioSource music;
    // Use this for initialization
    void Start () {
		
	}

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        music = GetComponent<AudioSource>();
        if (MusicArray[scene.buildIndex])
        {
            music.Stop();
            music.clip = MusicArray[scene.buildIndex];
            music.loop = true;
            music.Play();
        }
    }
}
