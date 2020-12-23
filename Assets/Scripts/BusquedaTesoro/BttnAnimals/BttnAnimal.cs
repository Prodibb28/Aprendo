using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BttnAnimal : MonoBehaviour
{
    GameObject Animal;
 
    public void SearchAnimal(string nameAnimal) {

        Animal = GameObject.FindWithTag(nameAnimal);
    }
     public void CheckQuest() {

        if (Animal??false){
             PlayerPrefs.SetInt("CheckScore",1); 
             Debug.Log("Ganaste");  
        }
        else{
             PlayerPrefs.SetInt("CheckScore",2);   
              Debug.Log("Perdiste");
        }
    }
}
