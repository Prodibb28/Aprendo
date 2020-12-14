using UnityEngine;
using UnityEngine.UI;

public enum ButtonType
{
    START_GAME,
    PERFIL,
    INFO,
    CONFIG,
    PNIÑO,
    PSELECTOR,
    PNIÑA,
    MENUOPC,
    END_GAME
}

[RequireComponent(typeof(Button))]
public class ButtonController : MonoBehaviour
{
    public ButtonType buttonType;

    CanvasManager canvasManager;
    Button menuButton;

    private void Start()
    {
        menuButton = GetComponent<Button>();
        menuButton.onClick.AddListener(OnButtonClicked);
        canvasManager = CanvasManager.GetInstance();
    }

    void OnButtonClicked()
    {
        switch (buttonType)
        {
            case ButtonType.START_GAME:
                //Call other code that is necessary to start the game like levelManager.StartGame()
                canvasManager.SwitchCanvas(CanvasType.StartMenu);
                break;
            case ButtonType.PERFIL:
                //Do More Things like SaveSystem.Save()
                canvasManager.SwitchCanvas(CanvasType.Perfil);
                break;
            case ButtonType.INFO:
                //Do More Things like SaveSystem.Save()
                canvasManager.SwitchCanvas(CanvasType.info);
                break;
            case ButtonType.CONFIG:
                //Do More Things like SaveSystem.Save()
                canvasManager.SwitchCanvas(CanvasType.Config);
                break;
            case ButtonType.PNIÑO:
                //Do More Things like SaveSystem.Save()
                canvasManager.SwitchCanvas(CanvasType.PanelNiño);
                SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Play);
                break;
            case ButtonType.PNIÑA:
                //Do More Things like SaveSystem.Save()
                canvasManager.SwitchCanvas(CanvasType.PanelNiña);
                SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Play);
                break;
            case ButtonType.PSELECTOR:
                //Do More Things like SaveSystem.Save()
                canvasManager.SwitchCanvas(CanvasType.Pselector);
                SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Play);
                break;
            case ButtonType.END_GAME:
                //Do More Things like SaveSystem.Save()
                canvasManager.SwitchCanvas(CanvasType.EndScreen);
                break;
            default:
                break;
        }
    }
}
