using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetName : MonoBehaviour
{
    public Text textName,textEdad;
    // Start is called before the first frame update
    void Start()
    {
        textName.text = PlayerPrefs.GetString("Name");
        textEdad.text = PlayerPrefs.GetString("Edad");
    }

}
