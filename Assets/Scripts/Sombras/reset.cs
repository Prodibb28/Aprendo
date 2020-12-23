using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour
{

    public int firstTime = 0;

    private void Start()
    {
        firstTime = PlayerPrefs.GetInt("valor", firstTime);
    }
    public void FirstTimeN()
    {
        firstTime = 0;
        PlayerPrefs.SetInt("valor", firstTime);
    }
}
