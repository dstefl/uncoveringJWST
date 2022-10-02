using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIButton : MonoBehaviour
{

	//privatepublic Button myButton;
	[SerializeField] GameObject[] objectsToShow;
	[SerializeField] GameObject[] objectsToHide;


	void Start()
	{
		Button btn = gameObject.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
		
	}

	void TaskOnClick()
	{
		// objectToShow.SetActive;
		for (int i = 0; i < objectsToShow.Length; i++)
		{
			objectsToShow[i].SetActive(true);
		}
		
		

		for (int i = 0; i < objectsToHide.Length; i++)
		{
			objectsToHide[i].SetActive(false);
		}
		Debug.Log("You have clicked the button!");

	}
}

