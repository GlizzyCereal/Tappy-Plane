using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    void Start()
    {
        // Optional: You can remove this if you don't want to load the scene on start
        // LoadScene();
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}