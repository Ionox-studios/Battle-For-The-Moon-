using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homingEnemyScript : MonoBehaviour
{
    public Transform player;
    public float playerDistance;
    public float distanceToGoal;
    public float rotationDampen;
    public float moveSpeed;
    public GameObject missle;
    public float missleAccel = 10f;
    private float nextUpdate = 1;
    public Transform objective;
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
        playerDistance = Vector3.Distance(player.position, transform.position);
        distanceToGoal = Vector3.Distance(objective.position, transform.position);
        if (Time.time > (birth + waitTime))
        {
            activeFactor = 1.0f;
        }

        lookAtPlayer();
        if (playerDistance > 5f && activeFactor>0.0f)
        {
            Chase();
        }
        if (Time.time >= nextUpdate && activeFactor>0.0f)
        {

            Attack();
            nextUpdate = Time.time + 1+Random.Range(0, 1.0f);
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
        void Attack()
        {
            
            GameObject intstMissle = Instantiate(missle, transform.position+transform.forward * 25.0f, transform.rotation) as GameObject; //need to make this nonrelative
            homingMissleLogic missleBrain = intstMissle.GetComponent<homingMissleLogic>();
            missleBrain.player = player;
            Transform instBulletTrans = intstMissle.GetComponent<Transform>();
            instBulletTrans.Rotate(00f, 0f, 90f);
            Destroy(intstMissle, 5f);
        }
    }
}
