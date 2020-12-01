using UnityEngine;
using System.Collections;
public class player : MonoBehaviour {

	public Animator anim;
	public Rigidbody rbody;
	private float inputH;
	private float inputV;
    private bool run;
	private Vector2 movementInput;
	private PlayerController c;
	// Use this for initialization

	void Start () 
	{
		anim = GetComponent<Animator>();
		run = false;
		

	}



	// Update is called once per frame
	void Update () 
	{
		PlayerController c = GetComponentInParent<PlayerController>();
		movementInput = c.DummyVar;
		Debug.Log(movementInput);
		inputH = movementInput.y;
		inputV = movementInput.x;
		if (inputH==0.0f && inputV==0.0f)
        {
			anim.SetBool("runtrig", false);
		}
		else
        {
			anim.SetBool("runtrig", true);
        }


		anim.SetFloat("intH",inputH);
		anim.SetFloat("intV",inputV);
	    //anim.SetBool ("run",run);



		//rbody.velocity = new Vector3(moveX,0f,moveZ);

	}


}











