using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    public float speed;
    public float jumpForce;

    public bool isGrounded; //Esta en el suelo
    private bool isSecondJumpAvailable;

    // Update is called once per frame
    void Update()
    {
        //Movement
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        //Jump
        if (Input.GetKeyDown(KeyCode.Space) && (isGrounded || isSecondJumpAvailable))
        {
            Rigidbody rigidbody = GetComponent<Rigidbody>();
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

            if(!isGrounded && isSecondJumpAvailable)
            {
                isSecondJumpAvailable = false;
            }
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("CollisionEnter: " + collision.gameObject.name);
        isGrounded = true;
        isSecondJumpAvailable = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("CollisionExit");
        isGrounded = false;
    }
}
