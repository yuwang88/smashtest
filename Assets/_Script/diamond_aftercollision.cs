using UnityEngine;
using System.Collections;
//using System;

public class diamond_aftercollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.rigidbody.useGravity = true;
//		System.Random ran=new System.Random();
//				int xforce=ran.Next(1,5);
//		int yforce=ran.Next(1,5);
//		int zforce=ran.Next(1,5);
//
		rigidbody.AddForce (new Vector3(0,0,5),ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	void Update () {
//		transform.rigidbody.useGravity = true;
	}

	void OnCollisionEnter(Collision collision)
	{
//		transform.rigidbody.useGravity = true;
	}
}
