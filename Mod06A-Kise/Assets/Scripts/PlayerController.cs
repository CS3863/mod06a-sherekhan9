using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed;
    private float turnSpeed;
    private float horizonatalInput;
    private float forwardInput;
    void Start()
    {
        
        speed = 25.0f;
        turnSpeed = 120.0f;
    }

    // Update is called once per frame
    void Update()
    {
        horizonatalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizonatalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizonatalInput);
    }
}
