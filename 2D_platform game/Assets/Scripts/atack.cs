using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atack : MonoBehaviour
{
    [SerializeField]private float time;
    private float damage = 20;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    private void OnCollisionEnter2D(Collision2D hit)
    {
        if (hit.gameObject.CompareTag("Enemy"))
        {
            //going to end later
        }
    }

    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(time);
        Destroy(this.gameObject);
    }
    
}
