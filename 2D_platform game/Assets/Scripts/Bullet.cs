using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;

    [SerializeField]private float time;
    // Start is called before the first frame update
    public float damage = 80f;
    public MeeleAtack atack;
    void Start()
    {
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(new Vector3(-speed * Time.deltaTime,0,0));
        }
        else
        {
             transform.Translate(new Vector3(speed * Time.deltaTime,0,0));
        }
    }
    private IEnumerator Timer()
         {
             yield return new WaitForSeconds(time);
             Destroy(this.gameObject);
         }
}
