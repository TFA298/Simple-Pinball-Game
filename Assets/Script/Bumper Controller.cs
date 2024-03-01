using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public Collider bola;
    public float multiplier;
    public Color color;
    public float score;

    public AudioManager audioManager;
    public VFXManager vFXManager;
    public ScoreManager scoreManager;

    private Renderer render;
    private Animator animator;

    private void Start() 
    {
        render = GetComponent<Renderer>();
        animator = GetComponent<Animator>();

        render.material.color = color;
    }
    private void OnCollisionEnter(Collision collision) 
    {
        if(collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;

            //animasi
            animator.SetTrigger("Hit");

            //play sfx
            audioManager.PlaySFX(collision.transform.position);

            //play vfx
            vFXManager.PlayVFX(collision.transform.position);

            //score add
            scoreManager.AddScore(score);
        }
    }
} 
