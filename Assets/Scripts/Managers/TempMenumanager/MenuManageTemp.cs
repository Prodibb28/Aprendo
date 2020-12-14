using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManageTemp : MonoBehaviour
{

    public GameObject Menu,btn;

    void Start()
    {
        Menu.SetActive(false);
        btn.SetActive(false);
    }

    

    public void press()
    {
        Menu.SetActive(true);
        btn.SetActive(true);
    }
    public void Npress()
    {
        Menu.SetActive(false);
        btn.SetActive(false);
    }

}
