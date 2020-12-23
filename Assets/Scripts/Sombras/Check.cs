using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Check : MonoBehaviour
{
    public int firstTime = 0;

    public GameObject panelFristTime, panelGame;

    void Start()
    {
        panelFristTime.SetActive(false);
        firstTime = PlayerPrefs.GetInt("valor", firstTime);
        ConfFirsTime();

    }

    // Update is called once per frame
    void Update()
    {
        if (firstTime == 1)
        {
            panelFristTime.SetActive(false);
            panelGame.SetActive(true);
        }
        else if (firstTime == 0)
        {
            panelFristTime.SetActive(true);
        }
    }

    private void ConfFirsTime()
    {
        if (firstTime == 1)
        {
            panelFristTime.SetActive(false);
        }
    }

    public void FirstTimeY()
    {
        if (firstTime == 0)
        {
            firstTime = 1;
            PlayerPrefs.SetInt("valor", firstTime);
            panelFristTime.SetActive(false);
            panelGame.SetActive(true);
            SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Confirm);
        }       
              
    }

    public void FirstTimeN()
    {
        firstTime = 0;
        PlayerPrefs.SetInt("valor", firstTime);
    }

    public void IrScene(int NumScene)
    {
        if (firstTime == 1)
        {
            SceneManager.LoadScene(NumScene);
        }
        else if (firstTime == 0)
        {
            panelFristTime.SetActive(true);
            panelGame.SetActive(false);
        }
        
    }

}
