using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	private float moveSpeed, sidewaysSpeed, sideInput = 0;

	public GameObject character;
	public Rigidbody rb;
	public bool Player1 = true;
	public float touchDiv = 2.5f;

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
		sideInput = 0;
		//Keyboard
		if (Player1)
		{
			if (Input.GetKey("d"))
			{
				sideInput = 1;
			}

			if (Input.GetKey("a"))
			{
				sideInput = -1;
			}
		}
		else
		{
			if (Input.GetKey(KeyCode.RightArrow))
			{
				sideInput = 1;
			}

			if (Input.GetKey(KeyCode.LeftArrow))
			{
				sideInput = -1;
			}
		}
		//Touch
		if (Input.touchCount > 0)
        {
            for(int i = 0; i < Input.touchCount; i++) 
			{
				Touch touch = Input.GetTouch(i);
				if(touch.position.x < Screen.width/touchDiv && touch.position.y < Screen.height/touchDiv)
				{
					sideInput = -1;
				}
				else if (touch.position.x > Screen.width - Screen.width/touchDiv && touch.position.y < Screen.height/touchDiv)
				{
					sideInput = 1;
				}
			}

        }

		rb.AddForce(sideInput * sidewaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		rb.AddForce(0, 0, moveSpeed);
	}
}