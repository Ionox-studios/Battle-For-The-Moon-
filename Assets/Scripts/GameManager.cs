using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Doublsb.Dialog;


public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public GameObject youWinText;
    public GameObject youLoseText;
    public float resetDelay;



    // Start is called before the first frame update
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }


    }
    private void Start()
    {


        //DialogAsset.gameObject.SetActive(false);


    }

    void Update()
    {
        if (GameObject.FindWithTag("Enemy") == null)
        {
            Win();
        }

    }
    public void Win()
    {
        //Debug.Log("Win");
        youWinText.SetActive (true);
        //Debug.Log("Win2");
        //Invoke("Reset", resetDelay);
        LoadNextScene();
    }
    public void Lose()
    {
        //Debug.Log("Lose");
        youLoseText.SetActive(true);
        //Debug.Log("Lose2");
        Invoke("Reset", resetDelay);
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    void Reset()
    {
        Scene scene = SceneManager.GetActiveScene(); 
        SceneManager.LoadScene(scene.name);
 
    }

}
