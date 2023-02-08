using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] List<GameObject> points;

    [SerializeField] float cameraSpeed;

    [SerializeField] int index = 0;

    bool cameraStop = true;
    
   

    // Start is called before the first frame update
    void Start()
    {
        cameraStop = true;
    }

    // Update is called once per frame
    void Update()
    {

        MovementCamera();
    }

    void MovementCamera()
    {
        transform.position = Vector3.MoveTowards(transform.position, points[index].transform.position, cameraSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, points[index].transform.position) < 1 && cameraStop == true )
        {
            index++;

            

        }

        if(index == 1)
        {
            
            cameraStop = false;

        }


          

        
        
        

    }


}
