using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerAI : MonoBehaviour
{
    public Transform player;
    public float playerDistance;
    public float distanceToGoal;
    public float rotationDampen;
    public float moveSpeed;
    public float missleAccel = 10f;
    private int nextUpdate = 1;
    private int timetoNextUpdate = 10;
    public Transform objective;
    private int spawns;
    public GameObject spawn;
    private Vector3 randomVector;
    public float activeFactor = 0.0f;
    public float waitTime = 50.0f;
    private float birth;


    // Start is called before the first frame update
    void Start()
    {
        birth = Time.time;
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > (birth + waitTime))
        {
            activeFactor = 1.0f;
        }

        playerDistance = Vector3.Distance(player.position, transform.position);
        distanceToGoal = Vector3.Distance(objective.position, transform.position);


        lookAtPlayer();
        if (playerDistance > 5f && activeFactor>0.0f)
        {
            Chase();
        }
        if (Time.time >= nextUpdate && activeFactor > 0.0f)
        {

            createSpawns();
            nextUpdate = Mathf.FloorToInt(Time.time) + timetoNextUpdate;
            Debug.Log("tic");
        }
        if (distanceToGoal < 1f)
        {
            GameManager.instance.Lose();

        }
        void lookAtPlayer()
        {
            Quaternion enemrotation = Quaternion.LookRotation(player.position - transform.position);

            transform.rotation = Quaternion.Slerp(transform.rotation, enemrotation, Time.deltaTime * rotationDampen);
        }
        void Chase()
        {
            transform.position = Vector3.MoveTowards(transform.position, objective.position, moveSpeed * Time.deltaTime);
        }
        void createSpawns()
        {

            if (GameObject.FindGameObjectsWithTag("spawns").Length < 30)
            {
                for (int i = 0; i < 5; i++)
                {
                    randomVector = new Vector3(UnityEngine.Random.Range(.5f, 1f), UnityEngine.Random.Range(.5f, 1f), UnityEngine.Random.Range(.5f, 1f));
                    GameObject spawnedShip = Instantiate(spawn, transform.position + randomVector * 100.0f, transform.rotation) as GameObject; //need to make this nonrelative
                    droneAI spawnBrain = spawnedShip.GetComponent<droneAI>();
                    spawnBrain.player = player;
                }
            }
               
            }
        
    }
}

