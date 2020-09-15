using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Restart2 : MonoBehaviour
{
	public GameObject kostka;
	public GameObject skok;
	public GameObject green;
	public void Start()
	{






		for (int i = 5; i < 400; i++)
			Instantiate(kostka, new Vector3(Random.Range(-7, 7), 1, 5 * i), new Quaternion());

		for (int i = 5; i < 400; i++)
			Instantiate(green, new Vector3(Random.Range(-7, 7), 1, 10 * i), new Quaternion());

		for (int i = 1; i < 100; i++)
			Instantiate(skok, new Vector3(Random.Range(-4, 4), 1, 200 * i), skok.transform.localRotation);

		//for (int i=0;i<100;i++)
		//	Instantiate(green,new Vector3(Random.Range(-1,1),1,25*i),new Quaternion());





		//kostka.transform.Translate(new Vector3(10.0f, 0.0f, 0.0f),Space.World);
		//Instantiate(GameObject.CreatePrimitive(PrimitiveType.Cube));
		//Scene scene = SceneManager.GetActiveScene();
		//GameObject[] objects = scene.GetRootGameObjects();
		//foreach (GameObject object in objects)
		//for (int i=0;i<objects.GetLength(0);i++);
		//	if (objects[i].tag=="Obstacle" && (i%2)==0)
		//	{
		//		objects[i].transform.Translate(new Vector3(0.0f, 4.0f, 0.0f),Space.World);
		//	}
	}
}