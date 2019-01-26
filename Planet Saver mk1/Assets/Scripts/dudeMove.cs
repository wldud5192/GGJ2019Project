using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
public class dudeMove : MonoBehaviour {

    SpriteRenderer rend;
    Animator anim;
	public GameObject Planet;
	public float speed;
	// private Vector3 endPosition = new Vector3(-6, -4, 0);

    void Start(){
        rend = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    void Update() 
    {
    	MoveAround();

  		// if(transform.position != endPosition) {
    //     	transform.position = Vector3.MoveTowards(transform.position, endPosition, speed * Time.deltaTime);
    //     }
    }

    void MoveAround()
    {
<<<<<<< HEAD

	if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) {
=======
        
	if (Input.GetKey (KeyCode.A)) {
>>>>>>> 05c50e5f9b03e9bac94fdd74dae787864b34d55d
	 	transform.RotateAround(Planet.transform.position, Vector3.forward, speed * Time.deltaTime); //LEFT
            rend.flipX = false;
		}
<<<<<<< HEAD
	if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {
=======
	if (Input.GetKey (KeyCode.D)) {
>>>>>>> 05c50e5f9b03e9bac94fdd74dae787864b34d55d
	 	transform.RotateAround(Planet.transform.position, Vector3.back, speed * Time.deltaTime); //RIGHT
            rend.flipX = true;
		}

    if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.D))
        {
            anim.SetBool("IsWalking", true);
        } else
        {
            anim.SetBool("IsWalking", false);
        }


	}

    // rotationZ = Mathf.Clamp (rotationZ, -90, 90);
    // transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, -rotationZ);


	// float maxX = 4;
	// float maxY = 4;


	// Vector3 pos = transform.position;
	// pos.x = Mathf.Clamp (pos.x, -maxX, maxX);
	// pos.y = Mathf.Clamp (pos.y, -maxY, maxY);
	// transform.position = pos;

}
