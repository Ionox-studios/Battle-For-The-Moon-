using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heroBullet : MonoBehaviour
{
    private Vector3 lastPosition;
    public ParticleSystem ps;
    public float activeDist = 0.3f;
    public float birth = 0.0f;

    // Start is called before the first frame update
    void Awake()
    {
        lastPosition = transform.position;
        birth = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
       // Destroy(gameObject, 1f);
    }
    
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag != "Player")
        {
            Debug.Log("Hit!");
            col.gameObject.GetComponent<HealthScript>().health -= 1;
            var boom = Instantiate(ps, transform.position, Quaternion.identity);
            Destroy(boom, 2);
            Destroy(gameObject);
        }
    }
}
