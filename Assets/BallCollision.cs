using UnityEngine;
using System.Collections;

public class BallCollision : MonoBehaviour {
	public Transform shattered;
	private GameObject shatter;
	// Use this for initialization
	void Start () {
//		shatter = GameObject.Find("Shattered");
//		shatter.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

//	void OnCollisionEnter(Collision collision)
//	{
//		if (collision.transform.tag == "ZhuiTi") 
//		{
////			collision.gameObject.SetActive(false);
////			shatter.SetActive(true);
////			shatter.transform.position = collision.transform.position;
//
////			GameObject.Find("Shattered");
////			Instantiate(shattered,collision.transform.position,collision.transform.rotation);	
//			Debug.Log ("ball collision");
////			Debug.Log(collision.transform.position);
//		}
//		Debug.Log ("1111ball collision");
////		//		animator.SetBool ();
////		transform.GetComponent<Animator> ().SetBool ("cameracontact",true);
//	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "shatterdetect") 
		{
			Debug.Log ("shatterdetect");

		}
	}
}
