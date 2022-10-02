using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIButton : MonoBehaviour
{

	//privatepublic Button myButton;
	[SerializeField] GameObject objectToShow;
	[SerializeField] GameObject[] objectToHide;


	void Start()
	{
		Button btn = gameObject.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		// objectToShow.SetActive;
		objectToShow.SetActive(true);

		for (int i = 0; i < objectToHide.Length; i++)
		{
			objectToHide[i].SetActive(false);
		}
		Debug.Log("You have clicked the button!");

	}
}

