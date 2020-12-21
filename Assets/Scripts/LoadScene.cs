using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadScene : MonoBehaviour {

	public void LoadHard()
	{
		SceneManager.LoadScene ("Hard");
	}
	public void LoadEasy()
	{
		SceneManager.LoadScene("Easy");
    }
	public void LoadMenu()
	{
		SceneManager.LoadScene("Menu");
	}
	public void LoadOther()
	{
		SceneManager.LoadScene("Other");
	}

}