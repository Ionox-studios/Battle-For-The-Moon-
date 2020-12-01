using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scikle : MonoBehaviour
{
    public ParticleSystem ps;
    // Start is called befosre the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider col)
    {
        Debug.Log("Hitsleec!");
        if (col.gameObject.tag == "Enemy" || col.gameObject.tag == "spawns") {
            Debug.Log("GoodJob");
            col.gameObject.GetComponent<HealthScript>().health -= 10;
            var boom = Instantiate(ps, col.gameObject.transform.position, Quaternion.identity);
            Destroy(boom, 2);
        }
        

    }

}
