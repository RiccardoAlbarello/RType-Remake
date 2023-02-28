using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{

    [SerializeField] float playerSpeed = 5f;
    MenuController m;



    public Transform player;

    [SerializeField] List<GameObject> points;

    [SerializeField] float automaticSpeed;


    [SerializeField] int index = 0;

    bool playerStop = true;

    [SerializeField] GameObject objecttospawnstart;

    public bool movementPlayer;







    // Start is called before the first frame update
    void Start()
    {
        playerStop = true;
        movementPlayer = false;
        m = FindObjectOfType<MenuController>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(movementPlayer == true)
        {
        PlayerMovement();

        }
        
        MovementPlayerAuto();




    }


    void PlayerMovement()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(HorizontalInput, VerticalInput, 0);
        transform.Translate(direction * playerSpeed * Time.deltaTime);
    }

    void MovementPlayerAuto()
    {

        if (index == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, points[index].transform.position, automaticSpeed * Time.deltaTime);

        }




        if (Vector3.Distance(transform.position, points[index].transform.position) == 0 && playerStop == true)
        {
            index++;




        }

        if (index == 2)
        {
            index = 0;
            Instantiate(objecttospawnstart);
            movementPlayer = true;


        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EnemyBomb")
        {
            
            m.GameOver();
        }
        if (other.gameObject.tag == "EnemySpeed")
        {
            
            m.GameOver();
        }
        if (other.gameObject.tag == "LimiteGiocatore")
        {
            
            m.GameOver();
        }
        if (other.gameObject.tag == "EnemyTank")
        {
            
            m.GameOver();
        } 
        if (other.gameObject.tag == "NormalEnemy")
        {
            
            m.GameOver();
        }
        
        if(other.gameObject.tag == "ColliderLaterali")
        {
            
            m.GameOver();
        }

        if(other.gameObject.tag == "MonetaVittoria")
        {
            m.Victory();

        }
    }
}
