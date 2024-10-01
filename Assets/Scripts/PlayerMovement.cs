using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideForce = 500f;
    public float jumpForce = 15f;

    private bool isGrounded;

    protected bool strateLeft = false;  
    protected bool strateRight = false;  
    protected bool doJump = false;

    private AudioSource audioSource;
    public AudioClip otherSound;
    public AudioClip fallSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            doJump = true;

        }
    }

    void PlaySound(AudioClip clip)
    {
        // Убедимся, что звук назначен
        if (clip != null)
        {
            audioSource.clip = clip;
            audioSource.Play();
        }
    }
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        } else if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else 
        if (doJump && isGrounded)
        {
            PlaySound(otherSound);
            rb.AddForce(jumpForce * Vector3.up, ForceMode.Impulse);
            doJump = false;
           
        }



        if(rb.position.y < -1f)
        {
            PlaySound(otherSound);
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }

    
        void OnCollisionStay(Collision collision)
        {
            if (collision.gameObject.CompareTag("Ground"))  
            {
                isGrounded = true;
            }
        }

        void OnCollisionExit(Collision collision)
        {
            if (collision.gameObject.CompareTag("Ground"))
            {
                isGrounded = false;
            }
        }

    
}
