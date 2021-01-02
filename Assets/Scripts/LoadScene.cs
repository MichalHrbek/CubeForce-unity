using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadScene : MonoBehaviour
{

	public void LoadHard()
	{
		SceneManager.LoadScene("Hard");
	}
	public void LoadMedium()
	{
		SceneManager.LoadScene("Medium");
	}
	public void LoadEasy()
	{
		SceneManager.LoadScene("Easy");
	}
	public void LoadHardM()
	{
		SceneManager.LoadScene("HardM");
	}
	public void LoadMediumM()
	{
		SceneManager.LoadScene("MediumM");
	}
	public void LoadEasyM()
	{
		SceneManager.LoadScene("EasyM");
	}
	public void LoadMenu()
	{
		SceneManager.LoadScene("Menu");
	}
	public void LoadOther()
	{
		SceneManager.LoadScene("Other");
	}
	public void LoadMulti()
	{
		SceneManager.LoadScene("Multiplayer");
	}
	public void LoadSing()
	{
		SceneManager.LoadScene("Singleplayer");
	}

}