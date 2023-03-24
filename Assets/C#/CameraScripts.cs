using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraScripts : MonoBehaviour
{
    [SerializeField] private GameObject Canvas;

    public void Activate()
    {
        Canvas.SetActive(true);
    }

    public void UnActivate()
    {
        Canvas.SetActive(false);
    }

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
