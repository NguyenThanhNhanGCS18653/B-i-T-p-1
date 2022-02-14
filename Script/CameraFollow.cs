using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform car;

    private Vector3 carCamera;
    // Start is called before the first frame update
    void Start()
    {
        carCamera = car.transform.position - transform.position;
    }
    private void LateUpdate()
    {
        transform.position = car.transform.position - car.transform.rotation * carCamera;

        transform.LookAt(car);
    }
}
