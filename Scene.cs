using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void ChangeScences(int numerScenes)
    {
        SceneManager.LoadScene(numerScenes);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
