using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public static class ButtonExtension
{
    public static void AddEventListener<T>(this Button button, T param, Action<T> OnClick)
    {
        button.onClick.AddListener(delegate ()
        {
            OnClick(param);
        });
    }
}

public class BtnCreator : MonoBehaviour
{
    [Serializable]
    public struct Game
    {
        public Sprite icon;
        public Sprite Backgrund;
        public string Titulo;
    }

    [SerializeField] Game[] allGames;

    // Start is called before the first frame update
    void Start()
    {
        GameObject buttonTemplate = transform.GetChild(0).gameObject;
        GameObject g;

        int N = allGames.Length;

        for (int i = 0; i < N; i++)
        {
            g = Instantiate(buttonTemplate, transform);
            g.transform.GetChild(0).GetComponent <Image> ().sprite = allGames[i].Backgrund;
            g.transform.GetChild(1).GetComponent<Image>().sprite = allGames[i].icon;
            g.transform.GetChild(2).GetComponent<Text>().text = allGames[i].Titulo.ToString();

            g.GetComponent<Button>().AddEventListener(i, ItemClicedk);

        }
        Destroy(buttonTemplate);
    }

    void ItemClicedk(int itenIdenx)
    {
        switch (itenIdenx)
        {
            case 0:
                Debug.Log("item" + itenIdenx);
                SceneManager.LoadScene(2);
                break;
            case 1:
                Debug.Log("item" + itenIdenx);
                SceneManager.LoadScene(3);
                break;

        }

        
    }
}
