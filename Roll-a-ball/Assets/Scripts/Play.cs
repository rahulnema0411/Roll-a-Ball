using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public void OnClick(int level)
    {
        SceneManager.LoadScene(level);
    }
    public void OnQuitButton()
    {
        Application.Quit();
    }

    public void OnBackButton()
    {
        SceneManager.LoadScene(0);
    }
}
