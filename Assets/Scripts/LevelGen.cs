using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelGen : MonoBehaviour
{
	public GameObject RedCube;
	public GameObject Ramp;
	public GameObject GreenCube;
    
	public bool hard = true;

    public void Start()
    {

        if (hard) //Hard
        {
			for (int i = 5; i < 400; i++) //Spawning RedCubes
				Instantiate(RedCube, new Vector3(Random.Range(-7, 7), 1, 5 * i), new Quaternion());

			for (int i = 5; i < 400; i++) //Spawning GreenCubes
				Instantiate(GreenCube, new Vector3(Random.Range(-7, 7), 1, 10 * i), new Quaternion());

			for (int i = 1; i < 100; i++) //Spawning Ramps
				Instantiate(Ramp, new Vector3(Random.Range(-4, 4), 1, 200 * i), Ramp.transform.localRotation);
		}
		else //Easy
		{
			for (int i = 5; i < 400; i++) //Spawning RedCubes
				Instantiate(RedCube, new Vector3(Random.Range(-7, 7), 1, 7 * i), new Quaternion());

			for (int i = 5; i < 400; i++) //Spawning GreenCubes
				Instantiate(GreenCube, new Vector3(Random.Range(-7, 7), 1, 12 * i), new Quaternion());

			for (int i = 1; i < 100; i++) //Spawning Ramps
				Instantiate(Ramp, new Vector3(Random.Range(-4, 4), 1, 200 * i), Ramp.transform.localRotation);
		}

	}

}