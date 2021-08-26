using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public Transform tr;
    public int DeathHeight = 0;
    public PlayerMovement TouchMovement;
    public GameObject GameOverScreen;
    public AudioSource death;
    private void Update()
    {
        if (DeathHeight > tr.position.y) //When falls of map
        {
            TouchMovement.enabled = false;      //Disable movement
            GameOverScreen.SetActive(true);     //Show death screen
        }
    }
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle") //When collides with obstacle
        {
            TouchMovement.enabled = false;      //Disable movement
            GameOverScreen.SetActive(true);     //Show death screen
        }
    }
}
