using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Sounds sound;

    public TextMeshProUGUI scoreValue;


    float horizontalMove = 0f;

    public float runSpeed = 850f;
    public Animator animator;
    public float score;
   // AudioSource audioSource;
   // public AudioClip Step;
   // public AudioClip Collect;
   // public AudioClip Jump;
   // public AudioClip Land;

    bool jump = false;
    bool crouch = false;
    void Start()
    {
      //  audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        } else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

    }

    public void ScorePlus()
    {
        score = score + 1;
        scoreValue.text = ("Gems: " + score + "/10");
        sound.collectSound();
    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }
    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }
        void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump );
        jump = false;
    }
}
