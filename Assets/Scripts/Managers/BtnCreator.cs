using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public static class ButtonExtension
{
	public static void AddEventListener<X>(this Button button, X param, Action<X> OnClick)
	{
		button.onClick.AddListener(delegate () {
			OnClick(param);
		});
	}
}

public class BtnCreator : MonoBehaviour
{
	[Serializable]
	public struct Game
	{
		//public string Name;
		//public string Description;
		public Sprite Icon;
	}

	[SerializeField] Game[] allGames;

	void Start()
	{
		GameObject buttonTemplate = transform.GetChild(0).gameObject;
		GameObject g;

		int N = allGames.Length;

		for (int i = 0; i < N; i++)
		{
			g = Instantiate(buttonTemplate, transform);
			g.transform.GetChild(0).GetComponent<Image>().sprite = allGames[i].Icon;
			//g.transform.GetChild(1).GetComponent<Text>().text = allGames[i].Name;
			//g.transform.GetChild(2).GetComponent<Text>().text = allGames[i].Description;

			/*g.GetComponent <Button> ().onClick.AddListener (delegate() {
				ItemClicked (i);
			});*/
			g.GetComponent<Button>().AddEventListener(i, ItemClicked);
		}

		Destroy(buttonTemplate);
	}

	void ItemClicked(int itenIdenx)
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
