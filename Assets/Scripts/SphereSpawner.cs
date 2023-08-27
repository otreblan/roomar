using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSpawner : MonoBehaviour
{
    public Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        if(!camera)
            camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
