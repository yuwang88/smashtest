using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {
	public float cameraspeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0,0,cameraspeed*Time.deltaTime);
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
			Debug.Log("game over");		
		}

		transform.GetComponent<Animator> ().SetTrigger ("cameracontact");
	}
}
