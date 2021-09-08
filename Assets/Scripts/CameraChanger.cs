using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChanger : MonoBehaviour
{
    public Camera tpsCamera;
    public Camera fpsCamera;
    public KeyCode switchKey;

    // Start is called before the first frame update
    void Start()
    {
        tpsCamera.enabled = true;
        fpsCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(switchKey))
        {
            tpsCamera.enabled = !tpsCamera.enabled;
            fpsCamera.enabled = !fpsCamera.enabled;
        }

    }
}
