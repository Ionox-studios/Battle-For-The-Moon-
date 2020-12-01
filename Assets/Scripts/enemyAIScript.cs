using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAIScript : MonoBehaviour
{
    public Transform player;
    public float playerDistance;
    public float distanceToGoal;
    public float rotationDampen;
    public float moveSpeed;
    public GameObject bullet;
    public float bulletSpeed = 100f;
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
        if (playerDistance > 5f)
        {
            Chase();
        }
        if (Time.time >= nextUpdate && activeFactor>0.0f)
        {

            Attack();
            nextUpdate = Time.time + 1.0f+Random.Range(0,1.0f);
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
            transform.position = Vector3.MoveTowards(transform.position, objective.position, moveSpeed * activeFactor * Time.deltaTime);
        }
        void Attack()
        {
            
            GameObject instBullet = Instantiate(bullet, transform.position+transform.forward * 25.0f, transform.rotation) as GameObject; //need to make this nonrelative
            Transform instBulletTrans = instBullet.GetComponent<Transform>();
            instBulletTrans.Rotate(90f, 0f, 0f);
            Rigidbody instBulltRigidbody = instBullet.GetComponent<Rigidbody>();
            instBulltRigidbody.AddForce(transform.forward * bulletSpeed);
            Destroy(instBullet, 10f);
        }
    }
}
