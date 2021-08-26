using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	float moveSpeed, sidewaysSpeed;

	public GameObject character;
	public Rigidbody rb;
	public bool Player1 = true;

	void Start()
	{
		rb = character.GetComponent<Rigidbody>();
		switch (Menu.difficulty)
		{
			case 1:
				moveSpeed = 22;
				sidewaysSpeed = 45;
				break;
			case 2:
				moveSpeed = 26;
				sidewaysSpeed = 45;
				break;
			case 3:
				moveSpeed = 32;
				sidewaysSpeed = 45;
				break;
		}
	}
	void FixedUpdate()
	{
		if (Player1)
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
		rb.AddForce(0, 0, moveSpeed);
	}
}