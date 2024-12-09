using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atack : MonoBehaviour
{
    [SerializeField]private float time;
    public float damage = 20;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    

    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(time);
        Destroy(this.gameObject);
    }
}
