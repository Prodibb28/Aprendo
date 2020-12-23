using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float time = 30;
    public Text UIText;
    public GameObject Win, Lose;

    void Start()
    {
        Win.SetActive(false);
        Lose.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        UIText.text = time.ToString("f0");
       

        if (time <= 0)
        {
            Time.timeScale = 0;
            time = 0;
            Lose.SetActive(true);
            SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Error);
        }
    }
}
