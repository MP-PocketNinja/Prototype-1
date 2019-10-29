using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    private float forwardInput;
    private float horizontalInput;
    public float TurnSpeed = 150f;
    public float speed = 20f;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        Steering();
    }

    private void Steering()
    {
        //Move forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //Turn
        transform.Rotate(Vector3.up, TurnSpeed * horizontalInput * Time.deltaTime);
    }
}
