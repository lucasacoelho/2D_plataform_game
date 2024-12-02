using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeeleAtack : MonoBehaviour
{
    public GameObject atackMeelePrefab;
    public GameObject player;

    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(atackMeelePrefab, new Vector3(player.transform.position.x + 0.10f, player.transform.position.y - 0.20f, 0), Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(bullet, new Vector3(player.transform.position.x + 0.10f, player.transform.position.y - 0.20f, 0), Quaternion.identity);
        }
        
    }
    
}
