using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadScene : MonoBehaviour
{
	public Animator transition;
	public void LoadSceneByName(string name)
	{
		SceneManager.LoadScene(name);
	}
	public void LoadGame()
    {
        if (Menu.multiplayer)
        {
            LoadSceneByName("GameM");
        }
        else
        {
            LoadSceneByName("Game");
        }
    }
	public void LoadSceneWithAnimation(string name)
    {
        if (transition != null)
        {
			StartCoroutine(LoadSceneByNameWithAnimation(name));
		}
        else
        {
			LoadSceneByName(name);
        }
    }
	public IEnumerator LoadSceneByNameWithAnimation(string name)
    {
		transition.SetTrigger("Start");

		yield return new WaitForSeconds(1);

		LoadSceneByName(name);
    }
}