using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlManager : MonoBehaviour
{
    public void IrScene(int NumScene)
    {
        SceneManager.LoadScene(NumScene);
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Back);
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
