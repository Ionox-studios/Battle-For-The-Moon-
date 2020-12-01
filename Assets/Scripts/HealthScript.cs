using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HealthScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float health;
    public ParticleSystem ps;
    private ParticleSystem boom;
    public float birth = 0f;
    public float respawnTime = 5f;
    public float startingHealth = 100f;
    public bool dead = false;
    public float invulnTime = 5f;
    private bool invuln = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
  
        if (invuln ==true)
        {
            health = startingHealth;
        }
        if (health < 0 && this.gameObject.tag!="Player")
        {
           
            boom = Instantiate(ps, transform.position, Quaternion.identity) as ParticleSystem;
            Destroy(this.gameObject);
            Destroy(boom, 2);
            Debug.Log("Destroyed");
            Debug.Log(gameObject.tag);
        }
        else if (health < 0 && this.gameObject.tag == "Player")
        {
            boom = Instantiate(ps, transform.position, Quaternion.identity) as ParticleSystem;
            Destroy(boom, 5);
            gameObject.SetActive(false);
            birth = Time.time;
            health = startingHealth;
            dead = true;
            invuln = true;
            Invoke(nameof(Show), respawnTime);
            Invoke(nameof(RemoveInvuln), invulnTime + respawnTime);
        }
        
    }
    private void Show()
    {
        gameObject.SetActive(true);
        dead = false;
    }
    private void RemoveInvuln()
    {
        invuln = false;
    }

}
