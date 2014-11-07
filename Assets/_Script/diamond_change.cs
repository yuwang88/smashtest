using UnityEngine;
using System.Collections;

public class diamond_change : MonoBehaviour {
	public Transform aftercollison;
	public Transform number;
	public Transform bomb;
	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter(Collider other)
	{
		//logic for the ball count
		TouchControl.ballnumber += 5;
		TouchControl.ballmodecounter++;
		if (TouchControl.ballmodecounter >= 3) 
		{
			TouchControl.shootingballmode++;	
			TouchControl.ballmodecounter = 0;
		}
		//TODO:update UI counter

		Debug.Log ("the total ball num is"+TouchControl.ballnumber);
		GameObject.Destroy(transform.parent.gameObject);
		Instantiate (aftercollison,transform.parent.position,transform.parent.rotation);
		Instantiate (number,transform.position,transform.rotation);
		Instantiate (bomb,transform.position,transform.rotation);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
