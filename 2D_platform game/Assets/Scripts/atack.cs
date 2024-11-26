using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atack : MonoBehaviour
{
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
        yield return new WaitForSeconds(0.1f);
        Destroy(this.gameObject);
    }
}
