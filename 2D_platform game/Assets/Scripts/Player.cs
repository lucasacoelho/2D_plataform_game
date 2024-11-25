using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float vel;

    public Rigidbody2D player;

    public bool IsJump;
    
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
    }

    private void jump()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& IsJump == false)
        {
            player.AddForce(new Vector2(0,5f), ForceMode2D.Impulse);
            IsJump = true;
            StartCoroutine(JumpTimer());
        }
    }

    private IEnumerator JumpTimer()
    {
        Debug.Log("enter");
        if (IsJump == true)
        {
            while (true)
            {
                Debug.Log("enter");
                yield return new WaitForSeconds(2f);
                IsJump = false;
                Debug.Log("count");
                break;
            }
        }

    }
}
