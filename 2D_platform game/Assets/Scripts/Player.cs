using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Object = UnityEngine.Object;

public class Player : MonoBehaviour
{
    public float vel;

    public Rigidbody2D player;

    public bool IsJump;
    public float JumpForce;
    public bool super;
    public GameObject win;
    public GameObject wintext;
    public GameObject powerUp;

    public bool IsFacingLeft = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float Haxis = Input.GetAxis("Horizontal");
        transform.Translate(new Vector2((Haxis * vel) * Time.deltaTime, 0));
        jump();
        if (Input.GetKeyDown(KeyCode.A))
        {
            IsFacingLeft = true;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            IsFacingLeft = false;
        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            super = false;
            vel = 5;
            JumpForce = 7;
        }
    }

    private void jump()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& IsJump == false)
        {
            player.AddForce(new Vector2(0,JumpForce), ForceMode2D.Impulse);
            IsJump = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            IsJump = false;
            Debug.Log("collide");
        }

        if (collision.gameObject.CompareTag("PowerUp"))
        {
            super = true;
            Destroy(powerUp);
            if (super == true)
            {
                vel = 10;
                JumpForce = 10;
            }
        
        }

        if (collision.gameObject.CompareTag("win"))
        {
            Destroy(win);
            wintext.SetActive(true);
        }
    }
}
