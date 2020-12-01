using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kilSelf : MonoBehaviour
{
    // Start is called before the first frame update
    public float deathTime;
    void Awake()
    {
        Object.Destroy(this.gameObject, deathTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
