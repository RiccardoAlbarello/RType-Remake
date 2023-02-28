using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyNormal : MonoBehaviour
{

    [SerializeField] float speed;
    public int numeroDiColpi = 0;



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (numeroDiColpi >= 3)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {

            Destroy(gameObject);
        }
        if (other.gameObject.tag == "ColliderMorte")
        {
            Destroy(gameObject);
        }

            if (other.gameObject.tag == "Bullet")
            {
                numeroDiColpi++;

            }

       
        

            
        





    }






}

