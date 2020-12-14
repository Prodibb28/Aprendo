using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (!GameControl.youWin)
            transform.Rotate(0f, 0f, 90f);
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Touch);
    }
}
