using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Text.RegularExpressions;

public class panelDescription : MonoBehaviour
{
	private LevelManager t_LevelManager;
	public Text descriptionText;
    public string[] arr = new string[] { "value1", "value2", "value3" };
    private int counter = 0;

    void Start () {
		t_LevelManager = FindObjectOfType<LevelManager> ();
	}

    public void TurnObjectOff()
    {
        StartCoroutine(TurnObjectOffCoroutine());
    }

    private IEnumerator TurnObjectOffCoroutine()
    {
        yield return StartCoroutine(t_LevelManager.UnpauseGameCo());
        
        // Coroutine has finished executing, continue with your code here
        
        GameObject.Find("Level Starter").transform.Find("Canvas").transform.Find("descriptionContainer").gameObject.SetActive(false);
        
        if (counter > arr.Length - 1)
        {
            counter = arr.Length - 1;
        }
        
        counter++;
        descriptionText.text = arr[counter];
    }
}
