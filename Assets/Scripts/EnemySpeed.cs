using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpeed : MonoBehaviour
{

    [SerializeField] float speed;

    

    // Start is called before the first frame update
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bullet")
        {

        Destroy(gameObject);
        }
        if(other.gameObject.tag == "ColliderMorte")
        {
            Destroy(gameObject);
        }

    }






}
