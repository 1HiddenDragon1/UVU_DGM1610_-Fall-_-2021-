using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //components are referenced for the script
    private Rigidbody playerRB;
    private Animator playerAnim;
    private AudioSource playerAudio;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround = true;
    public bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        //private assets are called into the script
        playerRB = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        
        //realistic gravity established
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        //player jumps if these conditions are met
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            //these things happen if these conditions are met to jump. note: particle effect is stopped.
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
            dirtParticle.Stop();
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //player can only jump after landing. particle effect starts again when landing on tagged "ground"
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            dirtParticle.Play();
        }

        //end game, death anim., and other things occur when collision with "obstacle" occurs.
        //note: particle effect stops and explosion happens
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Game Over");
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
            dirtParticle.Stop();
            playerAudio.PlayOneShot(crashSound, 1.0f);
        }
    }
}
