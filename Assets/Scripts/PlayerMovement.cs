﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement	 : MonoBehaviour
{
	//variables
	public float moveSpeed = 300; //Speed | Rychlost
	public float sidewaysSpeed = 50f; //Steering speed | Rychlost zataceni
	public float horizontalInput;

	private Rigidbody characterBody;
	private float ScreenWidth;
	private float ScreenHeight;

    public GameObject character;
	public Rigidbody rb;
	public bool Player1 = true;
	public bool Touch = false;

	// Use this for initialization
	void Start()
	{
		characterBody = character.GetComponent<Rigidbody>();
		ScreenWidth = Screen.width;
		ScreenHeight = Screen.height;
	}

	// Update is called once per frame
	void Update()
	{
		//Debug.Log(Input.GetAxis("Horizontal"));
		int i = 0;
        //loop over every touch found
        if (Touch)
        {

			while (i < Input.touchCount)
			{
				float v = ScreenWidth - (ScreenWidth / 6);
				if (Input.GetTouch(i).position.x > v)
				{
					if (Input.GetTouch(i).position.y < ScreenHeight / 3.50)
					{
						//move right
						RunCharacter(1.0f);
					}

				}
				if (Input.GetTouch(i).position.x < ScreenWidth / 6)
				{
					if (Input.GetTouch(i).position.y < ScreenHeight / 3.50)
					{
						//move left
						RunCharacter(-1.0f);
					}
				}
				++i;
			}

		}
		characterBody.AddForce(0, 0, moveSpeed * Time.deltaTime, ForceMode.VelocityChange);
	}
	void FixedUpdate()
	{
		

		if(Touch)
		{
			RunCharacter(Input.GetAxis("Vertical"));
		}
		

		if(Player1)
		{
			if (Input.GetKey("d"))
			{
				rb.AddForce(sidewaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
			}

			if (Input.GetKey("a"))
			{
				rb.AddForce(-sidewaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
			}
		}
		else
		{
			if (Input.GetKey(KeyCode.RightArrow))
			{
				rb.AddForce(sidewaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
			}

			if (Input.GetKey(KeyCode.LeftArrow))
			{
				rb.AddForce(-sidewaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
			}
		}

	}

	private void RunCharacter(float horizontalInput)
	{
		//move player
		characterBody.AddForce(horizontalInput * sidewaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

	}
			
}