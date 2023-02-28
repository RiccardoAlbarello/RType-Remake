using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelEnemyNormal : MonoBehaviour
{
    public GameObject bullet;
    [SerializeField] float tempoSparo = 3;

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
            tempoSparo = 3;
        }
    }

    void shootBullet()
    {
        Instantiate(bullet, transform.position, transform.rotation);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EnemyNormal")
        {
            DavantiLibero = false;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "EnemyNormal")
        {
            DavantiLibero = true;
        }
    }
}
