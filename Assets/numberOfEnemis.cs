using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class numberOfEnemis : MonoBehaviour
{
    public Text numberOfEnemies;
    public GameObject[] enemies;
    private int countOfFoes;
    // Start is called before the first frame update
    void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        countOfFoes = enemies.Length;
        numberOfEnemies.text = "Number of Enemies Remaining : " + countOfFoes;
    }

    // Update is called once per frame
    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        countOfFoes = enemies.Length;
        numberOfEnemies.text = "Number of Enemies Remaining : " + countOfFoes;
    }
}
