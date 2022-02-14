using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private float speed;

    [SerializeField]
    private float turnSpeed;

    [SerializeField]
    private GameObject smokeEffect;

    private float zInput;
    private float yInput;
    
    private void Start()
    {
        smokeEffect.SetActive(false);    
    }

    private void Update()
    {
        if (Mathf.Abs(zInput) > 0.1f)
        {
            smokeEffect.SetActive(true);
        }
        else
        {
            smokeEffect.SetActive(false);
        }
    }

    private void FixedUpdate()
    {
        zInput = Input.GetAxis("Vertical");
        transform.Translate(zInput * transform.forward * speed * Time.deltaTime);//Moving

        yInput = Input.GetAxis("Horizontal");
        rb.AddTorque(transform.up * yInput * turnSpeed);
    }

}
