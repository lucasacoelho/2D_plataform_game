using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;

    [SerializeField]private float time;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(speed * Time.deltaTime,0,0));

    }
    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(time);
        Debug.Log(speed);
        Destroy(this.gameObject);
    }
}
