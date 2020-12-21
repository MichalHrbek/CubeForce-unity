using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuParticles : MonoBehaviour
{
    Vector3 screen;

    // Start is called before the first frame update
    void Start()
    {
        screen.x = Screen.width;
        screen.y = Screen.height;
        screen.z = 10;

        ParticleSystem ps = GetComponent<ParticleSystem>();
        var sh = ps.shape;
        sh.scale = screen;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
