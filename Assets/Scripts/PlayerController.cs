using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rollPow = 60f;
    public float yawPow = 60f;
    public float pitchPow = 60f;
    public GameObject bullet;
    public float bulletSpeed = 100f;
    Rigidbody myRb;
    private float nextUpdate = 0.03f;
    private bool held = false;
    public GameObject SicklePrefab;
    public GameObject SicklePrefabBig;
    Animator animator;
    Animator aniBigScythe;
    private float Swingstart;
    public Vector2 DummyVar;
    private float moveX;
    private float moveY;
    private float roll = 0.0f;
    private float yaw = 0.0f;
    private float pitch = 0.0f;
    private float current = 0f;
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        myRb = GetComponent<Rigidbody>();
       
        animator = SicklePrefab.GetComponent<Animator>();
        aniBigScythe = SicklePrefabBig.GetComponent<Animator>();

    }
   
    private void Update()
    {

        ProcessInputs();
        DummyVar = new Vector2 (moveX, moveY);
        if ((Input.GetButton("Fire1") || Input.GetAxis("Fire1")>0.0f) && (Time.timeScale == 1f)&& (Time.time> current))
        {
                current = Time.time + nextUpdate;
                Shoot();
         }
        
        if (Time.time > Swingstart + .9f)
        {
            animator.SetBool("that",true);
            SicklePrefabBig.SetActive(false);
            aniBigScythe.SetBool("that", false);
        }
        transform.position += transform.forward * moveSpeed * moveY * Time.deltaTime;
        transform.position += transform.right * moveSpeed * .6f * moveX * Time.deltaTime;
        transform.Rotate(pitch, yaw, roll);
    }
    void ProcessInputs()
    {
        moveY = Input.GetAxis("Vertical");
        moveX = Input.GetAxis("Horizontal");
        yaw = Input.GetAxis("Mouse X") * yawPow * Time.deltaTime;
        pitch = Input.GetAxis("Mouse Y") * pitchPow * Time.deltaTime*-1;
        if(Input.GetButtonDown("Fire2"))
        {
            Swing();
        }
        
    }
    
    //public void Turn()
    //{
    //    var movementInput = controls.gameplay.Move.ReadValue<Vector2>();
    //    var playerLook = controls.gameplay.Look.ReadValue<Vector2>();
    //    float roll;
    //    float yaw;
    //    float pitch;
    //    //roll = movementInput.x * rollPow * Time.deltaTime; fix later with bumpers
    //    roll = 0f;
    //    yaw = playerLook.x*yawPow * Time.deltaTime;
    //    pitch = playerLook.y   * pitchPow * Time.deltaTime;
    //    transform.Rotate(pitch, yaw, roll);
    //}
    //public void MoveForward()
    //{

    //    var movementInput = controls.gameplay.Move.ReadValue<Vector2>();
    //    transform.position += transform.forward * moveSpeed * movementInput.y * Time.deltaTime;
    //    transform.position += transform.right * moveSpeed*.4f * movementInput.x * Time.deltaTime;
    //    //myRb.AddForce(transform.forward * moveSpeed * movementInput.y);


    //}
    public void Shoot()
    {
        

            GameObject instBullet = Instantiate(bullet, transform.position + transform.forward * 10.0f, transform.rotation) as GameObject; //need to make this nonrelative
            Transform instBulletTrans = instBullet.GetComponent<Transform>();
            instBulletTrans.Rotate(90f, 0f, 0f);
            Rigidbody instBulltRigidbody = instBullet.GetComponent<Rigidbody>();
            instBulltRigidbody.AddForce(transform.forward * (bulletSpeed+ moveSpeed * moveY));
            Destroy(instBullet, 3f);
        
    }
    public void Swing()
    {
        SicklePrefabBig.SetActive(true);
        Debug.Log("YouTrie");
        animator.SetBool("that",false);
        aniBigScythe.SetBool("that", false);
        Swingstart = Time.time;
    }


}
