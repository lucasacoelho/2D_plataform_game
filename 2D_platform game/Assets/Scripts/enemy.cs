using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject lifebar;

    public float lifepoints = 200f;
    public GameObject bullet;
    public GameObject meele;
    public float dano;
    private GameObject clone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lifepoints <= 0f)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter2D (Collision2D GetHit) 
    {
        if( GetHit.gameObject.CompareTag("Shot"))
        {
            dano = bullet.GetComponent<Bullet>().damage;
            lifepoints -= dano;
            clone = GameObject.Find("/Clone");
            Debug.Log(clone);
            //Destroy(clone.gameObject);
            Debug.Log("vida " +  lifepoints);
        }

        if (GetHit.gameObject.CompareTag("Meele Atack"))
        {
            dano = meele.GetComponent<atack>().damage;
            lifepoints -= dano;
            Debug.Log("vida " +  lifepoints);
        }
    }
}
