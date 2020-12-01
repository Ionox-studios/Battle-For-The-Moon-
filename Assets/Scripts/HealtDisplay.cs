
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealtDisplay : MonoBehaviour
{
    public GameObject player;
    public Text healthText;
    private float health = 5f;
    // Start is called before the first frame update
    void Start()
    {
        HealthScript healthVals = player.GetComponent<HealthScript>();
        health = healthVals.health;
        healthText.text = "HEALTH : " + health;
    }

    // Update is called once per frame
    void Update()
    {
        HealthScript healthVals = player.GetComponent<HealthScript>();
        health = healthVals.health;
        healthText.text = "HEALTH : " + health;
    }
}
