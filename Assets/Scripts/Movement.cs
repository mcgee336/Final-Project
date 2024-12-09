using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Timeline;

public class Movement : MonoBehaviour
{
    [SerializeField] float Mspeed = 20f;
    [SerializeField] float jumpForce = 2f;
    Rigidbody rbody;
    float horizontalInput;
    float forwardlInput;
    public bool isGrounded = true;
    public bool isAirborne = false;

  


    private void Start()
    {
        rbody = GetComponent<Rigidbody>();
    }

    RaycastHit hit;
    TimelinePlayer Director;
    



    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        forwardlInput = Input.GetAxis("Vertical");


        transform.Translate(Vector3.forward * Time.deltaTime * Mspeed * forwardlInput);
        transform.Translate(Vector3.right * Time.deltaTime * Mspeed * horizontalInput);


        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
            isAirborne = true;

        }

        if (Input.GetKeyDown(KeyCode.LeftShift) && isAirborne)
        {
            rbody.AddForce(Vector3.down * jumpForce, ForceMode.Impulse);
            isAirborne = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }

        if (collision.gameObject.CompareTag("Mobile"))
        {
            isGrounded = true;
        }

        if (collision.gameObject.CompareTag("Mobile"))
        {
           Director = FindAnyObjectByType<TimelinePlayer>();
            Director.StartTimeline();
           
        }

    }
    

}
