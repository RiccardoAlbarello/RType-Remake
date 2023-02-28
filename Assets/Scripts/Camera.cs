using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] List<GameObject> points;

    [SerializeField] float cameraSpeed;

    [SerializeField] int index = 0;

    bool cameraStop = true;

    public Transform[] spawnPoints;
    public GameObject[] enemySpeedSpawn;
    public GameObject[] enemyTankSpawn;
    public GameObject[] enemyNormalSpawn;

    float spawnTimer;

    [SerializeField] float spawnRate = 3;

    public bool enemySpeed;

    public bool enemyTank;

    public bool enemyNormal;

    



    // Start is called before the first frame update
    void Start()
    {
        cameraStop = true;
        enemySpeed = true;
        enemyTank = false;
        enemyNormal = false;


    }

    // Update is called once per frame
    void Update()
    {

        MovementCamera();

        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnRate && enemySpeed == true)
        {
        int randEnmy = Random.Range(0, enemySpeedSpawn.Length);
        int randSpawnPoint = Random.Range(0, spawnPoints.Length);
        
        Instantiate(enemySpeedSpawn[0], spawnPoints[randSpawnPoint].position, transform.rotation);
            spawnTimer = 0;

        }
        if (spawnTimer >= spawnRate && enemyTank == true)
        {
            int randEnmy = Random.Range(0, enemyTankSpawn.Length);
            int randSpawnPoint = Random.Range(0, spawnPoints.Length);

            Instantiate(enemyTankSpawn[0], spawnPoints[randSpawnPoint].position, transform.rotation);
            spawnTimer = 0;

        }
        if (spawnTimer >= spawnRate && enemyNormal == true)
        {
            int randEnmy = Random.Range(0, enemyNormalSpawn.Length);
            int randSpawnPoint = Random.Range(0, spawnPoints.Length);

            Instantiate(enemyNormalSpawn[0], spawnPoints[randSpawnPoint].position, transform.rotation);
            spawnTimer = 0;

        }



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

    public void OnTriggerEnter (Collider collider)
    {
        if (collider.gameObject.tag == "Enemytank")
        {
            enemySpeed = false;
            enemyTank = true;
            
            Debug.Log("Ciao");
        }
    
        if(collider.gameObject.tag == "NormalEnemy")
        {
            enemyTank = false;
            enemyNormal = true;
            enemySpeed = false;
        }
        
        if(collider.gameObject.tag == "FineCorsa")
        {
            enemyTank = false;
            enemyNormal = false;
            enemySpeed = false;

        }
    
    
    }
}
