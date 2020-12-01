using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class homingMissleLogic : MonoBehaviour
{
    public float chaseTime = 3.0f;
    public float explosionDistance = 2.0f;
    public Transform player;
    public float missleAccel = 10f;
    public float rotationDampen; //change for faster or slower turn 0 is nearly instant turn
    public ParticleSystem smokeTrail;
    private float birth;
    public Rigidbody myRb;
    private float stopChase;
    private bool megaBoom = true;
    public float playerDistance;
    public float boomRadius;
    public ParticleSystem ps;
    // Start is called before the first frame update
    void Awake()
    {
       birth = Time.time;
        stopChase = birth + chaseTime;
        myRb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        lookAtPlayer();
        myRb.AddForce(transform.forward * missleAccel);
        if (Time.time < stopChase)
        {
            myRb.AddForce(transform.forward * missleAccel);
            lookAtPlayer();
        }
        else if (Time.time > stopChase && megaBoom)
        {
            myRb.AddForce(transform.forward * missleAccel*10) ;
            megaBoom = false;
        }
        Collider[] hitColliders = Physics.OverlapSphere(transform.position,15.0f);
        if (hitColliders.Length > 0 && (Time.time-birth>2.0f)) {
            foreach (var hitCollider in hitColliders)
            {
                hitCollider.gameObject.GetComponent<HealthScript>().health -= 2;
            }
            var boom = Instantiate(ps, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(boom, 2);

            //Destroy(gameObject);

        }




    }
    void lookAtPlayer()
    {
        Quaternion enemrotation = Quaternion.LookRotation(player.position - transform.position);

        transform.rotation = Quaternion.Slerp(transform.rotation, enemrotation, Time.deltaTime * rotationDampen);
        
    }
}
