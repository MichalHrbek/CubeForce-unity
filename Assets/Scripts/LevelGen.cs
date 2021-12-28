using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Sys = System;
public class LevelGen : MonoBehaviour
{
	public GameObject Player, Player2;
	public float renderDistance;
	[SerializeField] private Obstacle[] obstacles;
	public void FixedUpdate() 
	{
		for(int i = 0; i < obstacles.Length; i++)
		{
			while(obstacles[i].protectionOffset + obstacles[i].rens * obstacles[i].spawnFrequency[Menu.difficulty-1] < renderDistance + Player.transform.position.z || obstacles[i].protectionOffset + obstacles[i].rens * obstacles[i].spawnFrequency[Menu.difficulty-1] < renderDistance + Player2.transform.position.z)
			{
				obstacles[i].Generate();
			}
		}
	}

	[Sys.Serializable]
	private class Obstacle {
		public GameObject gameObject;
		public float[] spawnFrequency;
		public int rens = 1;
		public float protectionOffset;

		public void Generate()
		{
			rens++;
			Instantiate(gameObject, new Vector3(
			Random.Range(-(15-gameObject.transform.localScale.x)/2, (15-gameObject.transform.localScale.x)/2),
			1, 
			protectionOffset + spawnFrequency[Menu.difficulty-1] * rens),
			gameObject.transform.localRotation);
		}
	}
}