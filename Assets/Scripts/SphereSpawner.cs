using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSpawner : MonoBehaviour
{
    public Camera mainCamera;

    public GameObject prefab;

    public float speed = 1.0f;
    public float distance = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        if(!mainCamera)
            mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Ray ray = mainCamera.ScreenPointToRay(touch.position);

            GameObject newObject = Instantiate(prefab, ray.GetPoint(distance), Quaternion.identity);

            newObject.transform.parent = transform;
            newObject.GetComponent<Rigidbody>().velocity = ray.GetPoint(speed)-ray.origin;
        }
    }
}
