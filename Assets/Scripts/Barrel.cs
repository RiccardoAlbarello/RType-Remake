using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    //public Rigidbody bulletPrefab;
    
    public GameObject bullet;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shootBullet();
        }
    }

    void shootBullet()
    {
        Instantiate(bullet, transform.position, transform.rotation);
        
    }

}
