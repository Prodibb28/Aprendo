using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PerfilManager : MonoBehaviour
{

    public Text textName;
    public InputField InputName;

    // Start is called before the first frame update
    void Start()
    {
        textName.text = PlayerPrefs.GetString("Name");
    }

    public void SaveName()
    {
        if (!string.IsNullOrEmpty(InputName.text))
            PlayerPrefs.SetString("Name", InputName.text);
        PlayerPrefs.SetInt("CheckName", 1);
        textName.text = PlayerPrefs.GetString("Name");
    }

}
