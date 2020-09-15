using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementKeyboard : MonoBehaviour


{
    public Rigidbody rb;
    public float sidewaysForce = 50f; //Rychlost zataceni
    public float moveSpeed = 300; //Speed | Rychlost
    public GameObject character;
	private Rigidbody characterBody;
    
        void Start()    
	{

		characterBody = character.GetComponent<Rigidbody>();
	}

    void FixedUpdate() //FixedUpdate() je na veci s fyzikou, jinak Update()
    {

        characterBody.AddForce(0, 0, moveSpeed * Time.deltaTime, ForceMode.VelocityChange);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }


    }


}
