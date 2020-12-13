using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PerfilManager : MonoBehaviour
{

    public Text textName, txtEdad;
    public InputField InputName;
    public InputField InputEdad;

    


    // Start is called before the first frame update
    void Start()
    {
        textName.text = PlayerPrefs.GetString("Name");
        textName.text = PlayerPrefs.GetString("Edad");

        
    }

   

    public void SaveName()
    {
        if (!string.IsNullOrEmpty(InputName.text))
        {
            PlayerPrefs.SetString("Name", InputName.text);
            PlayerPrefs.SetString("Edad", InputEdad.text);
        }
            
        PlayerPrefs.SetInt("CheckName", 1);
        textName.text = PlayerPrefs.GetString("Name");
        txtEdad.text = PlayerPrefs.GetString("Edad");
    }

}
