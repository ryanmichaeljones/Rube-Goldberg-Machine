using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void gameScene()
    {
        SceneManager.LoadScene("gameScene");
    }

    public void menuScene()
    {
        SceneManager.LoadScene("menuScene");
    }
}
