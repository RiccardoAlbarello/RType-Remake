using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelEnemyTank : MonoBehaviour
{
    public GameObject bullet;
    [SerializeField] float tempoSparo = 5;

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
            tempoSparo = 5;
        }
    }

    void shootBullet()
    {
        Instantiate(bullet, transform.position, transform.rotation);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EnemyTank")
        {
            DavantiLibero = false;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "EnemyTank")
        {
            DavantiLibero = true;
        }
    }

}

