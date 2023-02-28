using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelEnemySpeed : MonoBehaviour
{
    public GameObject bullet;
     [SerializeField] float tempoSparo = 2;

    public bool DavantiLibero;

    private void Start()
    {
        DavantiLibero = true;
    }

    private void Update()
    {

        tempoSparo -= Time.deltaTime;
        
        if (tempoSparo <= 0 && DavantiLibero == true)
        {
            shootBullet();
            tempoSparo = 2;
        }
    }

    void shootBullet()
    {
        Instantiate(bullet, transform.position, transform.rotation);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EnemySpeed")
        {
            DavantiLibero = false;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "EnemySpeed")
        {
            DavantiLibero = true;
        }
    }

}
