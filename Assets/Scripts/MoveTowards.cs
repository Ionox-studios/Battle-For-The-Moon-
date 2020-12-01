using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform objective;
    public float moveSpeed;
    public float playerDistance;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerDistance = Vector3.Distance(objective.position, transform.position);
        lookAtObjective();
        Chase();
        void lookAtObjective()
        {
            Quaternion enemrotation = Quaternion.LookRotation(objective.position - transform.position);

            transform.rotation = Quaternion.Slerp(transform.rotation, enemrotation, 1);
        }
        void Chase()
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }

}
