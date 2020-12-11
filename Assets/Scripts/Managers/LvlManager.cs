using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlManager : MonoBehaviour
{
    public void IrScene(int NumScene)
    {
        SceneManager.LoadScene(NumScene);
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
