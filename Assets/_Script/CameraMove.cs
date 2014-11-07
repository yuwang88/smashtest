using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {
	public float cameraspeed;
	public float slowdownacceleration;
	// Use this for initialization
	private bool gameover;
	void Start () {
//		transform.rigidbody.velocity = new Vector3 (0,0,cameraspeed);
		gameover = false;
	}
	
	// Update is called once per frame
	void Update () {
//		transform.Translate (0,0,cameraspeed*Time.deltaTime);
	}
	void FixedUpdate(){
		if (!gameover)
			transform.rigidbody.velocity = new Vector3 (0, 0, cameraspeed * Time.deltaTime);
		else {
//			transform.rigidbody.velocity = new Vector3 (0, 0, slowdownacceleration * Time.deltaTime);


			transform.rigidbody.velocity*=slowdownacceleration;
			if(transform.rigidbody.velocity.z < 1)
				transform.rigidbody.velocity = Vector3.zero;
		}

	}
	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("collision");
		//logic for the ball count
		TouchControl.ballnumber -= 10;
		TouchControl.ballmodecounter = 0;
		TouchControl.shootingballmode = 1;
		if (TouchControl.ballnumber <= 0) 
		{
			//TODO:UI counter set to 0 game over
			//TODO:camera slow down speed to 0
			gameover = true;
			Debug.Log("game over");		
			Debug.Log ("the camera spped is"+transform.rigidbody.velocity);
		}

		transform.GetComponent<Animator> ().SetTrigger ("cameracontact");
	}
}
