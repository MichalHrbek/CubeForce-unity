using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableOnPlatform : MonoBehaviour
{
    public List<GameObject> onAndroidDisable;
    public List<GameObject> onAndroidEnable;

    // Start is called before the first frame update
    void Start()
    {
        if(Application.platform == RuntimePlatform.Android) {
            for(int i = 0; i < onAndroidDisable.Count; i++) {
                onAndroidDisable[i].SetActive(false);
            }
            for(int i = 0; i < onAndroidEnable.Count; i++) {
                onAndroidEnable[i].SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
