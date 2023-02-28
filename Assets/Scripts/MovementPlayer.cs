using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{

    [SerializeField] float playerSpeed = 5f;

    
    
    

    [SerializeField] List<GameObject> points;

    [SerializeField] float automaticSpeed;
    

    [SerializeField] int index = 0;

    bool playerStop = true;

    [SerializeField] GameObject objecttospawnstart;

    



    // Start is called before the first frame update
    void Start()
    {
        playerStop = true;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
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
            
            if(index == 1)
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
            

        }
    }

    


}
