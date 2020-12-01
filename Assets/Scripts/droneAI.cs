using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droneAI : MonoBehaviour
{
    public Transform player;
    public float playerDistance;
    public float distanceToGoal;
    public float rotationDampen;
    public float moveSpeed;
    public GameObject bullet;
    public float bulletSpeed = 100f;
    private int nextUpdate = 1;
    public float accel = 3f;
    public Rigidbody myRb;
    private float birth;
    private float startChase;
    // Start is called before the first frame update
    void Awake()
    {
        birth = Time.time;
        startChase = birth + startChase;
        myRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        playerDistance = Vector3.Distance(player.position, transform.position);



        lookAtPlayer();
        Chase();
        if (Time.time >= nextUpdate)
        {

            if (Time.time >= startChase)
            {
                Attack();
                nextUpdate = Mathf.FloorToInt(Time.time) + 1;
            }
        }



        void lookAtPlayer()
        {
            Quaternion enemrotation = Quaternion.LookRotation(player.position - transform.position);

            transform.rotation = Quaternion.Slerp(transform.rotation, enemrotation, Time.deltaTime * rotationDampen);
        }
        void Chase()
        {
            myRb.AddForce(transform.forward * accel);
        }
        void Attack()
        {

            GameObject instBullet = Instantiate(bullet, transform.position + transform.forward * 10.0f, transform.rotation) as GameObject; //need to make this nonrelative
            Transform instBulletTrans = instBullet.GetComponent<Transform>();
            instBulletTrans.Rotate(90f, 0f, 0f);
            Rigidbody instBulltRigidbody = instBullet.GetComponent<Rigidbody>();
            instBulltRigidbody.AddForce(transform.forward * bulletSpeed);
            Destroy(instBullet, 3f);
        }
    }
}
