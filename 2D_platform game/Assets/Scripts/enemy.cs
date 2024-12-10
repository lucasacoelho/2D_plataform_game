using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject lifebar;

    public float lifepoints = 200f;
    public float momentlife;
    public GameObject bullet;
    public GameObject meele;
    public float dano;
    private GameObject clone;
    // Start is called before the first frame update
    void Start()
    {
        momentlife = lifepoints;
    }

    // Update is called once per frame
    void Update()
    {
        if (momentlife <= 0f)
        {
            Destroy(this.gameObject);
        }

        while (momentlife < lifepoints)
        {
            healing();
            scalelife();  
        }
        
    }
    private void OnCollisionEnter2D (Collision2D GetHit) 
    {
        if( GetHit.gameObject.CompareTag("Shot"))
        {
            dano = bullet.GetComponent<Bullet>().damage;
            
            momentlife -= dano;
            clone = GameObject.Find("/Clone");
            Debug.Log(clone);
            //Destroy(clone.gameObject);
            Debug.Log("vida " +  momentlife);
            scalelife();
        }

        if (GetHit.gameObject.CompareTag("Meele Atack"))
        {
            dano = meele.GetComponent<atack>().damage;
            momentlife -= dano;
            Debug.Log("vida " +  lifepoints);
            scalelife();
        }
    }

    private void scalelife()
    {
        float size = (momentlife / lifepoints) * 100f;
        lifebar.transform.localScale = new Vector3(size, 5.679343f, 1f);

    }

    private IEnumerator healing()
    {
        yield return new WaitForSeconds(1f);
        momentlife += 1f;
    }
}
