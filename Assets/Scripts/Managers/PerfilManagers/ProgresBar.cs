using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode()]
public class ProgresBar : MonoBehaviour
{
    [Header("bar")]
    public Image Barra;
    public int maximun, current; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void sumarPuntos()
    {
        current = current + 10;
    }

    void GetCurrentFill()
    {
        float fillAmount = (float)current / (float)maximun;
        Barra.fillAmount = fillAmount;
    }

    void Update()
    {
        GetCurrentFill();
    }
}
