using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 3f;
    private Rigidbody2D rb;
    private Vector2 moveDirection;
    private SpriteRenderer sprite;
    private Animator animPlayer;
    //private CapsuleCollider2D colisaoDeitada;
    private float horizontal;
    private float vertical;
    //private bool temRoupa = false;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        animPlayer = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            sprite.flipX = false;
            animPlayer.SetLayerWeight(2, 1);
            animPlayer.SetLayerWeight(3, 0);

        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            sprite.flipX = true;
            animPlayer.SetLayerWeight(2, 1);
            animPlayer.SetLayerWeight(3, 0);
        }
        else
        {
            animPlayer.SetLayerWeight(2, 0);
            animPlayer.SetLayerWeight(3, 1);
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            sprite.flipX = false;
            animPlayer.SetLayerWeight(1, 1);
            animPlayer.SetLayerWeight(3, 0);
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            sprite.flipX = true;
            animPlayer.SetLayerWeight(0, 1);
            animPlayer.SetLayerWeight(1, 0);
            animPlayer.SetLayerWeight(3, 0);
        }
        if (horizontal == 0 && vertical == 0)
        {
            animPlayer.SetLayerWeight(1, 0);
            animPlayer.SetLayerWeight(2, 0);
            animPlayer.SetLayerWeight(3, 1);
        }
        if (Input.GetKey(KeyCode.C))
        {
            animPlayer.SetLayerWeight(4, 4);
            animPlayer.SetLayerWeight(4, 0);
        }
    }
    private void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        transform.position += new Vector3(speed * Time.fixedDeltaTime * horizontal, speed * Time.fixedDeltaTime * vertical, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }

    private void OnCollisionStay2D(Collision2D collision)
    {

    }

    private void OnCollisionExit2D(Collision2D collision)
    {

    }

    /*public void ColocaRoupa()
    {
       temRoupa = true;
    }

    public bool VerificaSeEstaComRoupa()
    {
       return temRoupa;
    }*/
}