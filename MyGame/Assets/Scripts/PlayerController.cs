using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    public float JumpForce;

    Rigidbody rb;
    Vector3 movementinput;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movementinput.x = Input.GetAxis("Horizontal") *speed;
        movementinput.z = Input.GetAxis("Vertical") * speed;
        movementinput.y = rb.velocity.y;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * JumpForce);
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = movementinput;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="DeathTrap")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
